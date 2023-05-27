using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Wrappers.Interfaces;
using System;

namespace RMTBanking.Automation.UI.Tests.Core.Wrappers
{
    public class ExplicitWrappedDriver : IWrappedDriver
    {
        private bool _disposedValue;

        public ExplicitWrappedDriver(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; set; }

        public void Dispose(bool disposing)
        {
            if (_disposedValue) return;

            if (disposing)
            {
                Driver.Quit();
            }

            _disposedValue = true;
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }
}
