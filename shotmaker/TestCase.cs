using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace shotmaker
{
    class ScenarioStepAndExpectedResults
    {
        public string Step { get; private set; }
        public List<string> ExpectedResults { get; private set; }
    }

    class ScenarioVerification
    {
        public List<string> Data { get; private set; }
        public List<ScenarioStepAndExpectedResults> StepAndExpectedResults { get; private set; }
    }

    class TestCaseScenario
    {
        public string ExecutionID { get; private set; }
        public string ExecutionTitle { get; private set; }
        public string ID { get; private set; }
        public string Title { get; private set; }
        public List<string> Preconditions { get; private set; }
        public List<ScenarioVerification> Verifications { get; private set; }

        static TestCaseScenario LoadFromXml(XmlDocument doc) { return null; }
        static TestCaseScenario LoadFromXml(string fileName) { return null; }
    }

    public enum TResult { Passed, Failed }

    enum TStatus { None, Done, Skipped }

    class TestCase
    {
        public TestCaseScenario Scenario { get; private set; }
        public List<Precondition> Preconditions { get; private set; }
        public List<Verification> Verifications { get; private set; }

        static TestCase LoadScenarioFromXml(string fileName) { return null; }
        public void ClearSession() { }
        private string _outputDir;
        public bool CheckOutputDir(string dirName) { return false; }
        public string OutputDir { get { return _outputDir; } set { _outputDir = value; ClearSession(); } }
    }


    abstract class Screenshotable
    {
        public bool Skip() { return false; }
        public TStatus Status { get; private set; }
        public bool Show() { return false; }
    }

    abstract class ScreenshotableWithoutResult : Screenshotable
    {
        public bool MakeScreenshot() { return false; }
    }
    
    class Precondition : ScreenshotableWithoutResult
    {

    }

    class Data : ScreenshotableWithoutResult
    {

    }

    class StepResult : Screenshotable
    {
        public bool MakeScreenshot(TResult result) { return false; }
        public TResult Result { get; private set; }
    }

    class Step
    {
        public List<StepResult> Results { get; private set; }
    }

    class Verification
    {
        public List<Data> Data { get; private set; }
        public List<Step> Steps { get; private set; }
    }
    


    public class Tree<T> : List<Tree<T>>
    {
        public T Value { get; set; }
    }

}
