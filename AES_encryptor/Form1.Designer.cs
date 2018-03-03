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
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnDestFile = new System.Windows.Forms.Button();
            this.txtEnding = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.chDeleteOrigin = new System.Windows.Forms.CheckBox();
            this.chAddEnding = new System.Windows.Forms.CheckBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.chEnableAll = new System.Windows.Forms.CheckBox();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(12, 35);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(75, 21);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(94, 35);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.ReadOnly = true;
            this.txtOpenFile.Size = new System.Drawing.Size(289, 20);
            this.txtOpenFile.TabIndex = 1;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(94, 98);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(289, 20);
            this.txtFolder.TabIndex = 3;
            // 
            // btnDestFile
            // 
            this.btnDestFile.Location = new System.Drawing.Point(12, 98);
            this.btnDestFile.Name = "btnDestFile";
            this.btnDestFile.Size = new System.Drawing.Size(75, 21);
            this.btnDestFile.TabIndex = 2;
            this.btnDestFile.Text = "Folder";
            this.btnDestFile.UseVisualStyleBackColor = true;
            this.btnDestFile.Click += new System.EventHandler(this.btnDestFile_Click);
            // 
            // txtEnding
            // 
            this.txtEnding.Location = new System.Drawing.Point(389, 98);
            this.txtEnding.Name = "txtEnding";
            this.txtEnding.Size = new System.Drawing.Size(166, 20);
            this.txtEnding.TabIndex = 4;
            this.txtEnding.TextChanged += new System.EventHandler(this.txtEnding_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Open File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "file ending";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Passphrase:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 300);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(261, 55);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // chDeleteOrigin
            // 
            this.chDeleteOrigin.AutoSize = true;
            this.chDeleteOrigin.Location = new System.Drawing.Point(12, 240);
            this.chDeleteOrigin.Name = "chDeleteOrigin";
            this.chDeleteOrigin.Size = new System.Drawing.Size(87, 17);
            this.chDeleteOrigin.TabIndex = 13;
            this.chDeleteOrigin.Text = "Delete Origin";
            this.chDeleteOrigin.UseVisualStyleBackColor = true;
            // 
            // chAddEnding
            // 
            this.chAddEnding.AutoSize = true;
            this.chAddEnding.Location = new System.Drawing.Point(12, 264);
            this.chAddEnding.Name = "chAddEnding";
            this.chAddEnding.Size = new System.Drawing.Size(81, 17);
            this.chAddEnding.TabIndex = 14;
            this.chAddEnding.Text = "Add Ending";
            this.chAddEnding.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(292, 300);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(263, 55);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // chEnableAll
            // 
            this.chEnableAll.AutoSize = true;
            this.chEnableAll.Location = new System.Drawing.Point(131, 240);
            this.chEnableAll.Name = "chEnableAll";
            this.chEnableAll.Size = new System.Drawing.Size(73, 17);
            this.chEnableAll.TabIndex = 16;
            this.chEnableAll.Text = "Enable All";
            this.chEnableAll.UseVisualStyleBackColor = true;
            this.chEnableAll.CheckedChanged += new System.EventHandler(this.chEnableAll_CheckedChanged);
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(12, 171);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(543, 20);
            this.txtPassphrase.TabIndex = 17;
            this.txtPassphrase.UseSystemPasswordChar = true;
            this.txtPassphrase.TextChanged += new System.EventHandler(this.txtPassphrase_TextChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(392, 35);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(163, 20);
            this.txtFileName.TabIndex = 18;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "file name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(9, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Settings:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(16, 383);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "label7";
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 424);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtPassphrase);
            this.Controls.Add(this.chEnableAll);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.chAddEnding);
            this.Controls.Add(this.chDeleteOrigin);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnding);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnDestFile);
            this.Controls.Add(this.txtOpenFile);
            this.Controls.Add(this.BtnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnDestFile;
        private System.Windows.Forms.TextBox txtEnding;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.CheckBox chDeleteOrigin;
        private System.Windows.Forms.CheckBox chAddEnding;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.CheckBox chEnableAll;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
    }
}

