using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;

namespace AvBy.Automation.UI.Tests.Pages.SecurityPages
{
    public class ChangePasswordPage : SettingPage
    {
        public static WrappedElement CurrentPasswordInput => new(With.XPath("//*[@id = 'old-password']"), "Current(old) Passwordd Input");
        public static WrappedElement NewPasswordInput => new(With.XPath("//*[@id = 'new-password']"), "New Password Input");
        public static WrappedElement SubmitButton => new(With.XPath("//button[@class='button button--action']"), "Submit Button");
        public static WrappedElement WrongPassError => new(With.XPath("//*[@class= 'error-message']"), "Wrong Password Error");
    }
}
