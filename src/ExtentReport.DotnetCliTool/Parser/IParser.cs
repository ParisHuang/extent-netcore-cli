namespace AventStack.ExtentReports.DotnetCliTool.Parser
{
    interface IParser
    {
        void ParseTestRunnerOutput(string resultsFile);
    }
}
