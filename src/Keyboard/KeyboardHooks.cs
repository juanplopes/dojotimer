using System;

namespace DojoTimer.Keyboard
{
	public static class KeyboardHooks
	{
        public static bool IsLinux
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;
                return (p == 4) || (p == 6) || (p == 128);
            }
        }

		public static IKeyboardHook Create() {
			if (!IsLinux)
				return new Win32KeyboardHook();
			else
				return new X11KeyboardHook();
		}
	}
}

