using OpenQA.Selenium;

namespace RMTBanking.Automation.UI.Tests.Core.Element.Interfaces
{
    public interface IWrappedElement
    {
        IWebElement ActualWebElement { get; }
        string Description { get; }
    }
}
