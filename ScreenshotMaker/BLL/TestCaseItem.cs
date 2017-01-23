using System.Drawing;

namespace ScreenshotMaker.BLL
{
	public class TestCaseItem : ITestCaseItem
	{
		private readonly string _fileName = null;

		public TestCaseItem(string text, IGeneratePathAndFileNameForTestCaseItem parent)
		{
			Text = text;
			Parent = parent;
		}

		public Status Status { get; set; }
		public Result Result { get; set; }

		public string Text { get; set; }

		public IGeneratePathAndFileNameForTestCaseItem Parent { get; }

		public virtual bool MakeScreenshot(Result result)
		{
			string path;
			string fileName;
			ScreenshotMaker.TakeAndSaveScreenshot(Parent.GeneratePathAndFileNameForTestCaseItem(this));

			Status = Status.Done;
			Result = result;
			return true;
		}

		public bool Skip()
		{
			Status = Status.Skipped;
			Result = Result.Unknown;
			return true;
		}

		public bool Show()
		{
			return false;
		}

		public bool HasScreenshot()
		{
			return Status == Status.Done && _fileName != null;
		}
	}
}