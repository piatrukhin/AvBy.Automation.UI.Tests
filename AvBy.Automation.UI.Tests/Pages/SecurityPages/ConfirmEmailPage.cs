using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;

namespace AvBy.Automation.UI.Tests.Pages.SecurityPages
{
    public class ConfirmEmailPage : SettingPage
    {
        public static WrappedElement CurrentEMailInput => new(With.XPath("//*[@id = 'email']"), "Current E-Mail input");
        public static WrappedElement CurrentPasswordInput => new(With.XPath("//*[@id = 'password']"), "Current Password Input");
        public static WrappedElement SendMailConfirmButton => new(With.XPath("//button[@class='button button--primary']"), "Send Mail by Confirm E-Mail");
        public static WrappedElement WrongPassError => new(With.XPath("//*[@class= 'error-message']"), "Wrong Password Error");
    }
}
