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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "3DS IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cia file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host IP (Your PC IP)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Host port (3DS Port)";
            // 
            // txt3DS_IP
            // 
            this.txt3DS_IP.Location = new System.Drawing.Point(21, 51);
            this.txt3DS_IP.Name = "txt3DS_IP";
            this.txt3DS_IP.Size = new System.Drawing.Size(297, 20);
            this.txt3DS_IP.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(21, 106);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileDirectory
            // 
            this.txtFileDirectory.Enabled = false;
            this.txtFileDirectory.Location = new System.Drawing.Point(102, 109);
            this.txtFileDirectory.Name = "txtFileDirectory";
            this.txtFileDirectory.Size = new System.Drawing.Size(216, 20);
            this.txtFileDirectory.TabIndex = 6;
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(21, 165);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(297, 20);
            this.txtHostIP.TabIndex = 7;
            // 
            // txtHostPort
            // 
            this.txtHostPort.Location = new System.Drawing.Point(21, 223);
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(297, 20);
            this.txtHostPort.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(102, 272);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 51);
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
            this.lnkSteveice10.Location = new System.Drawing.Point(12, 355);
            this.lnkSteveice10.Name = "lnkSteveice10";
            this.lnkSteveice10.Size = new System.Drawing.Size(176, 13);
            this.lnkSteveice10.TabIndex = 10;
            this.lnkSteveice10.TabStop = true;
            this.lnkSteveice10.Text = "FBI and Servefile.py by  Steveice10";
            this.lnkSteveice10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSteveice10_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 377);
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
            this.Name = "Form1";
            this.Text = "Server files";
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
    }
}

