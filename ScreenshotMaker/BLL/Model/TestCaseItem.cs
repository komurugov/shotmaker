using System.Drawing;
using System.Drawing.Imaging;

namespace ScreenshotMaker.BLL
{
	public class TestCaseItem : ITestCaseItem
	{
		private readonly string _fileName = null;

		public TestCaseItem(string text, IGenerateFileInfoForTestCaseItem parent)
		{
			Text = text;
			Parent = parent;
		}

		public Status Status { get; set; }
		public Result Result { get; set; }

		public string Text { get; set; }

		public IGenerateFileInfoForTestCaseItem Parent { get; }

		public virtual bool MakeScreenshot(Result result, string rootFolder)
		{
			Result = result;
			var screenshotFileInfoDto = Parent.GenerateFileInfoForTestCaseItem(
				new TestCaseItemInfoDto { Item = this, RootFolder = rootFolder, ImageFormat = ScreenshotMaker.ImageFormat});
			ScreenshotMaker.TakeAndSaveScreenshot(new FileInfoDto(screenshotFileInfoDto.Path, screenshotFileInfoDto.FileName));
			Status = Status.Done;
			return true;
		}

		public bool Skip(string rootFolder)
		{
			ScreenshotFileInfoDto screenshotFileInfoDto = Parent.GenerateFileInfoForTestCaseItem(
				new TestCaseItemInfoDto { Item = this, RootFolder = rootFolder, ImageFormat = ScreenshotMaker.ImageFormat });
			foreach (string possiblyFileName in screenshotFileInfoDto.GetPossiblyFileNames())
				ScreenshotMaker.RemoveScreenshot(new FileInfoDto(screenshotFileInfoDto.Path, possiblyFileName));
			Status = Status.Skipped;
			Result = Result.Unknown;
			return true;
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