using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public class Visible : Condition<WrappedElement>
    {
        public override bool Apply(WrappedElement element)
        {
            var result = element.ActualWebElement.Displayed;
            return result;
        }
    }
}
