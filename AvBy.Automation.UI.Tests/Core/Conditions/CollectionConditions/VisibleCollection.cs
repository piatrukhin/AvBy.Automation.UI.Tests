using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions.CollectionConditions
{
    public class VisibleCollection : Condition<WrappedElementsCollection>
    {
        public override bool Apply(WrappedElementsCollection entity)
        {
            var elements = entity.ActualWebElements;
            foreach (var element in elements)
            {
                var displayed = element.Displayed;
                if (!displayed) return false;
            }

            return true;
        }
    }
}
