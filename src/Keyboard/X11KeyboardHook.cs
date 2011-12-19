using System;
using System.Windows.Forms;

namespace DojoTimer.Keyboard
{
	public class X11KeyboardHook : IKeyboardHook
	{
		public X11KeyboardHook ()
		{
		}

		public event EventHandler<KeyPressedEventArgs> KeyPressed;

		public void RegisterHotKey (ModifierKeys modifier, Keys key)
		{
			
		}

		public void Dispose ()
		{
			
		}
	}
}

