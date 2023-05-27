using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Conditions.CollectionConditions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public static class Be
    {
        public static Condition<WrappedElement> InDom => new InDom();
        public static Condition<WrappedElementsCollection> InDomCollection => new InDomCollection();
        public static Condition<WrappedElement> Enabled => new Enabled();
        public static Condition<WrappedElement> Selected => new Selected();
        public static Condition<WrappedElement> Visible => new Visible();
        public static Condition<WrappedElementsCollection> VisibleCollection => new VisibleCollection();
        public static Condition<WrappedElement> Clickable => new Clickable();
        public static Condition<WrappedElementsCollection> ClickableCollection => new ClickableCollection();
        public static Condition<WrappedElement> Disabled => new Disabled();
    }
}
