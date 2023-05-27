using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RMTBanking.Automation.UI.Tests.Core.Wrappers
{
    internal static class DriverManager
    {
        public static WrappedDriver CommonDriver = new WrappedDriver();

        public static IWebDriver GetWebDriver()
        {
            var optionsChrome = new ChromeOptions();
            optionsChrome.AddArguments(ChromiumBrowserOptions);
            optionsChrome.AddExcludedArgument("enable-automation");
            optionsChrome.AddUserProfilePreference("credentials_enable_service", false);
            optionsChrome.AddUserProfilePreference("profile.password_manager_enabled", false);
            return new ChromeDriver(optionsChrome);
        }

        static readonly string[] ChromiumBrowserOptions =
{
            "--test-type",
            "--start-maximized",
            "--no-sandbox",
            "--incognito"
        };
    }
}
