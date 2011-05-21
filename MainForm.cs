using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace DojoTimer
{
    public partial class MainForm : Form
    {
        Options options;
        Stopwatch stopwatch = new Stopwatch();

        public MainForm() : this(new Options()) { }
        public MainForm(Options options)
        {
            InitializeComponent();
            this.options = options;
            SetTime();
            var hook = new KeyboardHook();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(DojoTimer.ModifierKeys.Alt | DojoTimer.ModifierKeys.Control | DojoTimer.ModifierKeys.Win, Keys.T);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            RunButton_Click(this, e);
        }


        private void SetTime()
        {
            var remaining = options.Period - stopwatch.Elapsed;
            TimeLabel.Text = string.Format("{0:00}:{1:00}", remaining.Minutes, remaining.Seconds);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
                Stop();
            else
                Start();
        }

        private void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
            MainTimer.Enabled = true;
        }

        private void Stop()
        {
            stopwatch.Stop();
            MainTimer.Enabled = false;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            SetTransparency();
            if (stopwatch.Elapsed < options.Period)
            {
                SetTime();
            }
            else
            {
                Reset();
                using (var alarm = Resources.alarm)
                    new SoundPlayer(alarm).Play();
            }
        }

        private void SetTransparency(bool force = false)
        {
            foreach(Control control in this.Controls)
                control.ForeColor = force || inside ? Color.White : this.BackColor;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            stopwatch.Stop();
            MainTimer.Enabled = false;
            SetTime();
            SetTransparency(true);
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {
            new ConfigForm(options).ShowDialog(this);
            SetTime();
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<OutputWindow>().ToList().ForEach(x => x.Close());
            var output = new OutputWindow();
            output.Clear();
            options.Write += s => output.Write(s);
            output.Show(this);
            
            this.BackColor = options.Run() ? Color.Green : Color.Red;
            output.ShowText();

        }

        bool inside = true;

        private void MainForm_Activated(object sender, EventArgs e)
        {
            inside = true;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            inside = false;
        }

    }
}
