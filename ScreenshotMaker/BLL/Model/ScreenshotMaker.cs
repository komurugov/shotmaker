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

		public static void AddExtensionAndSave(this Bitmap bitmap, FileInfoDto fileInfo, ImageFormat format)
		{
			string fileName = fileInfo.FileName + "." + format.ToString().ToLower();
			string destination = Path.Combine(fileInfo.Path, fileName);

			try
			{
				bitmap.Save(fileName, format);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't save the temporary file in {0}: {1}", Environment.CurrentDirectory, exception.Message));
			}
			try
			{ 
				Win32Interop.File.Move(
					Path.Combine(Environment.CurrentDirectory, fileName),
					destination);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't copy the temporary file to {0}: {1}", destination, exception.Message));
			}
		}

		public static void TakeAndSaveScreenshot(FileInfoDto pathAndFileName)
		{
			try
			{
				Win32Interop.Directory.CreateDirectory(pathAndFileName.Path);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't create path '{0}': {1}", pathAndFileName.Path, exception.Message));
			}
			Bitmap bitmap = TakeScreenshot();
			bitmap.AddExtensionAndSave(pathAndFileName, ImageFormat.Png);
		}
	}
}
