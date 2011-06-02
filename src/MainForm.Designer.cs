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
            this.TopMostCheck = new System.Windows.Forms.CheckBox();
            this.CommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(150, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(48, 47);
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
            this.ResetButton.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(204, 12);
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
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(132, 47);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "12:34";
            this.TimeLabel.UseVisualStyleBackColor = false;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // TopMostCheck
            // 
            this.TopMostCheck.AccessibleDescription = "test";
            this.TopMostCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.TopMostCheck.BackColor = System.Drawing.Color.Transparent;
            this.TopMostCheck.Checked = true;
            this.TopMostCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopMostCheck.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.TopMostCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TopMostCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostCheck.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TopMostCheck.ForeColor = System.Drawing.Color.White;
            this.TopMostCheck.Location = new System.Drawing.Point(310, 12);
            this.TopMostCheck.Name = "TopMostCheck";
            this.TopMostCheck.Size = new System.Drawing.Size(47, 47);
            this.TopMostCheck.TabIndex = 5;
            this.TopMostCheck.Text = "2";
            this.TopMostCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMostCheck.UseVisualStyleBackColor = false;
            this.TopMostCheck.CheckedChanged += new System.EventHandler(this.TopMostCheck_CheckedChanged);
            // 
            // CommitButton
            // 
            this.CommitButton.BackColor = System.Drawing.Color.Transparent;
            this.CommitButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.CommitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CommitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommitButton.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CommitButton.ForeColor = System.Drawing.Color.White;
            this.CommitButton.Location = new System.Drawing.Point(257, 12);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(47, 47);
            this.CommitButton.TabIndex = 6;
            this.CommitButton.Text = "^";
            this.CommitButton.UseVisualStyleBackColor = false;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(370, 68);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.TopMostCheck);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "github.com/juanplopes/dojotimer";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button TimeLabel;
        private System.Windows.Forms.CheckBox TopMostCheck;
        private System.Windows.Forms.Button CommitButton;
    }
}

