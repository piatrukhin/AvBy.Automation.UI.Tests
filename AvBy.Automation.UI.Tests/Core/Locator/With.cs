﻿using OpenQA.Selenium;

namespace RMTBanking.Automation.UI.Tests.Core.Locator
{
    public static class With
    {
        private const string NormalizedXpath = "normalize-space(translate(string(.), '\t\n\r\u00a0', '    '))";

        public static By Type(string type)
        {
            return By.XPath($"//*[@type = '{type}']");
        }

        public static By Value(string value)
        {
            return By.XPath($"//*[@value = '{value}']");
        }

        public static By Text(string text)
        {
            return By.XPath($"//*/text()[contains({NormalizedXpath}, '{text}')]/parent::*");
        }

        public static By ExactText(string text)
        {
            return By.XPath($"//*/text()[{NormalizedXpath} = '{text}']/parent::*");
        }

        public static By Id(string id)
        {
            return By.Id(id);
        }

        public static By Name(string name)
        {
            return By.Name(name);
        }

        public static By TagName(string name)
        {
            return By.TagName(name);
        }

        public static By ClassName(string className)
        {
            return By.ClassName(className);
        }

        public static By XPath(string xpath)
        {
            return By.XPath(xpath);
        }

        public static By Css(string css)
        {
            return By.CssSelector(css);
        }
    }
}
