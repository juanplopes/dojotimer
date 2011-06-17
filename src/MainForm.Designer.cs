namespace DojoTimer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Button();
            this.CommitButton = new System.Windows.Forms.Button();
            this.TopMostCheck = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.GotoLink = new System.Windows.Forms.LinkLabel();
            this.TitleBar = new DojoTimer.MainTitleBar();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(152, 34);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(47, 47);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "4";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(206, 34);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(47, 47);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "9";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 250;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.TimeLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Location = new System.Drawing.Point(12, 34);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(132, 47);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "12:34";
            this.TimeLabel.UseVisualStyleBackColor = false;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // CommitButton
            // 
            this.CommitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommitButton.BackColor = System.Drawing.Color.Transparent;
            this.CommitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.CommitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CommitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitButton.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CommitButton.ForeColor = System.Drawing.Color.White;
            this.CommitButton.Location = new System.Drawing.Point(179, -2);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(30, 30);
            this.CommitButton.TabIndex = 14;
            this.CommitButton.Text = "^";
            this.CommitButton.UseVisualStyleBackColor = false;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click_1);
            // 
            // TopMostCheck
            // 
            this.TopMostCheck.AccessibleDescription = "test";
            this.TopMostCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMostCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.TopMostCheck.BackColor = System.Drawing.Color.Transparent;
            this.TopMostCheck.Checked = true;
            this.TopMostCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopMostCheck.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.TopMostCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TopMostCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostCheck.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopMostCheck.ForeColor = System.Drawing.Color.White;
            this.TopMostCheck.Location = new System.Drawing.Point(209, -2);
            this.TopMostCheck.Name = "TopMostCheck";
            this.TopMostCheck.Size = new System.Drawing.Size(30, 30);
            this.TopMostCheck.TabIndex = 13;
            this.TopMostCheck.Text = "ë";
            this.TopMostCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMostCheck.UseVisualStyleBackColor = false;
            this.TopMostCheck.CheckedChanged += new System.EventHandler(this.TopMostCheck_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(239, -2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "r";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(152, -2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(30, 30);
            this.SettingsButton.TabIndex = 15;
            this.SettingsButton.Text = "@";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // GotoLink
            // 
            this.GotoLink.ActiveLinkColor = System.Drawing.Color.White;
            this.GotoLink.BackColor = System.Drawing.Color.DarkGreen;
            this.GotoLink.DisabledLinkColor = System.Drawing.Color.White;
            this.GotoLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GotoLink.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.GotoLink.LinkColor = System.Drawing.Color.White;
            this.GotoLink.Location = new System.Drawing.Point(0, 88);
            this.GotoLink.Name = "GotoLink";
            this.GotoLink.Size = new System.Drawing.Size(269, 23);
            this.GotoLink.TabIndex = 17;
            this.GotoLink.TabStop = true;
            this.GotoLink.Text = "http://github.com/juanplopes/dojotimer";
            this.GotoLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GotoLink.VisitedLinkColor = System.Drawing.Color.White;
            this.GotoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GotoLink_LinkClicked);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.DarkGreen;
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.ForeColor = System.Drawing.Color.White;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(269, 28);
            this.TitleBar.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(269, 111);
            this.ControlBox = false;
            this.Controls.Add(this.GotoLink);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.TopMostCheck);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button TimeLabel;
        private MainTitleBar TitleBar;
        private System.Windows.Forms.Button CommitButton;
        private System.Windows.Forms.CheckBox TopMostCheck;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.LinkLabel GotoLink;
    }
}

