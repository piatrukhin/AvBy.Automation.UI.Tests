using AvBy.Automation.UI.Tests.Pages.Elements;
using AvBy.Automation.UI.Tests.Pages.SecurityPages;
using AvBy.Automation.UI.Tests.Tests.Base;
using RMTBanking.Automation.UI.Tests.Core.Conditions;
using static AvBy.Automation.UI.Tests.Pages.Enum.EnumOptions;
using static AvBy.Automation.UI.Tests.Pages.Enum.EnumSubOption;

namespace AvBy.Automation.UI.Tests.Tests.SecuritySettings
{
    public class SecuritySettingsTest : BaseLogin
    {
        public SecuritySettingsTest() : base(1)
        {

        }

        [Test]
        public void SecurityOptionChangePasswordPage_SendIncorrectPassword_PasswordAlertShouldBeVisible()
        {
            ProfileMenu.ProfileTab.MoveTo();
            ProfileMenu.GetOptionByName(Options.Settings).Click();
            SettingPage.ChangePasswordButton.Click();
            ChangePasswordPage.CurrentPasswordInput.SendKeys("qazwaz123");
            ChangePasswordPage.NewPasswordInput.SendKeys("ffff123132");
            ChangePasswordPage.SubmitButton.Click();
            ChangePasswordPage.WrongPassError.Should(Be.Visible);
        }

        [Test]
        public void SecurityOptionConfirmEMailPage_SendIncorrectEMail_EMailAlertShouldBeVisible()
        {
            ProfileMenu.ProfileTab.MoveTo();
            ProfileMenu.GetOptionByName(Options.Settings).Click();
            SettingPage.ConfirmEMailButtion.Click();
            ConfirmEmailPage.CurrentEMailInput.SendKeys("fdsdfs@mail.ru");
            ConfirmEmailPage.CurrentPasswordInput.SendKeys("3421wewe");
            ConfirmEmailPage.SendMailConfirmButton.Click();
            ConfirmEmailPage.WrongPassError.Should(Be.Clickable);
        }
    }
}
