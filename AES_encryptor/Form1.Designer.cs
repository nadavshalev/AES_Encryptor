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
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.chEnableAll = new System.Windows.Forms.CheckBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_folder = new System.Windows.Forms.Panel();
            this.btn2File = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog_encFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_file = new System.Windows.Forms.Panel();
            this.btn2Folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.pnl_buttons.SuspendLayout();
            this.pnl_folder.SuspendLayout();
            this.pnl_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.lblResult);
            this.pnl_buttons.Controls.Add(this.label5);
            this.pnl_buttons.Controls.Add(this.txtPassphrase);
            this.pnl_buttons.Controls.Add(this.chEnableAll);
            this.pnl_buttons.Controls.Add(this.btnDecrypt);
            this.pnl_buttons.Controls.Add(this.btnEncrypt);
            this.pnl_buttons.Controls.Add(this.label4);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 148);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(565, 276);
            this.pnl_buttons.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(16, 254);
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
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Settings:";
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(12, 42);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(543, 20);
            this.txtPassphrase.TabIndex = 36;
            this.txtPassphrase.UseSystemPasswordChar = true;
            this.txtPassphrase.TextChanged += new System.EventHandler(this.txtPassphrase_TextChanged);
            // 
            // chEnableAll
            // 
            this.chEnableAll.AutoSize = true;
            this.chEnableAll.Location = new System.Drawing.Point(12, 111);
            this.chEnableAll.Name = "chEnableAll";
            this.chEnableAll.Size = new System.Drawing.Size(73, 17);
            this.chEnableAll.TabIndex = 35;
            this.chEnableAll.Text = "Enable All";
            this.chEnableAll.UseVisualStyleBackColor = true;
            this.chEnableAll.CheckedChanged += new System.EventHandler(this.chEnableAll_CheckedChanged);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(292, 171);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(263, 55);
            this.btnDecrypt.TabIndex = 34;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 171);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(261, 55);
            this.btnEncrypt.TabIndex = 31;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Passphrase:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(226, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Open Folder:";
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.Location = new System.Drawing.Point(176, 86);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.ReadOnly = true;
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
            // pnl_file
            // 
            this.pnl_file.Controls.Add(this.btn2Folder);
            this.pnl_file.Controls.Add(this.label1);
            this.pnl_file.Controls.Add(this.txtOpenFile);
            this.pnl_file.Controls.Add(this.BtnOpenFile);
            this.pnl_file.Location = new System.Drawing.Point(0, 0);
            this.pnl_file.Name = "pnl_file";
            this.pnl_file.Size = new System.Drawing.Size(565, 142);
            this.pnl_file.TabIndex = 42;
            // 
            // btn2Folder
            // 
            this.btn2Folder.Location = new System.Drawing.Point(469, 0);
            this.btn2Folder.Name = "btn2Folder";
            this.btn2Folder.Size = new System.Drawing.Size(96, 23);
            this.btn2Folder.TabIndex = 52;
            this.btn2Folder.Text = "Encrypt Folder";
            this.btn2Folder.UseVisualStyleBackColor = true;
            this.btn2Folder.Click += new System.EventHandler(this.btn2Folder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(224, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Open File:";
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(177, 86);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.ReadOnly = true;
            this.txtOpenFile.Size = new System.Drawing.Size(289, 20);
            this.txtOpenFile.TabIndex = 43;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(94, 86);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(76, 21);
            this.BtnOpenFile.TabIndex = 42;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 424);
            this.Controls.Add(this.pnl_file);
            this.Controls.Add(this.pnl_folder);
            this.Controls.Add(this.pnl_buttons);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.pnl_folder.ResumeLayout(false);
            this.pnl_folder.PerformLayout();
            this.pnl_file.ResumeLayout(false);
            this.pnl_file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.CheckBox chEnableAll;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_folder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSelectFolder;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btn2File;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_encFolder;
        private System.Windows.Forms.Panel pnl_file;
        private System.Windows.Forms.Button btn2Folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.Button BtnOpenFile;
    }
}

