using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace ScreenshotMaker.BLL.Win32Interop
{
	public static class Directory
	{
		public static void CreateDirectory(string path)
		{
			int currentFolderLastCharNum = 0;

			string prefix = @"\\";
			if (path.IndexOf(prefix) == 0 && path.Length > prefix.Length)
				currentFolderLastCharNum = path.IndexOf(System.IO.Path.DirectorySeparatorChar, prefix.Length);
			else
			{
				prefix = @":\";
				if (path.IndexOf(prefix) == 0 && path.Length > prefix.Length)
					currentFolderLastCharNum = prefix.Length;
			}
			
			while (currentFolderLastCharNum > -1 && currentFolderLastCharNum + 1 < path.Length)
			{
				currentFolderLastCharNum = path.IndexOf(System.IO.Path.DirectorySeparatorChar, currentFolderLastCharNum + 1);
				if (currentFolderLastCharNum == -1)
					break;
				string currentFolder = path.Substring(0, currentFolderLastCharNum);
				if (!System.IO.Directory.Exists(currentFolder))
				{

					//var lpSecurityAttributes = new Win32Interop.SECURITY_ATTRIBUTES();
					//DirectorySecurity security = new DirectorySecurity();
					//lpSecurityAttributes.nLength = Marshal.SizeOf(lpSecurityAttributes);
					//byte[] src = security.GetSecurityDescriptorBinaryForm();
					//IntPtr dest = Marshal.AllocHGlobal(src.Length);
					//Marshal.Copy(src, 0, dest, src.Length);
					//lpSecurityAttributes.lpSecurityDescriptor = dest;

					//					bool result = Win32Interop.CreateDirectory(Path.GetLongWin32(currentFolder), /*IntPtr.Zero*/lpSecurityAttributes);

					string win32Path = Path.GetLongWin32(currentFolder);
					bool result = Win32Interop.CreateDirectory(win32Path, IntPtr.Zero);
					if (!result)
					{
						Win32Interop.ErrorCodes errorCode = (Win32Interop.ErrorCodes)Marshal.GetLastWin32Error();
						if (errorCode != Win32Interop.ErrorCodes.ERROR_ALREADY_EXISTS)
							throw new InvalidOperationException(string.Format("Can't create directory {0}, win32api error code {1}", win32Path, errorCode));
					}
				}
			}
		}

		internal static bool Exists(string path)
		{
			Win32Interop.FileAttributesFlags result = Win32Interop.GetFileAttributes(Path.GetLongWin32(path));
			return (result == Win32Interop.FileAttributesFlags.FILE_ATTRIBUTE_DIRECTORY);
		}
	}
}
