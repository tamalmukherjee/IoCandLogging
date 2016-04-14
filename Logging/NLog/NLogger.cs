using NLog;
using System;

namespace Logging.NLog
{
    public class NLogger : ILogger
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message, string userId = "", string subdomain = "")
        {
            WriteLog(message, userId, subdomain, LogLevel.Debug);
        }

        public void LogError(Exception ex, string userId = "", string subdomain = "")
        {
            WriteLog(ex, userId, subdomain, LogLevel.Error);
        }

        public void LogError(string message, string userId = "", string subdomain = "")
        {
            WriteLog(message, userId, subdomain, LogLevel.Error);
        }

        public void LogFatalError(Exception ex, string userId = "", string subdomain = "")
        {
            WriteLog(ex, userId, subdomain, LogLevel.Fatal);
        }

        public void LogFatalError(string message, string userId = "", string subdomain = "")
        {
            WriteLog(message, userId, subdomain, LogLevel.Fatal);
        }

        public void LogInfo(string message, string userId = "", string subdomain = "")
        {
            WriteLog(message, userId, subdomain, LogLevel.Info);
        }

        public void LogTrace(string message, string userId = "", string subdomain = "")
        {
            WriteLog(message, userId, subdomain, LogLevel.Trace);
        }

        public void LogWarning(string message, string userId = "", string subdomain = "")
        {
            WriteLog(message, userId, subdomain, LogLevel.Warn);
        }

        private void WriteLog(string message, string userId, string subdomain, LogLevel level)
        {
            LogEventInfo logEvent = new LogEventInfo
            {
                Level = level,
                Message = message
            };
            SetLogEventProperties(logEvent, userId, subdomain);
            logger.Log(logEvent);
        }

        private void WriteLog(Exception ex, string userId, string subdomain, LogLevel level)
        {
            LogEventInfo logEvent = new LogEventInfo
            {
                Level = level,
                Exception = ex
            };
            SetLogEventProperties(logEvent, userId, subdomain);
            logger.Log(logEvent);
        }

        private static void SetLogEventProperties(LogEventInfo logEvent, string userId, string subdomain)
        {
            logEvent.LoggerName = "ConnectNowLogger";
            if (!string.IsNullOrEmpty(userId))
            {
                logEvent.Properties["userId"] = userId;
            }
            if (!string.IsNullOrEmpty(subdomain))
            {
                logEvent.Properties["subdomain"] = subdomain;
            }
        }
    }
}