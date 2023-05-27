namespace AvBy.Automation.Common.Configuration.Models
{
    public class AppConfig
    {
        public Uri BaseUrl { get; set; }
        public Uri UserServiceBaseUrl { get; set; }
        public List<User> Users { get; set; }
        public int TimeoutSeconds { get; set; }
        public int PollingIntervalMilliseconds { get; set; }
    }
}
