using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_encryptor_menu
{
    public partial class EncryptBox : Form
    {
        public IEnumerable<string> Pathes { get; set; }

        public EncryptBox()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            AES_encryptor.AES256 aes = new AES_encryptor.AES256(txtPass.Text);

            new Thread(() =>
            {
                try
                {
                    foreach (var path in Pathes)
                    {
                    
                            aes.EncryptFile(path, path + "." + MenuService.ENCRYPTED_FILE_EXTANTION);
                            if (File.Exists(path))
                            {
                                File.Delete(path);
                            }
                    
                    }

                    this.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length >= MenuService.MIN_PASSWORD_LENGTH)
            {
                btnEncrypt.Enabled = true;
            }
            else
            {
                btnEncrypt.Enabled = false;
            }
        }

        private void btnEncrypt_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEncrypt.Enabled)
            {
                btnEncrypt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                this.btnEncrypt.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                btnEncrypt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                btnEncrypt.BackColor = System.Drawing.Color.Maroon;
            }
        }
    }
}
