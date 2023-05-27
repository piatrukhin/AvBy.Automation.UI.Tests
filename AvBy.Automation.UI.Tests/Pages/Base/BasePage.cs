using RMTBanking.Automation.UI.Tests.Core.Conditions;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;
using RMTBanking.Automation.UI.Tests.Core.Locator;
using RMTBanking.Automation.UI.Tests.Core.Wrappers;

namespace AvBy.Automation.UI.Tests.Pages.Base
{
    public class BasePage
    {
        public static void RefreshPage() => WrappedDriverManager.Refresh();
        public static void ClosePage() => WrappedDriverManager.Close();
        public static void SwitchToTheFirstTab() => WrappedDriverManager.SwitchToTheFirstTab();

        public static void SwitchToTheLastTab()
        {
            WrappedDriverManager.SwitchToTheLastTab();
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
        }

        public static void SwitchIFrame(int index = 0)
        {
            WrappedDriverManager.WaitTo(JavaScript.JavaScriptLoadingComplete(), 30);
            var frames = new WrappedElementsCollection(With.TagName("iframe"), "IFrame").Should(Have.CountAtLeast(1));
            WrappedDriverManager.GetWebDriver().SwitchTo().Frame(frames[index].ActualWebElement);
        }

        public static string GetTitleOfCurrentWindow => WrappedDriverManager.GetTitle;

    }
}
