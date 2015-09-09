namespace File_Encrypter_Decrypyer
{
    partial class frmEncDec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncDec));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.label31 = new System.Windows.Forms.Label();
            this.rTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.btnDecrypt = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rC4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKey = new System.Windows.Forms.Label();
            this.rTxtKey = new System.Windows.Forms.RichTextBox();
            this.btnClear = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.btnClose = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.btnGenerateKey = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(12, 58);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(329, 24);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AnimationOpacityChange = 0.1D;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnBrowse.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnBrowse.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnBrowse.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnBrowse.ControlOpacity = 255;
            this.btnBrowse.CornerRadius = 8;
            this.btnBrowse.DrawHoverOverIcon = false;
            this.btnBrowse.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnBrowse.Icon = null;
            this.btnBrowse.IsAnimated = true;
            this.btnBrowse.Location = new System.Drawing.Point(347, 56);
            this.btnBrowse.MaximumGlowOpacity = 0.8D;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NormalColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnBrowse.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnBrowse.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnBrowse.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnBrowse.Size = new System.Drawing.Size(64, 24);
            this.btnBrowse.StartMenuIndex = 0;
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.TextCentered = true;
            this.btnBrowse.TextDistanceFromBorder = 5;
            this.btnBrowse.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label31.Location = new System.Drawing.Point(9, 40);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 17);
            this.label31.TabIndex = 46;
            this.label31.Text = "File Path";
            // 
            // rTxtBox
            // 
            this.rTxtBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBox.Location = new System.Drawing.Point(12, 113);
            this.rTxtBox.Name = "rTxtBox";
            this.rTxtBox.Size = new System.Drawing.Size(468, 243);
            this.rTxtBox.TabIndex = 47;
            this.rTxtBox.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AnimationOpacityChange = 0.1D;
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.ButtonText = "Encrypt";
            this.btnEncrypt.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnEncrypt.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnEncrypt.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnEncrypt.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEncrypt.ControlOpacity = 255;
            this.btnEncrypt.CornerRadius = 8;
            this.btnEncrypt.DrawHoverOverIcon = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnEncrypt.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Certificate;
            this.btnEncrypt.IsAnimated = true;
            this.btnEncrypt.Location = new System.Drawing.Point(238, 371);
            this.btnEncrypt.MaximumGlowOpacity = 0.8D;
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.NormalColors_1 = System.Drawing.Color.Silver;
            this.btnEncrypt.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnEncrypt.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnEncrypt.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEncrypt.Size = new System.Drawing.Size(119, 39);
            this.btnEncrypt.StartMenuIndex = 0;
            this.btnEncrypt.TabIndex = 49;
            this.btnEncrypt.TextCentered = true;
            this.btnEncrypt.TextDistanceFromBorder = 5;
            this.btnEncrypt.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.AnimationOpacityChange = 0.1D;
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.ButtonText = "Decrypt";
            this.btnDecrypt.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDecrypt.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDecrypt.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnDecrypt.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDecrypt.ControlOpacity = 255;
            this.btnDecrypt.CornerRadius = 8;
            this.btnDecrypt.DrawHoverOverIcon = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnDecrypt.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Locked_users;
            this.btnDecrypt.IsAnimated = true;
            this.btnDecrypt.Location = new System.Drawing.Point(361, 370);
            this.btnDecrypt.MaximumGlowOpacity = 0.8D;
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.NormalColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnDecrypt.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnDecrypt.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDecrypt.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnDecrypt.Size = new System.Drawing.Size(119, 39);
            this.btnDecrypt.StartMenuIndex = 0;
            this.btnDecrypt.TabIndex = 50;
            this.btnDecrypt.TextCentered = true;
            this.btnDecrypt.TextDistanceFromBorder = 5;
            this.btnDecrypt.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.BackColor = System.Drawing.Color.Transparent;
            this.chkData.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkData.Location = new System.Drawing.Point(14, 93);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(337, 21);
            this.chkData.TabIndex = 51;
            this.chkData.Text = "Or write direct to text editor to encrypt/decrypt text";
            this.chkData.UseVisualStyleBackColor = false;
            this.chkData.CheckedChanged += new System.EventHandler(this.chkData_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numericUpDown.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(417, 58);
            this.numericUpDown.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(63, 24);
            this.numericUpDown.TabIndex = 52;
            this.numericUpDown.ThousandsSeparator = true;
            this.numericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(414, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Key Length";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 25);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rC4ToolStripMenuItem,
            this.rSAToolStripMenuItem});
            this.encryptionToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            // 
            // rC4ToolStripMenuItem
            // 
            this.rC4ToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rC4ToolStripMenuItem.Name = "rC4ToolStripMenuItem";
            this.rC4ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rC4ToolStripMenuItem.Text = "RC4";
            this.rC4ToolStripMenuItem.Click += new System.EventHandler(this.rC4ToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKey.Location = new System.Drawing.Point(9, 359);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(27, 17);
            this.lblKey.TabIndex = 55;
            this.lblKey.Text = "Key";
            // 
            // rTxtKey
            // 
            this.rTxtKey.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtKey.Location = new System.Drawing.Point(12, 378);
            this.rTxtKey.Name = "rTxtKey";
            this.rTxtKey.Size = new System.Drawing.Size(217, 74);
            this.rTxtKey.TabIndex = 56;
            this.rTxtKey.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.AnimationOpacityChange = 0.1D;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClear.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnClear.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnClear.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClear.ControlOpacity = 255;
            this.btnClear.CornerRadius = 8;
            this.btnClear.DrawHoverOverIcon = false;
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnClear.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Brush;
            this.btnClear.IsAnimated = true;
            this.btnClear.Location = new System.Drawing.Point(238, 417);
            this.btnClear.MaximumGlowOpacity = 0.8D;
            this.btnClear.Name = "btnClear";
            this.btnClear.NormalColors_1 = System.Drawing.Color.Silver;
            this.btnClear.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClear.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnClear.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClear.Size = new System.Drawing.Size(119, 39);
            this.btnClear.StartMenuIndex = 0;
            this.btnClear.TabIndex = 57;
            this.btnClear.TextCentered = true;
            this.btnClear.TextDistanceFromBorder = 5;
            this.btnClear.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationOpacityChange = 0.1D;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClose.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnClose.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnClose.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.ControlOpacity = 255;
            this.btnClose.CornerRadius = 8;
            this.btnClose.DrawHoverOverIcon = false;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnClose.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Move2Red1;
            this.btnClose.IsAnimated = true;
            this.btnClose.Location = new System.Drawing.Point(362, 417);
            this.btnClose.MaximumGlowOpacity = 0.8D;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalColors_1 = System.Drawing.Color.Silver;
            this.btnClose.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClose.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnClose.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClose.Size = new System.Drawing.Size(119, 39);
            this.btnClose.StartMenuIndex = 0;
            this.btnClose.TabIndex = 58;
            this.btnClose.TextCentered = true;
            this.btnClose.TextDistanceFromBorder = 5;
            this.btnClose.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.AnimationOpacityChange = 0.1D;
            this.btnGenerateKey.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateKey.ButtonText = "Generate Key";
            this.btnGenerateKey.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnGenerateKey.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnGenerateKey.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnGenerateKey.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnGenerateKey.ControlOpacity = 255;
            this.btnGenerateKey.CornerRadius = 8;
            this.btnGenerateKey.DrawHoverOverIcon = false;
            this.btnGenerateKey.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.ForeColor = System.Drawing.Color.White;
            this.btnGenerateKey.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnGenerateKey.Icon = global::File_Encrypter_Decrypyer.Properties.Resources.Access_key2;
            this.btnGenerateKey.IsAnimated = true;
            this.btnGenerateKey.Location = new System.Drawing.Point(12, 459);
            this.btnGenerateKey.MaximumGlowOpacity = 0.8D;
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.NormalColors_1 = System.Drawing.Color.Silver;
            this.btnGenerateKey.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnGenerateKey.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnGenerateKey.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnGenerateKey.Size = new System.Drawing.Size(156, 39);
            this.btnGenerateKey.StartMenuIndex = 0;
            this.btnGenerateKey.TabIndex = 59;
            this.btnGenerateKey.TextCentered = true;
            this.btnGenerateKey.TextDistanceFromBorder = 5;
            this.btnGenerateKey.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.IconOverText;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // frmEncDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 510);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rTxtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rTxtBox);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncDec";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Encrypter Decrypter";
            this.Load += new System.EventHandler(this.frmEncDec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnBrowse;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RichTextBox rTxtBox;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnEncrypt;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnDecrypt;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rC4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.RichTextBox rTxtKey;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnClear;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnClose;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnGenerateKey;
    }
}

