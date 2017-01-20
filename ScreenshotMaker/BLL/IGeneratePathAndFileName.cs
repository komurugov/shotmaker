namespace ScreenshotMaker.BLL
{
	public interface IGeneratePathAndFileNameForTestCaseItem
	{
		void GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem, out string path, out string fileName);
	}
}