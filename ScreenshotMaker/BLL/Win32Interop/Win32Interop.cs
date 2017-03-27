using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL.Win32Interop
{
	public class Win32Interop
	{
		[Flags]
		public enum MoveFileFlags : uint
		{
			MOVEFILE_REPLACE_EXISTING = 1u,
			MOVEFILE_COPY_ALLOWED = 2u,
			MOVEFILE_DELAY_UNTIL_REBOOT = 4u,
			MOVEFILE_WRITE_THROUGH = 8u,
			MOVEFILE_CREATE_HARDLINK = 16u,
			MOVEFILE_FAIL_IF_NOT_TRACKABLE = 32u
		}

		[Flags]
		public enum FileAttributesFlags : uint
		{
			FILE_ATTRIBUTE_DIRECTORY = 0x10
		}

		public enum ErrorCodes : int
		{
			ERROR_FILE_NOT_FOUND = 2,
			ERROR_PATH_NOT_FOUND = 3,
			ERROR_ALREADY_EXISTS = 183
		}

		public enum WindowsHooks : int
		{
			WH_MOUSE_LL = 14
		}

		public enum WindowsMessages : uint
		{
			WM_MOUSEMOVE = 0x200,
			WM_LBUTTONDOWN = 0x201,
			WM_LBUTTONUP = 0x202,
			WM_LBUTTONDBLCLK = 0x203,
			WM_RBUTTONDOWN = 0x204,
			WM_RBUTTONUP = 0x205,
			WM_RBUTTONDBLCLK = 0x206,
			WM_MBUTTONDOWN = 0x207,
			WM_MBUTTONUP = 0x208,
			WM_MBUTTONDBLCLK = 0x209
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int X;
			public int Y;
			public POINT(int x, int y)
			{
				X = x;
				Y = y;
			}
			public POINT(System.Drawing.Point pt) : this(pt.X, pt.Y)
			{
			}
			public static implicit operator System.Drawing.Point(POINT p)
			{
				return new System.Drawing.Point(p.X, p.Y);
			}
			public static implicit operator POINT(System.Drawing.Point p)
			{
				return new POINT(p.X, p.Y);
			}
		}


		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteFile([MarshalAs(UnmanagedType.LPTStr)] string lpFileName);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool CreateDirectory(string lpPathName, IntPtr lpSecurityAttributes);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern FileAttributesFlags GetFileAttributes(string lpFileName);
	}
}
