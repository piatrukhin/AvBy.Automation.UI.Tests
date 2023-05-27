using Microsoft.Extensions.Configuration;


namespace AvBy.Automation.Common.Configuration
{
    public static class ConfigurationManager
    {
        public static T GetConfiguration<T>()
        {
            return GetConfiguration().Get<T>();  
        }

        private static IConfigurationRoot GetConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("C:\\Users\\roman\\source\\repos\\AvBy.Automation.UI\\AvBy.Automation.UI.Tests\\appsettings.json", true, true)
                .Build();
        }
    }
}
