﻿// Emotion - https://github.com/Cryru/Emotion

#region Using

using System;
using System.Threading;
using Emotion.Engine;
using Emotion.Game.Camera;
using Emotion.GLES;
using Emotion.Primitives;
using Soul.Logging;

#endregion

namespace Emotion.Debug
{
    public static class Debugger
    {
        #region Declarations

        #if DEBUG

        /// <summary>
        /// A Soul.Logging service which logs all debug messages to a file.
        /// </summary>
        private static ImmediateLoggingService _logger = new ImmediateLoggingService
        {
            LogLimit = 10,
            Limit = 2000,
            Stamp = "Emotion Engine Log"
        };

        /// <summary>
        /// An empty object used as a mutex when writing log messages.
        /// </summary>
        private static object _mutexLock = new object();

        /// <summary>
        /// The next debug command to process.
        /// </summary>
        private static string _command = "";

        /// <summary>
        /// The thread on which console input is read.
        /// </summary>
        private static Thread _consoleThread;

        #endif

        #endregion

        /// <summary>
        /// Setup the debugger.
        /// </summary>
        /// <param name="context">
        /// The context which will host the debugger. Other contexts can use it, but only the provided one
        /// will run.
        /// </param>
        internal static void Setup(Context context)
        {
#if DEBUG
            // Check if already setup.
            if (_consoleThread != null) return;

            // Start the console thread.
            _consoleThread = new Thread(() => ConsoleThread(context));
            _consoleThread.Start();
            while (!_consoleThread.IsAlive)
            {
            }
#endif
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="type">The type of message to log.</param>
        /// <param name="source">The source of the message.</param>
        /// <param name="message">The message itself.</param>
        public static void Log(MessageType type, MessageSource source, string message)
        {
#if DEBUG
            // Prevent logging from multiple threads messing up coloring and logging.
            lock (_mutexLock)
            {
                // Change the color of the log depending on the type.
                switch (type)
                {
                    case MessageType.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case MessageType.Info:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case MessageType.Trace:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case MessageType.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }

                // Log and display the message.
                _logger.Log("[" + type + "-" + source + "] " + message);
                Console.WriteLine("[" + source + "] " + message);

                // Restore the normal color.
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
#endif
        }

        #region Loops

        /// <summary>
        /// Is run every tick by the platform context.
        /// </summary>
        internal static void Update(ScriptingEngine scripting)
        {
#if DEBUG
            // Check if there is a command to execute.
            if (_command == string.Empty) return;
            scripting.RunScript(_command);
            _command = "";
#endif
        }

        internal static void Draw(Renderer renderer, Context context)
        {
#if DEBUG
            // Check if there is an attached renderer with a camera.
            if (renderer?.Camera != null) CameraBoundDraw(renderer);

            // Draw the mouse cursor location.
            MouseBoundDraw(renderer, context.Input);
#endif
        }

        #endregion

#if DEBUG

        #region Debug Drawing

        private static void CameraBoundDraw(Renderer renderer)
        {
            CameraBase camera = renderer.Camera;

            // Draw bounds.
            renderer.DrawRectangleOutline(camera.Bounds, Color.Yellow);

            // Draw center.
            Rectangle centerDraw = new Rectangle(0, 0, 10, 10);
            centerDraw.X = (int) camera.Bounds.Center.X - centerDraw.Width / 2;
            centerDraw.Y = (int) camera.Bounds.Center.Y - centerDraw.Height / 2;

            renderer.DrawRectangleOutline(centerDraw, Color.Yellow);
        }

        private static void MouseBoundDraw(Renderer renderer, Input.Input input)
        {
            Vector2 mouseLocation = input.GetMousePosition();

            Rectangle mouseBounds = new Rectangle(0, 0, 10, 10);
            mouseBounds.X = (int) mouseLocation.X - mouseBounds.Width / 2;
            mouseBounds.Y = (int) mouseLocation.Y - mouseBounds.Height / 2;

            renderer.DrawRectangleOutline(mouseBounds, Color.Pink, false);
        }

        #endregion

        #region Scripting

        /// <summary>
        /// Processes console input without blocking the engine.
        /// </summary>
        private static void ConsoleThread(Context context)
        {
            while (context.Running)
            {
                string readLine = Console.ReadLine();
                if (readLine != null) _command = readLine.Trim(' ');
            }
        }

        #endregion

#endif
    }
}