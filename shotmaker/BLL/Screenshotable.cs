namespace ScreenshotMaker.BLL
{
	public class Screenshotable : IScreenshotable
	{
		private readonly string _FileName = null;

		public Screenshotable(string t)
		{
			Text = t;
			Status = Status.None;
			Result = Result.Unknown;
		}

		public Status Status { get; set; }
		public Result Result { get; set; }

		public string Text { get; set; }

		public bool MakeScreenshot(Result result)
		{
			return false;
		}

		public bool Skip()
		{
			return false;
		}

		public bool Show()
		{
			return false;
		}

		public bool HasScreenshot()
		{
			return Status == Status.Done && _FileName != null;
		}
	}
}