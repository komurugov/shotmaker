using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotMaker.BLL
{
	class ScreenshotMaker
	{
		public static Bitmap GetScreenshot()
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
	}
}
