﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DojoTimer.Helpers;

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

        [Editor(typeof(System.Drawing.Design.ImageEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public Image TitleIcon
        {
            get { return IconLabel.Image; }
            set { IconLabel.Image = value; }
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
                CloseButton.ForeColor = value;
                base.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                BackPanel.BackColor = value; 
                base.BackColor = value; 
                CloseButton.BackColor = value;
                CloseButton.FlatAppearance.BorderColor = value;
            }
        }

        public DraggingHandle BindHandleTo(Form form)
        {
            var handle = new DraggingHandle(form);
            handle.Bind(IconLabel, DescriptionLabel, TitleLabel, label1, this, BackPanel);
            return handle;
        }

        public FormTitleBar()
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
