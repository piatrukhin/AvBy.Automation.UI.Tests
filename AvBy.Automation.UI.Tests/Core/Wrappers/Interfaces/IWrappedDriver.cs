using System;
using OpenQA.Selenium;

namespace RMTBanking.Automation.UI.Tests.Core.Wrappers.Interfaces
{
    public interface IWrappedDriver : IDisposable
    {
        IWebDriver Driver { get; set; }
    }
}
