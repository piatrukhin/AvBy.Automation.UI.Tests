using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public class Clickable : Condition<WrappedElement>
    {
        public override bool Apply(WrappedElement element)
        {
            return element.ActualWebElement.Displayed && element.ActualWebElement.Enabled;
        }
    }
}
