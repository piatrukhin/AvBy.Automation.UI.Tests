namespace RMTBanking.Automation.UI.Tests.Core.Element.Abstractions
{
    public abstract class WrappedLocator<TWebElement>
    {
        public abstract string Info { get; }
        public abstract TWebElement Find();
    }
}
