using AvBy.Automation.UI.Tests.Pages.Elements;
using AvBy.Automation.UI.Tests.Tests.Base;
using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AvBy.Automation.UI.Tests.Pages.Enum.EnumSubOption;

namespace AvBy.Automation.UI.Tests.Tests.UserProfile
{
    public class ProfileMainPageTest : BaseLogin
    {
        public ProfileMainPageTest() : base(1)
        {

        }

        [Test]
        public void ProfileMainPage_VerifyElementsAvailability_ElementsShouldBeAvailable()
        {
            ProfileMenu.ProfileTab.Click();
            ProfileMenu.GetSubOptionByName(SubOption.MyAd).Should(Be.Clickable);
            ProfileMenu.GetSubOptionByName(SubOption.MyPoints).Should(Be.Clickable);
            ProfileMenu.GetSubOptionByName(SubOption.Bookmarks).Should(Be.Clickable);
            ProfileMenu.GetSubOptionByName(SubOption.Message).Should(Be.Clickable);
            ProfileMenu.GetSubOptionByName(SubOption.SavedSearch).Should(Be.Clickable);

            ProfileMenu.GetSubOptionByName(SubOption.Settings).ShouldNot(Be.Visible); //     \
                                                                                           // TODO: rework Settings and Warnings
            ProfileMenu.GetSubOptionByName(SubOption.Warnings).ShouldNot(Be.Clickable); //   /
        }
    }
}