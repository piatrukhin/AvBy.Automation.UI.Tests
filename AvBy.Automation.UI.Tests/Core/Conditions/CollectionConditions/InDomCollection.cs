using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions.CollectionConditions
{
    public class InDomCollection : Condition<WrappedElementsCollection>
    {
        public override bool Apply(WrappedElementsCollection entity)
        {
            var element = entity.ActualWebElements;
            return true;
        }
    }
}
