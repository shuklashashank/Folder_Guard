using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace File_Encrypter_Decrypyer
{
    public partial class FolderLock : Form
    {
        private int p;
        private int flags;

        public FolderLock()
        {
            InitializeComponent();
        }

        //public FolderLock(int p, int flags)
        //{
        //    // TODO: Complete member initialization
        //    this.p = p;
        //    this.flags = flags;
        //}
        public FolderLock(int AnimationTime,int Flags)
		{
//			animationTime = AnimationTime;
			flags = Flags;
			InitializeComponent();
		}
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void cloudButton2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\s.png");
                string folderPath = textBox1.Text;
                string adminUserName = Environment.UserName;// getting your adminUserName
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);

                ds.AddAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
                MessageBox.Show("Locked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cloudButton3_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\s1.png");
                string folderPath = textBox1.Text;
                string adminUserName = Environment.UserName;
                // getting your adminUserName
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);

                ds.RemoveAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
                MessageBox.Show("UnLocked");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FolderLock_Load(object sender, EventArgs e)
        {
           
			formAnimation.WinAPI.AnimateWindow(this.Handle,1800,flags);
		}
        

    }
}
