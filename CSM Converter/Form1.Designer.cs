// Token: 0x0200000D RID: 13
public partial class Form1 : global::System.Windows.Forms.Form
{
	// Token: 0x0600004C RID: 76 RVA: 0x00013768 File Offset: 0x00011968
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.settingCheckBox2 = new System.Windows.Forms.CheckBox();
            this.settingCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.browseButton1 = new System.Windows.Forms.Button();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.parentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.parentCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.writeDownBox = new System.Windows.Forms.TextBox();
            this.parentBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.folderContextMenuStrip.SuspendLayout();
            this.fileContextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderContextMenuStrip
            // 
            this.folderContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_0,
            this.toolStripMenuItem_1,
            this.toolStripMenuItem_2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem_7,
            this.toolStripMenuItem_3});
            this.folderContextMenuStrip.Name = "folderContextMenuStrip";
            this.folderContextMenuStrip.Size = new System.Drawing.Size(142, 120);
            // 
            // toolStripMenuItem_0
            // 
            this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
            this.toolStripMenuItem_0.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem_0.Text = "切り取り(&T)";
            this.toolStripMenuItem_0.Click += new System.EventHandler(this.toolStripMenuItem_0_Click);
            // 
            // toolStripMenuItem_1
            // 
            this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
            this.toolStripMenuItem_1.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem_1.Text = "コピー(&C)";
            this.toolStripMenuItem_1.Click += new System.EventHandler(this.toolStripMenuItem_1_Click);
            // 
            // toolStripMenuItem_2
            // 
            this.toolStripMenuItem_2.Name = "toolStripMenuItem_2";
            this.toolStripMenuItem_2.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem_2.Text = "貼り付け(&P)";
            this.toolStripMenuItem_2.Click += new System.EventHandler(this.toolStripMenuItem_2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripMenuItem_7
            // 
            this.toolStripMenuItem_7.Name = "toolStripMenuItem_7";
            this.toolStripMenuItem_7.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem_7.Text = "元に戻す(&U)";
            this.toolStripMenuItem_7.Click += new System.EventHandler(this.toolStripMenuItem_7_Click);
            // 
            // toolStripMenuItem_3
            // 
            this.toolStripMenuItem_3.Name = "toolStripMenuItem_3";
            this.toolStripMenuItem_3.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem_3.Text = "デスクトップ(&D)";
            this.toolStripMenuItem_3.Click += new System.EventHandler(this.toolStripMenuItem_3_Click);
            // 
            // fileContextMenuStrip
            // 
            this.fileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_4,
            this.toolStripMenuItem_5,
            this.toolStripMenuItem_6});
            this.fileContextMenuStrip.Name = "fileContextMenuStrip";
            this.fileContextMenuStrip.Size = new System.Drawing.Size(132, 70);
            // 
            // toolStripMenuItem_4
            // 
            this.toolStripMenuItem_4.Name = "toolStripMenuItem_4";
            this.toolStripMenuItem_4.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem_4.Text = "切り取り(&T)";
            this.toolStripMenuItem_4.Click += new System.EventHandler(this.toolStripMenuItem_4_Click);
            // 
            // toolStripMenuItem_5
            // 
            this.toolStripMenuItem_5.Name = "toolStripMenuItem_5";
            this.toolStripMenuItem_5.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem_5.Text = "コピー(&C)";
            this.toolStripMenuItem_5.Click += new System.EventHandler(this.toolStripMenuItem_5_Click);
            // 
            // toolStripMenuItem_6
            // 
            this.toolStripMenuItem_6.Name = "toolStripMenuItem_6";
            this.toolStripMenuItem_6.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem_6.Text = "貼り付け(&P)";
            this.toolStripMenuItem_6.Click += new System.EventHandler(this.toolStripMenuItem_6_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.settingCheckBox1);
            this.tabPage2.Controls.Add(this.settingCheckBox2);
            this.tabPage2.Controls.Add(this.linkLabel2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.themeComboBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "infos";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Luke Hax";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Made by:";
            // 
            // themeComboBox
            // 
            this.themeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.themeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.themeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.themeComboBox.Location = new System.Drawing.Point(24, 148);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(121, 24);
            this.themeComboBox.TabIndex = 14;
            this.themeComboBox.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Theme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 44);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(128, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Location = new System.Drawing.Point(310, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "CSM Converter v1.0.1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(21, 45);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 16);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Luke Worker";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // settingCheckBox2
            // 
            this.settingCheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingCheckBox2.AutoSize = true;
            this.settingCheckBox2.Checked = true;
            this.settingCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingCheckBox2.Location = new System.Drawing.Point(24, 219);
            this.settingCheckBox2.Name = "settingCheckBox2";
            this.settingCheckBox2.Size = new System.Drawing.Size(186, 20);
            this.settingCheckBox2.TabIndex = 19;
            this.settingCheckBox2.Text = "Open folder when saving";
            this.settingCheckBox2.UseVisualStyleBackColor = true;
            this.settingCheckBox2.CheckedChanged += new System.EventHandler(this.settingCheckBox2_CheckedChanged);
            // 
            // settingCheckBox1
            // 
            this.settingCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingCheckBox1.AutoSize = true;
            this.settingCheckBox1.Location = new System.Drawing.Point(24, 197);
            this.settingCheckBox1.Name = "settingCheckBox1";
            this.settingCheckBox1.Size = new System.Drawing.Size(137, 20);
            this.settingCheckBox1.TabIndex = 20;
            this.settingCheckBox1.Text = "Display at the top";
            this.settingCheckBox1.UseVisualStyleBackColor = true;
            this.settingCheckBox1.CheckedChanged += new System.EventHandler(this.settingCheckBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thanks: BlueDragon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(21, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Source By: Misaki Sagiri";
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabPage1.Controls.Add(this.parentBox);
            this.tabPage1.Controls.Add(this.writeDownBox);
            this.tabPage1.Controls.Add(this.folderBox);
            this.tabPage1.Controls.Add(this.fileBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.parentCheckBox);
            this.tabPage1.Controls.Add(this.doneButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.parentComboBox);
            this.tabPage1.Controls.Add(this.browseButton2);
            this.tabPage1.Controls.Add(this.browseButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Converter";
            this.tabPage1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragDrop);
            this.tabPage1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage1_DragEnter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File selection";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // fileBox
            // 
            this.fileBox.AccessibleDescription = "";
            this.fileBox.AccessibleName = "";
            this.fileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileBox.ContextMenuStrip = this.fileContextMenuStrip;
            this.fileBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(221)))), ((int)(((byte)(220)))));
            this.fileBox.Location = new System.Drawing.Point(11, 26);
            this.fileBox.Multiline = true;
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(410, 22);
            this.fileBox.TabIndex = 2;
            this.fileBox.TextChanged += new System.EventHandler(this.fileBox_TextChanged);
            // 
            // folderBox
            // 
            this.folderBox.AccessibleDescription = "";
            this.folderBox.AccessibleName = "";
            this.folderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.folderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderBox.ContextMenuStrip = this.folderContextMenuStrip;
            this.folderBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(221)))), ((int)(((byte)(220)))));
            this.folderBox.Location = new System.Drawing.Point(11, 70);
            this.folderBox.Multiline = true;
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(410, 23);
            this.folderBox.TabIndex = 3;
            this.folderBox.TextChanged += new System.EventHandler(this.folderBox_TextChanged);
            // 
            // browseButton1
            // 
            this.browseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.browseButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.browseButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.browseButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.browseButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.browseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton1.Location = new System.Drawing.Point(427, 26);
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Size = new System.Drawing.Size(30, 23);
            this.browseButton1.TabIndex = 5;
            this.browseButton1.Text = "...";
            this.browseButton1.UseVisualStyleBackColor = false;
            this.browseButton1.Click += new System.EventHandler(this.browseButton1_Click);
            // 
            // browseButton2
            // 
            this.browseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.browseButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.browseButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.browseButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.browseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton2.Location = new System.Drawing.Point(427, 70);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(30, 23);
            this.browseButton2.TabIndex = 6;
            this.browseButton2.Text = "...";
            this.browseButton2.UseVisualStyleBackColor = false;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // parentComboBox
            // 
            this.parentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.parentComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.parentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.parentComboBox.Items.AddRange(new object[] {
            "head",
            "body",
            "Right arm",
            "Left arm",
            "Right foot",
            "Left foot"});
            this.parentComboBox.Location = new System.Drawing.Point(14, 190);
            this.parentComboBox.Name = "parentComboBox";
            this.parentComboBox.Size = new System.Drawing.Size(121, 24);
            this.parentComboBox.TabIndex = 13;
            this.parentComboBox.SelectedIndexChanged += new System.EventHandler(this.parentComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(11, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "parent";
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.doneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.doneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.doneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(385, 189);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 25);
            this.doneButton.TabIndex = 15;
            this.doneButton.Text = "Convert";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // parentCheckBox
            // 
            this.parentCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.parentCheckBox.Checked = true;
            this.parentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parentCheckBox.Location = new System.Drawing.Point(195, 194);
            this.parentCheckBox.Name = "parentCheckBox";
            this.parentCheckBox.Size = new System.Drawing.Size(132, 20);
            this.parentCheckBox.TabIndex = 0;
            this.parentCheckBox.Text = "Generate parent";
            this.parentCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 16;
            // 
            // writeDownBox
            // 
            this.writeDownBox.Location = new System.Drawing.Point(14, 99);
            this.writeDownBox.Name = "writeDownBox";
            this.writeDownBox.Size = new System.Drawing.Size(100, 22);
            this.writeDownBox.TabIndex = 17;
            this.writeDownBox.Visible = false;
            // 
            // parentBox
            // 
            this.parentBox.Location = new System.Drawing.Point(120, 99);
            this.parentBox.Name = "parentBox";
            this.parentBox.Size = new System.Drawing.Size(100, 22);
            this.parentBox.TabIndex = 18;
            this.parentBox.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 277);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(471, 277);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(415, 277);
            this.Name = "Form1";
            this.Text = "CSM Converter v1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.folderContextMenuStrip.ResumeLayout(false);
            this.fileContextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

	}

	// Token: 0x0400002E RID: 46
	private global::System.ComponentModel.IContainer icontainer_0 = null;

    // Token: 0x0400002F RID: 47

    // Token: 0x04000030 RID: 48

    // Token: 0x04000031 RID: 49

    // Token: 0x04000032 RID: 50

    // Token: 0x04000033 RID: 51

    // Token: 0x04000034 RID: 52

    // Token: 0x04000035 RID: 53

    // Token: 0x04000036 RID: 54

    // Token: 0x04000037 RID: 55

    // Token: 0x04000038 RID: 56

    // Token: 0x04000039 RID: 57

    // Token: 0x0400003A RID: 58

    // Token: 0x0400003B RID: 59

    // Token: 0x0400003C RID: 60

    // Token: 0x0400003D RID: 61

    // Token: 0x0400003E RID: 62

    // Token: 0x0400003F RID: 63

    // Token: 0x04000040 RID: 64

    // Token: 0x04000041 RID: 65

    // Token: 0x04000042 RID: 66

    // Token: 0x04000043 RID: 67

    // Token: 0x04000044 RID: 68

    // Token: 0x04000045 RID: 69

    // Token: 0x04000046 RID: 70

    // Token: 0x04000047 RID: 71

	// Token: 0x04000048 RID: 72
	private global::System.Windows.Forms.ContextMenuStrip folderContextMenuStrip;

	// Token: 0x04000049 RID: 73
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

	// Token: 0x0400004A RID: 74
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

	// Token: 0x0400004B RID: 75
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;

	// Token: 0x0400004C RID: 76
	private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

	// Token: 0x0400004D RID: 77
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_3;

	// Token: 0x0400004E RID: 78
	private global::System.Windows.Forms.ContextMenuStrip fileContextMenuStrip;

	// Token: 0x0400004F RID: 79
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_4;

	// Token: 0x04000050 RID: 80
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_5;

	// Token: 0x04000051 RID: 81
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_6;

    // Token: 0x04000052 RID: 82

	// Token: 0x04000053 RID: 83
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_7;
    private System.ComponentModel.IContainer components;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.CheckBox settingCheckBox1;
    private System.Windows.Forms.CheckBox settingCheckBox2;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox themeComboBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TextBox parentBox;
    private System.Windows.Forms.TextBox writeDownBox;
    private System.Windows.Forms.TextBox folderBox;
    private System.Windows.Forms.TextBox fileBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox parentCheckBox;
    private System.Windows.Forms.Button doneButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox parentComboBox;
    private System.Windows.Forms.Button browseButton2;
    private System.Windows.Forms.Button browseButton1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
}
