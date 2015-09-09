using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace File_Encrypter_Decrypyer
{
    public class RC4EncryptionDecryption
    {
        private static long _keyLength = 255;
        private byte[] _keyArray;
        private string _encryptionKeyAscii = "";
        private string _encryptionKey = "";

        public RC4EncryptionDecryption()
        {
            _keyArray = new Byte[_keyLength];
        }

        public string EncryptionKey
        {
            get
            {
                return (this._encryptionKey);
            }
            set
            {
                if (this._encryptionKey != value)
                {
                    this._encryptionKey = value;

                    long index2 = 0;

                    Encoding ascii = Encoding.ASCII;
                    Encoding unicode = Encoding.Unicode;
                    
                    byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicode.GetBytes(this._encryptionKey));

                    char[] asciiChars = new Char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
                    ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
                    this._encryptionKeyAscii = new String(asciiChars);

                    long KeyLen = _encryptionKey.Length;

                    for (long count = 0; count < _keyLength; count++)
                    {
                        this._keyArray[count] = (byte)count;
                    }

                    for (long count = 0; count < _keyLength; count++)
                    {
                        index2 = (index2 + _keyArray[count] + asciiChars[count % KeyLen]) % _keyLength;
                        byte temp = _keyArray[count];
                        _keyArray[count] = _keyArray[index2];
                        _keyArray[index2] = temp;
                    }
                }
            }
        }

        private string _inClearText = "";

        public string InClearText
        {
            get
            {
                return (this._inClearText);
            }
            set
            {
                if (this._inClearText != value)
                {
                    this._inClearText = value;
                }
            }
        }

        private string _cryptedText = "";

        public string CryptedText
        {
            get
            {
                return (this._cryptedText);
            }
            set
            {
                if (this._cryptedText != value)
                {
                    this._cryptedText = value;
                }
            }
        }

        public Boolean RC4Encryption()
        {
            bool result = true;

            try
            {
                long i = 0;
                long j = 0;

                Encoding enc_default = Encoding.Default;
                byte[] input = enc_default.GetBytes(this._inClearText);

                byte[] output = new byte[input.Length];

                byte[] n_LocBox = new byte[_keyLength];
                this._keyArray.CopyTo(n_LocBox, 0);

                long chipherLen = input.Length + 1;

                // RC4 Algorithm

                for (long offset = 0; offset < input.Length; offset++)
                {
                    i = (i + 1) % _keyLength;
                    j = (j + n_LocBox[i]) % _keyLength;
                    byte temp = n_LocBox[i];
                    n_LocBox[i] = n_LocBox[j];
                    n_LocBox[j] = temp;
                    byte a = input[offset];
                    byte b = n_LocBox[(n_LocBox[i] + n_LocBox[j]) % _keyLength];
                    output[offset] = (byte)((int)a ^ (int)b);
                }

                char[] outarrchar = new char[enc_default.GetCharCount(output, 0, output.Length)];
                enc_default.GetChars(output, 0, output.Length, outarrchar, 0);
                this._cryptedText = new string(outarrchar);
            }
            catch
            {
                result = false;
            }

            return (result);
        }

        public Boolean RC4Decryption()
        {
            bool result = true;

            try
            {
                this._inClearText = this._cryptedText;
                _cryptedText = "";
                if (result = RC4Encryption())
                {
                    _inClearText = _cryptedText;
                }
            }
            catch
            { 
                result = false;
            }

            return result;
        }
    }
}
