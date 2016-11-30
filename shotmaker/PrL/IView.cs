using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.PrL
{
	public interface IView
	{
		void RefreshTreeStructure();
		void Refresh();
		string GetInputFileName();
		string GetTestExecutionName();
		string GetOuputFolderPath();
		void ShowMessage(string message);
	}
}
