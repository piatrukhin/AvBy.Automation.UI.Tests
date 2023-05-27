using AvBy.Automation.Common.Configuration;
using AvBy.Automation.Common.Configuration.Models;
using AvBy.Automation.UI.Tests.Pages;
using AvBy.Automation.UI.Tests.Tests.Base;
using RMTBanking.Automation.UI.Tests.Core.Conditions;


namespace AvBy.Automation.UI.Tests.Tests.Authorization
{
    public class AuthorizationByPhoneTests : BaseHome
    {
       public User user;

        [SetUp]
        public void GetUser()
        {
            this.user = AppConfiguration.Users.Single(u => u.SetId == 1);
        }

        [Test]
        public void LoginMenu_SendMoreThenSixChar_ShouldNotBeClickable()
        {
            HomePage.LoginMenu.LogInTab.Click();
            HomePage.LoginMenu.LoginField.SendKeys(user.PhoneNumber);
            HomePage.LoginMenu.LogInButton.Should(Be.Disabled);            
        }

        [Test]
        public void LoginMenu_SendWrongPassword_AlertShouldBeVisible()
        {
            HomePage.LoginMenu.LogInTab.Click();
            HomePage.LoginMenu.LoginField.SendKeys("296183717");
            HomePage.LoginMenu.PasswordField.SendKeys("244334");
            HomePage.LoginMenu.LogInButton.Click();
            HomePage.LoginMenu.PasswordCharactersAlert.Should(Be.Visible);
            
        }

    }
}
