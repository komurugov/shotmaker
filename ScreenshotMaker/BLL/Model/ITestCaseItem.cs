namespace ScreenshotMaker.BLL
{
	public interface ITestCaseItem
	{
		Status Status { get; set; }
		Result Result { get; set; }

		string Text { get; set; }

		bool HasScreenshot();
		bool MakeScreenshot(System.IntPtr window, Result result, string rootFolder);
		bool Skip(string rootFolder);
		bool Show();
	}
}