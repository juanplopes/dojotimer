using System;
using System.Windows.Forms;

namespace DojoTimer.Keyboard
{
	public interface IKeyboardHook : IDisposable
	{
		void RegisterHotKey(ModifierKeys modifier, Keys key);
		event EventHandler<KeyPressedEventArgs> KeyPressed;
	}
}

