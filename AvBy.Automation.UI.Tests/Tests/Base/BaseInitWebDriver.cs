using RMTBanking.Automation.UI.Tests.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvBy.Automation.UI.Tests.Tests.Base
{
    public class BaseInitWebDriver
    {
        [SetUp]
        public void DriverSetup()
        {
            WrappedDriverManager.InitWebDriver();
        }

        [TearDown]
        public void DriverTearDown()
        {
            WrappedDriverManager.GetWebDriver().Quit();
        }
    }
}
