using LoggingSystem.Models;

namespace LoggingSystem.Extensions
{
    public static class LogExtensions
    {
        public static List<LogEntry> AddLogRange(this List<LogEntry> orderedLogs, IEnumerable<LogEntry> infoLogs, IEnumerable<LogEntry> warningLogs, IEnumerable<LogEntry> errorLogs)
        {
            orderedLogs.AddRange(infoLogs);
            orderedLogs.AddRange(warningLogs);
            orderedLogs.AddRange(errorLogs);
            return orderedLogs;
        }
  
    }
}
