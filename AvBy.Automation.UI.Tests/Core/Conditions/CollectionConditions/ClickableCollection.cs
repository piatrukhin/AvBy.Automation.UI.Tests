using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions.CollectionConditions
{
    public class ClickableCollection : Condition<WrappedElementsCollection>
    {
        public override bool Apply(WrappedElementsCollection entity)
        {
            var elements = entity.ActualWebElements;
            foreach (var element in elements)
            {
                var displayed = element.Displayed;
                var enabled = element.Enabled;
                if (!displayed | !enabled) return false;
            }

            return true;
        }
    }
}
