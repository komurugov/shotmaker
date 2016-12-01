namespace ScreenshotMaker.BLL
{
	public enum Result
	{
		Unknown,
		Passed,
		Failed
	}

	public enum Status
	{
		None,
		Done,
		Skipped
	}

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
}