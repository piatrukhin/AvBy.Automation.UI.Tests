using OpenQA.Selenium;
using RMTBanking.Automation.UI.Tests.Core.Locator.Abstractions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RMTBanking.Automation.UI.Tests.Core.Locator
{
    public class WrappedElementsCollectionLocator : WrappedLocator<ReadOnlyCollection<IWebElement>>
    {
        private readonly string _info;
        private readonly IList<IWebElement> _collection;

        public WrappedElementsCollectionLocator(string info, IList<IWebElement> collection)
        {
            _info = info;
            _collection = collection;
        }

        public WrappedElementsCollectionLocator(IList<IWebElement> collection) : this("wrapped collection", collection)
        {
        }

        public override string Info => $"{_info} : {_collection}";
        public override ReadOnlyCollection<IWebElement> Find()
        {
            return new ReadOnlyCollection<IWebElement>(_collection);
        }
    }
}
