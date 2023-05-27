using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces;
using System.Collections.ObjectModel;

namespace RMTBanking.Automation.UI.Tests.Core.Locator
{
    public class WrappedElementsCollectionSearchContextLocator : WrappedLocator<ReadOnlyCollection<IWebElement>>
    {
        private readonly IWrappedSearchContext _context;
        private readonly By _locator;


        public WrappedElementsCollectionSearchContextLocator(By locator, IWrappedSearchContext context)
        {
            _context = context;
            _locator = locator;
        }

        public override string Info => $"{_context}.FindAll({_locator})";
        public override ReadOnlyCollection<IWebElement> Find()
        {
            return _context.FindElements(_locator);
        }
    }
}
