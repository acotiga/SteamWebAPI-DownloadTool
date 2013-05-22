namespace SteamAPI_MatchDetailDownloader
{
    partial class DownloaderUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mInputPanel = new System.Windows.Forms.Panel();
            this.mDownloadButton = new System.Windows.Forms.Button();
            this.mOutputBrowseButton = new System.Windows.Forms.Button();
            this.mOutputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.mOutputDirectoryLabel = new System.Windows.Forms.Label();
            this.mBrowseButton = new System.Windows.Forms.Button();
            this.mMatchHistoryFileTextBox = new System.Windows.Forms.TextBox();
            this.mKeyTextBox = new System.Windows.Forms.TextBox();
            this.mMatchHistoryFileLabel = new System.Windows.Forms.Label();
            this.mKeyLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mStatusStripTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.mInputPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mInputPanel
            // 
            this.mInputPanel.Controls.Add(this.mDownloadButton);
            this.mInputPanel.Controls.Add(this.mOutputBrowseButton);
            this.mInputPanel.Controls.Add(this.mOutputDirectoryTextBox);
            this.mInputPanel.Controls.Add(this.mOutputDirectoryLabel);
            this.mInputPanel.Controls.Add(this.mBrowseButton);
            this.mInputPanel.Controls.Add(this.mMatchHistoryFileTextBox);
            this.mInputPanel.Controls.Add(this.mKeyTextBox);
            this.mInputPanel.Controls.Add(this.mMatchHistoryFileLabel);
            this.mInputPanel.Controls.Add(this.mKeyLabel);
            this.mInputPanel.Location = new System.Drawing.Point(0, 27);
            this.mInputPanel.Name = "mInputPanel";
            this.mInputPanel.Size = new System.Drawing.Size(518, 144);
            this.mInputPanel.TabIndex = 1;
            // 
            // mDownloadButton
            // 
            this.mDownloadButton.Location = new System.Drawing.Point(423, 104);
            this.mDownloadButton.Name = "mDownloadButton";
            this.mDownloadButton.Size = new System.Drawing.Size(75, 23);
            this.mDownloadButton.TabIndex = 3;
            this.mDownloadButton.Text = "Download";
            this.mDownloadButton.UseVisualStyleBackColor = true;
            this.mDownloadButton.Click += new System.EventHandler(this.mDownloadButton_Click);
            // 
            // mOutputBrowseButton
            // 
            this.mOutputBrowseButton.Location = new System.Drawing.Point(423, 69);
            this.mOutputBrowseButton.Name = "mOutputBrowseButton";
            this.mOutputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.mOutputBrowseButton.TabIndex = 7;
            this.mOutputBrowseButton.Text = "Browse";
            this.mOutputBrowseButton.UseVisualStyleBackColor = true;
            this.mOutputBrowseButton.Click += new System.EventHandler(this.mOutputBrowseButton_Click);
            // 
            // mOutputDirectoryTextBox
            // 
            this.mOutputDirectoryTextBox.Location = new System.Drawing.Point(111, 71);
            this.mOutputDirectoryTextBox.Name = "mOutputDirectoryTextBox";
            this.mOutputDirectoryTextBox.Size = new System.Drawing.Size(306, 20);
            this.mOutputDirectoryTextBox.TabIndex = 6;
            // 
            // mOutputDirectoryLabel
            // 
            this.mOutputDirectoryLabel.AutoSize = true;
            this.mOutputDirectoryLabel.Location = new System.Drawing.Point(14, 74);
            this.mOutputDirectoryLabel.Name = "mOutputDirectoryLabel";
            this.mOutputDirectoryLabel.Size = new System.Drawing.Size(84, 13);
            this.mOutputDirectoryLabel.TabIndex = 5;
            this.mOutputDirectoryLabel.Text = "Output Directory";
            // 
            // mBrowseButton
            // 
            this.mBrowseButton.Location = new System.Drawing.Point(423, 42);
            this.mBrowseButton.Name = "mBrowseButton";
            this.mBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.mBrowseButton.TabIndex = 4;
            this.mBrowseButton.Text = "Browse";
            this.mBrowseButton.UseVisualStyleBackColor = true;
            this.mBrowseButton.Click += new System.EventHandler(this.mBrowseButton_Click);
            // 
            // mMatchHistoryFileTextBox
            // 
            this.mMatchHistoryFileTextBox.Location = new System.Drawing.Point(111, 44);
            this.mMatchHistoryFileTextBox.Name = "mMatchHistoryFileTextBox";
            this.mMatchHistoryFileTextBox.Size = new System.Drawing.Size(306, 20);
            this.mMatchHistoryFileTextBox.TabIndex = 3;
            // 
            // mKeyTextBox
            // 
            this.mKeyTextBox.Location = new System.Drawing.Point(111, 18);
            this.mKeyTextBox.Name = "mKeyTextBox";
            this.mKeyTextBox.Size = new System.Drawing.Size(306, 20);
            this.mKeyTextBox.TabIndex = 2;
            // 
            // mMatchHistoryFileLabel
            // 
            this.mMatchHistoryFileLabel.AutoSize = true;
            this.mMatchHistoryFileLabel.Location = new System.Drawing.Point(14, 47);
            this.mMatchHistoryFileLabel.Name = "mMatchHistoryFileLabel";
            this.mMatchHistoryFileLabel.Size = new System.Drawing.Size(91, 13);
            this.mMatchHistoryFileLabel.TabIndex = 1;
            this.mMatchHistoryFileLabel.Text = "Match History File";
            // 
            // mKeyLabel
            // 
            this.mKeyLabel.AutoSize = true;
            this.mKeyLabel.Location = new System.Drawing.Point(14, 21);
            this.mKeyLabel.Name = "mKeyLabel";
            this.mKeyLabel.Size = new System.Drawing.Size(71, 13);
            this.mKeyLabel.TabIndex = 0;
            this.mKeyLabel.Text = "Web API Key";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStatusStripTextLabel,
            this.mStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 174);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mStatusStripTextLabel
            // 
            this.mStatusStripTextLabel.Name = "mStatusStripTextLabel";
            this.mStatusStripTextLabel.Size = new System.Drawing.Size(39, 17);
            this.mStatusStripTextLabel.Text = "Status";
            // 
            // mStatus
            // 
            this.mStatus.Name = "mStatus";
            this.mStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // DownloaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 196);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mInputPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DownloaderUI";
            this.Text = "Match Detail Downloader Utility";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mInputPanel.ResumeLayout(false);
            this.mInputPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel mInputPanel;
        private System.Windows.Forms.Button mBrowseButton;
        private System.Windows.Forms.TextBox mMatchHistoryFileTextBox;
        private System.Windows.Forms.TextBox mKeyTextBox;
        private System.Windows.Forms.Label mMatchHistoryFileLabel;
        private System.Windows.Forms.Label mKeyLabel;
        private System.Windows.Forms.TextBox mOutputDirectoryTextBox;
        private System.Windows.Forms.Label mOutputDirectoryLabel;
        private System.Windows.Forms.Button mOutputBrowseButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mStatusStripTextLabel;
        private System.Windows.Forms.ToolStripStatusLabel mStatus;
        private System.Windows.Forms.Button mDownloadButton;
    }
}

