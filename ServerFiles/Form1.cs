using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ServerFiles
{
    public partial class Form1 : MaterialForm
    {
        DataSet ds = new DataSet();
        List<Queueing> queued = new List<Queueing>();
        private readonly MaterialSkinManager materialSkinManager;
        int actualOption = -1;
        string directory;
        string path;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);

        }

        private void lnkSteveice10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Steveice10/FBI");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            txtHostPort.Text = "5000";

            ReadXML();


            string hostName = Dns.GetHostName(); // Retrive the Name of HOST

            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            IPAddress[] addr = hostEntry.AddressList;
            var ip = addr.Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                         .FirstOrDefault();

            txtHostIP.Text = ip.ToString(); //Writes the PC IP by itself.

            TextReader config = new StreamReader(@"config.txt");
            string f = config.ReadLine();
            string[] trimedConfiguration = f.Split(',');
            if (trimedConfiguration[0] == "false") //Initial state, if false it doesn't read anything
            {

            }
            else //Otherwise it reads the saved data
            {
                cRememberMyData.Checked = true;
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
        private void Cover(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = "CMD.exe",
                Arguments = "/c python titleID.py \"" + path + "\"",   //Since the extraction of the titleID is a python Script, it need to be called [Python 3]
                CreateNoWindow = true
            };

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd(); //Capture the data of the output in the CMD
            string[] trimed = output.Split('|'); //Since it prints more than just the titleID, it splits the string to get trimed[1] wich is the titleID 

            process.WaitForExit(1);

            TextReader preferences = new StreamReader(@"preferences.txt");
            string p = preferences.ReadLine();
            string[] trimedPreferences = p.Split(',');
            preferences.Close();
            //The XML file contains all the titlesID in upper case, so it must be in upper case
            string titleID = "";
            try
            {
                titleID = trimed[1].ToUpper();
            }
            catch (Exception)
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

                        switch (region)
                        {
                            case "USA":
                                picBox.LoadAsync("https://art.gametdb.com/3ds/box/US/" + picSerial[1] + ".png");
                                break;
                            case "EUR":
                                try
                                {
                                    picBox.LoadAsync("https://art.gametdb.com/3ds/box/" + trimedPreferences[0] + "/" + picSerial[1] + ".png");
                                }
                                catch (Exception)
                                {
                                    picBox.LoadAsync("https://art.gametdb.com/3ds/box/EN/" + picSerial[1] + ".png");
                                }
                                break;
                            case "JPN":
                                picBox.LoadAsync("https://art.gametdb.com/3ds/box/JA/" + picSerial[1] + ".png");
                                break;
                            case "KOR":
                                picBox.LoadAsync("https://art.gametdb.com/3ds/box/KO/" + picSerial[1] + ".png");
                                break;
                            case "CHN":
                            case "TWN":
                                picBox.LoadAsync("https://art.gametdb.com/3ds/box/ZH/" + picSerial[1] + ".png");
                                break;
                            default: picBox.ImageLocation = @"cover\error.png"; break;

                        }
                    }
                    catch (Exception)
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

        private void picBox3dsdb_Click(object sender, EventArgs e)
        {
            Process.Start("http://3dsdb.com/");
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    Cover(path + "\\" + dataGridView1.CurrentCell.Value.ToString());
        }
      
        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            openFileDialog1.Filter = "cia File|*.cia|All|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtFileDirectory.Text = file;
            }
            Cover(txtFileDirectory.Text);
            actualOption = 1; //Set for knowing that the user selected only on Cia
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            var openFolder = new CommonOpenFileDialog();
            openFolder.AllowNonFileSystemItems = true;
            openFolder.Multiselect = true;
            openFolder.IsFolderPicker = true;
            openFolder.Title = "Select folders with cia files";

            if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            // get all the directories in selected dirctory
            var dirs = openFolder.FileNames.ToArray();
            foreach (var u in dirs)
            {
                //MessageBox.Show(u);
                txtFileDirectory.Text = u;
                directory = u;
            }
            string[] files = Directory.GetFiles(directory);
            string[] wantedExtensions = { ".cia", ".CIA" }; // you can extend it  

            List<Queueing> qList = new List<Queueing>();

            foreach (string item in files)
            {
                string ext = Path.GetExtension(item);
                if (wantedExtensions.Contains<string>(ext))
                {
                    string fullPath = item;
                    int indx = fullPath.LastIndexOf('\\');
                    path = fullPath.Substring(0, indx);
                    string game = fullPath.Substring(indx + 1);

                    FileInfo fi = new FileInfo(fullPath);

                    qList.Add(new Queueing()
                    {
                        Game = game,
                        Size = (fi.Length / 1048576) + " MB",
                        State = false
                    }); 
                }

            }
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.DataSource = qList;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 50, 50, 50);
            actualOption = 2;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.FromArgb(1, 50, 50, 50);
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStartM_Click_1(object sender, EventArgs e)
        {
            if (actualOption == -1) 
            { 
                MaterialDialog materialDialog = new MaterialDialog(this, "One problem", "You haven't selected any CIA file!");
                DialogResult result = materialDialog.ShowDialog(this);
                return; 
            }

            if (cRememberMyData.Checked)
            {
                string savedInfo = "true," + txt3DS_IP.Text + "," + txtHostIP.Text + "," + txtHostPort.Text;
                File.WriteAllText(@"config.txt", savedInfo);
            }

            string old = txtFileDirectory.Text;

            if (actualOption == 2)
            {
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (row.Cells[2].Value.ToString() != "False")
                        txtFileDirectory.Text += path + "\\" + row.Cells[0].Value.ToString() + "|";
                txtFileDirectory.Text = txtFileDirectory.Text + directory;
            }

            string strCmdText = "/k python servefiles.py " + txt3DS_IP.Text + " \"" + txtFileDirectory.Text + "\" " + txtHostIP.Text + " " + txtHostPort.Text;
            Process.Start("CMD.exe", strCmdText);
            txtFileDirectory.Text = old;
        }
    }
}
