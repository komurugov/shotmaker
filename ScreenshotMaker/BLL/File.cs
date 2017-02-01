using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agilent.System.IO
{
	public static class File
	{
		private const string LongWin32FilenamePrefix = @"\\?\";
		public static string GetLongWin32Filename(string filename)
		{
			return filename.IndexOf(LongWin32FilenamePrefix) == 0 ?
				filename :
				LongWin32FilenamePrefix + filename;
		}
		public static void Move(string source, string destination)
		{
			if (!Win32Interop.MoveFileEx(
				GetLongWin32Filename(source),
				GetLongWin32Filename(destination),
				Win32Interop.MoveFileFlags.MOVEFILE_COPY_ALLOWED | Win32Interop.MoveFileFlags.MOVEFILE_REPLACE_EXISTING))
				throw new InvalidOperationException(string.Format("Can't move {0} to {1}", source, destination));
		}
	}
}
