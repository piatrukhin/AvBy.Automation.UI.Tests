namespace RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions
{
    public abstract class BaseCondition<TWebElement>
    {
        public abstract bool Apply(TWebElement entity);

        public abstract string Explain();
    }
}
