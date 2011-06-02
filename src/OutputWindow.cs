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
            textBox1.Text = text;
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
            OutputTitleBar.BackColor = result ? Color.Green : Color.Red;
            OutputTitleBar.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
