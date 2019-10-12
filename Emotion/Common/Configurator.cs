﻿#region Using

using System;
using System.Collections.Generic;
using System.Numerics;
using Emotion.Standard.Logging;

#endregion

namespace Emotion.Common
{
    public sealed class Configurator
    {
        /// <summary>
        /// Whether the configurator was used to setup the engine.
        /// After this it is no longer modifiable.
        /// </summary>
        public bool Setup { get; private set; }

        /// <summary>
        /// Lock the configuration, making the configurator unmodifiable.
        /// </summary>
        public void Lock()
        {
            Setup = true;
        }

        /// <summary>
        /// The logging provider to use.
        /// </summary>
        public LoggingProvider Logger { get; private set; }

        /// <summary>
        /// Set the logging provider. If none set the default one will be created at setup.
        /// The default logger logs to the console if in debug mode, and to a file.
        /// </summary>
        /// <param name="logger">The logger instance to use.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator SetLogger(LoggingProvider logger)
        {
            if (!Setup) Logger = logger;
            return this;
        }

        /// <summary>
        /// Whether the Engine is in debug mode. Off by default.
        /// There are other factors such as compilation targets which determine whether it is "truly" debug mode,
        /// but most of the "in engine" debugging functionalities are runtime and determined using this flag,
        /// because the nuget package is compiled in Release mode. The debug mode compilation is for debugging
        /// the engine, while this switch is for debugging the game running on it.
        /// </summary>
        public bool DebugMode { get; private set; }

        /// <summary>
        /// The function to use in frame by frame mode to decide whether to tick over to the next frame.
        /// If the function returns true, the next tick will be ran.
        /// This is off by default, and is only available if debug mode is enabled.
        /// </summary>
        public Func<bool> FrameByFrame { get; private set; }

        /// <summary>
        /// Whether to use the debug game loop.
        /// By default this is off. Without it you cannot use "FrameByFrame" mode.
        /// </summary>
        public bool DebugLoop { get; private set; }

        /// <summary>
        /// Set debug mode on, or off.
        /// For more information read the documentation on the DebugMode property itself.
        /// </summary>
        /// <param name="debug">What to set debug mode to.</param>
        /// <param name="frameByFrame">
        /// The function to use in frame by frame mode.
        /// Having this function automatically enables frame by frame mode. If it returns true the frame (and tick) will be
        /// executed.
        /// </param>
        /// <param name="debugLoop">Whether to use the debug loop.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator SetDebug(bool debug, bool debugLoop = false, Func<bool> frameByFrame = null)
        {
            if (Setup) return this;
            DebugMode = debug;
            DebugLoop = debugLoop;
            FrameByFrame = frameByFrame;
            return this;
        }

        /// <summary>
        /// The resolution to render at.
        /// </summary>
        public Vector2 RenderSize { get; private set; } = new Vector2(640, 360);

        /// <summary>
        /// Whether to scale the resolution at exact multitudes of the render size. Off by default.
        /// This means that pixels will never be interpolated into one another, and will remain squares.
        /// If off the viewport will be scaled in a letterbox/pillarbox to the closest multitude of the render size.
        /// </summary>
        public bool IntegerScale { get; private set; }

        /// <summary>
        /// Whether to scale the render size to the host size.
        /// When set to this mode the render size is used as a reference point for the "Engine.Renderer.Scale" and
        /// "Engine.Renderer.IntScale" properties.
        /// This is the default.
        /// </summary>
        public bool FullScale { get; private set; } = true;

        /// <summary>
        /// Set the resolution to render at. 640x360 by default as it is 16:9 (the most common aspect ratio) and scales well.
        /// The default framebuffer will be set to this resolution and scaling will be done around it.
        /// If the host is in windowed mode this will be the size of the window as well.
        /// </summary>
        /// <param name="renderSize">The resolution to render at.</param>
        /// <param name="integerScale">
        /// Whether to scale the framebuffer on integer levels only. Read the IntegerScale property for
        /// more information.
        /// </param>
        /// <param name="fullScale">Whether to scale the render size to the host size.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator SetRenderSize(Vector2? renderSize = null, bool integerScale = false, bool fullScale = true)
        {
            if (Setup) return this;
            if (renderSize != null) RenderSize = (Vector2) renderSize;
            IntegerScale = integerScale;
            FullScale = fullScale;
            return this;
        }

        /// <summary>
        /// Whether to run the renderer in compatibility mode.
        /// In this mode newer features such as "direct state access" are disabled.
        /// </summary>
        public bool RendererCompatMode { get; private set; }

        /// <summary>
        /// Other settings related to the Renderer.
        /// These shouldn't need to be modified by the user and are here for debugging or testing purposes.
        /// </summary>
        /// <param name="rendererCompatMode">Whether to run the renderer in compatibility mode.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator SetRenderSettings(bool rendererCompatMode)
        {
            if (Setup) return this;
            RendererCompatMode = rendererCompatMode;
            return this;
        }

        /// <summary>
        /// The desired tps and fps.
        /// 60 by default, if set to 0 or below, the loop will run as fast as possible.
        /// You usually don't want that as it means it will have an uneven delta time.
        /// </summary>
        public uint DesiredStep { get; private set; } = 60;

        /// <summary>
        /// Set settings regarding the main loop.
        /// </summary>
        /// <param name="desiredStep">The target tps and fps.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator SetLoopSettings(uint desiredStep)
        {
            if (Setup) return this;
            DesiredStep = desiredStep;
            return this;
        }

        /// <summary>
        /// The starting size of the host. On desktop platforms the host is the window.
        /// On some platforms this is ignored as the host is either always fullscreen or unresizable.
        /// </summary>
        public Vector2 HostSize = new Vector2(640, 360);

        /// <summary>
        /// Set starting settings regarding the host.
        /// Some of these might be ignored depending on the platform.
        /// </summary>
        /// <param name="hostSize">The starting size of the host.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator SetHostSettings(Vector2 hostSize)
        {
            if (Setup) return this;
            HostSize = hostSize;
            return this;
        }

        /// <summary>
        /// List of plugins to load.
        /// </summary>
        public List<IPlugin> Plugins { get; private set; } = new List<IPlugin>();

        /// <summary>
        /// Add a plugin.
        /// </summary>
        /// <param name="plugin">The plugin to add.</param>
        /// <returns>This configurator, for chaining purposes.</returns>
        public Configurator AddPlugin(IPlugin plugin)
        {
            if (Setup) return this;
            Plugins.Add(plugin);
            return this;
        }
    }
}