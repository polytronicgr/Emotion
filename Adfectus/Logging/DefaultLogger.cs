﻿#region Using

using System;
using System.IO;
using System.Threading;
using Adfectus.Common;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

#endregion

namespace Adfectus.Logging
{
    /// <summary>
    /// The default logger. Uses SeriLog.
    /// </summary>
    public sealed class DefaultLogger : LoggingProvider
    {
        /// <summary>
        /// SeriLog logger instance.
        /// </summary>
        private Logger _logger;

        /// <summary>
        /// Create a default logger.
        /// </summary>
        public DefaultLogger()
        {
            string fileName = $".{Path.DirectorySeparatorChar}Logs{Path.DirectorySeparatorChar}Log_{DateTime.Now.ToFileTime()}.log";

            LoggerConfiguration loggerConfig = new LoggerConfiguration()
                .MinimumLevel.Is(LogEventLevel.Verbose)
                .WriteTo.Async(a => a.File(fileName));

            if (Engine.DebugMode) loggerConfig.WriteTo.Async(a => a.Console(LogEventLevel.Verbose, theme: AnsiConsoleTheme.Code));

            _logger = loggerConfig.CreateLogger();
        }

        /// <inheritdoc />
        public override void Log(MessageType type, MessageSource source, string message)
        {
            string fullMessage = $"[{source}] [{Thread.CurrentThread.Name}/{Thread.CurrentThread.ManagedThreadId}] {message}";

            switch (type)
            {
                case MessageType.Error:
                    _logger.Error(fullMessage);
                    break;
                case MessageType.Info:
                    _logger.Information(fullMessage);
                    break;
                case MessageType.Trace:
                    _logger.Debug(fullMessage);
                    break;
                case MessageType.Warning:
                    _logger.Warning(fullMessage);
                    break;
                default:
                    _logger.Verbose(fullMessage);
                    break;
            }
        }

        /// <inheritdoc />
        public override void Dispose()
        {
            _logger.Dispose();
        }
    }
}