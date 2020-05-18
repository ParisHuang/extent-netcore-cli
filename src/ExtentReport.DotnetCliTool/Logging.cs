using AventStack.ExtentReports.DotnetCliTool.Model;
using System;

namespace AventStack.ExtentReports.DotnetCliTool
{
    internal class Logger
    {
        private LoggingLevel _loggingLevel;

        public Logger(LoggingLevel loggingLevel)
        {
            _loggingLevel = loggingLevel;
        }

        internal void WriteLine(LoggingLevel loggingLevel, string messageFormat, params object[] args)
        {
            if (loggingLevel <= _loggingLevel)
                Console.WriteLine(messageFormat, args);

        }

    }
}
