using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using System;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions.WebDriverConditions
{
    class WindowsTabCountAtLeast : Condition<IWebDriver>
    {
        private int _expected;
        private int _actual;

        public WindowsTabCountAtLeast(int expected)
        {
            _expected = expected;
        }

        public override bool Apply(IWebDriver entity)
        {
            _actual = entity.WindowHandles.Count;
            return _actual >= _expected;
        }

        public override string ActualResult()
        {
            return $"'{_actual}'";
        }

        public override string ExpectedResult()
        {
            return $"'{_expected}'";
        }

        public override string ToString()
        {
            var message =
                $"{GetType().Name}{Environment.NewLine} Expected : {ExpectedResult()}{Environment.NewLine} Actual : {ActualResult()}";

            return message;
        }
    }
}
