using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotraser.Isoa.Common.Security
{
    public class CryptographySystem 
    {
        public static string Encrypt(string cipherText)
        {
            return CommonLibrary.Security.CryptographySystem.Encrypt(cipherText, Constants.EncryptionKey, Constants.EncryptionIv);
        }

        public static string Decript(string cipherText)
        {
            return CommonLibrary.Security.CryptographySystem.Decrypt(cipherText, Constants.EncryptionKey, Constants.EncryptionIv);
        }
    }
}
