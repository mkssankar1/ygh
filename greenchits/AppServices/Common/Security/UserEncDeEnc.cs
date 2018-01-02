using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Web;

namespace GreenChits.Common.Security
{
    public static class UtilCipher
    {
        private const string InitVector = "Siva$ankar2@@1mk$s";
        private const int Keysize = 256;
        private readonly static string PassPhrase = DateTime.Today.ToShortDateString().ToString();

        public static string Encrypt(string plainText)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(InitVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(PassPhrase, null);
            byte[] keyBytes = password.GetBytes(Keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return HttpUtility.UrlEncode(Convert.ToBase64String(cipherTextBytes));
        }

        public static string Decrypt(string cipherText, bool encode=true)
        {
            cipherText = (encode) ? HttpUtility.UrlDecode(cipherText) : cipherText;
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(InitVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(PassPhrase, null);
            byte[] keyBytes = password.GetBytes(Keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }


    }
}