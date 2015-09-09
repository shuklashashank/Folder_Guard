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
using formAnimation;
using System.Diagnostics;

namespace File_Encrypter_Decrypyer
{
    public partial class Form1 : Form
    {
        private int flags;
        object data = new object();
        string uname, upass;
        FileStream outs;
        StreamReader sr;
        StreamWriter sw;
        int panelwidthsize = 1;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop,true);
            foreach (string file in files)
                MessageBox.Show(file);
                
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelwidthsize == 516)
            {
                timer1.Enabled = false;
                menuStrip1.BringToFront();


            }
            panel_main.Size = new Size(panelwidthsize, 354);
            panelwidthsize += 5;
        }

        private void encripToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEncDec fr = new frmEncDec();
            fr.ShowDialog();
        }

        private void stagnographToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stagnograph sg = new stagnograph();
            sg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            outs = new FileStream("d:/ss.txt", FileMode.OpenOrCreate);
            sr = new StreamReader(outs);
            uname = sr.ReadLine();
            upass = sr.ReadLine();
            if (uname == null | upass == null)
            {
                panel_auth.Visible = true;
            }
            else
            {
                pan_after_auth.Visible = true;

            }
        }
      
        private void but_authentic_Click_1(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim() != "" & textBox2.Text.Trim() != "")
            {
                sw = new StreamWriter(outs);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.Close();
                MessageBox.Show("Restart The Application");
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter Correct Value To Be Saved");
                textBox2.Text = "";
                textBox1.Text = "";
            }
            pan_after_auth.Visible = true;
            panel_auth.Visible = false;
        }

        private void but_after_auth_Click(object sender, EventArgs e)
        {
           
            if (textBox3.Text == upass)
            {
                MessageBox.Show("Done");
                panel_auth.Visible = false;
                pan_after_auth.Visible = false;
                panel_main.Visible = true;
                timer1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Invalid Password");
                textBox3.Text = "";
            }

        }

       


        private void lockFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderLock fl = new FolderLock();
            fl.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            flags = WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND;

            FolderLock a = new FolderLock(1000, flags);
            //FolderLock fl = new FolderLock();
            a.ShowDialog();
           
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmEncDec fr = new frmEncDec();
            fr.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            stagnograph sg = new stagnograph();
            sg.ShowDialog();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(Application.StartupPath + "\\Legal notices.pdf");
        }



        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\File Rakshak Overview.pdf");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\How File Rakshak works.pdf");
        }

        private void understangingFileRakshakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Understanding file rakshak.pdf");
        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            cloudLabel1.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            cloudLabel2.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            cloudLabel3.Visible = true;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            cloudLabel1.Visible = false;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            cloudLabel2.Visible = false;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            cloudLabel3.Visible = false;
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\Understanding file rakshak.pdf");
        }
       
    }
}
