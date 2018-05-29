﻿// Emotion - https://github.com/Cryru/Emotion

#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Emotion.Debug;
using Emotion.Engine;

#endregion

namespace Emotion.IO
{
    public class AssetLoader : ContextObject
    {
        #region Properties

        /// <summary>
        /// The root directory in which assets are located.
        /// </summary>
        public string RootDirectory = "Assets";

        #endregion

        #region Objects

        /// <summary>
        /// Loaded assets.
        /// </summary>
        private Dictionary<string, Asset> _loadedAssets;

        #endregion

        internal AssetLoader(Context context) : base(context)
        {
            _loadedAssets = new Dictionary<string, Asset>();
        }

        /// <summary>
        /// Returns an asset, if not loaded loads it.
        /// </summary>
        /// <typeparam name="T">The type of asset.</typeparam>
        /// <param name="path">A file path to the asset with the RootDirectory as the parent. Will be converted to an engine path.</param>
        /// <returns>A loaded asset.</returns>
        [SuppressMessage("ReSharper", "ConvertIfStatementToReturnStatement")]
        public T Get<T>(string path) where T : Asset
        {
            // Convert the path to an engine path.
            string enginePath = PathToEnginePath(path);

            // Check if the asset is already loaded, in which case return it.
            if (_loadedAssets.ContainsKey(enginePath))
            {
                // Get the asset.
               return (T) _loadedAssets[enginePath];
            }

            // Check whether the file exists.
            if (!Exists(enginePath)) throw new Exception("Could not find asset " + enginePath);

            // Read the file.
            byte[] fileContents = ReadFile(enginePath);

            // Create an instance of the asset.
            T temp = (T) Activator.CreateInstance(typeof(T));
            temp.AssetName = enginePath;
            _loadedAssets[enginePath] = temp;

            // Process.
            DebugMessageWrap("Processing", enginePath, typeof(T));
            temp.Process(fileContents);

            // Return.
            return temp;
        }

        /// <summary>
        /// Free an asset unloading and destroying it.
        /// </summary>
        /// <param name="path">A path to the asset. Will be converted to an engine path.</param>
        public void Free(string path)
        {
            // Convert the path to an engine path.
            string enginePath = PathToEnginePath(path);

            // Check if loaded.
            if (!_loadedAssets.ContainsKey(enginePath)) return;

            // Destroy it.
            _loadedAssets[enginePath].Destroy();

            // Remove from the list.
            _loadedAssets.Remove(enginePath);
        }

        #region Helpers

        /// <summary>
        /// Returns whether the specified file exists.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>True if it exists, false otherwise.</returns>
        public bool Exists(string path)
        {
            return File.Exists(PathToCrossPlatform(path));
        }

        /// <summary>
        /// Reads a file and returns its contents as a byte array.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>The contents of the file as a byte array.</returns>
        private byte[] ReadFile(string path)
        {
            string parsedPath = PathToCrossPlatform(path);

            if (!File.Exists(parsedPath)) throw new Exception("The file " + parsedPath + " could not be found.");

            // Load the bytes of the file.
            return File.ReadAllBytes(parsedPath);
        }

        /// <summary>
        /// Converts the provided path to an engine universal format,
        /// </summary>
        /// <param name="path">The path to convert.</param>
        /// <returns>The converted path.</returns>
        private static string PathToEnginePath(string path)
        {
            return path.Replace('/', '$').Replace('\\', '$').Replace('$', '/');
        }

        /// <summary>
        /// Converts the provided path to the current platform's path signature.
        /// </summary>
        /// <param name="path">The path to convert.</param>
        /// <returns>The converted path.</returns>
        private string PathToCrossPlatform(string path)
        {
            return RootDirectory + Path.DirectorySeparatorChar + path.Replace('/', '$').Replace('\\', '$').Replace('$', Path.DirectorySeparatorChar);
        }

        /// <summary>
        /// Post a formatted asset loader debug message.
        /// </summary>
        /// <param name="operation">The operation being performed.</param>
        /// <param name="path">An engine path to the file.</param>
        /// <param name="type">The type of asset.</param>
        /// <param name="warning">Whether the message is a warning.</param>
        private void DebugMessageWrap(string operation, string path, Type type, bool warning = false)
        {
            Debugger.Log(warning ? MessageType.Warning : MessageType.Info, MessageSource.AssetLoader, operation + " asset [" + path + "] of type " + type);
        }

        #endregion
    }
}