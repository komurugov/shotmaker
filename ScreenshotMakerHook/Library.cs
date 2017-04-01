using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ScreenshotMakerHook
{
    public class Library
    {
		public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);
		static HookProc _action;
		public void DoIt(HookProc action)
		{
			_action = action;
		}

		public static Library CreateLibrary()
		{
			return new Library();
		}

		public static int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			return _action(nCode, wParam, lParam);
		}

	}
}
