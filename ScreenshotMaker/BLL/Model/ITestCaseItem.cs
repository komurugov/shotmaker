namespace ScreenshotMaker.BLL
{
	public interface ITestCaseItem
	{
		Status Status { get; set; }
		Result Result { get; set; }

		string Text { get; set; }

		bool HasScreenshot();
		bool MakeScreenshot(Result result, string rootFolder, bool entireScreen);
		bool Skip(string rootFolder);
		bool Show();
	}
}