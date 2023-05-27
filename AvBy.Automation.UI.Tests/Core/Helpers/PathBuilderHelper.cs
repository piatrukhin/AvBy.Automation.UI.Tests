using System;
using System.IO;
using System.Reflection;

namespace RMTBanking.Automation.UI.Tests.Core.Helpers
{
    public static class PathBuilderHelper
    {
        private static string _exsistSetingsPath = @"../../../";

        private static string GetLocalPath()
        {
            string path = new Uri(Assembly.GetExecutingAssembly().Location).LocalPath;
            return Path.GetDirectoryName(path) + @"/";
        }

        public static string GetConfigPath()
        {
            string fullPath = GetLocalPath() + _exsistSetingsPath;
            if (!Directory.Exists(fullPath))
            {
                throw new Exception("No settings folder '" + fullPath + "' was found.");
            }
            return fullPath;
        }
    }
}
