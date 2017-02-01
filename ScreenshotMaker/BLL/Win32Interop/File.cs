using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL.Win32Interop
{
	public static class File
	{
		public static void Move(string source, string destination)
		{
			if (!Win32Interop.MoveFileEx(
				Path.GetLongWin32(source),
				Path.GetLongWin32(destination),
				Win32Interop.MoveFileFlags.MOVEFILE_REPLACE_EXISTING))  // with Win32Interop.MoveFileFlags.MOVEFILE_COPY_ALLOWED not overwrites existing file
				throw new InvalidOperationException(string.Format("Can't move {0} to {1}", source, destination));
		}
	}
}
