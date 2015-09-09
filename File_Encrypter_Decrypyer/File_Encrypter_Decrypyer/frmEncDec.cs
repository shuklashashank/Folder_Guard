using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace File_Encrypter_Decrypyer
{
    public partial class frmEncDec : Form
    {
        private static int _keyLength = 0;
        private String _key = null;
        private String _cryptedText = "";
        private static Boolean _flag = false;
        private String _randomKey = "";

        private static String APPLICATION_NAME = "Text Encrypter Decrypter";

        public frmEncDec()
        {
            InitializeComponent();
        }
       
        private void frmEncDec_Load(object sender, EventArgs e)
        {
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            
            _flag = true; // by default RC4 encryption is chosen
        }

        public String ReadFullFileData(string fileName)
        {
            TextReader tr = null;
            try
            {
                tr = File.OpenText(fileName);

                if (tr != null)
                    return tr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                tr.Close();
            }

            return null;
        }

        public void OpenFile(String title)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = title;
            fileDialog.Filter = "TEXT Files(*.txt)|*.txt";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
                string dataToEncrypt = ReadFullFileData(fileDialog.FileName);
                rTxtBox.Text = dataToEncrypt;
                chkData.Checked = true;
            }
            else 
            {
                return;
            }
        }

        public void SaveFile(String title)
        {
            TextWriter tw = null;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = title;
                saveFileDialog.Filter = "TEXT Files(*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tw = File.CreateText(saveFileDialog.FileName);
                    tw.WriteLine(rTxtBox.Text);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                tw.Close();
            }
        }

        public static String RandomKeyString() // random key generator
        {
            StringBuilder builder = new StringBuilder();
            Random r = new Random();
            char ch;
            int size = r.Next(10, 20);

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(r.Next(65, 122));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFile("Open A File To Encrypt");
            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
        }

        public void RC4Encryption()
        {
            RC4EncryptionDecryption rc4Enc = new RC4EncryptionDecryption();
            rc4Enc.EncryptionKey = _randomKey;
            lblKey.Text = "RC4 Encryption Key";
            rTxtKey.Text = _randomKey;
            rc4Enc.InClearText = rTxtBox.Text;
            rc4Enc.RC4Encryption();
            this._cryptedText = rc4Enc.CryptedText;
            rTxtBox.Clear();
            rTxtBox.Text = this._cryptedText;
        }

        public void RC4Decryption()
        {
            RC4EncryptionDecryption rc4Enc = new RC4EncryptionDecryption();
            rc4Enc.EncryptionKey = _randomKey;

            lblKey.Text = "RC4 Decryption Key";
            rTxtKey.Text = _randomKey;

            rc4Enc.CryptedText = rTxtBox.Text;
            rc4Enc.RC4Decryption();
            rTxtBox.Clear();
            rTxtBox.Text = rc4Enc.InClearText;
        }

        public void RSAEncryption()
        {
            _keyLength = Convert.ToInt32(numericUpDown.Value.ToString());
            string encryptedString = RSAEncryptionDecryption.RSAEncryption(rTxtBox.Text, _keyLength, _key);
            lblKey.Text = "RSA Encryption Key";
            rTxtKey.Text = _key;
            rTxtBox.Clear();
            rTxtBox.Text = encryptedString;
            chkData.Checked = true;
        }

        public void RSADecryption()
        {
            string decryptedString = RSAEncryptionDecryption.RSADecryption(rTxtBox.Text, _keyLength, _key);
            rTxtBox.Clear();
            rTxtBox.Text = decryptedString;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(rTxtKey.Text))
                {
                    MessageBox.Show("You must generate key first to encrypt or decrypt text.", APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!String.IsNullOrEmpty(rTxtKey.Text))
                {
                    if (rTxtBox.Text != null && !chkData.Checked) // data is from file
                    {
                        if (_flag) // user select RC4 encrytion from Encryption Menu
                        {
                            RC4Encryption();
                        }
                        else // user select RSA encrytion from Encryption Menu
                        {
                            RSAEncryption();
                        }

                        DialogResult result = MessageBox.Show("Want to save encrypted text to file?", APPLICATION_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            // then save the encrypted text to file
                            SaveFile("Save a encrypted text to file");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (chkData.Checked && rTxtBox.Text != null)
                    {
                        // user write direct to rich text box, not open a file from browse button
                        // now first convert text to encrypted text, then prompt user to save that text or not

                        if (_flag)
                        {
                            RC4Encryption();
                        }
                        else
                        {
                            RSAEncryption();
                        }

                        DialogResult result = MessageBox.Show("Want to save encrypted text to file?", APPLICATION_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            // then save the encrypted text to file
                            SaveFile("Save a encrypted text to file");
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (rTxtBox.Text != null && !chkData.Checked)
                {
                    // means data that is to be decrypted is from file, so first open file by clicking button browse

                    OpenFile("Open A Encrypted File To Decrypt");

                    if (_flag)
                    {
                        RC4Decryption();
                    }
                    else
                    {
                        RSADecryption();
                    }

                    DialogResult result = MessageBox.Show("Want to save decrypted text to file?", APPLICATION_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // then save the encrypted text to file
                        SaveFile("Save a decrypted text to file");
                    }
                    else
                    {
                        return;
                    }
                }
                else if (chkData.Checked && rTxtBox.Text != null)
                {
                    // means data that is to be decrypted is written by user directly to rich textbox, 
                    // so simple decrypt it and prompt user for its saving

                    if (_flag)
                    {
                        RC4Decryption();
                    }
                    else
                    {
                        RSADecryption();
                    }

                    DialogResult result = MessageBox.Show("Want to save decrypted text to file?", APPLICATION_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // then save the encrypted text to file
                        SaveFile("Save a decrypted text to file");
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, APPLICATION_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkData_CheckedChanged(object sender, EventArgs e)
        {
            if (chkData.Checked)
            {
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;
            }
            else
            {
                btnEncrypt.Enabled = false;
                btnDecrypt.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rC4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _flag = true;
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _flag = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rTxtBox.Clear();
            rTxtKey.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            if (_flag)
            {
                lblKey.Text = "RC4 Encryption Key";
                _randomKey = RandomKeyString(); // generating random key
                rTxtKey.Text = _randomKey;
            }
            else 
            {
                _key = RSAEncryptionDecryption.RSAGenerateKey(_keyLength);
                string bitStrengthString = _key.Substring(0, _key.IndexOf("</BitStrength>") + 14);
                _key = _key.Replace(bitStrengthString, "");
                lblKey.Text = "RSA Encryption Key";
                rTxtKey.Text = _key;
            }
        }
    }
}