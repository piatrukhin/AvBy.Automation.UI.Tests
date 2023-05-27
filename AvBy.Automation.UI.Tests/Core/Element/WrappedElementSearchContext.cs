using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces;

namespace RMTBanking.Automation.UI.Tests.Core.Element
{
    public class WrappedElementSearchContext : WrappedLocator<IWebElement>
    {
        private readonly IWrappedSearchContext _context;
        private readonly By _locator;

        public WrappedElementSearchContext(By locator, IWrappedSearchContext context)
        {
            _context = context;
            _locator = locator;
        }

        public override string Info => $"By.WrappedLocator: ({_context}).Find({_locator})";
        public override IWebElement Find()
        {
            return _context.FindElement(_locator);
        }
    }
}
