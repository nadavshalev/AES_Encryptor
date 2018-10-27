using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AES_encryptor
{
    class SecurePassword
    {
        private SecureString password;

        public SecurePassword(string pass)
        {
            password = new SecureString();

            foreach (char c in pass)
            {
                password.AppendChar(c);
            }
        }
        public SecurePassword(SecurePassword other)
        {
            password = other.password.Copy();
        }

        public byte[] getByte()
        {
            byte[] secureStringBytes = null;
            // Convert System.SecureString to Pointer
            IntPtr unmanagedBytes = Marshal.SecureStringToGlobalAllocAnsi(password);
            try
            {
                unsafe
                {
                    byte* byteArray = (byte*)unmanagedBytes.ToPointer();
                    // Find the end of the string
                    byte* pEnd = byteArray;
                    while (*pEnd++ != 0) { }
                    // Length is effectively the difference here (note we're 1 past end) 
                    int length = (int)((pEnd - byteArray) - 1);
                    secureStringBytes = new byte[length];
                    for (int i = 0; i < length; ++i)
                    {
                        // Work with data in byte array as necessary, via pointers, here
                        secureStringBytes[i] = *(byteArray + i);
                    }
                        // Work with data in byte array as necessary, via pointers, here
                }
            }
            finally
            {
                // This will completely remove the data from memory
                Marshal.ZeroFreeGlobalAllocAnsi(unmanagedBytes);
            }
            return secureStringBytes;
        }

        public string getString()
        {
            return Encoding.UTF8.GetString(getByte());
        }
    }
}
