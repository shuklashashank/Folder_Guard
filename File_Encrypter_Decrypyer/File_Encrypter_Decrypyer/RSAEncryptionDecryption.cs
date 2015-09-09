using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace File_Encrypter_Decrypyer
{
    public class RSAEncryptionDecryption
    {
        public static String RSAEncryption(string dataToEncrypt, int keyLength, string key)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(keyLength);
            rsaCryptoServiceProvider.FromXmlString(key);
            int keySize = keyLength / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(dataToEncrypt);
            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);
                Array.Reverse(encryptedBytes);
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }

            return stringBuilder.ToString();
        }

        public static String RSADecryption(string dataToDecrypt, int keyLength, string key)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(keyLength);
            rsaCryptoServiceProvider.FromXmlString(key);
            int base64BlockSize = ((keyLength / 8) % 3 != 0) ? (((keyLength / 8) / 3) * 4) + 4 : ((keyLength / 8) / 3) * 4;
            int iterations = dataToDecrypt.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(dataToDecrypt.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }

        public static String RSAGenerateKey(int keyLength)
        {
            RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider(keyLength);
            string key = "<BitStrength>" + keyLength.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(true);

            return key; // return key in XML Format against specified keyLength
        }
    }
}
