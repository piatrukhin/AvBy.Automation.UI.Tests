using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Conditions.WebDriverConditions;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    static class WindowsTabs
    {
        public static Condition<IWebDriver> WindowsTabsCountShouldBe(int value)
        {
            return new WindowsTabCount(value);
        }

        public static Condition<IWebDriver> WindowsTabsCountShouldBeAtLeast(int value)
        {
            return new WindowsTabCountAtLeast(value);
        }
    }
}
