﻿using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using System.Linq;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public class CssValue : Condition<WrappedElement>
    {
        private readonly string _expected;
        private string _actual;

        public CssValue(string expected)
        {
            _expected = expected;
        }

        public override bool Apply(WrappedElement entity)
        {
            _actual = entity.ActualWebElement.GetAttribute("value");
            return _actual != null && _actual.Split(' ').Any(a => a.Contains(_expected));
        }

        public override string ActualResult()
        {
            return $"'{_actual}'";
        }

        public override string ExpectedResult()
        {
            return $"'{_expected}'";
        }
    }
}