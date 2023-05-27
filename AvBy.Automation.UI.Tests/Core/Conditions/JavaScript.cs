using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Conditions.WebDriverConditions;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public static class JavaScript
    {
        public static Condition<IWebDriver> JsReturnedTrue(string script, params object[] arguments)
        {
            return new JsReturnedTrue(script, arguments);
        }

        public static Condition<IWebDriver> JavaScriptLoadingComplete() => new JavaScriptLoadingComplete();
    }
}
