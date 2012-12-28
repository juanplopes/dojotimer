namespace DojoTimer
{
    partial class WhoWasHereForm
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
            this.Person1Input = new System.Windows.Forms.TextBox();
            this.Person2Input = new System.Windows.Forms.TextBox();
            this.SaveCommitButton = new System.Windows.Forms.Button();
            this.OnlySaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClickHereLabel = new System.Windows.Forms.Label();
            this.formTitleBar1 = new DojoTimer.FormTitleBar();
            this.SuspendLayout();
            // 
            // Person1Input
            // 
            this.Person1Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Person1Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Person1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person1Input.Location = new System.Drawing.Point(17, 75);
            this.Person1Input.Name = "Person1Input";
            this.Person1Input.Size = new System.Drawing.Size(448, 31);
            this.Person1Input.TabIndex = 1;
            // 
            // Person2Input
            // 
            this.Person2Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Person2Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Person2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person2Input.Location = new System.Drawing.Point(17, 112);
            this.Person2Input.Name = "Person2Input";
            this.Person2Input.Size = new System.Drawing.Size(448, 31);
            this.Person2Input.TabIndex = 3;
            // 
            // SaveCommitButton
            // 
            this.SaveCommitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveCommitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.SaveCommitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveCommitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCommitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCommitButton.Location = new System.Drawing.Point(17, 159);
            this.SaveCommitButton.Name = "SaveCommitButton";
            this.SaveCommitButton.Size = new System.Drawing.Size(113, 51);
            this.SaveCommitButton.TabIndex = 4;
            this.SaveCommitButton.Text = "Save and commit.";
            this.SaveCommitButton.UseVisualStyleBackColor = true;
            this.SaveCommitButton.Click += new System.EventHandler(this.SaveCommitButton_Click);
            // 
            // OnlySaveButton
            // 
            this.OnlySaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OnlySaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.OnlySaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OnlySaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnlySaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlySaveButton.Location = new System.Drawing.Point(136, 159);
            this.OnlySaveButton.Name = "OnlySaveButton";
            this.OnlySaveButton.Size = new System.Drawing.Size(113, 51);
            this.OnlySaveButton.TabIndex = 5;
            this.OnlySaveButton.Text = "Save, but don\'t commit.";
            this.OnlySaveButton.UseVisualStyleBackColor = true;
            this.OnlySaveButton.Click += new System.EventHandler(this.OnlySaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(352, 159);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(113, 51);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Leave me alone!";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClickHereLabel
            // 
            this.ClickHereLabel.AutoSize = true;
            this.ClickHereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickHereLabel.Location = new System.Drawing.Point(102, 95);
            this.ClickHereLabel.Name = "ClickHereLabel";
            this.ClickHereLabel.Size = new System.Drawing.Size(279, 33);
            this.ClickHereLabel.TabIndex = 8;
            this.ClickHereLabel.Text = "Hey, you, click here!";
            // 
            // formTitleBar1
            // 
            this.formTitleBar1.BackColor = System.Drawing.Color.Green;
            this.formTitleBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.formTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTitleBar1.ForeColor = System.Drawing.Color.White;
            this.formTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.formTitleBar1.Name = "formTitleBar1";
            this.formTitleBar1.Size = new System.Drawing.Size(482, 60);
            this.formTitleBar1.TabIndex = 7;
            this.formTitleBar1.TitleDescription = "The one will stay should come first.";
            this.formTitleBar1.TitleIcon = "^";
            this.formTitleBar1.TitleText = "Who was here?";
            // 
            // WhoWasHereForm
            // 
            this.AcceptButton = this.SaveCommitButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 222);
            this.ControlBox = false;
            this.Controls.Add(this.ClickHereLabel);
            this.Controls.Add(this.formTitleBar1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OnlySaveButton);
            this.Controls.Add(this.SaveCommitButton);
            this.Controls.Add(this.Person2Input);
            this.Controls.Add(this.Person1Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WhoWasHereForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.WhoWasHereForm_Activated);
            this.Deactivate += new System.EventHandler(this.WhoWasHereForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Person1Input;
        private System.Windows.Forms.TextBox Person2Input;
        private System.Windows.Forms.Button SaveCommitButton;
        private System.Windows.Forms.Button OnlySaveButton;
        private System.Windows.Forms.Button CloseButton;
        private FormTitleBar formTitleBar1;
        private System.Windows.Forms.Label ClickHereLabel;
    }
}