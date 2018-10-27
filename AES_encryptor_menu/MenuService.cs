using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SharpShell.SharpContextMenu;
using System.IO;
using System.Runtime.InteropServices;
using SharpShell.Attributes;

namespace AES_encryptor_menu
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class MenuService : SharpContextMenu
    {
        public const string ENCRYPTED_FILE_EXTANTION = "enc";
        public const int MIN_PASSWORD_LENGTH = 6;

        protected override bool CanShowMenu()
        {
            //  We will always show the menu.
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            //  Create the menu strip.
            var menu = new ContextMenuStrip();

            //  Create a 'count lines' item.
            var itemCountLines = new ToolStripMenuItem
            {
                Text = "Lock/Unlock"
            };

            //  When we click, we'll call the 'CountLines' function.
            itemCountLines.Click += (sender, args) => ShowGUI();

            //  Add the item to the context menu.
            menu.Items.Add(itemCountLines);

            //  Return the menu.
            return menu;
        }

        private void ShowGUI()
        {
            bool toEnc = false;
            bool toDec = false;
            //  Go through each file.
            foreach (var filePath in SelectedItemPaths)
            {
                if (Path.GetExtension(filePath) == "." + ENCRYPTED_FILE_EXTANTION)
                    toDec = true;
                else
                    toEnc = true;
            }

            if (toDec && toEnc)
                MessageBox.Show("Chose Encrypted files or Decrypted files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(toEnc)
                {
                    EncryptBox enBox = new EncryptBox();
                    enBox.Pathes = SelectedItemPaths;
                    enBox.Show();
                }
                else
                {
                    DecryptBox dcBox = new DecryptBox();
                    dcBox.Pathes = SelectedItemPaths;
                    dcBox.Show();
                }
            }
        }
    }
}
