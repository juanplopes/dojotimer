using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

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
            MinutesInput.Text = ((int)options.Period.TotalMinutes).ToString("00");
            SecondsInput.Text = options.Period.Seconds.ToString("00");
            ShortcutInput.Text = (ShortcutInput.Tag = options.Shortcut).ToString();
            ScriptInput.Text = options.Script;
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
            options.Period = TimeSpan.FromSeconds(int.Parse(MinutesInput.Text) * 60 + int.Parse(SecondsInput.Text));
            options.Shortcut = (Keys)ShortcutInput.Tag;
            options.Script = ScriptInput.Text;
        }
    }
}
