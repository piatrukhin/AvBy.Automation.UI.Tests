using AvBy.Automation.Common.Configuration.Models;
using AvBy.Automation.Common.Configuration;
using AvBy.Automation.UI.Tests.Pages;
using RMTBanking.Automation.UI.Tests.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvBy.Automation.UI.Tests.Tests.Base
{
    public class BaseLogin : BaseHome
    {
        public static User _user;

        public BaseLogin(int setId)
        {
            _user = AppConfiguration.Users.Single(u => u.SetId == setId);
        }

        [SetUp]
        public static void Login()
        {
            HomePage.LoginMenu.LogInTab.Click();
            HomePage.LoginMenu.LoginField.SendKeys(StringHelper.GetStringWithoutFirstSymbols(_user.PhoneNumber, 0));
            HomePage.LoginMenu.PasswordField.SendKeys(_user.Password);
            HomePage.LoginMenu.LogInButton.Click();
            Thread.Sleep(1000);
        }
    }
}
