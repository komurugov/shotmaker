using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL
{
	public static class Logger
	{
		public enum Levels
		{
			Info,
			Warning,
			Error,
			FatalError
		}

		public static void OutputToLog(Levels level, string text)
		{
			
		}
	}
}
