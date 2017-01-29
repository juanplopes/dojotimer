using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Media;
using System.IO.Ports;
using System.Windows.Forms;
using DojoTimer.Helpers;

namespace DojoTimer
{
    public partial class OutputWindow : Form
    {
        string text = "";

        public OutputWindow(Font font)
        {
            InitializeComponent();
            OutputTitleBar.BindHandleTo(this);
            OutputText.Font = font;
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
            var scheme = result ? ColorScheme.Green : ColorScheme.Red;
            scheme.ApplyTo(this);
            OutputTitleBar.TitleText = result ? "SUCCEEDED" : "FAILED";
            OutputTitleBar.TitleDescription = result ?
                "Yay, it works!" : "Gotta fix it. That's the game.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
