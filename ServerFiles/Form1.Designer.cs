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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt3DS_IP = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileDirectory = new System.Windows.Forms.TextBox();
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lnkSteveice10 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cBoxRemember = new System.Windows.Forms.CheckBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblTitleID = new System.Windows.Forms.Label();
            this.picBoxGameTDB = new System.Windows.Forms.PictureBox();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.picBox3dsdb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameTDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3dsdb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(370, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "3DS IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cia file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(373, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host IP (Your PC IP)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(370, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Host port (3DS Port)";
            // 
            // txt3DS_IP
            // 
            this.txt3DS_IP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txt3DS_IP.ForeColor = System.Drawing.Color.White;
            this.txt3DS_IP.Location = new System.Drawing.Point(373, 50);
            this.txt3DS_IP.Name = "txt3DS_IP";
            this.txt3DS_IP.Size = new System.Drawing.Size(297, 20);
            this.txt3DS_IP.TabIndex = 4;
            this.txt3DS_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3DS_IP_KeyPress);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelectFile.FlatAppearance.BorderSize = 2;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(373, 105);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileDirectory
            // 
            this.txtFileDirectory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFileDirectory.Enabled = false;
            this.txtFileDirectory.ForeColor = System.Drawing.Color.White;
            this.txtFileDirectory.Location = new System.Drawing.Point(454, 108);
            this.txtFileDirectory.Name = "txtFileDirectory";
            this.txtFileDirectory.Size = new System.Drawing.Size(216, 20);
            this.txtFileDirectory.TabIndex = 6;
            // 
            // txtHostIP
            // 
            this.txtHostIP.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtHostIP.ForeColor = System.Drawing.Color.White;
            this.txtHostIP.Location = new System.Drawing.Point(373, 164);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(297, 20);
            this.txtHostIP.TabIndex = 7;
            this.txtHostIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHostIP_KeyPress);
            // 
            // txtHostPort
            // 
            this.txtHostPort.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtHostPort.ForeColor = System.Drawing.Color.White;
            this.txtHostPort.Location = new System.Drawing.Point(373, 222);
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(297, 20);
            this.txtHostPort.TabIndex = 8;
            this.txtHostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHostPort_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(423, 267);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 51);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lnkSteveice10
            // 
            this.lnkSteveice10.AutoSize = true;
            this.lnkSteveice10.LinkColor = System.Drawing.Color.MediumTurquoise;
            this.lnkSteveice10.Location = new System.Drawing.Point(410, 370);
            this.lnkSteveice10.Name = "lnkSteveice10";
            this.lnkSteveice10.Size = new System.Drawing.Size(176, 13);
            this.lnkSteveice10.TabIndex = 10;
            this.lnkSteveice10.TabStop = true;
            this.lnkSteveice10.Text = "FBI and Servefile.py by  Steveice10";
            this.lnkSteveice10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSteveice10_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(519, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Github";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(592, 370);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(118, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "Version 2.0 R-3 ALPHA";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHelp.FlatAppearance.BorderSize = 2;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(614, 11);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(679, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cBoxRemember
            // 
            this.cBoxRemember.AutoSize = true;
            this.cBoxRemember.ForeColor = System.Drawing.Color.White;
            this.cBoxRemember.Location = new System.Drawing.Point(373, 331);
            this.cBoxRemember.Name = "cBoxRemember";
            this.cBoxRemember.Size = new System.Drawing.Size(117, 17);
            this.cBoxRemember.TabIndex = 15;
            this.cBoxRemember.Text = "Remember my data";
            this.cBoxRemember.UseVisualStyleBackColor = true;
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(674, 324);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.Size = new System.Drawing.Size(15, 10);
            this.dtGrid.TabIndex = 16;
            this.dtGrid.Visible = false;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(54, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(240, 216);
            this.picBox.TabIndex = 17;
            this.picBox.TabStop = false;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(12, 242);
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
            this.lblRegion.Location = new System.Drawing.Point(12, 267);
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
            this.lblTitleID.Location = new System.Drawing.Point(12, 296);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(67, 22);
            this.lblTitleID.TabIndex = 20;
            this.lblTitleID.Text = "Title ID";
            // 
            // picBoxGameTDB
            // 
            this.picBoxGameTDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxGameTDB.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxGameTDB.InitialImage")));
            this.picBoxGameTDB.Location = new System.Drawing.Point(2, 360);
            this.picBoxGameTDB.Name = "picBoxGameTDB";
            this.picBoxGameTDB.Size = new System.Drawing.Size(219, 40);
            this.picBoxGameTDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxGameTDB.TabIndex = 21;
            this.picBoxGameTDB.TabStop = false;
            this.picBoxGameTDB.Click += new System.EventHandler(this.picBoxGameTDB_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPreferences.FlatAppearance.BorderSize = 2;
            this.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferences.ForeColor = System.Drawing.Color.White;
            this.btnPreferences.Location = new System.Drawing.Point(12, 327);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(87, 23);
            this.btnPreferences.TabIndex = 22;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = false;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // picBox3dsdb
            // 
            this.picBox3dsdb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox3dsdb.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox3dsdb.InitialImage")));
            this.picBox3dsdb.Location = new System.Drawing.Point(206, 363);
            this.picBox3dsdb.Name = "picBox3dsdb";
            this.picBox3dsdb.Size = new System.Drawing.Size(202, 30);
            this.picBox3dsdb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox3dsdb.TabIndex = 23;
            this.picBox3dsdb.TabStop = false;
            this.picBox3dsdb.Click += new System.EventHandler(this.picBox3dsdb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(715, 392);
            this.Controls.Add(this.picBox3dsdb);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.picBoxGameTDB);
            this.Controls.Add(this.lblTitleID);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.cBoxRemember);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkSteveice10);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtHostPort);
            this.Controls.Add(this.txtHostIP);
            this.Controls.Add(this.txtFileDirectory);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txt3DS_IP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PC FBI Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameTDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3dsdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3DS_IP;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileDirectory;
        private System.Windows.Forms.TextBox txtHostIP;
        private System.Windows.Forms.TextBox txtHostPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel lnkSteveice10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cBoxRemember;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.PictureBox picBoxGameTDB;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.PictureBox picBox3dsdb;
    }
}

