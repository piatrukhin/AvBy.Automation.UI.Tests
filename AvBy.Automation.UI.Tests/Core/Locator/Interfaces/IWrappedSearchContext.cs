using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces
{
    public interface IWrappedSearchContext
    {
        IWebElement FindElement(By by);
        ReadOnlyCollection<IWebElement> FindElements(By by);
    }
}
