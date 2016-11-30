using System;
using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
    public class TestCase
    {
        public string ExecutionIdAndTitle { get; set; }
        public string IdAndTitle { get; set; }

        public List<Setup> Setups { get; set; }
        public List<Verification> Verifications { get; set; }

        public void ClearSession() { }
        private string _outputDir;
        public bool CheckOutputDir(string dirName) { return false; }

		public void ChangeTestExecution(string name)
		{
			throw new NotImplementedException();
		}

		public void ChangeOutputFolder(string path)
		{
			throw new NotImplementedException();
		}

		public void DoPassed(ModelItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public void DoFailed(ModelItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public void DoSkipped(ModelItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public void Show(ModelItem selectedItem)
		{
			throw new NotImplementedException();
		}

		public string OutputDir { get { return _outputDir; } set { _outputDir = value; ClearSession(); } }
    }

	public enum Result { Unknown, Passed, Failed }
	public enum Status { None, Done, Skipped }

	public interface IScreenshotable
    {
		Status Status { get; set; }
        Result Result { get; set; }

        string Text { get; set; }
		bool HasScreenshot();

        bool MakeScreenshot(Result result);
        bool Skip();
        bool Show();
    }

    public class Screenshotable : IScreenshotable
    {
	    private string _screenshotFileName;

        public Status Status { get; set; }
        public Result Result { get; set; }

        public string Text { get; set; }

        public bool MakeScreenshot(Result result) { return false; }
        public bool Skip() { return false; }
        public bool Show() { return false; }

		public bool HasScreenshot()
		{
			throw new NotImplementedException();
		}
	}

    public class Setup : Screenshotable
    {
    }

    public class Data : Screenshotable
    {
    }

    public class StepResult : Screenshotable
    {
    }

    public class Step
    {
        public List<StepResult> Results { get; set; }
    }

    public class Verification
    {
        public List<Data> Data { get; set; }
        public List<Step> Steps { get; set; }
    }
}
