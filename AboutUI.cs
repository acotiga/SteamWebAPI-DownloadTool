using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SteamAPI_MatchDetailDownloader
{
    public partial class AboutUI : Form
    {
        public AboutUI()
        {
            InitializeComponent();
        }

        private void mOKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
