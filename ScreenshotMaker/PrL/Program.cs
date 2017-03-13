using System;
using System.Windows.Forms;
using ScreenshotMaker.BLL;

namespace ScreenshotMaker.PrL
{
	internal static class Program
	{
        public static FormMain MainForm;
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var presenter = new Presenter();
            MainForm = new FormMain(presenter);
            Application.Run(MainForm);
		}
	}
}