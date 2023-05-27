using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace RMTBanking.Automation.UI.Tests.Core.ElementsCollection.Interfaces
{
    public interface IWrappedElementsCollection
    {
        ReadOnlyCollection<IWebElement> ActualWebElements { get; }
        string Description { get; }
    }
}
