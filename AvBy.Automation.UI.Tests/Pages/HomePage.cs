using AvBy.Automation.Common.Configuration;
using AvBy.Automation.UI.Tests.Pages.Base;
using AvBy.Automation.UI.Tests.Pages.Elements;
using RMTBanking.Automation.UI.Tests.Core.Wrappers;

namespace AvBy.Automation.UI.Tests.Pages
{
    public class HomePage : BasePage
    {
        public static HeaderMenu HeaderMenu => new();
        public static LoginMenu LoginMenu => new();
        public static CookiesPopUpWindow CookiesPopUpWindow => new();

        public static void Open()
        {
            WrappedDriverManager.Open(AppConfiguration.BaseUrl);
        }
    }
}
