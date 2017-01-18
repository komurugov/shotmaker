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
			graphics.CopyFromScreen(SystemInformation.VirtualScreen.X,
				SystemInformation.VirtualScreen.Y,
				0,
				0,
				SystemInformation.VirtualScreen.Size,
				CopyPixelOperation.SourceCopy);
			return bitmap;
		}

		private static string GetPathWithoutInvalidChars(string path)
		{
			var invalidChars = Path.GetInvalidFileNameChars().Concat(Path.GetInvalidPathChars());
			foreach (char ch in invalidChars)
				path = path.Replace(ch.ToString(), "");
			return path;
		}

		public static void TakeAndSaveScreenshot(string path)
		{
			string validPath = GetPathWithoutInvalidChars(path) + ".png";
			TakeScreenshot().Save(validPath, ImageFormat.Png);
		}
	}
}
