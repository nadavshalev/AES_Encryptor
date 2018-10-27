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

namespace AES_encryptor_menu
{
    public partial class DecryptBox : Form
    {
        public IEnumerable<string> Pathes { get; set; }

        public DecryptBox()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            AES_encryptor.AES256 aes = new AES_encryptor.AES256(txtPass.Text);

            try
            {
                foreach (var path in Pathes)
                {
                    string newPath = path.Substring(0, path.Length - MenuService.ENCRYPTED_FILE_EXTANTION.Length - 1);
                    aes.DecryptFile(path, newPath);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
                this.Close();
            }
            catch (Exception exp)
            {
                string msg;
                if (exp.Message == "Padding is invalid and cannot be removed.")
                    msg = "Wrong Password";
                else if (exp.Message == "Length of the data to decrypt is invalid.")
                    msg = "File is not encrypted";
                else
                    msg = exp.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(txtPass.Text.Length >= MenuService.MIN_PASSWORD_LENGTH)
            {
                btnDecrypt.Enabled = true;
            }
            else
            {
                btnDecrypt.Enabled = false;
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
    }
}
