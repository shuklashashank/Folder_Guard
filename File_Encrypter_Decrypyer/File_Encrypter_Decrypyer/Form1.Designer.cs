namespace File_Encrypter_Decrypyer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.Panel();
            this.cloudLabel3 = new CloudToolkitN6.CloudLabel();
            this.cloudLabel2 = new CloudToolkitN6.CloudLabel();
            this.cloudLabel1 = new CloudToolkitN6.CloudLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lockFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stagnographToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.understangingFileRakshakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.w7Button1 = new CloudToolkitN6.W7Button();
            this.pan_after_auth = new System.Windows.Forms.Panel();
            this.but_after_auth = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_auth = new System.Windows.Forms.Panel();
            this.but_authentic = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pan_after_auth.SuspendLayout();
            this.panel_auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_main.Controls.Add(this.cloudLabel3);
            this.panel_main.Controls.Add(this.cloudLabel2);
            this.panel_main.Controls.Add(this.cloudLabel1);
            this.panel_main.Controls.Add(this.pictureBox3);
            this.panel_main.Controls.Add(this.pictureBox2);
            this.panel_main.Controls.Add(this.menuStrip1);
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.w7Button1);
            this.panel_main.Location = new System.Drawing.Point(0, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(521, 360);
            this.panel_main.TabIndex = 1;
            this.panel_main.Visible = false;
            this.panel_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // cloudLabel3
            // 
            this.cloudLabel3.AutoSize = true;
            this.cloudLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cloudLabel3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.cloudLabel3.ForeColor = System.Drawing.Color.Blue;
            this.cloudLabel3.Location = new System.Drawing.Point(316, 226);
            this.cloudLabel3.Name = "cloudLabel3";
            this.cloudLabel3.Size = new System.Drawing.Size(132, 26);
            this.cloudLabel3.TabIndex = 9;
            this.cloudLabel3.Text = "Steganograph";
            this.cloudLabel3.Visible = false;
            // 
            // cloudLabel2
            // 
            this.cloudLabel2.AutoSize = true;
            this.cloudLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cloudLabel2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudLabel2.ForeColor = System.Drawing.Color.Blue;
            this.cloudLabel2.Location = new System.Drawing.Point(199, 226);
            this.cloudLabel2.Name = "cloudLabel2";
            this.cloudLabel2.Size = new System.Drawing.Size(81, 26);
            this.cloudLabel2.TabIndex = 8;
            this.cloudLabel2.Text = "Encrypt";
            this.cloudLabel2.Visible = false;
            // 
            // cloudLabel1
            // 
            this.cloudLabel1.AutoSize = true;
            this.cloudLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cloudLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudLabel1.ForeColor = System.Drawing.Color.Blue;
            this.cloudLabel1.Location = new System.Drawing.Point(57, 227);
            this.cloudLabel1.Name = "cloudLabel1";
            this.cloudLabel1.Size = new System.Drawing.Size(89, 26);
            this.cloudLabel1.TabIndex = 7;
            this.cloudLabel1.Text = "File Lock";
            this.cloudLabel1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(330, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 91);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockFileToolStripMenuItem,
            this.encripToolStripMenuItem,
            this.stagnographToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(521, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lockFileToolStripMenuItem
            // 
            this.lockFileToolStripMenuItem.Name = "lockFileToolStripMenuItem";
            this.lockFileToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.lockFileToolStripMenuItem.Text = "Lock File";
            this.lockFileToolStripMenuItem.Click += new System.EventHandler(this.lockFileToolStripMenuItem_Click);
            // 
            // encripToolStripMenuItem
            // 
            this.encripToolStripMenuItem.Name = "encripToolStripMenuItem";
            this.encripToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.encripToolStripMenuItem.Text = "Encrypt";
            this.encripToolStripMenuItem.Click += new System.EventHandler(this.encripToolStripMenuItem_Click_1);
            // 
            // stagnographToolStripMenuItem1
            // 
            this.stagnographToolStripMenuItem1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.stagnographToolStripMenuItem1.Name = "stagnographToolStripMenuItem1";
            this.stagnographToolStripMenuItem1.Size = new System.Drawing.Size(94, 21);
            this.stagnographToolStripMenuItem1.Text = "Steganograph";
            this.stagnographToolStripMenuItem1.Click += new System.EventHandler(this.stagnographToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem,
            this.understangingFileRakshakToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.indexToolStripMenuItem.Text = "legel notices";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.searchToolStripMenuItem.Text = "overview";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(220, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aboutToolStripMenuItem.Text = "how it works";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // understangingFileRakshakToolStripMenuItem
            // 
            this.understangingFileRakshakToolStripMenuItem.Name = "understangingFileRakshakToolStripMenuItem";
            this.understangingFileRakshakToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.understangingFileRakshakToolStripMenuItem.Text = "understanging file Rakshak";
            this.understangingFileRakshakToolStripMenuItem.Click += new System.EventHandler(this.understangingFileRakshakToolStripMenuItem_Click);
            // 
            // w7Button1
            // 
            this.w7Button1.BackColor = System.Drawing.Color.Transparent;
            this.w7Button1.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button1.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button1.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button1.ControlOpacity = 255;
            this.w7Button1.CornerRadius = 3;
            this.w7Button1.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button1.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.w7Button1.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(77)))), ((int)(((byte)(71)))));
            this.w7Button1.Icon = null;
            this.w7Button1.IconOpacity = 0F;
            this.w7Button1.Location = new System.Drawing.Point(0, 28);
            this.w7Button1.Name = "w7Button1";
            this.w7Button1.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button1.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(116)))));
            this.w7Button1.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.w7Button1.Size = new System.Drawing.Size(518, 332);
            this.w7Button1.TabIndex = 5;
            // 
            // pan_after_auth
            // 
            this.pan_after_auth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_after_auth.Controls.Add(this.but_after_auth);
            this.pan_after_auth.Controls.Add(this.textBox3);
            this.pan_after_auth.Controls.Add(this.label3);
            this.pan_after_auth.Controls.Add(this.groupBox2);
            this.pan_after_auth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_after_auth.Location = new System.Drawing.Point(0, 0);
            this.pan_after_auth.Name = "pan_after_auth";
            this.pan_after_auth.Size = new System.Drawing.Size(512, 357);
            this.pan_after_auth.TabIndex = 5;
            // 
            // but_after_auth
            // 
            this.but_after_auth.AnimationOpacityChange = 0.1D;
            this.but_after_auth.BackColor = System.Drawing.Color.Transparent;
            this.but_after_auth.ButtonText = "submit";
            this.but_after_auth.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.but_after_auth.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.but_after_auth.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.but_after_auth.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.but_after_auth.ControlOpacity = 255;
            this.but_after_auth.CornerRadius = 8;
            this.but_after_auth.DrawHoverOverIcon = false;
            this.but_after_auth.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_after_auth.ForeColor = System.Drawing.Color.White;
            this.but_after_auth.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.but_after_auth.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Access_key2;
            this.but_after_auth.IsAnimated = true;
            this.but_after_auth.Location = new System.Drawing.Point(197, 186);
            this.but_after_auth.MaximumGlowOpacity = 0.8D;
            this.but_after_auth.Name = "but_after_auth";
            this.but_after_auth.NormalColors_1 = System.Drawing.Color.Silver;
            this.but_after_auth.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.but_after_auth.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.but_after_auth.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.but_after_auth.Size = new System.Drawing.Size(111, 28);
            this.but_after_auth.StartMenuIndex = 0;
            this.but_after_auth.TabIndex = 61;
            this.but_after_auth.TextCentered = true;
            this.but_after_auth.TextDistanceFromBorder = 5;
            this.but_after_auth.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.but_after_auth.Click += new System.EventHandler(this.but_after_auth_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label3.Location = new System.Drawing.Point(109, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.groupBox2.Location = new System.Drawing.Point(89, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 135);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter the correct password";
            // 
            // panel_auth
            // 
            this.panel_auth.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel_auth.Controls.Add(this.but_authentic);
            this.panel_auth.Controls.Add(this.textBox2);
            this.panel_auth.Controls.Add(this.textBox1);
            this.panel_auth.Controls.Add(this.label2);
            this.panel_auth.Controls.Add(this.label1);
            this.panel_auth.Controls.Add(this.groupBox1);
            this.panel_auth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_auth.Location = new System.Drawing.Point(0, 0);
            this.panel_auth.Name = "panel_auth";
            this.panel_auth.Size = new System.Drawing.Size(512, 357);
            this.panel_auth.TabIndex = 3;
            this.panel_auth.Visible = false;
            // 
            // but_authentic
            // 
            this.but_authentic.AnimationOpacityChange = 0.1D;
            this.but_authentic.BackColor = System.Drawing.Color.Transparent;
            this.but_authentic.ButtonText = "submit";
            this.but_authentic.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.but_authentic.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.but_authentic.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.but_authentic.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.but_authentic.ControlOpacity = 255;
            this.but_authentic.CornerRadius = 8;
            this.but_authentic.DrawHoverOverIcon = false;
            this.but_authentic.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_authentic.ForeColor = System.Drawing.Color.White;
            this.but_authentic.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.but_authentic.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Access_key2;
            this.but_authentic.IsAnimated = true;
            this.but_authentic.Location = new System.Drawing.Point(218, 215);
            this.but_authentic.MaximumGlowOpacity = 0.8D;
            this.but_authentic.Name = "but_authentic";
            this.but_authentic.NormalColors_1 = System.Drawing.Color.Silver;
            this.but_authentic.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.but_authentic.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.but_authentic.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.but_authentic.Size = new System.Drawing.Size(125, 29);
            this.but_authentic.StartMenuIndex = 0;
            this.but_authentic.TabIndex = 60;
            this.but_authentic.TextCentered = true;
            this.but_authentic.TextDistanceFromBorder = 5;
            this.but_authentic.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.but_authentic.Click += new System.EventHandler(this.but_authentic_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(88, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.groupBox1.Location = new System.Drawing.Point(64, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 163);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter the username and password to start the application ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 357);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_auth);
            this.Controls.Add(this.pan_after_auth);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 395);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 395);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Rakshak";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pan_after_auth.ResumeLayout(false);
            this.pan_after_auth.PerformLayout();
            this.panel_auth.ResumeLayout(false);
            this.panel_auth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stagnographToolStripMenuItem1;
        private System.Windows.Forms.Panel pan_after_auth;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_auth;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton but_authentic;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton but_after_auth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem lockFileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem understangingFileRakshakToolStripMenuItem;
        private CloudToolkitN6.W7Button w7Button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CloudToolkitN6.CloudLabel cloudLabel3;
        private CloudToolkitN6.CloudLabel cloudLabel2;
        private CloudToolkitN6.CloudLabel cloudLabel1;
    }
}