namespace ServerFiles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtFileDirectory = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lnkSteveice10 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStartM = new MaterialSkin.Controls.MaterialButton();
            this.txt3DS_IP = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mCard = new MaterialSkin.Controls.MaterialCard();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtHostPort = new MaterialSkin.Controls.MaterialTextBox();
            this.txtHostIP = new MaterialSkin.Controls.MaterialTextBox();
            this.cRememberMyData = new MaterialSkin.Controls.MaterialSwitch();
            this.btnFolder = new MaterialSkin.Controls.MaterialButton();
            this.btnSelectFile = new MaterialSkin.Controls.MaterialButton();
            this.picBox3dsdb = new System.Windows.Forms.PictureBox();
            this.picBoxGameTDB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.mCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3dsdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameTDB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileDirectory
            // 
            this.txtFileDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFileDirectory.Enabled = false;
            this.txtFileDirectory.ForeColor = System.Drawing.Color.White;
            this.txtFileDirectory.Location = new System.Drawing.Point(1070, 566);
            this.txtFileDirectory.Name = "txtFileDirectory";
            this.txtFileDirectory.Size = new System.Drawing.Size(294, 20);
            this.txtFileDirectory.TabIndex = 6;
            this.txtFileDirectory.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lnkSteveice10
            // 
            this.lnkSteveice10.AutoSize = true;
            this.lnkSteveice10.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.lnkSteveice10.Location = new System.Drawing.Point(10, 625);
            this.lnkSteveice10.Name = "lnkSteveice10";
            this.lnkSteveice10.Size = new System.Drawing.Size(176, 13);
            this.lnkSteveice10.TabIndex = 10;
            this.lnkSteveice10.TabStop = true;
            this.lnkSteveice10.Text = "FBI and Servefile.py by  Steveice10";
            this.lnkSteveice10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSteveice10_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1115, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Github";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(10, 647);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "Version 3.0";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(1196, 78);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 30);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(677, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(-3, 672);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.Size = new System.Drawing.Size(15, 10);
            this.dtGrid.TabIndex = 16;
            this.dtGrid.Visible = false;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(17, 316);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(107, 22);
            this.lblGameName.TabIndex = 18;
            this.lblGameName.Text = "Game name";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblRegion.ForeColor = System.Drawing.Color.White;
            this.lblRegion.Location = new System.Drawing.Point(17, 341);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(67, 22);
            this.lblRegion.TabIndex = 19;
            this.lblRegion.Text = "Region";
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTitleID.ForeColor = System.Drawing.Color.White;
            this.lblTitleID.Location = new System.Drawing.Point(17, 370);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(67, 22);
            this.lblTitleID.TabIndex = 20;
            this.lblTitleID.Text = "Title ID";
            // 
            // btnPreferences
            // 
            this.btnPreferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreferences.FlatAppearance.BorderSize = 2;
            this.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferences.ForeColor = System.Drawing.Color.White;
            this.btnPreferences.Location = new System.Drawing.Point(1277, 78);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(87, 30);
            this.btnPreferences.TabIndex = 22;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = false;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 593);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btnStartM
            // 
            this.btnStartM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartM.Depth = 0;
            this.btnStartM.HighEmphasis = true;
            this.btnStartM.Icon = null;
            this.btnStartM.Location = new System.Drawing.Point(1297, 635);
            this.btnStartM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartM.Name = "btnStartM";
            this.btnStartM.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartM.Size = new System.Drawing.Size(67, 36);
            this.btnStartM.TabIndex = 26;
            this.btnStartM.Text = "Start";
            this.btnStartM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartM.UseAccentColor = false;
            this.btnStartM.UseVisualStyleBackColor = true;
            this.btnStartM.Click += new System.EventHandler(this.btnStartM_Click_1);
            // 
            // txt3DS_IP
            // 
            this.txt3DS_IP.AllowPromptAsInput = true;
            this.txt3DS_IP.AnimateReadOnly = false;
            this.txt3DS_IP.AsciiOnly = false;
            this.txt3DS_IP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt3DS_IP.BeepOnError = false;
            this.txt3DS_IP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt3DS_IP.Depth = 0;
            this.txt3DS_IP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt3DS_IP.HidePromptOnLeave = false;
            this.txt3DS_IP.HideSelection = true;
            this.txt3DS_IP.Hint = "3DS IP Port";
            this.txt3DS_IP.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt3DS_IP.LeadingIcon = null;
            this.txt3DS_IP.Location = new System.Drawing.Point(1008, 139);
            this.txt3DS_IP.Mask = "";
            this.txt3DS_IP.MaxLength = 32767;
            this.txt3DS_IP.MouseState = MaterialSkin.MouseState.OUT;
            this.txt3DS_IP.Name = "txt3DS_IP";
            this.txt3DS_IP.PasswordChar = '\0';
            this.txt3DS_IP.PrefixSuffixText = null;
            this.txt3DS_IP.PromptChar = '_';
            this.txt3DS_IP.ReadOnly = false;
            this.txt3DS_IP.RejectInputOnFirstFailure = false;
            this.txt3DS_IP.ResetOnPrompt = true;
            this.txt3DS_IP.ResetOnSpace = true;
            this.txt3DS_IP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt3DS_IP.SelectedText = "";
            this.txt3DS_IP.SelectionLength = 0;
            this.txt3DS_IP.SelectionStart = 0;
            this.txt3DS_IP.ShortcutsEnabled = true;
            this.txt3DS_IP.Size = new System.Drawing.Size(356, 48);
            this.txt3DS_IP.SkipLiterals = true;
            this.txt3DS_IP.TabIndex = 27;
            this.txt3DS_IP.TabStop = false;
            this.txt3DS_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt3DS_IP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt3DS_IP.TrailingIcon = null;
            this.txt3DS_IP.UseSystemPasswordChar = false;
            this.txt3DS_IP.ValidatingType = null;
            this.txt3DS_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3DS_IP_KeyPress);
            // 
            // mCard
            // 
            this.mCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCard.Controls.Add(this.picBox);
            this.mCard.Controls.Add(this.lblGameName);
            this.mCard.Controls.Add(this.lblRegion);
            this.mCard.Controls.Add(this.lblTitleID);
            this.mCard.Depth = 0;
            this.mCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCard.Location = new System.Drawing.Point(13, 78);
            this.mCard.Margin = new System.Windows.Forms.Padding(14);
            this.mCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCard.Name = "mCard";
            this.mCard.Padding = new System.Windows.Forms.Padding(14);
            this.mCard.Size = new System.Drawing.Size(341, 438);
            this.mCard.TabIndex = 28;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(-1, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(342, 293);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 17;
            this.picBox.TabStop = false;
            // 
            // txtHostPort
            // 
            this.txtHostPort.AnimateReadOnly = false;
            this.txtHostPort.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHostPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHostPort.Depth = 0;
            this.txtHostPort.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHostPort.ForeColor = System.Drawing.Color.White;
            this.txtHostPort.Hint = "3DS Port";
            this.txtHostPort.LeadingIcon = null;
            this.txtHostPort.Location = new System.Drawing.Point(1008, 205);
            this.txtHostPort.MaxLength = 50;
            this.txtHostPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHostPort.Multiline = false;
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(356, 50);
            this.txtHostPort.TabIndex = 29;
            this.txtHostPort.Text = "";
            this.txtHostPort.TrailingIcon = null;
            this.txtHostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3DS_IP_KeyPress);
            // 
            // txtHostIP
            // 
            this.txtHostIP.AnimateReadOnly = false;
            this.txtHostIP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtHostIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHostIP.Depth = 0;
            this.txtHostIP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHostIP.ForeColor = System.Drawing.Color.White;
            this.txtHostIP.Hint = "PC IP";
            this.txtHostIP.LeadingIcon = null;
            this.txtHostIP.Location = new System.Drawing.Point(1008, 276);
            this.txtHostIP.MaxLength = 50;
            this.txtHostIP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHostIP.Multiline = false;
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(356, 50);
            this.txtHostIP.TabIndex = 33;
            this.txtHostIP.Text = "";
            this.txtHostIP.TrailingIcon = null;
            this.txtHostIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3DS_IP_KeyPress);
            // 
            // cRememberMyData
            // 
            this.cRememberMyData.AutoSize = true;
            this.cRememberMyData.Depth = 0;
            this.cRememberMyData.Location = new System.Drawing.Point(1008, 379);
            this.cRememberMyData.Margin = new System.Windows.Forms.Padding(0);
            this.cRememberMyData.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cRememberMyData.MouseState = MaterialSkin.MouseState.HOVER;
            this.cRememberMyData.Name = "cRememberMyData";
            this.cRememberMyData.Ripple = true;
            this.cRememberMyData.Size = new System.Drawing.Size(196, 37);
            this.cRememberMyData.TabIndex = 36;
            this.cRememberMyData.Text = "Remember my data";
            this.cRememberMyData.UseVisualStyleBackColor = true;
            this.cRememberMyData.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFolder.Depth = 0;
            this.btnFolder.HighEmphasis = true;
            this.btnFolder.Icon = ((System.Drawing.Image)(resources.GetObject("btnFolder.Icon")));
            this.btnFolder.Location = new System.Drawing.Point(1201, 335);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFolder.Size = new System.Drawing.Size(163, 36);
            this.btnFolder.TabIndex = 35;
            this.btnFolder.Text = " Select folder";
            this.btnFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFolder.UseAccentColor = false;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelectFile.Depth = 0;
            this.btnSelectFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectFile.HighEmphasis = true;
            this.btnSelectFile.Icon = global::ServerFiles.Properties.Resources.file_white;
            this.btnSelectFile.Location = new System.Drawing.Point(1008, 335);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelectFile.Size = new System.Drawing.Size(186, 36);
            this.btnSelectFile.TabIndex = 34;
            this.btnSelectFile.Text = " Select single CIA";
            this.btnSelectFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelectFile.UseAccentColor = false;
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click_1);
            // 
            // picBox3dsdb
            // 
            this.picBox3dsdb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox3dsdb.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox3dsdb.InitialImage")));
            this.picBox3dsdb.Location = new System.Drawing.Point(13, 582);
            this.picBox3dsdb.Name = "picBox3dsdb";
            this.picBox3dsdb.Size = new System.Drawing.Size(202, 30);
            this.picBox3dsdb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox3dsdb.TabIndex = 23;
            this.picBox3dsdb.TabStop = false;
            this.picBox3dsdb.Click += new System.EventHandler(this.picBox3dsdb_Click);
            // 
            // picBoxGameTDB
            // 
            this.picBoxGameTDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxGameTDB.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxGameTDB.InitialImage")));
            this.picBoxGameTDB.Location = new System.Drawing.Point(13, 536);
            this.picBoxGameTDB.Name = "picBoxGameTDB";
            this.picBoxGameTDB.Size = new System.Drawing.Size(219, 40);
            this.picBoxGameTDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxGameTDB.TabIndex = 21;
            this.picBoxGameTDB.TabStop = false;
            this.picBoxGameTDB.Click += new System.EventHandler(this.picBoxGameTDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1371, 688);
            this.Controls.Add(this.cRememberMyData);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtHostIP);
            this.Controls.Add(this.txtHostPort);
            this.Controls.Add(this.mCard);
            this.Controls.Add(this.txt3DS_IP);
            this.Controls.Add(this.btnStartM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picBox3dsdb);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.picBoxGameTDB);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkSteveice10);
            this.Controls.Add(this.txtFileDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PC FBI Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.mCard.ResumeLayout(false);
            this.mCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3dsdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameTDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFileDirectory;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel lnkSteveice10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.PictureBox picBoxGameTDB;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.PictureBox picBox3dsdb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnStartM;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt3DS_IP;
        private MaterialSkin.Controls.MaterialCard mCard;
        private MaterialSkin.Controls.MaterialTextBox txtHostPort;
        private MaterialSkin.Controls.MaterialTextBox txtHostIP;
        private MaterialSkin.Controls.MaterialButton btnSelectFile;
        private MaterialSkin.Controls.MaterialButton btnFolder;
        private MaterialSkin.Controls.MaterialSwitch cRememberMyData;
    }
}

