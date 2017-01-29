using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DojoTimer.Helpers;

namespace DojoTimer
{
    public partial class MainTitleBar : UserControl
    {
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                TitleLabel.ForeColor = value;
                panel1.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                TitleLabel.BackColor = value;
                panel1.BackColor = value;
            }
        }

        public override string Text
        {
            get { return TitleLabel.Text; }
            set { TitleLabel.Text = value; }
        }

        public DraggingHandle BindHandleTo(Form form)
        {
            var handle = new DraggingHandle(form);
            handle.Bind(this, TitleLabel, panel1);
            return handle;
        }

        public MainTitleBar()
        {
            InitializeComponent();
            this.ForeColor = Color.Navy;
            this.BackColor = Color.White;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
