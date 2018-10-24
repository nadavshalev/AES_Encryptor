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

namespace AES_encryptor
{
    public partial class Form1 : Form
    {
        private const int MIN_PASS_SIZE = 5;
        private const string ENCRYPTED_FILE_EXTANTION = "enc";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /********************* FILE ENCRYPTION  *********************/
        #region FILE ENCRYPTION
        
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string fullPath = openFileDialog1.FileName;
                
                //set folder box
                txtOpenFile.Text = fullPath;
                setOptionsFile();
            }
        }

        /// <summary>
        /// Enables the encryption button only if the file is encrypted. 
        /// Enables the decryption button only if the file is decrypted.
        /// also check that all the requaired fuilds are full.
        /// </summary>
        private void setOptionsFile()
        {
            if (chEnableAll.Checked)
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
                txtOpenFile.ReadOnly = false;
                txtOpenFile.BackColor = System.Drawing.SystemColors.Menu;
            }
            else
            {
                //set defult params
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
                txtOpenFile.ReadOnly = true;
                txtOpenFile.BackColor = System.Drawing.Color.LightGray;

                if (txtPassphrase.Text.Length >= MIN_PASS_SIZE)
                {
                    
                    if (File.Exists(txtOpenFile.Text))
                    {
                        txtOpenFile.ReadOnly = true;
                        if (Path.GetExtension(txtOpenFile.Text) != "." + ENCRYPTED_FILE_EXTANTION)
                        {
                            btnEncrypt.Enabled = true;
                            btnDecrypt.Enabled = false;
                        }
                        else
                        {
                            btnDecrypt.Enabled = true;
                            btnEncrypt.Enabled = false;
                        }
                    }
                    else
                    {
                        btnDecrypt.Enabled = false;
                        btnEncrypt.Enabled = false;
                    }
                }
                else
                {
                    btnDecrypt.Enabled = false;
                    btnEncrypt.Enabled = false;
                }
            }
            lblResult.Visible = false;
        }
         
        #endregion

        /********************* FOLDER ENCRYPTION  *********************/
        #region FOLDER ENCRYPTION

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog_encFolder.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtSelectFolder.Text = folderBrowserDialog_encFolder.SelectedPath;
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;
            }
            setOptionsFolder();
        }

        /// <summary>
        /// Enables the encryption button only if there are files which are encrypted. 
        /// Enables the decryption button only if are files which are not decrypted.
        /// also check that all the requaired fuilds are full.
        /// </summary>
        private void setOptionsFolder()
        {
            if (chEnableAll.Checked)
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
                txtSelectFolder.ReadOnly = false;
                txtSelectFolder.BackColor = System.Drawing.SystemColors.Menu;
            }
            else
            {
                //set defult params
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
                txtSelectFolder.ReadOnly = true;
                txtSelectFolder.BackColor = System.Drawing.Color.LightGray;

                if (txtPassphrase.Text.Length >= MIN_PASS_SIZE)
                {
                    txtSelectFolder.ReadOnly = true;
                    btnDecrypt.Enabled = false;
                    btnEncrypt.Enabled = false;
                    if (checkEncritedfoder(txtSelectFolder.Text, false))
                    {
                        btnEncrypt.Enabled = true;
                    }
                    if (checkEncritedfoder(txtSelectFolder.Text, true))
                    {
                        btnDecrypt.Enabled = true;
                    }
                }
                else
                {
                    btnDecrypt.Enabled = false;
                    btnEncrypt.Enabled = false;
                }
            }
            lblResult.Visible = false;
        }

        /// <summary>
        /// search files in subfoldes
        /// </summary>
        /// <param name="sDir">root folder path</param>
        /// <param name="isEncrypted">true = seach *.enc or else</param>
        /// <returns>file names list</returns>
        private List<String> DirSearch(string sDir, bool isEncrypted)
        {
            List<String> files = new List<String>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    if ((isEncrypted && Path.GetExtension(f) == "." + ENCRYPTED_FILE_EXTANTION) ||
                            (!isEncrypted && Path.GetExtension(f) != "." + ENCRYPTED_FILE_EXTANTION))
                        files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d, isEncrypted));
                }
            }
            catch (System.Exception excpt)
            {
                //MessageBox.Show(excpt.Message);
            }

            return files;
        }

        /// <summary>
        /// check wether encrypted/ unencypted files exists in folder
        /// </summary>
        /// <param name="sDir">root folder path</param>
        /// <param name="isEncrypted">true = seach for encrypeted</param>
        /// <returns>true if found any</returns>
        private bool checkEncritedfoder(string sDir, bool isEncrypted)
        {
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    if ((isEncrypted && Path.GetExtension(f) == "." + ENCRYPTED_FILE_EXTANTION) ||
                            (!isEncrypted && Path.GetExtension(f) != "." + ENCRYPTED_FILE_EXTANTION))
                        return true;
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    return checkEncritedfoder(d, isEncrypted);
                }
            }
            catch (System.Exception excpt)
            {
                //MessageBox.Show(excpt.Message);
            }
            return false;
        }

        #endregion

        /*********************  GENERAL  *********************/
        #region GENERAL

        /// <summary>
        /// clear the form for next use
        /// </summary>
        private void clearForm()
        {
            txtOpenFile.Text = "";
            txtPassphrase.Text = "";
            chEnableAll.Checked = false;
            btnDecrypt.Enabled = false;
            btnEncrypt.Enabled = false;
            txtSelectFolder.Text = "";
        }

        /// <summary>
        /// set the status labe to 'Success' or 'Fail' and change the color
        /// </summary>
        /// <param name="res">true for Success, false for Fail</param>
        /// <param name="text">error text if exists</param>
        private void setResultLabel(bool res, string text = "")
        {
            if (res)
            {
                lblResult.Visible = true;
                lblResult.ForeColor = System.Drawing.Color.Green;
                lblResult.Text = "Success!";
            }
            else
            {
                lblResult.Visible = true;
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = "Fail! - " + text;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AES256 aes = new AES256(txtPassphrase.Text);
                if(pnl_folder.Visible)
                {
                    List<string> pathes = DirSearch(txtSelectFolder.Text, false);
                    foreach(string path in pathes)
                    {
                        aes.EncryptFile(path, path + "." + ENCRYPTED_FILE_EXTANTION);
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                }
                else
                {
                    string path = txtOpenFile.Text;
                    aes.EncryptFile(path, path + "." + ENCRYPTED_FILE_EXTANTION);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
                
                clearForm();
                setResultLabel(true);
            }
            catch(Exception exp)
            {
                setResultLabel(false, exp.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AES256 aes = new AES256(txtPassphrase.Text);
                if (pnl_folder.Visible)
                {
                    List<string> pathes = DirSearch(txtSelectFolder.Text, true);
                    foreach (string path in pathes)
                    {
                        string newPath = path.Substring(0, path.Length - ENCRYPTED_FILE_EXTANTION.Length - 1);
                        aes.DecryptFile(path, newPath);
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                }
                else
                {
                    string path = txtOpenFile.Text;
                    string newPath = path.Substring(0, path.Length - ENCRYPTED_FILE_EXTANTION.Length - 1);
                    aes.DecryptFile(txtOpenFile.Text, newPath);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
                clearForm();
                setResultLabel(true);
            }
            catch (Exception exp)
            {
                if (exp.Message == "Padding is invalid and cannot be removed.")
                    setResultLabel(false, "Wrong Password");
                else if(exp.Message == "Length of the data to decrypt is invalid.")
                    setResultLabel(false, "File is not encrypted");
                else
                    setResultLabel(false, exp.Message);
            }
        }

        private void txtPassphrase_TextChanged(object sender, EventArgs e)
        {
            if(pnl_folder.Visible)
            {
                setOptionsFolder();
            }
            else
            {
                setOptionsFile();
            }
        }

        private void chEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl_folder.Visible)
            {
                setOptionsFolder();
            }
            else
            {
                setOptionsFile();
            }
        }

        private void txtEnding_TextChanged(object sender, EventArgs e)
        {
            setOptionsFile();
        }

        private void btn2Folder_Click(object sender, EventArgs e)
        {
            pnl_folder.Visible = true;
            pnl_file.Visible = false;
            clearForm();
        }

        private void btn2File_Click(object sender, EventArgs e)
        {
            pnl_folder.Visible = false;
            pnl_file.Visible = true;
            clearForm();
        }

        private void btnEncrypt_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEncrypt.Enabled)
            {
                btnEncrypt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                this.btnEncrypt.BackColor = System.Drawing.Color.Maroon;
            }
            else
            {
                btnEncrypt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void btnDecrypt_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDecrypt.Enabled)
            {
                btnDecrypt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                btnDecrypt.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                btnDecrypt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            }
        }

        #endregion


    }
}
