using McMaster.Extensions.CommandLineUtils;
using AventStack.ExtentReports;

namespace AventStack.ExtentReports.DotnetCliTool
{
    internal class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>Return code indicating success/failure.</returns>
        internal static void Main(string[] args)
        {
            CommandLineApplication.Execute<ExtentCommand>(args);
        }
    }
}
