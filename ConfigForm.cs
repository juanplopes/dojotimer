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
    public partial class ConfigForm : Form
    {
        Options options;
        public ConfigForm(Options options)
        {
            InitializeComponent();
            this.options = options;
            MinutesInput.Text = options.Period.Minutes.ToString("00");
            SecondsInput.Text = options.Period.Seconds.ToString("00");
            RefreshConfig(options.WorkingDir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            options.Period = TimeSpan.FromSeconds(int.Parse(MinutesInput.Text) * 60 + int.Parse(SecondsInput.Text));
            this.Close();
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (FolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var newpath = FolderDialog.SelectedPath;
                if (File.Exists(Path.Combine(newpath, Options.DefaultRunFile)))
                {
                    options.WorkingDir = newpath;
                    RefreshConfig(newpath);
                }
                else
                {
                    MessageBox.Show("O diretório não possui um arquivo run.cmd. Faça um agora!");
                }
            }
        }

        private void RefreshConfig(string newpath)
        {
            DirectoryButton.Text = Path.GetFileName(newpath);
            FolderDialog.SelectedPath = newpath;
        }
    }
}
