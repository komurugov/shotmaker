using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shotmaker.PrL
{
	public interface IView
	{
		void Refresh();
		string GetTestExecutionName();
		string GetOuputFolderPath();
		void ShowMessage(string message);
	}
}
