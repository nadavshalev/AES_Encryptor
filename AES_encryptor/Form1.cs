﻿using System;
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

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string fullPath = openFileDialog1.FileName;

                //set the extension box
                string[] eps = fullPath.Split('.');
                string ending = eps[eps.Length - 1];
                if (ending == ENCRYPTED_FILE_EXTANTION)
                {
                    if (eps.Length > 2)
                        txtEnding.Text = eps[eps.Length - 2];
                    else
                        txtEnding.Text = "";
                    chAddEnding.Checked = false;
                }
                else
                {
                    txtEnding.Text = ENCRYPTED_FILE_EXTANTION;
                    chAddEnding.Checked = true;
                }

                //set folder box
                int sleshid = fullPath.LastIndexOf('\\');
                txtFolder.Text = fullPath.Substring(0, sleshid);
                txtOpenFile.Text = txtFolder.Text;
                txtFileName.Text = fullPath.Substring(sleshid + 1);
                setOptions();
                chDeleteOrigin.Checked = true;
            }
        }

        private void btnDestFile_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
            }
            setOptions();
            chDeleteOrigin.Checked = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AES256 aes = new AES256(txtPassphrase.Text);
                aes.EncryptFile(txtOpenFile.Text + "\\" + txtFileName.Text, setFileName());
                if (chDeleteOrigin.Checked)
                {
                    string path = txtOpenFile.Text + "\\" + txtFileName.Text;
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
                aes.DecryptFile(txtOpenFile.Text + "\\" + txtFileName.Text, setFileName());
                if (chDeleteOrigin.Checked)
                {
                    string path = txtOpenFile.Text + "\\" + txtFileName.Text;
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

        /// <summary>
        /// Enables the encryption button only if the file is encrypted. 
        /// Enables the decryption button only if the file is decrypted.
        /// also check that all the requaired fuilds are full.
        /// </summary>
        private void setOptions()
        {
            if (txtPassphrase.Text.Length >= MIN_PASS_SIZE)
            {
                if (txtEnding.Text != "" && txtOpenFile.Text != "" && txtFolder.Text != "" && txtFileName.Text != "")
                {
                    if(chEnableAll.Checked)
                    {
                        btnDecrypt.Enabled = true;
                        btnEncrypt.Enabled = true;
                    }
                    else
                    {
                        if (txtEnding.Text == ENCRYPTED_FILE_EXTANTION)
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
            lblResult.Visible = false;
        }

        /// <summary>
        /// set the return file name acording to the extension type and settings
        /// </summary>
        /// <returns>full path of the file</returns>
        private string setFileName()
        {
            if(chAddEnding.Checked)
            {
                return txtFolder.Text + "\\" + txtFileName.Text + "." + txtEnding.Text;
            }
            else
            {
                //get type
                int ind = txtFileName.Text.LastIndexOf('.');
                string text = txtFileName.Text.Substring(0, ind);
                //check older type and add only if not the same
                ind = text.LastIndexOf('.');
                string finalName = txtFolder.Text + "\\" + text;
                if (text.Substring(ind+1) != txtEnding.Text)
                    finalName += "." + txtEnding.Text;
                return finalName;
            }
        }

        /// <summary>
        /// clear the form for next use
        /// </summary>
        private void clearForm()
        {
            txtOpenFile.Text = "";
            txtFileName.Text = "";
            txtFolder.Text = "";
            txtEnding.Text = "";
            txtPassphrase.Text = "";
            chDeleteOrigin.Checked = false;
            chAddEnding.Checked = false;
            chEnableAll.Checked = false;
            btnDecrypt.Enabled = false;
            btnEncrypt.Enabled = false;
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

        private void txtPassphrase_TextChanged(object sender, EventArgs e)
        {
            setOptions();
        }
        private void chEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            setOptions();
        }
        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            setOptions();
        }
        private void txtEnding_TextChanged(object sender, EventArgs e)
        {
            setOptions();
        }
    }
}
