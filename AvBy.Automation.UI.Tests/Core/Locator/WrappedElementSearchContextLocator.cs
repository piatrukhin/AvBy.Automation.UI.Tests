using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces;

namespace RMTBanking.Automation.UI.Tests.Core.Locator
{
    public class WrappedElementSearchContextLocator : WrappedLocator<IWebElement>
    {
        private readonly By _locator;
        private readonly IWrappedSearchContext _context;

        public WrappedElementSearchContextLocator(By locator, IWrappedSearchContext context)
        {
            _locator = locator;
            _context = context;
        }

        public override string Info => $"{_context.GetType().Name}.Find({_locator})";
        public override IWebElement Find()
        {
            return _context.FindElement(_locator);
        }
    }
}
