using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;
using RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces;
using RMTBanking.Automation.UI.Tests.Core.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RMTBanking.Automation.UI.Tests.Core.Wrappers
{
    public class WrappedDriver : IWebDriver, INavigation, IWrappedSearchContext
    {
        private readonly IWrappedDriver _source;
        private bool _disposedValue;

        public WrappedDriver(IWrappedDriver driver)
        {
            _source = driver;
        }

        public WrappedDriver(IWebDriver driver) : this(new ExplicitWrappedDriver(driver))
        {
        }

        public WrappedDriver() : this(ThreadLocalWrappedDriver.Instance)
        {
        }

        public IWebDriver Value
        {
            get => _source.Driver;

            set => _source.Driver = value;
        }

        public Actions Actions()
        {
            return new Actions(this.Value);
        }

        private IWebDriver AsWebDriver()
        {
            return this;
        }

        public WrappedElement Find(By @by, string description)
        {
            return new WrappedElement(by, this, description);
        }

        public WrappedElement Find(IWebElement element, string description)
        {
            return new WrappedElement(element, this, description);
        }

        public WrappedElementsCollection FindAll(By @by, string description)
        {
            return new WrappedElementsCollection(by, this, description);
        }

        public WrappedElementsCollection FindAll(IList<IWebElement> elements, string description)
        {
            return new WrappedElementsCollection(elements, this, description);
        }

        IWebElement ISearchContext.FindElement(By by)
        {
            return new WrappedElement(by, this, "no description");
        }

        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {
            return new WrappedElementsCollection(by, this, "no description").ToReadOnlyWebElementsCollection();
        }

        IWebElement IWrappedSearchContext.FindElement(By by)
        {
            return Value.FindElement(by);
        }

        ReadOnlyCollection<IWebElement> IWrappedSearchContext.FindElements(By by)
        {
            return Value.FindElements(by);
        }

        protected virtual void Dispose(bool disposing)
        {
            _source.Dispose();
            if (_disposedValue) return;
            if (disposing)
            {
                _source.Dispose();
            }

            _disposedValue = true;
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        void IWebDriver.Close()
        {
            Value.Close();
        }

        void IWebDriver.Quit()
        {
            Value.Quit();
        }

        IOptions IWebDriver.Manage()
        {
            return Value.Manage();
        }

        INavigation IWebDriver.Navigate()
        {
            return Value.Navigate();
        }

        ITargetLocator IWebDriver.SwitchTo()
        {
            return Value.SwitchTo();
        }

        public string Url
        {
            get => AsWebDriver().Url;
            set => AsWebDriver().Url = value;
        }

        public string Title => AsWebDriver().Title;

        public string PageSource => AsWebDriver().PageSource;
        public string CurrentWindowHandle => AsWebDriver().CurrentWindowHandle;
        public ReadOnlyCollection<string> WindowHandles => AsWebDriver().WindowHandles;
        public void Back()
        {
            AsWebDriver().Navigate().Back();
        }

        public void Forward()
        {
            AsWebDriver().Navigate().Forward();
        }

        public void GoToUrl(string url)
        {
            AsWebDriver().Navigate().GoToUrl(url);
        }

        public void GoToUrl(Uri url)
        {
            AsWebDriver().Navigate().GoToUrl(url);
        }

        public void Refresh()
        {
            AsWebDriver().Navigate().Refresh();
        }

        public void Close()
        {
            AsWebDriver().Close();
        }

        public void Quit()
        {
            AsWebDriver().Quit();
        }
    }
}
