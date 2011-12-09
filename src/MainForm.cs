using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;
using System.Collections;
using DojoTimer.Resources;
using DojoTimer.Helpers;

namespace DojoTimer
{
    public partial class MainForm : Form
    {
        Options options;
        Stopwatch stopwatch = new Stopwatch();
        KeyboardHook hook = new KeyboardHook();
        ColorScheme scheme = ColorScheme.Green;

        public MainForm() : this(Options.Load()) { }
        public MainForm(Options options)
        {
            InitializeComponent();
            this.options = options;
            BindHotKey();

            Stop();
            this.Left = Screen.PrimaryScreen.WorkingArea.Right - Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 2 * SystemInformation.CaptionHeight;
            scheme.ApplyToMain(this);
            TitleBar.BindHandleTo(this);
        }


        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            RunButton_Click(this, e);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
                Stop();
            else
                Start();
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
                Stop();
                ReallyActivate();
                using (var alarm = Sounds.alarm)
                    new SoundPlayer(alarm).PlaySync();
                HandleFinish(false);
            }
        }

        private void ReallyActivate()
        {
            this.TopMost = true;
            this.Activate();
            this.TopMost = TopMostCheck.Checked;
        }

        private void HandleFinish(bool force)
        {
            if (force || options.KeepTrack)
            {
                scheme.ApplyTo(new WhoWasHereForm(options)).ShowDialog();
            }
        }

        private void SetTransparency()
        {
            var control = TimeLabel;
            var show = inside || !MainTimer.Enabled;
            control.FlatAppearance.MouseOverBackColor = Color.FromArgb(show ? 150 : 225, Color.White);
            control.ForeColor = show ? Color.White : this.BackColor;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void TimeLabel_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            hook.Dispose();
            options = ShowOptionsForm();
            options.Save();
            BindHotKey();
            SetTime();
        }

        private Options ShowOptionsForm()
        {
            var form = new OptionsForm(options);
            scheme.ApplyTo(form);
            bool topmost = this.TopMost;
            this.TopMost = false;
            form.ShowDialog();
            this.TopMost = topmost;
            return form.Options;
        }

        private void BindHotKey()
        {
            hook = new KeyboardHook();
            hook.KeyPressed += hook_KeyPressed;
            hook.RegisterHotKey(options.ShortcutModifiers, options.ShortcutKey);
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void SetTime()
        {
            var remaining = options.Period - stopwatch.Elapsed;
            if (remaining.Ticks < 0) remaining = TimeSpan.Zero;
            TimeLabel.Text = string.Format("{0:00}:{1:00}", (int)remaining.TotalMinutes, remaining.Seconds);
        }

        private void Start()
        {
            if (stopwatch.Elapsed >= options.Period)
                stopwatch.Reset();
            stopwatch.Start();
            MainTimer.Enabled = true;
            StartButton.Text = ";";
        }

        private void Stop()
        {
            stopwatch.Stop();
            MainTimer.Enabled = false;
            StartButton.Text = "4";
            SetTransparency();
            SetTime();
        }

        private void Reset()
        {
            stopwatch.Reset();
            Stop();
        }

        private void Run()
        {
            var list = new ArrayList(Application.OpenForms);
            foreach (Form form in list)
                if (form is OutputWindow && !form.IsDisposed)
                    form.Close();

            var output = new OutputWindow();
            options.Write += s => output.Write(s);
            RunAndShow(output);
        }

        private void RunAndShow(OutputWindow output)
        {
            output.Show();
            output.Activate();
            Application.DoEvents(); //huh?
            var run = options.Run();

            scheme = run ? ColorScheme.Green : ColorScheme.Red;
            scheme.ApplyToMain(this);
            output.ShowText(run);
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

        private void TopMostCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopMostCheck.Checked;
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            HandleFinish(true);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommitButton_Click_1(object sender, EventArgs e)
        {
            HandleFinish(true);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void GotoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GotoLink.Text);
        }

    }
}
