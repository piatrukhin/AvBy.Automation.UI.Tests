using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Conditions.CollectionConditions;
using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.ElementsCollection;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public static class Have
    {
        public static Condition<WrappedElementsCollection> Count(int count)
        {
            return new Count(count);
        }

        public static Condition<WrappedElementsCollection> CountAtLeast(int count)
        {
            return new CountAtLeast(count);
        }

        public static Condition<WrappedElement> CssClass(string value)
        {
            return new CssClass(value);
        }

        public static Condition<WrappedElement> Text(string value)
        {
            return new Text(value);
        }

        public static Condition<WrappedElement> CssValue(string value)
        {
            return new CssValue(value);
        }

        public static Condition<WrappedElement> ExactText(string value)
        {
            return new ExactText(value);
        }
    }
}
