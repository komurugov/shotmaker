using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ScreenshotMaker.BLL
{
	static class ScreenshotMaker
	{
		private static Bitmap TakeScreenshot()
		{
			var bitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			try
			{
				graphics.CopyFromScreen(SystemInformation.VirtualScreen.X,
					SystemInformation.VirtualScreen.Y,
					0,
					0,
					SystemInformation.VirtualScreen.Size,
					CopyPixelOperation.SourceCopy);
			}
			catch (Exception exception)
			{
				throw new Exception("Can't take screenshot: " + exception.Message);
			}
			return bitmap;
		}

		public static void TakeAndSaveScreenshot(FileInfoDto pathAndFileName)
		{
			try
			{
				Directory.CreateDirectory(pathAndFileName.Path);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't create path '{0}': {1}", pathAndFileName.Path, exception.Message));
			}
			Bitmap bitmap = TakeScreenshot();
			string fullFileName = Path.Combine(pathAndFileName.Path, pathAndFileName.FileName + ".png");
			try
			{
				bitmap.Save(fullFileName, ImageFormat.Png);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't save the image by the path '{0}': {1}", fullFileName, exception.Message));
			}
		}
	}
}
