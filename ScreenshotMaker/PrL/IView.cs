namespace ScreenshotMaker.PrL
{
	public interface IView
	{
		void RefreshTreeStructure();
		void RefreshData();
		string GetInputFileName();
		string GetTestExecutionName();
		string GetOuputFolderPath();
		void ShowMessage(string message);
	}
}