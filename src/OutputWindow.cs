using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace DojoTimer
{
    public partial class OutputWindow : Form
    {
        string text = "";

        public OutputWindow()
        {
            InitializeComponent();
            OutputTitleBar.BindHandleTo(this);
        }

        public void Clear()
        {
            text = "";
        }

        public void Write(string data)
        {
            text += data + "\r\n";
        }

        public void ShowText(bool result)
        {
            OutputText.Text = text;
            OutputText.SelectionStart = OutputText.TextLength;
            OutputText.ScrollToCaret();
            SetTitleMessages(result);
        }

        private void SetTitleMessages(bool result)
        {
            OutputTitleBar.BackColor = result ? Color.Green : Color.Red;
            OutputTitleBar.TitleText = result ? "SUCCEEDED" : "FAILED";
            OutputTitleBar.TitleDescription = result ?
                "Yay, it works!" : "Gotta fix it. Bad, bad programmer.";
            OutputTitleBar.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
