using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RMTBanking.Automation.UI.Tests.Core.Conditions;
using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element.Interfaces;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;
using RMTBanking.Automation.UI.Tests.Core.Locator;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Locator.Interfaces;
using RMTBanking.Automation.UI.Tests.Core.Wrappers;
using System;
using System.Collections.ObjectModel;
using System.Drawing;

namespace RMTBanking.Automation.UI.Tests.Core.Element
{
    public class WrappedElement : IWrappedElement, IWebElement, IWrappedSearchContext
    {
        private readonly WrappedDriver _driver;
        private readonly WrappedLocator<IWebElement> _locator;
        public string Description { get; }

        public WrappedElement(WrappedLocator<IWebElement> locator, WrappedDriver driver, string description)
        {
            _locator = locator;
            _driver = driver;
            Description = description;
        }

        public WrappedElement(By locator, WrappedDriver driver, string description)
            : this(new WrappedElementSearchContextLocator(locator, driver), driver, description)
        {
        }

        internal WrappedElement(IWebElement elementToWrap, IWebDriver driver, string description)
            : this(new WrappedElementLocator(elementToWrap), new WrappedDriver(driver), description)
        {
        }

        public WrappedElement(By locator, string description)
            : this(new WrappedElementSearchContextLocator(locator, DriverManager.CommonDriver), DriverManager.CommonDriver, description)
        {
        }

        public IWebElement ActualWebElement => _locator.Find();

        public Actions Actions => _driver.Actions();

        public string TagName
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
                Should(Be.Visible);
                return ActualWebElement.TagName;
            }
        }

        public string Text
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
                Should(Be.Visible);
                return ActualWebElement.Text;
            }
        }

        public bool Enabled
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
                Should(Be.Visible);
                return ActualWebElement.Enabled;
            }
        }

        public bool Selected
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
                Should(Be.Visible);
                return ActualWebElement.Selected;
            }
        }

        public Point Location
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
                Should(Be.Visible);
                return ActualWebElement.Location;
            }
        }

        public Size Size
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
                Should(Be.Visible);
                return ActualWebElement.Size;
            }
        }

        public bool Displayed
        {
            get
            {
                WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
                Should(Be.InDom);
                return ActualWebElement.Displayed;
            }
        }

        public override string ToString()
        {
            return Description + Environment.NewLine + _locator.Info;
        }

        IWebElement IWrappedSearchContext.FindElement(By by)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.Visible);
            return ActualWebElement.FindElement(by);
        }

        IWebElement ISearchContext.FindElement(By @by)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.Visible);
            return new WrappedElement(new WrappedElementSearchContextLocator(by, this), _driver, Description);
        }

        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {
            return new WrappedElementsCollection(new WrappedElementsCollectionSearchContextLocator(by, _driver),
                _driver, Description).ToReadOnlyWebElementsCollection();
        }

        ReadOnlyCollection<IWebElement> IWrappedSearchContext.FindElements(By by)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.Visible);
            return ActualWebElement.FindElements(by);
        }

        public WrappedElement Clear()
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.Visible);
            ActualWebElement.Clear();
            return this;
        }

        void IWebElement.Clear()
        {
            Clear();
        }

        public WrappedElement SendKeys(string text)
        {
            Should(Be.Visible);
            ActualWebElement.SendKeys(text);
            return this;
        }

        void IWebElement.SendKeys(string text)
        {
            SendKeys(text);
        }

        public WrappedElement Submit()
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.Visible);
            ActualWebElement.Submit();
            return this;
        }

        void IWebElement.Submit()
        {
            Submit();
        }

        public WrappedElement Click()
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
            Should(Be.Clickable);
            ActualWebElement.Click();
            return this;
        }

        public WrappedElement ClickOnElementInDom()
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
            Should(Be.InDom);
            ActualWebElement.Click();
            return this;
        }

        void IWebElement.Click()
        {
            Click();
        }

        public string GetAttribute(string attributeName)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.InDom);
            return ActualWebElement.GetAttribute(attributeName);
        }

        public string GetProperty(string propertyName)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.InDom);
            return ActualWebElement.GetDomProperty(propertyName);
        }

        public string GetCssValue(string propertyName)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.InDom);
            return ActualWebElement.GetCssValue(propertyName);
        }

        public WrappedElement PressEnter()
        {
            SendKeys(Keys.Enter);
            return this;
        }

        public WrappedElement PressTab()
        {
            SendKeys(Keys.Tab);
            return this;
        }

        public WrappedElement PressEscape()
        {
            SendKeys(Keys.Escape);
            return this;
        }

        public WrappedElement Set(string text)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete());
            Should(Be.Visible);
            var webElement = ActualWebElement;
            webElement.Clear();
            webElement.SendKeys(text);
            return this;
        }

        public WrappedElement Find(By locator, string description)
        {
            return new WrappedElement(new WrappedElementSearchContextLocator(locator, this), _driver, description);
        }

        public WrappedElementsCollection FindAll(By locator)
        {
            return new WrappedElementsCollection(new WrappedElementsCollectionSearchContextLocator(locator, this), _driver, Description);
        }

        public WrappedElement Should(Condition<WrappedElement> condition, int waitSeconds = -1)
        {
            if (waitSeconds == -1)
            {
                return WrappedDriverManager.WaitFor(this, condition);
            }
            return WrappedDriverManager.WaitFor(this, condition, TimeSpan.FromSeconds(waitSeconds));
        }

        public WrappedElement ShouldNot(Condition<WrappedElement> condition, int waitSeconds = -1)
        {
            if (waitSeconds == -1)
            {
                return WrappedDriverManager.WaitForNot(this, condition);
            }
            return WrappedDriverManager.WaitForNot(this, condition, TimeSpan.FromSeconds(waitSeconds));
        }

        public string GetDomAttribute(string attributeName)
        {
            return ActualWebElement.GetDomAttribute(attributeName);
        }

        public string GetDomProperty(string propertyName)
        {
            return ActualWebElement.GetDomProperty(propertyName);
        }

        public ISearchContext GetShadowRoot()
        {
            return ActualWebElement.GetShadowRoot();
        }

        public WrappedElement MoveTo()
        {
            Should(Be.Clickable);
            Actions.MoveToElement(ActualWebElement).Perform();
            return this;
        }
    }
}
