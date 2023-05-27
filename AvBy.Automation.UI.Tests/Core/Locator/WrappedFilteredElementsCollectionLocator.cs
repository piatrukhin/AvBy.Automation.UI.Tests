using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Wrappers;
using System.Collections.ObjectModel;
using System.Linq;

namespace RMTBanking.Automation.UI.Tests.Core.Locator
{
    public class WrappedFilteredElementsCollectionLocator : WrappedLocator<ReadOnlyCollection<IWebElement>>
    {
        private readonly Condition<WrappedElement> _condition;
        private readonly WrappedElementsCollection _collection;
        private readonly WrappedDriver _driver;

        public WrappedFilteredElementsCollectionLocator(Condition<WrappedElement> condition, WrappedElementsCollection collection, WrappedDriver driver)
        {
            _condition = condition;
            _collection = collection;
            _driver = driver;
        }

        public override string Info => $"{_collection}.FindBy{_condition.Explain()}";
        public override ReadOnlyCollection<IWebElement> Find()
        {
            return new(
                _collection.ActualWebElements.Where(e => _condition.Apply(new WrappedElement(
                    new WrappedElementLocator($"{Info}", e), _driver, ""))).ToList());
        }
    }
}
