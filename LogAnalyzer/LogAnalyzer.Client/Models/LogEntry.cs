namespace LogAnalyzer.Client.Models
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string AppDomainId { get; set; }
        public int ThreadId { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
    }
}
