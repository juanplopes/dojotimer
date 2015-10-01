namespace DojoTimer
{
    partial class OutputWindow
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
            this.OutputText = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OutputTitleBar = new DojoTimer.FormTitleBar();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputText.BackColor = System.Drawing.Color.Black;
            this.OutputText.Font = new System.Drawing.Font("Courier", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.ForeColor = System.Drawing.Color.White;
            this.OutputText.Location = new System.Drawing.Point(0, 60);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(772, 364);
            this.OutputText.TabIndex = 0;
            this.OutputText.Text = "Running...";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(0, 421);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(772, 45);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close (press ENTER)";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputTitleBar
            // 
            this.OutputTitleBar.BackColor = System.Drawing.Color.White;
            this.OutputTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputTitleBar.ForeColor = System.Drawing.Color.Black;
            this.OutputTitleBar.Location = new System.Drawing.Point(0, 0);
            this.OutputTitleBar.Name = "OutputTitleBar";
            this.OutputTitleBar.Size = new System.Drawing.Size(772, 60);
            this.OutputTitleBar.TabIndex = 10;
            this.OutputTitleBar.TitleDescription = "The result of everything we did here. We want it GREEN!";
            this.OutputTitleBar.TitleIcon = "~";
            this.OutputTitleBar.TitleText = "Running tests...";
            // 
            // OutputWindow
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(772, 466);
            this.Controls.Add(this.OutputTitleBar);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OutputText);
            this.Name = "OutputWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Output";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button CloseButton;
        private FormTitleBar OutputTitleBar;
    }
}
