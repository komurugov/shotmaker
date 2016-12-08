using System;
using System.Windows.Forms;
using ScreenshotMaker.BLL;

namespace ScreenshotMaker.PrL
{
	internal static class Program
	{
		/// <summary>
		///     The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var presenter = new Presenter();
			Application.Run(new FormMain(presenter));
		}
	}
}