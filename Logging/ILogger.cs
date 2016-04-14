using System;

namespace Logging
{
    public interface ILogger
    {
        void LogTrace(string message, string userId = "", string subdomain = "");

        void LogDebug(string message, string userId = "", string subdomain = "");

        void LogInfo(string message, string userId = "", string subdomain = "");

        void LogWarning(string message, string userId = "", string subdomain = "");

        void LogError(string message, string userId = "", string subdomain = "");

        void LogError(Exception ex, string userId = "", string subdomain = "");

        void LogFatalError(string message, string userId = "", string subdomain = "");

        void LogFatalError(Exception ex, string userId = "", string subdomain = "");
    }
}