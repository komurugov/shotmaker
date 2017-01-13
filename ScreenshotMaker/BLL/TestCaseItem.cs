using System.Drawing;

namespace ScreenshotMaker.BLL
{
	public class TestCaseItem : ITestCaseItem
	{
		private readonly string _fileName = null;

		public TestCaseItem(string text)
		{
			Text = text;
		}

		public Status Status { get; set; }
		public Result Result { get; set; }

		public string Text { get; set; }

		public bool MakeScreenshot(Result result)
		{
			Bitmap bitmap = ScreenshotMaker.GetScreenshot();
			bitmap.Save("image.png", System.Drawing.Imaging.ImageFormat.Png);

			return false;
		}

		public bool Skip()
		{
			return false;
		}

		public bool Show()
		{
			return false;
		}

		public bool HasScreenshot()
		{
			return Status == Status.Done && _fileName != null;
		}
	}
}