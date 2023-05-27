using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Wrappers;
using System;
using System.Linq;

namespace RMTBanking.Automation.UI.Tests.Core.Locator
{
    public class WrappedElementByConditionLocator : WrappedLocator<IWebElement>
    {
        private readonly Condition<WrappedElement> _condition;
        private readonly WrappedElementsCollection _collection;
        private readonly WrappedDriver _driver;

        public WrappedElementByConditionLocator(Condition<WrappedElement> condition, WrappedElementsCollection collection, WrappedDriver driver)
        {
            _condition = condition;
            _collection = collection;
            _driver = driver;
        }

        public override string Info => $"{_collection}.FindBy{_condition.Explain()}";
        public override IWebElement Find()
        {
            var webElements = _collection.ActualWebElements;

            var found = webElements.ToList()
                .Find(e => _condition.Apply(new WrappedElement(
                    new WrappedElementLocator(
                        $"{Info}", e),
                    _driver, $"{_collection.Description} filtering by {_condition.Explain()}")));

            if (found != null) return found;
            {
                var actualTexts = webElements.ToList().Select(element => element.Text).ToArray();
                throw new NotFoundException(
                    $"element was not found in collection by condition {_condition.Explain()}{Environment.NewLine}Actual visible texts : [{ string.Join(",", actualTexts) }]");
            }
        }
    }
}
