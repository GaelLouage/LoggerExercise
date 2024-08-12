using LoggingSystem.Extensions;
using LoggingSystem.Models;

namespace LoggingSystem.Helpers
{
    public static class Logger
    {
        private static List<LogEntry> _logs = new List<LogEntry>();

        public static void Log(string message, Enums.LogLevel level)
        {
            var logEntry = new LogEntry
            {
                Message = message,
                Severity = level,
                TimeStamp = DateTime.Now
            };
            _logs.Add(logEntry);
        }
 
        private static List<LogEntry> GetOrderedLogs(Enums.LogLevel? level, List<LogEntry> orderedLogs, IEnumerable<LogEntry> infoLogs, IEnumerable<LogEntry> warningLogs, IEnumerable<LogEntry> errorLogs)
        {
            return level switch
            {
                Enums.LogLevel.Info => orderedLogs.AddLogRange(infoLogs, warningLogs, errorLogs),
                Enums.LogLevel.Warning => orderedLogs.AddLogRange(warningLogs, infoLogs, errorLogs),
                _ => orderedLogs.AddLogRange(errorLogs, infoLogs, warningLogs)

            };
        }
    }
}
