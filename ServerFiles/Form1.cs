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
using System.Net;
using System.Net.Sockets;

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
            openFileDialog1.Filter = "cia File|*.cia|All|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtFileDirectory.Text = file;
            }
            char[] str = txtFileDirectory.Text.Trim().ToArray();
            foreach (char c in str)
            {
                if (char.IsSymbol(c))
                {
                    MessageBox.Show("Special simbol found! (" + c.ToString() + "). The transfer may fail, is highly " +
                        "recommended that you don't put white spaces or any special symbol in the cia name," +
                        " if so, change the name of the cia", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (char.IsWhiteSpace(c))
                {
                    MessageBox.Show("There is a white space!, the operation will fail, please change the name of the cia with out white spaces!", "Warning!",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
        }

        private void lnkSteveice10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Steveice10/FBI");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addr = hostEntry.AddressList;
            var ip = addr.Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                         .FirstOrDefault();
            txtHostIP.Enabled = false;
            txtHostIP.Text = ip.ToString(); //Writes the PC IP by itself.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DD2XAlpha/PC_FBIServer");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHostIP.Enabled = true;
        }
    }
}
