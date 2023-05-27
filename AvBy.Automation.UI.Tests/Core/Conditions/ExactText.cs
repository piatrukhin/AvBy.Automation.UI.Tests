using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using System;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public class ExactText : Condition<WrappedElement>
    {
        protected string _expected;
        protected string _actual;

        public ExactText(string expected)
        {
            _expected = expected;
            _actual = string.Empty;
        }

        public override bool Apply(WrappedElement entity)
        {
            _actual = entity.ActualWebElement.Text;
            return _actual.Equals(_expected, StringComparison.InvariantCultureIgnoreCase);
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
