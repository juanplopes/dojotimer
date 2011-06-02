using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DojoTimer
{
    public partial class FormTitleBar : UserControl
    {
        public string TitleText
        {
            get { return TitleLabel.Text; }
            set { TitleLabel.Text = value; }
        }

        public string TitleDescription
        {
            get { return DescriptionLabel.Text; }
            set { DescriptionLabel.Text = value; }
        }
        public string TitleIcon
        {
            get { return IconLabel.Text; }
            set { IconLabel.Text = value; }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                IconLabel.ForeColor = value;
                DescriptionLabel.ForeColor = value;
                TitleLabel.ForeColor = value;
                label1.BackColor = value;
                base.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set { BackPanel.BackColor = value; base.BackColor = value; }
        }

        public FormTitleBar()
        {
            InitializeComponent();
            this.ForeColor = Color.Navy;
            this.BackColor = Color.White;
        }
    }
}
