namespace RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions
{
    public abstract class WrappedLocator<TWebElement>
    {
        public abstract string Info { get; }
        public abstract TWebElement Find();
    }
}
