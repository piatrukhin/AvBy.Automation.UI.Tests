using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Element.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces;
using System.Collections.ObjectModel;

namespace RMTBanking.Automation.UI.Tests.Core.ElementsCollection
{
    class WrappedElementsCollectionSearchContext : WrappedLocator<ReadOnlyCollection<IWebElement>>
    {
        private readonly IWrappedSearchContext _context;
        private readonly By _locator;

        public WrappedElementsCollectionSearchContext(By locator, IWrappedSearchContext context)
        {
            _locator = locator;
            _context = context;
        }

        public override string Info => $"By.Selene: ({_context}).FindAll({_locator})";
        public override ReadOnlyCollection<IWebElement> Find()
        {
            return _context.FindElements(_locator);
        }
    }
}
