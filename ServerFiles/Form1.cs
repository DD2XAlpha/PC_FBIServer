using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ServerFiles
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (cBoxRemember.Checked)
            {
                string savedInfo = "true," + txt3DS_IP.Text + "," + txtHostIP.Text + "," + txtHostPort.Text;
                File.WriteAllText(@"config.txt", savedInfo);
            }
            string strCmdText;
            strCmdText = "/k python servefiles.py " + txt3DS_IP.Text + " \"" + txtFileDirectory.Text + "\" " + txtHostIP.Text + " " + txtHostPort.Text;
            Process.Start("CMD.exe", strCmdText);

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
            Cover();
        }

        private void lnkSteveice10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Steveice10/FBI");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadXML();
            //REMOVED BECAUSE OF SECURITY

            //string hostName = Dns.GetHostName(); // Retrive the Name of HOST

            //IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            //IPAddress[] addr = hostEntry.AddressList;
            //var ip = addr.Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            //             .FirstOrDefault();
            //txtHostIP.Enabled = false;
            //txtHostIP.Text = ip.ToString(); //Writes the PC IP by itself.

            TextReader config = new StreamReader(@"config.txt");
            string f = config.ReadLine();
            string[] trimedConfiguration = f.Split(',');
            if (trimedConfiguration[0] == "false") //Initial state, if false it doesn't read anything
            {

            }
            else //Otherwise it reads the saved data
            {
                cBoxRemember.Checked = true;
                txt3DS_IP.Text = trimedConfiguration[1];
                txtHostIP.Text = trimedConfiguration[2];
                txtHostPort.Text = trimedConfiguration[3];
            }
            config.Close();
            picBox3dsdb.ImageLocation = "img/3dsdb.png";
            picBoxGameTDB.ImageLocation = "img/GameTDBPower.png";
        }

        //Goes to github repository
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DD2XAlpha/PC_FBIServer");
        }

        //Just Open HELP Window/Form
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        //Not usable, discarded function
        private void button2_Click(object sender, EventArgs e)
        {
            txtHostIP.Enabled = true;
        }

        //Control of 3DS IP textbox, so the user can't type something wrong
        private void txt3DS_IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //Host IP textbox control
        private void txtHostIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //Host Port textbox control
        private void txtHostPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Read XML Database: Provided by 3dsdb.com
        private void ReadXML()
        {
            string myXMLfile = @"xml\3dsreleases.xml";
            try
            {
                //It is saved on the DataSet ds [Global variable]
                ds.ReadXml(myXMLfile);
            }
            catch (Exception ex)
            {
                //In case it didn't read the XML file show error
                MessageBox.Show(ex.ToString());
            }
        }

        //Show cover and info of the CIA, by looking in the XML file by the CIA titleID
        private void Cover()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            //Since the extraction of the titleID is a python Script, it need to be called [Python 3]
            startInfo.Arguments = "/c python titleID.py \"" + txtFileDirectory.Text + "\"";
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            //The CMD window will not appear
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            //Capture the data of the output in the CMD
            string output = process.StandardOutput.ReadToEnd();
            //Since it prints more than just the titleID, it splits the string to get trimed[1] wich is the titleID 
            string[] trimed = output.Split('|');
            process.WaitForExit(1);
            //DataTable creation for the XML file and filtering
            DataTable dt = new DataTable();
            TextReader preferences = new StreamReader(@"preferences.txt");
            string p = preferences.ReadLine();
            string[] trimedPreferences = p.Split(',');
            preferences.Close();
            dt = ds.Tables["release"].Clone();


            //The XML file contains all the titlesID in upper case, so it must be in upper case
            string titleID = "";
            try
            {
                titleID = trimed[1].ToUpper();
            }
            catch (Exception ex)
            {
                goto finish;
            }
            try
            {
                DataRow[] dr;
                //Filtering
                dr = ds.Tables["release"].Select("titleid = '" + titleID + "'");
                int check = 0;
                foreach (DataRow row in dr)
                {
                    string serial = row["serial"].ToString();
                    string[] picSerial = serial.Split('-');
                    string region = row["region"].ToString();
                    try
                    {
                        if (region == "USA")
                            picBox.Load("https://art.gametdb.com/3ds/box/US/" + picSerial[1] + ".png");
                        if (region == "EUR")
                            try
                            {
                                picBox.Load("https://art.gametdb.com/3ds/box/" + trimedPreferences[0] + "/" + picSerial[1] + ".png");
                            }
                            catch(Exception ex)
                            {
                                picBox.Load("https://art.gametdb.com/3ds/box/EN/" + picSerial[1] + ".png");
                            }
                                
                            if (region == "JPN")
                            picBox.Load("https://art.gametdb.com/3ds/box/JA/" + picSerial[1] + ".png");
                        if (region == "KOR")
                            picBox.Load("https://art.gametdb.com/3ds/box/KO/" + picSerial[1] + ".png");
                        if (region == "TWN")
                            picBox.Load("https://art.gametdb.com/3ds/box/ZH/" + picSerial[1] + ".png");
                        if (region == "CHN")
                            picBox.Load("https://art.gametdb.com/3ds/box/ZHCN/" + picSerial[1] + ".png");
                        if (region == "")
                            picBox.ImageLocation = @"cover\error.png";
                    }
                    catch (Exception ex)
                    {
                        picBox.ImageLocation = @"cover\error.png";
                    }
                    lblGameName.Text = row["name"].ToString();
                    lblRegion.Text = "Region: " + row["region"].ToString();
                    lblTitleID.Text = "Title ID: " + row["titleid"].ToString();
                    check = 1;
                    //For some reason sometimes the row returns more than 1 row, to don't cause problems, the Foreach breaks
                    break;
                }
                if (check == 0)
                {
                    picBox.ImageLocation = @"cover\error.png";
                    lblGameName.Text = "???";
                    lblRegion.Text = "???";
                    lblTitleID.Text = "Title ID: " + titleID.ToUpper();
                }
            }
            catch (Exception ex)
            {
                //In case of error show messagebox
                MessageBox.Show(ex.ToString());
            }
        finish:;

        }

        private void picBoxGameTDB_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.gametdb.com/");
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences();
            preferences.Show();
        }

        private void lnk3dsdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://3dsdb.com/");
        }

        private void picBox3dsdb_Click(object sender, EventArgs e)
        {
            Process.Start("http://3dsdb.com/");
        }
    }

}
