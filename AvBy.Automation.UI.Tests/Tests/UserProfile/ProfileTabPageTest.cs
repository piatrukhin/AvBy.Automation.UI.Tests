using AvBy.Automation.Common.Configuration;
using AvBy.Automation.Common.Configuration.Models;
using AvBy.Automation.UI.Tests.Pages;
using AvBy.Automation.UI.Tests.Pages.Elements;
using AvBy.Automation.UI.Tests.Tests.Base;
using OpenQA.Selenium.Interactions;
using RMTBanking.Automation.UI.Tests.Core.Conditions;
using RMTBanking.Automation.UI.Tests.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static AvBy.Automation.UI.Tests.Pages.Enum.EnumOptions;

namespace AvBy.Automation.UI.Tests.Tests.UserProfile
{
    public class ProfileTabPageTest : BaseLogin
    {
        public ProfileTabPageTest() : base(1)
        {

        }

        [Test]
        public void ProfileTabPage_VerifyElementsAvailability_ElementsShouldBeAvailable()
        {
            ProfileMenu.ProfileTab.MoveTo();
            ProfileMenu.GetOptionByName(Options.GetPoint).Should(Be.Clickable);
            ProfileMenu.GetOptionByName(Options.MyAd).Should(Be.Clickable);
            ProfileMenu.GetOptionByName(Options.HistoryOrder).Should(Be.Clickable);
            ProfileMenu.GetOptionByName(Options.Settings).Should(Be.Clickable);
            ProfileMenu.GetOptionByName(Options.Warnings).Should(Be.Clickable);
            ProfileMenu.GetOptionByName(Options.Exit).Should(Be.Clickable);
        }
    }
}
