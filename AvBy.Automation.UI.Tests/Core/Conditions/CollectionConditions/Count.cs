using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions.CollectionConditions
{
    public class Count : Condition<WrappedElementsCollection>
    {

        protected readonly int _expectedCount;
        protected int _actualCount;

        public Count(int count)
        {
            _expectedCount = count;
        }

        public override bool Apply(WrappedElementsCollection entity)
        {
            _actualCount = entity.ActualWebElements.Count;
            return _actualCount == _expectedCount;
        }

        public override string ExpectedResult()
        {
            return $"{_expectedCount}";
        }

        public override string ActualResult()
        {
            return $"{_actualCount}";
        }
    }
}
