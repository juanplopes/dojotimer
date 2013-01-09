using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace DojoTimer.Keyboard
{
    public class X11KeyboardHook : IKeyboardHook
    {
        private static int count = 0;
        
        private const int KeyPress = 2;
        private const int GrabModeAsync = 1;
        
        private IList<int> keycodes = new List<int>();
        private IList<XModMask> modifiers = new List<XModMask>();

        private IList<Keys> originalKey = new List<Keys>();
        private IList<ModifierKeys> originalModifier = new List<ModifierKeys>();

        private Gdk.Window window;
        
        class Filter : IMessageFilter {
            public bool PreFilterMessage(ref Message m) {
                Gtk.Application.RunIteration(false);
                return false;    
            }
        }
        
        public X11KeyboardHook()
        {
            if (Interlocked.Increment(ref count) == 1) {
                Gtk.Application.Init();
                Application.AddMessageFilter(new Filter());
            }
			Console.WriteLine (Marshal.SizeOf(typeof(IntPtr)));
            window = new Gdk.Window(gdk_get_default_root_window());
            window.AddFilter(FilterFunction);
        }

        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        private IEnumerable<XModMask> Combine(params XModMask[] masks)
        {
            for (var i = 0; i < (1 << masks.Length); i++)
            {
                var ii = i;
                XModMask mask = 0;
                for (var j = masks.Length - 1; j >= 0; j--)
                {
                    if ((ii & 1) > 0)
                        mask |= masks[j];
                    ii >>= 1;
                }

                yield return mask;
            }
        }

        public void RegisterHotKey(ModifierKeys modifier, Keys key)
        {
            var realKey = XKeysymToKeycode(GetXDisplay(), (int)(key & Keys.KeyCode));
            var realModifiers = XModMask.None;
            if ((modifier & ModifierKeys.Control) == ModifierKeys.Control)
                realModifiers |= XModMask.Control;
            if ((modifier & ModifierKeys.Shift) == ModifierKeys.Shift)
                realModifiers |= XModMask.Shift;
            if ((modifier & ModifierKeys.Alt) == ModifierKeys.Alt)
                realModifiers |= XModMask.Mod1;

            this.keycodes.Add(realKey);
            this.modifiers.Add(realModifiers);
            this.originalKey.Add(key);
            this.originalModifier.Add(modifier);

            IntPtr xid = gdk_x11_drawable_get_xid(gdk_get_default_root_window());
            IntPtr xdisplay = gdk_x11_get_default_xdisplay();

            gdk_error_trap_push();

            foreach (var mask in Combine(XModMask.Mod2, XModMask.Mod3, XModMask.Mod4, XModMask.Mod5, XModMask.Lock))
                XGrabKey(xdisplay, realKey, realModifiers | mask, xid, true, XGrabMode.Async, XGrabMode.Async);

            gdk_flush();
            if (gdk_error_trap_pop() != 0)
            {
                Console.Error.WriteLine("MMKeys: Could not grab key {0} (maybe another application has grabbed this key)", realKey);
            }
        }

        public void Dispose()
        {
            window.RemoveFilter(FilterFunction);

            IntPtr xid = gdk_x11_drawable_get_xid(gdk_get_default_root_window());
            IntPtr xdisplay = gdk_x11_get_default_xdisplay();

            for (var i = 0; i < keycodes.Count; i++)
            {
                gdk_error_trap_push();

                foreach (var mask in Combine(XModMask.Mod2, XModMask.Mod3, XModMask.Mod4, XModMask.Mod5, XModMask.Lock))
                    XUngrabKey(xdisplay, keycodes[i], modifiers[i] | mask, xid);

                gdk_flush();
                if (gdk_error_trap_pop() != 0)
                    Console.Error.WriteLine("MMKeys: Could not ungrab key {0} (maybe another application has grabbed this key)", keycodes[i]);
            }
        }

        private Gdk.FilterReturn FilterFunction(IntPtr xEvent, Gdk.Event evnt)
        {
            XKeyEvent xKeyEvent = (XKeyEvent)Marshal.PtrToStructure(
            xEvent,
            typeof(XKeyEvent));

            if (xKeyEvent.type == KeyPress)
                for (var i = 0; i < keycodes.Count; i++)
                    if (xKeyEvent.keycode == keycodes[i] && (xKeyEvent.state & modifiers[i]) == this.modifiers[i])
                    {
                        this.OnPressed(new KeyPressedEventArgs(originalModifier[i], originalKey[i]));
                        break;
                    }

            return Gdk.FilterReturn.Continue;
        }

        protected virtual void OnPressed(KeyPressedEventArgs e)
        {
            EventHandler<KeyPressedEventArgs> handler = this.KeyPressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private static IntPtr GetXDisplay()
        {
            return gdk_x11_get_default_xdisplay();
        }

        [DllImport("libgtk-x11-2.0.so.0")]
        private static extern IntPtr gdk_x11_drawable_get_xid(IntPtr gdkWindow);

        [DllImport("libgdk-x11-2.0.so.0")]
        extern static IntPtr gdk_x11_get_default_xdisplay();

        [DllImport("libgtk-x11-2.0.so.0")]
        private static extern IntPtr gdk_x11_drawable_get_xdisplay(IntPtr gdkDrawable);


        [DllImport("libgtk-x11-2.0.so.0")]
        private static extern IntPtr gdk_x11_window_get_drawable_impl(IntPtr gdkWindow);

        [DllImport("libgtk-x11-2.0.so.0")]
        extern static IntPtr gdk_get_default_root_window();


        [DllImport("libX11")]
        private static extern int XKeysymToKeycode(IntPtr display, int key);

        [DllImport("libX11")]
        extern static void XGrabKey(IntPtr display, int keycode, XModMask modifiers,
            IntPtr window, bool owner_events, XGrabMode pointer_mode, XGrabMode keyboard_mode);

        [DllImport("libX11")]
        extern static void XUngrabKey(IntPtr display, int keycode, XModMask modifiers,
            IntPtr window);


        [StructLayout(LayoutKind.Sequential)]
        private struct XKeyEvent
        {
            public int type;
            public ulong serial;
            public int send_event;
            public UIntPtr display;
            public UIntPtr window;
            public UIntPtr root;
            public UIntPtr subwindow;
            public UIntPtr time;
            public int x, y;
            public int x_root, y_root;
            public XModMask state;
            public uint keycode;
            public int same_screen;
        }
        [DllImport("libgdk-x11-2.0.so.0")]
        extern static void gdk_error_trap_push();

        [DllImport("libgdk-x11-2.0.so.0")]
        extern static int gdk_error_trap_pop();

        [DllImport("libgdk-x11-2.0.so.0")]
        extern static void gdk_flush();

        [Flags]
        private enum XModMask
        {
            None = 0,
            Shift = 1 << 0,
            Lock = 1 << 1,
            Control = 1 << 2,
            Mod1 = 1 << 3,
            Mod2 = 1 << 4,
            Mod3 = 1 << 5,
            Mod4 = 1 << 6,
            Mod5 = 1 << 7
        }

        private enum XGrabMode
        {
            Sync = 0,
            Async = 1
        }

        private enum XEventName
        {
            KeyPress = 2,
            KeyRelease = 3,
        }


    }
}

