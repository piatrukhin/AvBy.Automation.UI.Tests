using AvBy.Automation.UI.Tests.Pages;

namespace AvBy.Automation.UI.Tests.Tests.Base
{
    public class BaseHome : BaseInitWebDriver
    {
        [SetUp]
        public void OpenHomePage()
        {
            HomePage.Open();
            HomePage.CookiesPopUpWindow.AcceptCookiesButton.Click();
        }
    }
}
