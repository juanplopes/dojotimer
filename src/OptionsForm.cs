using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DojoTimer
{
    public partial class OptionsForm : Form
    {
        Options options;
        public OptionsForm(Options options)
        {
            InitializeComponent();
            this.options = options;
            MinutesInput.Text = options.Period.Minutes.ToString("00");
            SecondsInput.Text = options.Period.Seconds.ToString("00");
            ShortcutInput.Text = options.Shortcut.ToString();
            RefreshConfig(options.Script);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                options.Script = OpenFile.FileName;
                RefreshConfig(OpenFile.FileName);
            }
        }

        private void RefreshConfig(string newpath)
        {
            DirectoryButton.Text = Path.GetFileName(newpath);
            OpenFile.FileName = newpath;
        }

        private void ShortcutInput_KeyDown(object sender, KeyEventArgs e)
        {
            ShortcutInput.Text = e.KeyData.ToString();
            if (e.Modifiers > 0)
                options.Shortcut = e.KeyData;
            e.SuppressKeyPress = true;
        }

        private void ShortcutInput_Leave(object sender, EventArgs e)
        {
            ShortcutInput.Text = options.Shortcut.ToString();
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            options.Period = TimeSpan.FromSeconds(int.Parse(MinutesInput.Text) * 60 + int.Parse(SecondsInput.Text));
        }
    }
}
