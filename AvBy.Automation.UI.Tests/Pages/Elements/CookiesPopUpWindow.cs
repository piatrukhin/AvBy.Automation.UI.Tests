using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;

namespace AvBy.Automation.UI.Tests.Pages.Elements
{
    public class CookiesPopUpWindow
    {
        public WrappedElement AcceptCookiesButton => new(With.XPath("//*[@class='cookie-banner__container']/descendant::button"), "Accept Cookies Button"); 
    }
}
