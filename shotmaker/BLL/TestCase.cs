using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace shotmaker
{
    public enum TResult { Passed, Failed }

    enum TStatus { None, Done, Skipped }

    class TestCase
    {
        public string ExecutionIDAndTitle { get; private set; }
        public string IDAndTitle { get; private set; }

        public List<Setup> Setups { get; private set; }
        public List<Verification> Verifications { get; private set; }

        public void ClearSession() { }
        private string _outputDir;
        public bool CheckOutputDir(string dirName) { return false; }
        public string OutputDir { get { return _outputDir; } set { _outputDir = value; ClearSession(); } }
    }


    interface IScreenshotable
    {
        TStatus Status { get; set; }
        TResult Result { get; set; }

        string Text { get; set; }

        bool MakeScreenshot(TResult result);
        bool Skip();
        bool Show();
    }

    class Screenshotable : IScreenshotable
    {
        public TStatus Status { get; set; }
        public TResult Result { get; set; }

        public string Text { get; set; }

        public bool MakeScreenshot(TResult result) { return false; }
        public bool Skip() { return false; }
        public bool Show() { return false; }
    }

    class Setup : Screenshotable
    {
    }

    class Data : Screenshotable
    {
    }

    class StepResult : Screenshotable
    {
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
