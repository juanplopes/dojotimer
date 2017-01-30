using DojoTimer.Helpers;
using System;

namespace DojoTimer.Keyboard
{
	public static class KeyboardHooks
	{
		public static IKeyboardHook Create() {
			if (!ProcessUtil.IsLinux)
				return new Win32KeyboardHook();
			else
				return new X11KeyboardHook();
		}
	}
}

