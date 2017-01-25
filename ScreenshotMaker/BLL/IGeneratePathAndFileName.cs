namespace ScreenshotMaker.BLL
{
	public interface IGenerateFileInfoForTestCaseItem
	{
		FileInfoDto GenerateFileInfoForTestCaseItem(TestCaseItem testCaseItem);
	}
}