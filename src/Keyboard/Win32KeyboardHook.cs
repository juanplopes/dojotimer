using System;
using System.Collections.Generic;

using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DojoTimer.Keyboard
{
    public sealed class Win32KeyboardHook : IKeyboardHook, IDisposable
    {
	
        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private DummyWindow window = new DummyWindow();
        private int currentId = 0;

        public Win32KeyboardHook()
        {
            window.KeyPressed += delegate(object sender, KeyPressedEventArgs args)
            {
                if (KeyPressed != null)
                    KeyPressed(this, args);
            };
        }

        public void RegisterHotKey(ModifierKeys modifier, Keys key)
        {
            if (!RegisterHotKey(window.Handle, currentId++, (uint)modifier, (uint)key))
                throw new InvalidOperationException("Couldn’t register the hot key.");
        }

        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        public void Dispose()
        {
            for (int i = currentId; i > 0; i--)
				UnregisterHotKey(window.Handle, i);

			window.Dispose();
        }

    }



}