using AventStack.ExtentReports.DotnetCliTool.Model;

using System;

namespace AventStack.ExtentReports.DotnetCliTool.Extensions
{
    internal static class KnownFileExtensions
    {
        internal static string GetExtension(TestFramework parserName)
        {
            switch (parserName)
            {
                case TestFramework.NUnit:
                    return "xml";
                default:
                    throw new ArgumentException("Invalid ParserName specified: " + parserName);
            }
        }
    }
}
