using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerFiles
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            TextReader preferences = new StreamReader(@"preferences.txt");
            string p = preferences.ReadLine();
            string[] trimedPreferences = p.Split(',');

            if (trimedPreferences[0] == "EN")
                rBtnEn.Checked = true;
            if (trimedPreferences[0] == "ES")
                rBtnSP.Checked = true;
            if (trimedPreferences[0] == "FR")
                rBtnFR.Checked = true;
            if (trimedPreferences[0] == "IT")
                rBtnIT.Checked = true;
            if (trimedPreferences[0] == "PT")
                rBtnEn.Checked = true;
            if (trimedPreferences[0] == "NE")
                rBtnNE.Checked = true;
            if (trimedPreferences[0] == "DE")
                rBtnDE.Checked = true;
            if (trimedPreferences[0] == "FI")
                rBtnFI.Checked = true;
            if (trimedPreferences[0] == "DK")
                rBtnEn.Checked = true;
            if (trimedPreferences[0] == "AU")
                rBtnAU.Checked = true;
            if (trimedPreferences[0] == "NO")
                rBtnEn.Checked = true;
            if (trimedPreferences[0] == "RU")
                rBtnRU.Checked = true;
            if (trimedPreferences[0] == "SE")
                rBtnSE.Checked = true;
            preferences.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            string lang = "";
           
            if (rBtnEn.Checked)
                lang = "EN";
            if (rBtnSP.Checked)
                lang = "ES";
            if (rBtnFR.Checked)
                lang = "FR";
            if (rBtnIT.Checked)
                lang = "IT";
            if (rBtnPT.Checked)
                lang = "PT";
            if (rBtnNE.Checked)
                lang = "NE";
            if (rBtnDE.Checked)
                lang = "DE";
            if (rBtnFI.Checked)
                lang = "FI";
            if (rBtnDK.Checked)
                lang = "DK";
            if (rBtnAU.Checked)
                lang = "AU";
            if (rBtnNO.Checked)
                lang = "NO";
            if (rBtnRU.Checked)
                lang = "RU";
            if (rBtnSE.Checked)
                lang = "SE";
            string savedInfo = lang + "," + "BOX";
            File.WriteAllText(@"preferences.txt", savedInfo);
            MessageBox.Show("Saved!");
            Close();
        }
    }
}
