﻿#region Using

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Adfectus.Common;
using Adfectus.Logging;
using Adfectus.OpenAL;
using FreeImageAPI;
using SharpFont;

#endregion

namespace Adfectus.Platform.DesktopGL.Native
{
    /// <summary>
    /// Loads native libraries.
    /// </summary>
    public static class NativeLoader
    {
        /// <summary>
        /// Whether the native loader is ready.
        /// </summary>
        public static bool Ready { get; private set; }

        /// <summary>
        /// Default libraries to load on Windows.
        /// </summary>
        public static Dictionary<string, string> LibrariesWindows = new Dictionary<string, string>
        {
            {"vcruntime140.dll - glfw dependency", "vcruntime140.dll"},
            {"vcomp120.dll - freeimage dependency", "vcomp120.dll"},
            {"msvcr100.dll - freetype dependency", "msvcr100.dll"},
            {"freeimage", "FreeImage.dll"},
            {"freetype", "freetype6.dll"},
            {"glfw", "glfw3.dll"},
            {"openal", "openal32.dll"}
        };

        /// <summary>
        /// Default libraries to load on Linux systems.
        /// </summary>
        public static Dictionary<string, string> LibrariesLinux = new Dictionary<string, string>
        {
            {"libsndio - openal dependency", "libsndio.so.6.1"}, // maybe the NativeLibrary class can be made to load this from the folder without me loading it?
            {"freeimage", "FreeImage.so"},
            {"freetype", "freetype6.so"},
            {"glfw", "glfw3.so"},
            {"openal", "openal32.so"}
        };

        /// <summary>
        /// Default libraries to load on MacOS.
        /// </summary>
        public static Dictionary<string, string> LibrariesMacOs = new Dictionary<string, string>
        {
            {"libpng - freeimage dependency", "libpng14.14.dylib"}, // maybe the NativeLibrary class can be made to load this from the folder without me loading it?
            {"freeimage", "FreeImage.dylib"},
            {"freetype", "freetype6.dylib"},
            {"glfw", "glfw3.dylib"},
            {"openal", "openal32.dylib"}
        };

        /// <summary>
        /// Dictionary of loaded native libraries and pointers to them.
        /// </summary>
        public static Dictionary<string, IntPtr> LoadedLibraries;

        /// <summary>
        /// The folder libraries will be loaded from.
        /// </summary>
        public static string LibFolder { get; set; }

        /// <summary>
        /// Perform needed configuration.
        /// </summary>
        public static void Setup()
        {
            if (Ready)
            {
                Engine.Log.Warning("Native libraries are already setup.", MessageSource.Bootstrap);
                return;
            }

            Engine.Log.Info("Adfectus Native Loader", MessageSource.Bootstrap);
            Engine.Log.Info("-----------", MessageSource.Bootstrap);
            Engine.Log.Info($"OS: {RuntimeInformation.OSDescription}", MessageSource.Bootstrap);
            Engine.Log.Info($"64Bit: {Environment.Is64BitProcess}", MessageSource.Bootstrap);
            Engine.Log.Info($"Execution Directory: {Environment.CurrentDirectory}", MessageSource.Bootstrap);
            Engine.Log.Info($"Execution Assembly: {Assembly.GetCallingAssembly()}", MessageSource.Bootstrap);

            // Get lib folder and libs depending on platform.
            Dictionary<string, string> libs = null;

            // Check if a 64 bit system.
            if (RuntimeInformation.OSArchitecture != Architecture.X64)
            {
                ErrorHandler.SubmitError(new Exception("Only 64bit OSes are supported."));
                return;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                LibFolder = $"{Environment.CurrentDirectory}\\Libraries\\win\\";
                libs = LibrariesWindows;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Check for capitalized folder. Yes, really.
                if (Directory.Exists($"{Environment.CurrentDirectory}/Libraries/MacOS/"))
                {
                    LibFolder = $"{Environment.CurrentDirectory}/Libraries/MacOS/";
                }

                LibFolder = $"{Environment.CurrentDirectory}/Libraries/macOS/";

                libs = LibrariesMacOs;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Check for capitalized folder. Yes, really.
                if (Directory.Exists($"{Environment.CurrentDirectory}/Libraries/Linux/"))
                {
                    LibFolder = $"{Environment.CurrentDirectory}/Libraries/Linux/";
                }

                LibFolder = $"{Environment.CurrentDirectory}/Libraries/linux/";

                libs = LibrariesLinux;
            }

            // If no lib folder or libs - exit.
            if (LibFolder == null || libs == null)
            {
                ErrorHandler.SubmitError(new Exception("Cannot identify library folder or libraries to load."));
                return;
            }

            // Check if the folder exists.
            if (!Directory.Exists(LibFolder))
            {
                ErrorHandler.SubmitError(new Exception($"Library folder {LibFolder} not found."));
                return;
            }

            Engine.Log.Info($"Library Folder: {LibFolder}", MessageSource.Bootstrap);

            // Load libraries.
            LoadedLibraries = new Dictionary<string, IntPtr>();
            foreach (KeyValuePair<string, string> libArr in libs)
            {
                string curLib = libArr.Value;
                Engine.Log.Trace($"Loading library {curLib}...", MessageSource.Bootstrap);

                // Get the true path to the file.
                string libPath = $"{LibFolder}{curLib}";

                // Check if the file exists.
                if (!File.Exists(libPath))
                {
                    Engine.Log.Warning($"Couldn't load library {curLib} - it doesn't exist.", MessageSource.Bootstrap);
                    continue;
                }

                // Load the library.
                bool success = NativeLibrary.TryLoad(libPath, out IntPtr libAddr);
                if (!success)
                {
                    ErrorHandler.SubmitError(new Exception($"Couldn't load library {curLib}."));
                }
                else
                {
                    // Add to the list of loaded libraries with the specified key. Library invokers will use this afterward.
                    LoadedLibraries.Add(libArr.Key, libAddr);
                    Engine.Log.Trace($"Loaded library at address {libAddr}.", MessageSource.Bootstrap);
                }
            }

            // Init libraries.
            FreeImage.Init(LoadedLibraries["freeimage"]);
            FT.Init(LoadedLibraries["freetype"]);
            Al.Init(LoadedLibraries["openal"]);
            Alc.Init(LoadedLibraries["openal"]);

            Ready = true;
            Engine.Log.Info("Bootstrap complete!", MessageSource.Bootstrap);
        }

        /// <summary>
        /// Loads an additional native library. Used by plugins and such.
        /// </summary>
        /// <param name="name">The name of the library as it will be referenced from the LoadedLibraries dictionary.</param>
        /// <param name="fileName">Path to the library. The name should be the same for all platforms. Extensions will be appended.</param>
        public static void LoadAdditionalLibrary(string name, string fileName)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                fileName += ".dll";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                fileName += ".dylib";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                fileName += ".so";

            // Load the library.
            Engine.Log.Trace($"Loading library {fileName}...", MessageSource.Bootstrap);
            bool success = NativeLibrary.TryLoad($"{LibFolder}{fileName}", out IntPtr libAddr);
            if (!success)
            {
                ErrorHandler.SubmitError(new Exception($"Couldn't load additional library {name}."));
            }
            else
            {
                // Add to the list of loaded libraries with the specified key. Library invokers will use this afterward.
                LoadedLibraries.Add(name, libAddr);
                Engine.Log.Trace($"Loaded additional library at address {libAddr}.", MessageSource.Bootstrap);
            }
        }
    }
}