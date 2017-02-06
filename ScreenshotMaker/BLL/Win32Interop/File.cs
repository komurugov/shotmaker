using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
				Win32Interop.MoveFileFlags.MOVEFILE_REPLACE_EXISTING | Win32Interop.MoveFileFlags.MOVEFILE_COPY_ALLOWED))
			{
				Win32Interop.ErrorCodes errorCode = (Win32Interop.ErrorCodes)Marshal.GetLastWin32Error();
				throw new InvalidOperationException(string.Format("Can't move {0} to {1}, win32api error code {2}", source, destination, errorCode));
			}
		}

		internal static void Remove(string path)
		{
			string win32Path = Path.GetLongWin32(path);
			if (!Win32Interop.DeleteFile(win32Path))
			{
				Win32Interop.ErrorCodes errorCode = (Win32Interop.ErrorCodes)Marshal.GetLastWin32Error();
				if (errorCode != Win32Interop.ErrorCodes.ERROR_PATH_NOT_FOUND
					&& errorCode != Win32Interop.ErrorCodes.ERROR_FILE_NOT_FOUND)
					throw new InvalidOperationException(string.Format("Can't delete file {0}, win32api error code {1}", win32Path, errorCode));
			}
		}
	}
}
