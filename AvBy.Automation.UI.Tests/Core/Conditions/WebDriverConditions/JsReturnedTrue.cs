using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using System;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions.WebDriverConditions
{
    public class JsReturnedTrue : Condition<IWebDriver>
    {
        private readonly string _script;
        private readonly object[] _arguments;
        private bool _result;

        public JsReturnedTrue(string script, params object[] arguments)
        {
            _script = script;
            _arguments = arguments;
        }

        public override bool Apply(IWebDriver entity)
        {
            try
            {
                _result = (bool)((IJavaScriptExecutor)entity).ExecuteScript(_script, _arguments);
            }
            catch (Exception)
            {
                _result = false;
            }

            return _result;
        }
    }
}
