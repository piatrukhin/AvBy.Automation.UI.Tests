using NUnit.Framework.Constraints;
using RMTBanking.Automation.UI.Tests.Core.Conditions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;
using RMTBanking.Automation.UI.Tests.Core.Locator;
using static AvBy.Automation.UI.Tests.Pages.Enum.EnumOptions;
using static AvBy.Automation.UI.Tests.Pages.Enum.EnumSubOption;

namespace AvBy.Automation.UI.Tests.Pages.Elements
{
    public class ProfileMenu
    {
        private static WrappedElementsCollection ProfileMenuTab => new(With.XPath("//*[@href = 'https://av.by/profile/offers']"), "Profile options in tab");
        public static WrappedElement ProfileTab => new(With.XPath("//*[@href = 'https://av.by/profile/offers']"), "Profile options in tab");

        public static WrappedElement GetOptionByName(Options option)
        {
            return option switch
            {
                Options.GetPoint => new(With.XPath("//*[@href = '/profile/buying-coins']"),"Get Point Option"),
                Options.MyAd => new(With.XPath("//*[text() = 'Мои объявления']"), "My Ad Option"),
                Options.HistoryOrder => new(With.XPath("//*[@href= '/profile/orders']"), "History Order Option"),
                Options.Settings => new(With.XPath("//*[@href='/profile/settings']"), "Settings Option"),
                Options.Warnings => new(With.XPath("//*[@href= '/profile/warnings']"), "Wrnings Option"),                
                Options.Exit => new(With.XPath("//*[@ href= 'https://av.by/logout?redirect_to=https%3A%2F%2Fav.by']"),"Exit Options"),
                _ => throw new NotImplementedException(),
            } ;
        }

        public static WrappedElement GetSubOptionByName(SubOption option)
        {
            return option switch
            {
                SubOption.MyPoints => new(With.XPath("//*[text() = 'Мои баллы']"), "My points SubOption"),
                SubOption.MyAd => ProfileMenuTab.FindBy(Have.ExactText("Мои объявления"), "My Ad SubOption"),
                SubOption.Bookmarks => new(With.XPath("//*[@href = '/profile/bookmarks']"),"Bookmarks SubOption"), 
                SubOption.Message => new(With.XPath("//*[text() = 'Сообщения']"), "Message SubOption"),     
                SubOption.SavedSearch => new(With.XPath("//*[@href = '/profile/saved-filters']"), "Saved Searchers SubOption"),


                SubOption.Settings => new(With.XPath("//*[@href = '/profile/settings']"), "Settings SubOption"), // TODO: rework       
                SubOption.Warnings => new(With.XPath("//*[@href = '/profile/warnings'"), "Wrnings Option SubOption"), // TODO: rework
                _ => throw new NotImplementedException(),
            };
        }
    }
}
