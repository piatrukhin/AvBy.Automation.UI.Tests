using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;


namespace AvBy.Automation.UI.Tests.Pages.Elements
{
    public class UserProfileHeader
    {
        public WrappedElement BookMarksLink => new(With.XPath("//*[@href='/profile/bookmarks']"), "Bookmarks Link");
        public WrappedElement SavedSearchesLink => new(With.XPath("//*[@href='profile/saved-filters']"), "Saved Searchers Link");
        public WrappedElement DialoguesButton => new(With.XPath("//button[@xmlns='http://www.w3.org/2000/svg']"), "Dialogues Button");
        public WrappedElement OffersLink => new(With.XPath("//*[@href='https://av.by/profile/offers']"), "Offers Link");
    }
}
