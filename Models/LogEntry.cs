using Microsoft.VisualBasic;

namespace LoggingSystem.Models
{
    public class LogEntry
    {
        public string Message {  get; set; }
        public LoggingSystem.Enums.LogLevel Severity { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
