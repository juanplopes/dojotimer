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
            this.label1 = new System.Windows.Forms.Label();
            this.Person1Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Person2Input = new System.Windows.Forms.TextBox();
            this.SaveCommitButton = new System.Windows.Forms.Button();
            this.OnlySaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who was here?";
            // 
            // Person1Input
            // 
            this.Person1Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Person1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person1Input.Location = new System.Drawing.Point(17, 59);
            this.Person1Input.Name = "Person1Input";
            this.Person1Input.Size = new System.Drawing.Size(448, 31);
            this.Person1Input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "The one will stay should come first.";
            // 
            // Person2Input
            // 
            this.Person2Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Person2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Person2Input.Location = new System.Drawing.Point(17, 96);
            this.Person2Input.Name = "Person2Input";
            this.Person2Input.Size = new System.Drawing.Size(448, 31);
            this.Person2Input.TabIndex = 3;
            // 
            // SaveCommitButton
            // 
            this.SaveCommitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveCommitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCommitButton.Location = new System.Drawing.Point(17, 138);
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
            this.OnlySaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlySaveButton.Location = new System.Drawing.Point(136, 138);
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
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(352, 138);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(113, 51);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Please, leave me alone!";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WhoWasHereForm
            // 
            this.AcceptButton = this.SaveCommitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 195);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OnlySaveButton);
            this.Controls.Add(this.SaveCommitButton);
            this.Controls.Add(this.Person2Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Person1Input);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WhoWasHereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Person1Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Person2Input;
        private System.Windows.Forms.Button SaveCommitButton;
        private System.Windows.Forms.Button OnlySaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}