using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Preferences : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Preferences()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            TextReader preferences = new StreamReader(@"preferences.txt");
            string p = preferences.ReadLine();
            string[] trimedPreferences = p.Split(',');

            switch (trimedPreferences[0])
            {
                case "EN": rBtnEn.Checked = true; break;
                case "ES": rBtnSP.Checked = true; break;
                case "FR": rBtnFR.Checked = true; break;
                case "IT": rBtnIT.Checked = true; break;
                case "PT": rBtnPT.Checked = true; break;
                case "NE": rBtnNE.Checked = true; break;
                case "DE": rBtnDE.Checked = true; break;
                case "FI": rBtnFI.Checked = true; break;
                case "DK": rBtnDK.Checked = true; break;
                case "AU": rBtnAU.Checked = true; break;
                case "NO": rBtnNO.Checked = true; break;
                case "RU": rBtnRU.Checked = true; break;
                case "SE": rBtnSE.Checked = true; break;
            }
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
            MaterialDialog materialDialog = new MaterialDialog(this, "Ok!", "Saved!");
            DialogResult result = materialDialog.ShowDialog(this);
            Close();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

            materialSkinManager.Theme = materialSwitch1.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
        }
    }
}
