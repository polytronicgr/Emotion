﻿#region Using

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using Emotion.Common;
using Emotion.Platform.Config;
using Emotion.Platform.Implementation.Null;
using Emotion.Platform.Implementation.Win32;
using Emotion.Platform.Input;
using Emotion.Standard.Logging;
using Emotion.Utility;
using OpenGL;

#endregion

namespace Emotion.Platform.Implementation
{
    public abstract class PlatformBase
    {
        /// <summary>
        /// Whether the platform is setup.
        /// </summary>
        public bool IsSetup { get; private set; }

        /// <summary>
        /// Whether the platform's window is open, and considered active.
        /// </summary>
        public bool IsOpen { get; protected set; }

        /// <summary>
        /// The platform's window.
        /// </summary>
        public Window Window { get; protected set; }

        /// <summary>
        /// The platform's audio context. If any.
        /// </summary>
        public AudioContext Audio { get; protected set; }

        /// <summary>
        /// List of connected monitors.
        /// </summary>
        public List<Monitor> Monitors = new List<Monitor>();

        /// <summary>
        /// Called when a key is pressed, let go, or a held event is triggered.
        /// </summary>
        public EmotionEvent<Key, KeyStatus> OnKey = new EmotionEvent<Key, KeyStatus>();

        /// <summary>
        /// Called when a mouse key is pressed or let go.
        /// </summary>
        public EmotionEvent<MouseKey, KeyStatus> OnMouseKey = new EmotionEvent<MouseKey, KeyStatus>();

        /// <summary>
        /// Called when the mouse scrolls.
        /// </summary>
        public EmotionEvent<float> OnMouseScroll = new EmotionEvent<float>();

        /// <summary>
        /// Called when text input is detected. Most of the time this is identical to OnKey, but without the state.
        /// </summary>
        public EmotionEvent<char> OnTextInput = new EmotionEvent<char>();

        /// <summary>
        /// Returns the current mouse position. Is preprocessed by the Renderer to scale to the window if possible.
        /// </summary>
        public Vector2 MousePosition { get; protected set; } = Vector2.Zero;

        /// <summary>
        /// The event is set while the window is focused.
        /// </summary>
        public ManualResetEvent FocusWait { get; set; } = new ManualResetEvent(true);

        /// <summary>
        /// The sizes to switch between in debug mode by using ctrl + F1-F9
        /// </summary>
        private Vector2[] _windowSizes =
        {
            new Vector2(640, 360), // Lowest 16:9 good integer scaling potential
            new Vector2(960, 540), // Low 16:9
            new Vector2(1280, 720), // 16:9 720p HD
            new Vector2(1920, 1080), // 16:9 1080p FullHD

            new Vector2(640, 400), // Lowest 16:10
            new Vector2(768, 480), // Low 16:10
            new Vector2(1280, 800), // 16:10 HD
            new Vector2(1920, 1200), // 16:10 FullHD

            new Vector2(800, 600), // 4:3
            new Vector2(1600, 768) // Super Wide
        };

        #region Internal

        /// <summary>
        /// Setup the native platform and creates a window.
        /// </summary>
        /// <param name="config">Configuration for the platform - usually passed from the engine.</param>
        internal void Setup(Configurator config)
        {
            SetupPlatform(config);
            if (Window == null) return;

            // Bind this window and its context.
            // "There /can/ be only one."
            Window.Context.MakeCurrent();
            Gl.BindAPI(Window.Context.GetProcAddress);
            Gl.QueryContextVersion();

            // Set display mode, show and focus.
            Window.DisplayMode = config.InitialDisplayMode;
            Window.WindowState = WindowState.Normal;

            // Attach default key behavior.
            OnKey.AddListener(DefaultButtonBehavior);

            IsSetup = true;
            IsOpen = true;
        }

        /// <summary>
        /// Provides default button behavior for all platforms.
        /// </summary>
        private bool DefaultButtonBehavior(Key key, KeyStatus state)
        {
            if (Engine.Configuration.DebugMode)
            {
                bool ctrl = GetKeyDown(Key.LeftControl) || GetKeyDown(Key.RightControl);
                if (key >= Key.F1 && key <= Key.F10 && state == KeyStatus.Down && ctrl && Window != null)
                {
                    Vector2 chosenSize = _windowSizes[key - Key.F1];
                    Window.Size = chosenSize;
                    Engine.Log.Info($"Set window size to {chosenSize}", MessageSource.Platform);
                }
            }

            bool alt = GetKeyDown(Key.LeftAlt) || GetKeyDown(Key.RightAlt);

            if (key == Key.Enter && state == KeyStatus.Down && alt && Window != null)
            {
                Window.DisplayMode = Window.DisplayMode == DisplayMode.Fullscreen ? DisplayMode.Windowed : DisplayMode.Fullscreen;
            }

            return true;
        }

        internal void UpdateMonitor(Monitor monitor, bool connected, bool first)
        {
            if (connected)
            {
                Engine.Log.Info($"Connected monitor {monitor.Name} ({monitor.Width}x{monitor.Height}){(first ? " Primary" : "")}", MessageSource.Platform);

                if (first)
                {
                    Monitors.Insert(0, monitor);

                    // Re-initiate fullscreen mode.
                    if (Window == null || Window.DisplayMode != DisplayMode.Fullscreen) return;
                    Window.DisplayMode = DisplayMode.Windowed;
                    Window.DisplayMode = DisplayMode.Fullscreen;
                }
                else
                {
                    Monitors.Add(monitor);
                }
            }
            else
            {
                Engine.Log.Info($"Disconnected monitor {monitor.Name} ({monitor.Width}x{monitor.Height}){(first ? " Primary" : "")}", MessageSource.Platform);

                Monitors.Remove(monitor);

                // Exit fullscreen mode as it may have been fullscreen on this monitor.
                // This will cause a recenter on the primary monitor.
                if (Window != null && Window.DisplayMode == DisplayMode.Fullscreen && Monitors.Count > 0)
                    Window.DisplayMode = DisplayMode.Windowed;
            }
        }

        #endregion

        #region Implementation API

        /// <summary>
        /// Platform setup.
        /// </summary>
        protected abstract void SetupPlatform(Configurator config);

        /// <summary>
        /// Display an error message natively.
        /// Usually this means a popup will show up.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public abstract void DisplayMessageBox(string message);

        /// <summary>
        /// Update the platform. If this returns false then the platform/its window was closed.
        /// If the window is unfocused this blocks until a platform message is received.
        /// </summary>
        /// <returns>Whether the platform is alive.</returns>
        public abstract bool Update();

        #endregion

        #region Input API

        /// <summary>
        /// Returns whether the specified key is down.
        /// </summary>
        /// <param name="key">To key to check.</param>
        public abstract bool GetKeyDown(Key key);

        /// <summary>
        /// Returns whether the specified mouse key is down.
        /// </summary>
        /// <param name="key">To mouse key to check.</param>
        public abstract bool GetMouseKeyDown(MouseKey key);

        #endregion

        #region Library API

        /// <summary>
        /// Load a native library.
        /// </summary>
        /// <param name="path">The path to the native library.</param>
        public abstract IntPtr LoadLibrary(string path);

        /// <summary>
        /// Get the pointer which corresponds to a symbol (such as a function) in a native library.
        /// </summary>
        /// <param name="library">The pointer to a native library..</param>
        /// <param name="symbolName">The name of the symbol to find.</param>
        /// <returns>The pointer which corresponds to the library looking for.</returns>
        public abstract IntPtr GetLibrarySymbolPtr(IntPtr library, string symbolName);

        /// <summary>
        /// Get a function delegate from a library.
        /// </summary>
        public TDelegate GetFunctionByName<TDelegate>(IntPtr library, string funcName)
        {
            IntPtr funcAddress = GetLibrarySymbolPtr(library, funcName);
            return funcAddress == IntPtr.Zero ? default : Marshal.GetDelegateForFunctionPointer<TDelegate>(funcAddress);
        }

        #endregion

        /// <summary>
        /// Close the platform.
        /// This call is meant to notify the platform of a shut-down.
        /// No calls to the platform should be made afterward.
        /// </summary>
        public virtual void Close()
        {
            IsOpen = false;
            Window.Dispose();
        }

        /// <summary>
        /// Setup a native platform.
        /// </summary>
        /// <param name="engineConfig">The engine configuration.</param>
        /// <returns>The native platform.</returns>
        public static PlatformBase GetInstanceOfDetected(Configurator engineConfig)
        {
            PlatformBase platform = null;

            // Detect platform.
            if (engineConfig.PlatformOverride != null)
            {
                platform = engineConfig.PlatformOverride;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Win32
                platform = new Win32Platform();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Cocoa
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Check for Wayland.
                if (Environment.GetEnvironmentVariable("WAYLAND_DISPLAY") != null)
                {
                }
            }
            
            // If none initialized - fallback to none.
            if (platform == null)
            {
                platform = new NullPlatform();
            }

            Engine.Log.Info($"Platform is: {platform}", MessageSource.Platform);
            platform.Setup(engineConfig);

            return platform;
        }
    }
}