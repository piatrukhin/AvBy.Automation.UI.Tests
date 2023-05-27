﻿using RMTBanking.Automation.UI.Tests.Core.Conditions.Abstractions;
using RMTBanking.Automation.UI.Tests.Core.Element;

namespace RMTBanking.Automation.UI.Tests.Core.Conditions
{
    public class Enabled : Condition<WrappedElement>
    {
        public override bool Apply(WrappedElement entity)
        {
            return entity.ActualWebElement.Enabled;
        }
    }
}