using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace DojoTimer
{
    public partial class ToastyForm : Form
    {
        public ToastyForm()
        {
            InitializeComponent();
        }

        public static void MakeMeLaugh()
        {
            var thread = new Thread(() =>
            {
                using (var form = new ToastyForm())
                {
                    PlayToasty();

                    form.Left = Screen.PrimaryScreen.WorkingArea.Right;
                    form.Top = Screen.PrimaryScreen.WorkingArea.Bottom - form.Height;
                    form.Show();

                    for (int i = 0; i < 100; i++) PaintItWith(form, i);

                    form.Left = Screen.PrimaryScreen.WorkingArea.Right - form.Width;
                    Thread.Sleep(500);

                    for (int i = 99; i >= 0; i--) PaintItWith(form, i);
                }
            });
            thread.Start();
        }

        private static void PlayToasty()
        {
            using (var toasty = Resources.toasty)
                new SoundPlayer(toasty).Play();
        }

        private static void PaintItWith(ToastyForm form, int i)
        {
            form.Left = Screen.PrimaryScreen.WorkingArea.Right - (i * form.Width / 100);
            Application.DoEvents();
            Thread.Sleep(3);
        }
    }
}
