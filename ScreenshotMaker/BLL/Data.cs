namespace ScreenshotMaker.BLL
{
	public class Data : TestCaseItem
	{
		public Data(string text, IGeneratePathAndFileNameForTestCaseItem parent) : base(text, parent)
		{
		}
		public Verification GetVerification()
		{
			return Parent as Verification;
		}
	}
}