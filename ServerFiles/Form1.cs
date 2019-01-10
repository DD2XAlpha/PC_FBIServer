using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ServerFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/k python servefiles.py " + txt3DS_IP.Text + " " + txtFileDirectory.Text + " " + txtHostIP.Text + " " + txtHostPort.Text;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
           
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtFileDirectory.Text = file;
            }
        }

        private void lnkSteveice10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Steveice10/FBI");
        }
    }
}
