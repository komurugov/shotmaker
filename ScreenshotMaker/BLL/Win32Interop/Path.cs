using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL.Win32Interop
{
	class Path
	{
		private const string _longWin32Prefix = @"\\?\";
		private const string _uncPrefix = @"\\";
		private const string _uncWin32Prefix = @"\\?\UNC\";

		public static string GetLongWin32(string filename)
		{
			if (filename.StartsWith(_longWin32Prefix) || filename.StartsWith(_uncWin32Prefix))
				return filename;
			if (filename.StartsWith(_uncPrefix))
				return _uncWin32Prefix + filename.Remove(0, _uncPrefix.Length);
			return _longWin32Prefix + filename;
		}
	}
}
