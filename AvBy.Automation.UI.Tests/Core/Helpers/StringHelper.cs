using System.Text.RegularExpressions;

namespace RMTBanking.Automation.UI.Tests.Core.Helpers
{
    public static class StringHelper
    {
        public static string ReplaceCamelCaseWithSpaces(string s)
        {
            return Regex.Replace(s, "(\\B[A-Z])", " $1");
        }

        public static int GetNumberFromString(string s, string removePart = "")
        {
            var numberString = string.IsNullOrEmpty(removePart) ? s : s.Replace(removePart, "");
            int.TryParse(numberString.Replace(",", "").Trim(), out int number);
            return number;
        }

        public static string GetStringWithoutFirstSymbols(string s, int symbolsToReduce)
        {
            return s.Substring(symbolsToReduce);
        }
    }
}
