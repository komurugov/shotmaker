using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agilent.System.IO
{
	class Path
	{
		private const string _longWin32Prefix = @"\\?\";
		public static string GetLongWin32(string filename)
		{
			return filename.IndexOf(_longWin32Prefix) == 0 ?
				filename :
				_longWin32Prefix + filename;
		}
	}
}
