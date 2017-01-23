namespace ScreenshotMaker.BLL
{
	public interface IGeneratePathAndFileNameForTestCaseItem
	{
		PathAndFileName GeneratePathAndFileNameForTestCaseItem(TestCaseItem testCaseItem);
	}
}