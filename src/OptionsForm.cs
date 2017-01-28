using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.IO;
using DojoTimer.Helpers;

namespace DojoTimer
{
    public partial class OptionsForm : Form
    {
        Options options;
        public Options Options { get { return options; } }
        public OptionsForm(Options options)
        {
            InitializeComponent();
            SetOptions(options);
            formTitleBar1.BindHandleTo(this);
        }

        private void SetOptions(Options options)
        {
            this.options = options;
            MinutesInput.Text = ((int)options.Period.TotalMinutes).ToString("00");
            SecondsInput.Text = options.Period.Seconds.ToString("00");
            ShortcutInput.Text = (ShortcutInput.Tag = options.Shortcut).ToString();
            ScriptInput.Text = options.Script;
            WorkingDirectoryInput.Text = options.WorkingDirectory;

            ParticipantsInput.Lines = options.Participants;
            KeepTrackInput.Checked = options.KeepTrack;
            UseSemaphoreInput.Checked = options.UseSemaphore;
            SemaphorePortInput.Text = options.SemaphorePort;
            SemaphoreGreenSignalInput.Text = options.GreenSignalChar.ToString();
            SemaphoreRedSignalInput.Text = options.RedSignalChar.ToString();
            SemaphoreBaudRateInput.Text = options.SemaphoreBaudRate.ToString();
            CommitScript.Text = options.CommitScript;
            AlarmSoundInput.Checked = options.PlayAlarmSound;
            TestResultSound.Checked = options.PlayTestResultSound;
            SetFontButton(options.Font);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		
        private void ShortcutInput_KeyDown(object sender, KeyEventArgs e)
        {
            ShortcutInput.Text = (ShortcutInput.Tag = e.KeyData).ToString();
			e.SuppressKeyPress = true;
        }

        private void ShortcutInput_Leave(object sender, EventArgs e)
        {
            if ((((Keys)ShortcutInput.Tag) & Keys.Modifiers) == 0)
                ShortcutInput.Text = (ShortcutInput.Tag = options.Shortcut).ToString();
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckDirectory(e);
            if (e.Cancel) return;

            options.Period = TimeSpan.FromSeconds(int.Parse(MinutesInput.Text) * 60 + int.Parse(SecondsInput.Text));
            options.Shortcut = (Keys)ShortcutInput.Tag;
            options.Script = ScriptInput.Text;

            options.Participants = ParticipantsInput.Lines;
            options.KeepTrack = KeepTrackInput.Checked;
            options.UseSemaphore = UseSemaphoreInput.Checked;
            options.SemaphorePort = SemaphorePortInput.Text;
            if (SemaphoreGreenSignalInput.Text.Length == 1)
                options.GreenSignalChar = SemaphoreGreenSignalInput.Text[0];
            if (SemaphoreRedSignalInput.Text.Length == 1)
                options.RedSignalChar = SemaphoreRedSignalInput.Text[0];
            options.SemaphoreBaudRate = Int32.Parse(SemaphoreBaudRateInput.Text);
            options.CommitScript = CommitScript.Text;
            options.WorkingDirectory = WorkingDirectoryInput.Text;
            options.PlayAlarmSound = AlarmSoundInput.Checked;
            options.PlayTestResultSound = TestResultSound.Checked;
            options.Font = FontButton.Font;
        }

        private void CheckDirectory(FormClosingEventArgs e)
        {
            if (!Directory.Exists(WorkingDirectoryInput.Text) &&
                MessageBox.Show("The directory you selected doesn't seem to exist. Are you sure you want to close?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                SetOptions(new Options());
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            BrowseFolder.SelectedPath = WorkingDirectoryInput.Text;
            if (BrowseFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WorkingDirectoryInput.Text = BrowseFolder.SelectedPath;
            }
        }

        

        private void FontButton_Click(object sender, EventArgs e)
        {
            if (BrowseFont.ShowDialog() == DialogResult.OK)
            {
                var font = BrowseFont.Font;
                SetFontButton(font);
            }
        }

        private void SetFontButton(Font font)
        {
            if (font == null)
                font = Options.DEFAULT_OUTPUT_FONT;
            BrowseFont.Font = font;
            FontButton.Text = MakeFontName(font);
            FontButton.Font = font;
        }

        private static string MakeFontName(Font font)
        {
            return font.Name + ", " + font.Style + ", " + font.SizeInPoints + "pt";
        }
    }
}
