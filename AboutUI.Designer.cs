namespace SteamAPI_MatchDetailDownloader
{
    partial class AboutUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mOKButton = new System.Windows.Forms.Button();
            this.mDetailsTextBox = new System.Windows.Forms.RichTextBox();
            this.mAboutLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mOKButton);
            this.panel1.Controls.Add(this.mDetailsTextBox);
            this.panel1.Controls.Add(this.mAboutLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 125);
            this.panel1.TabIndex = 0;
            // 
            // mOKButton
            // 
            this.mOKButton.Location = new System.Drawing.Point(188, 101);
            this.mOKButton.Name = "mOKButton";
            this.mOKButton.Size = new System.Drawing.Size(75, 23);
            this.mOKButton.TabIndex = 2;
            this.mOKButton.Text = "OK";
            this.mOKButton.UseVisualStyleBackColor = true;
            this.mOKButton.Click += new System.EventHandler(this.mOKButton_Click);
            // 
            // mDetailsTextBox
            // 
            this.mDetailsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mDetailsTextBox.Location = new System.Drawing.Point(3, 16);
            this.mDetailsTextBox.Name = "mDetailsTextBox";
            this.mDetailsTextBox.ReadOnly = true;
            this.mDetailsTextBox.Size = new System.Drawing.Size(260, 79);
            this.mDetailsTextBox.TabIndex = 1;
            this.mDetailsTextBox.Text = resources.GetString("mDetailsTextBox.Text");
            // 
            // mAboutLabel
            // 
            this.mAboutLabel.AutoSize = true;
            this.mAboutLabel.Location = new System.Drawing.Point(0, 0);
            this.mAboutLabel.Name = "mAboutLabel";
            this.mAboutLabel.Size = new System.Drawing.Size(99, 13);
            this.mAboutLabel.TabIndex = 0;
            this.mAboutLabel.Text = "© 2013 Alex Cotiga";
            // 
            // AboutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 149);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutUI";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox mDetailsTextBox;
        private System.Windows.Forms.Label mAboutLabel;
        private System.Windows.Forms.Button mOKButton;
    }
}