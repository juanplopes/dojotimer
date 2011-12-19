using System;
using System.Windows.Forms;

namespace DojoTimer.Keyboard
{
	public class DummyWindow : NativeWindow, IDisposable
	{
		private static int WM_HOTKEY = 0x0312;

		public DummyWindow ()
		{
			this.CreateHandle (new CreateParams () { Caption = "DummyWindow" });
		}

		protected override void WndProc (ref Message m)
		{
			base.WndProc (ref m);

			if (m.Msg == WM_HOTKEY) {
				Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
				ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

				if (KeyPressed != null)
					KeyPressed (this, new KeyPressedEventArgs (modifier, key));
			}
		}

		public event EventHandler<KeyPressedEventArgs> KeyPressed;


		public void Dispose ()
		{
			this.DestroyHandle ();
		}
	}
}

