using AvBy.Automation.Common.Configuration.Models;
using static AvBy.Automation.Common.Configuration.ConfigurationManager;

namespace AvBy.Automation.Common.Configuration
{
    public static class AppConfiguration
    {
        static AppConfiguration()
        {
            Config = GetConfiguration<AppConfig>();
        }
       
        public static readonly AppConfig Config;
        public static Uri BaseUrl => Config.BaseUrl; //new Uri("https://av.by/")
        public static List<User> Users => new List<User> {new User(1,"296183717","rino2416rino"), new User(2, "qre3","roman.piatrukhin@gmail.com","qafre!r"), new User(3,"54543453","Zazer!rer@fd.ce","rere!") };
        public static TimeSpan GetTimeout() => TimeSpan.FromSeconds(Config.TimeoutSeconds);
        public static TimeSpan GetPollingInterval() => TimeSpan.FromMilliseconds(Config.PollingIntervalMilliseconds);
    }
}
