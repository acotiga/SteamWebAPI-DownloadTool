using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

///
/// Author:     Alex Cotiga
/// Date:       May 20th, 2013
/// Filename:   DownloaderUI.cs
///

namespace SteamAPI_MatchDetailDownloader
{
    public partial class DownloaderUI : Form
    {
        MatchDetailDownloader mdd;

        public DownloaderUI()
        {
            InitializeComponent();
            mdd = new MatchDetailDownloader();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUI aUI = new AboutUI();
            aUI.ShowDialog(this.Owner);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            mMatchHistoryFileTextBox.Text = ofd.FileName;
        }

        private void mOutputBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            mOutputDirectoryTextBox.Text = fbd.SelectedPath;
        }

        private void mDownloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                mStatus.Text = "Downloading...";
                mdd.Download(mKeyTextBox.Text, mMatchHistoryFileTextBox.Text, mOutputDirectoryTextBox.Text);
                mStatus.Text = "Complete";
            }
            catch (ArgumentException)
            {
                //This particular error is thrown from the XML Document Load function when the URL/URI is invalid.
                mStatus.Text = "Match History file was not found / could not be loaded. Check your input.";
            }
            catch (Exception ee)
            {
                //The rest of the errors that can occur have reasonable messages that describe the problem.
                //(401)Unauthorized --> Invalid Key 
                //(404)Not Found --> Invalid Match ID in Match History File or (possibly removed from Valve's database?)
                //(500)Internal Server Error --> Problem on Valve's end (try again or later).
                //Access to the path denied --> Invalid output directory (you do not have write priviledges there).
                mStatus.Text = ee.Message;
            }
        }
    }
}
