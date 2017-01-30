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

		public static void AddExtensionAndSave(this Bitmap bitmap, string fileName, ImageFormat format)
		{
			string fullFileName = fileName + "." + format.ToString().ToLower();
			try
			{
				bitmap.Save(fullFileName, format);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't save the image by the path '{0}': {1}", fullFileName, exception.Message));
			}
		}

		public static void AddExtensionAndSave(this Bitmap bitmap, string path, string name, ImageFormat format)
		{
			name += "." + format.ToString().ToLower();
			try
			{
				
				bitmap.Save(name, format);
				Delimon.Win32.IO.File.Move(Environment.CurrentDirectory + @"\" + name, path + name);
			}
			catch (Exception exception)
			{
				throw new InvalidOperationException(string.Format("Can't save the image by the path '{0}': {1}", path + name, exception.Message));
			}
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
			string fullFileNameWithoutExtension = Path.Combine(pathAndFileName.Path, pathAndFileName.FileName);
			bitmap.AddExtensionAndSave(pathAndFileName.Path, pathAndFileName.FileName, ImageFormat.Png);
		}
	}
}
