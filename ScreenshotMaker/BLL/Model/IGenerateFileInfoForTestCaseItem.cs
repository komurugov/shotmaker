namespace ScreenshotMaker.BLL
{
	public interface IGenerateFileInfoForTestCaseItem
	{
		ScreenshotFileInfoDto GenerateFileInfoForTestCaseItem(TestCaseItemInfoDto dto);
	}
}