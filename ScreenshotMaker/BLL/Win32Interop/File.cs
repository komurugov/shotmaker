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
				Win32Interop.MoveFileFlags.MOVEFILE_REPLACE_EXISTING))  // in case of adding Win32Interop.MoveFileFlags.MOVEFILE_COPY_ALLOWED doesn't overwrite existing file
				throw new InvalidOperationException(string.Format("Can't move {0} to {1}", source, destination));
		}

		internal static void Remove(string path)
		{
			if (!Win32Interop.DeleteFile(path))
			{
				Win32Interop.ErrorCodes errorCode = (Win32Interop.ErrorCodes)Marshal.GetLastWin32Error();
				if (errorCode != Win32Interop.ErrorCodes.ERROR_PATH_NOT_FOUND
					&& errorCode != Win32Interop.ErrorCodes.ERROR_FILE_NOT_FOUND)
					throw new InvalidOperationException("Can't delete file " + path);
			}
		}
	}
}
