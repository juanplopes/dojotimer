namespace DojoTimer
{
    partial class FormTitleBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTitleBar));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IconLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.DimGray;
            this.BackPanel.Controls.Add(this.CloseButton);
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Controls.Add(this.IconLabel);
            this.BackPanel.Controls.Add(this.DescriptionLabel);
            this.BackPanel.Controls.Add(this.TitleLabel);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackPanel.ForeColor = System.Drawing.Color.White;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(389, 60);
            this.BackPanel.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(337, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 35);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 2);
            this.label1.TabIndex = 6;
            // 
            // IconLabel
            // 
            this.IconLabel.Image = ((System.Drawing.Image)(resources.GetObject("IconLabel.Image")));
            this.IconLabel.Location = new System.Drawing.Point(13, 12);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(43, 39);
            this.IconLabel.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(58, 37);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(227, 16);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "description long enough to cover something";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(56, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(98, 29);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "title (g)";
            // 
            // FormTitleBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BackPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormTitleBar";
            this.Size = new System.Drawing.Size(389, 62);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
    }
}
