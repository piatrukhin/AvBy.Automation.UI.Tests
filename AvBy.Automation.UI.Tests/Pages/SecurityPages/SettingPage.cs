using AvBy.Automation.UI.Tests.Pages.Base;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;
  
namespace AvBy.Automation.UI.Tests.Pages.SecurityPages
{
    public class SettingPage : BaseProfilePage
    {
        public static WrappedElement ChangePasswordButton => new(With.XPath("//*[@href = '/profile/settings/password']"), "Change Password Button");
        public static WrappedElement ConfirmEMailButtion => new(With.XPath("//*[@href = '/profile/settings/email']"), "Confirm E-Mail Button");
        public static WrappedElement ChangePhoneButton => new(With.XPath("//*[@href = href= '/profile/settings/phone']"), "Change Phone Button");
        public static WrappedElement UserNameInput => new(With.XPath("//*[@id = 'name']"), "Input by change username");
        public static WrappedElement AcceptMailingList => new(With.XPath("//*[@id = 'mailingEnabled']"), "Accept Mailing List");
        public static WrappedElement AcceptDialogList => new(With.XPath("//*[@id = 'dialogsEnabled']"), "Accept Dialog List");
        public static WrappedElement SaveChangeButton => new(With.XPath("//*[text() = 'Сохранить изменения']"), "Save Change Button");
        public static WrappedElement ExitButton => new(With.XPath("//*[text() = 'Выйти']"), "Exit Button");
    }
}
