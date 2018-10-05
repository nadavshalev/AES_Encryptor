namespace AES_encryptor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_file = new System.Windows.Forms.Panel();
            this.pnl_folder = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.chEnableAll = new System.Windows.Forms.CheckBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.chAddEnding = new System.Windows.Forms.CheckBox();
            this.chDeleteOrigin = new System.Windows.Forms.CheckBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnding = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnDestFile = new System.Windows.Forms.Button();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.btn2File = new System.Windows.Forms.Button();
            this.btn2Folder = new System.Windows.Forms.Button();
            this.folderBrowserDialog_encFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_file.SuspendLayout();
            this.pnl_folder.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnl_file
            // 
            this.pnl_file.Controls.Add(this.btn2Folder);
            this.pnl_file.Controls.Add(this.lblResult);
            this.pnl_file.Controls.Add(this.label5);
            this.pnl_file.Controls.Add(this.label6);
            this.pnl_file.Controls.Add(this.txtFileName);
            this.pnl_file.Controls.Add(this.txtPassphrase);
            this.pnl_file.Controls.Add(this.chEnableAll);
            this.pnl_file.Controls.Add(this.btnDecrypt);
            this.pnl_file.Controls.Add(this.chAddEnding);
            this.pnl_file.Controls.Add(this.chDeleteOrigin);
            this.pnl_file.Controls.Add(this.btnEncrypt);
            this.pnl_file.Controls.Add(this.label4);
            this.pnl_file.Controls.Add(this.label3);
            this.pnl_file.Controls.Add(this.label2);
            this.pnl_file.Controls.Add(this.label1);
            this.pnl_file.Controls.Add(this.txtEnding);
            this.pnl_file.Controls.Add(this.txtFolder);
            this.pnl_file.Controls.Add(this.btnDestFile);
            this.pnl_file.Controls.Add(this.txtOpenFile);
            this.pnl_file.Controls.Add(this.BtnOpenFile);
            this.pnl_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_file.Location = new System.Drawing.Point(0, 0);
            this.pnl_file.Name = "pnl_file";
            this.pnl_file.Size = new System.Drawing.Size(565, 424);
            this.pnl_file.TabIndex = 0;
            // 
            // pnl_folder
            // 
            this.pnl_folder.Controls.Add(this.btn2File);
            this.pnl_folder.Controls.Add(this.label7);
            this.pnl_folder.Controls.Add(this.txtSelectFolder);
            this.pnl_folder.Controls.Add(this.btnOpenFolder);
            this.pnl_folder.Location = new System.Drawing.Point(0, 0);
            this.pnl_folder.Name = "pnl_folder";
            this.pnl_folder.Size = new System.Drawing.Size(565, 142);
            this.pnl_folder.TabIndex = 41;
            this.pnl_folder.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(234, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Open File:";
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.Location = new System.Drawing.Point(176, 86);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.Size = new System.Drawing.Size(289, 20);
            this.txtSelectFolder.TabIndex = 29;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(94, 86);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 21);
            this.btnOpenFolder.TabIndex = 28;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(16, 389);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 40;
            this.lblResult.Text = "label7";
            this.lblResult.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(9, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Settings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "file name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(392, 41);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(163, 20);
            this.txtFileName.TabIndex = 37;
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(12, 177);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(543, 20);
            this.txtPassphrase.TabIndex = 36;
            this.txtPassphrase.UseSystemPasswordChar = true;
            // 
            // chEnableAll
            // 
            this.chEnableAll.AutoSize = true;
            this.chEnableAll.Location = new System.Drawing.Point(131, 246);
            this.chEnableAll.Name = "chEnableAll";
            this.chEnableAll.Size = new System.Drawing.Size(73, 17);
            this.chEnableAll.TabIndex = 35;
            this.chEnableAll.Text = "Enable All";
            this.chEnableAll.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(292, 306);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(263, 55);
            this.btnDecrypt.TabIndex = 34;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // chAddEnding
            // 
            this.chAddEnding.AutoSize = true;
            this.chAddEnding.Location = new System.Drawing.Point(12, 270);
            this.chAddEnding.Name = "chAddEnding";
            this.chAddEnding.Size = new System.Drawing.Size(81, 17);
            this.chAddEnding.TabIndex = 33;
            this.chAddEnding.Text = "Add Ending";
            this.chAddEnding.UseVisualStyleBackColor = true;
            // 
            // chDeleteOrigin
            // 
            this.chDeleteOrigin.AutoSize = true;
            this.chDeleteOrigin.Location = new System.Drawing.Point(12, 246);
            this.chDeleteOrigin.Name = "chDeleteOrigin";
            this.chDeleteOrigin.Size = new System.Drawing.Size(87, 17);
            this.chDeleteOrigin.TabIndex = 32;
            this.chDeleteOrigin.Text = "Delete Origin";
            this.chDeleteOrigin.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 306);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(261, 55);
            this.btnEncrypt.TabIndex = 31;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Passphrase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "file ending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Destination Folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Open File:";
            // 
            // txtEnding
            // 
            this.txtEnding.Location = new System.Drawing.Point(389, 104);
            this.txtEnding.Name = "txtEnding";
            this.txtEnding.Size = new System.Drawing.Size(166, 20);
            this.txtEnding.TabIndex = 26;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(94, 104);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(289, 20);
            this.txtFolder.TabIndex = 25;
            // 
            // btnDestFile
            // 
            this.btnDestFile.Location = new System.Drawing.Point(12, 104);
            this.btnDestFile.Name = "btnDestFile";
            this.btnDestFile.Size = new System.Drawing.Size(75, 21);
            this.btnDestFile.TabIndex = 24;
            this.btnDestFile.Text = "Folder";
            this.btnDestFile.UseVisualStyleBackColor = true;
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(94, 41);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.ReadOnly = true;
            this.txtOpenFile.Size = new System.Drawing.Size(289, 20);
            this.txtOpenFile.TabIndex = 23;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(12, 41);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(75, 21);
            this.BtnOpenFile.TabIndex = 22;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btn2File
            // 
            this.btn2File.Location = new System.Drawing.Point(469, 0);
            this.btn2File.Name = "btn2File";
            this.btn2File.Size = new System.Drawing.Size(96, 23);
            this.btn2File.TabIndex = 31;
            this.btn2File.Text = "Encrypt File";
            this.btn2File.UseVisualStyleBackColor = true;
            this.btn2File.Click += new System.EventHandler(this.btn2File_Click);
            // 
            // btn2Folder
            // 
            this.btn2Folder.Location = new System.Drawing.Point(469, 0);
            this.btn2Folder.Name = "btn2Folder";
            this.btn2Folder.Size = new System.Drawing.Size(96, 23);
            this.btn2Folder.TabIndex = 41;
            this.btn2Folder.Text = "Encrypt Folder";
            this.btn2Folder.UseVisualStyleBackColor = true;
            this.btn2Folder.Click += new System.EventHandler(this.btn2Folder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 424);
            this.Controls.Add(this.pnl_file);
            this.Controls.Add(this.pnl_folder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_file.ResumeLayout(false);
            this.pnl_file.PerformLayout();
            this.pnl_folder.ResumeLayout(false);
            this.pnl_folder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pnl_file;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.CheckBox chEnableAll;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.CheckBox chAddEnding;
        private System.Windows.Forms.CheckBox chDeleteOrigin;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnding;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnDestFile;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Panel pnl_folder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSelectFolder;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btn2Folder;
        private System.Windows.Forms.Button btn2File;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_encFolder;
    }
}

