namespace ScreenshotMaker.BLL
{
	public interface ITestCaseItem
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