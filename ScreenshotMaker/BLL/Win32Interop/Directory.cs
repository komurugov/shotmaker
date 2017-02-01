using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ScreenshotMaker.BLL.Win32Interop
{
	public static class Directory
	{
		public static void CreateDirectory(string path)
		{
			int currentFolderLastCharNum = 2;
			while (currentFolderLastCharNum + 1 < path.Length)
			{
				currentFolderLastCharNum = path.IndexOf(System.IO.Path.DirectorySeparatorChar, currentFolderLastCharNum + 1);
				if (currentFolderLastCharNum == -1)
					break;
				string currentFolder = path.Substring(0, currentFolderLastCharNum);
				bool result = Win32Interop.CreateDirectory(Path.GetLongWin32(currentFolder), IntPtr.Zero);
				if (!result)
				{
					Win32Interop.ErrorCodes errorCode = (Win32Interop.ErrorCodes)Marshal.GetLastWin32Error();
					if (errorCode != Win32Interop.ErrorCodes.ERROR_ALREADY_EXISTS)
						throw new InvalidOperationException("Can't create directory " + currentFolder);
				}
			}
		}
	}
}
