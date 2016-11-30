using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenshotMaker.BLL;

namespace ScreenshotMaker.PrL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Presenter presenter = new Presenter();
            Application.Run(new FormMain(presenter));
        }
    }
}
