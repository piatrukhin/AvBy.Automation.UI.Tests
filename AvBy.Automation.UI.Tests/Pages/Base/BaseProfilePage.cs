using AvBy.Automation.UI.Tests.Pages.Elements;

namespace AvBy.Automation.UI.Tests.Pages.Base
{
    public class BaseProfilePage : BasePage
    {
        public static HeaderMenu HeaderMenu => new();
        public static LoginMenu LoginMenu => new();
        public static UserProfileHeader UserProfileHeader => new();
    }
}
