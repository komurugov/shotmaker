using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		private static string GetPathWithoutInvalidChars(string path)
		{
			var invalidChars = Path.GetInvalidPathChars();
			foreach (char ch in invalidChars)
				path = path.Replace(ch.ToString(), "");
			return path;
		}

		private static string GetFileNameWithoutInvalidChars(string fileName)
		{
			var invalidChars = Path.GetInvalidFileNameChars();
			foreach (char ch in invalidChars)
				fileName = fileName.Replace(ch.ToString(), "");
			return fileName;
		}

		public static void TakeAndSaveScreenshot(FileInfoDto pathAndFileName)
		{
			string validPath = GetPathWithoutInvalidChars(pathAndFileName.Path);
			try
			{
				Directory.CreateDirectory(validPath);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't create path '{0}': {1}", validPath, exception.Message));
			}
			string validFileName = GetFileNameWithoutInvalidChars(pathAndFileName.FileName);
			Bitmap bitmap = TakeScreenshot();
			string fullFileName = Path.Combine(validPath, validFileName + ".png");
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
