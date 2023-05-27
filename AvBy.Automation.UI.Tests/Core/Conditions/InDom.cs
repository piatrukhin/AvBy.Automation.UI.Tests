using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public class InDom : Condition<WrappedElement>
    {
        public override bool Apply(WrappedElement element)
        {
            var attribute = element.ActualWebElement;
            return true;
        }
    }
}
