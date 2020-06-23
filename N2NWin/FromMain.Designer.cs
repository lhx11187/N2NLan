namespace N2NWin
{
    partial class FromMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BT_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_SuperNode = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_SetupDirver = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CB_N2NOther = new System.Windows.Forms.ComboBox();
            this.RB_N2NOther = new System.Windows.Forms.RadioButton();
            this.RB_N2NV21 = new System.Windows.Forms.RadioButton();
            this.RB_N2NV2 = new System.Windows.Forms.RadioButton();
            this.RB_N2NV1 = new System.Windows.Forms.RadioButton();
            this.CB_N2NAuto = new System.Windows.Forms.CheckBox();
            this.N2NLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CB_SNOther = new System.Windows.Forms.ComboBox();
            this.RB_SNOther = new System.Windows.Forms.RadioButton();
            this.RB_SNV21 = new System.Windows.Forms.RadioButton();
            this.RB_SNV2 = new System.Windows.Forms.RadioButton();
            this.RB_SNV1 = new System.Windows.Forms.RadioButton();
            this.CB_SNAuto = new System.Windows.Forms.CheckBox();
            this.SNLog = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CB_SettingOther = new System.Windows.Forms.ComboBox();
            this.RB_SettingOther = new System.Windows.Forms.RadioButton();
            this.RB_SettingV21 = new System.Windows.Forms.RadioButton();
            this.RB_SettingV2 = new System.Windows.Forms.RadioButton();
            this.BT_SettingSave = new System.Windows.Forms.Button();
            this.RB_SettingV1 = new System.Windows.Forms.RadioButton();
            this.CB_Min = new System.Windows.Forms.CheckBox();
            this.CB_Auto = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_SuperNode_Port = new System.Windows.Forms.TextBox();
            this.TB_Local_Port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_passwd = new System.Windows.Forms.TextBox();
            this.TB_N2NPath = new System.Windows.Forms.TextBox();
            this.TB_Local_IP = new System.Windows.Forms.TextBox();
            this.TB_SuperNode_IP = new System.Windows.Forms.TextBox();
            this.TB_Group = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gpSuperNode = new System.Windows.Forms.GroupBox();
            this.TB_SN_Path = new System.Windows.Forms.TextBox();
            this.TB_SN_IP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_SN_Port = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB_verbose = new System.Windows.Forms.CheckBox();
            this.CB_packet_forwarding = new System.Windows.Forms.CheckBox();
            this.CB_http_tunneling = new System.Windows.Forms.CheckBox();
            this.CB_resolve_supernode = new System.Windows.Forms.CheckBox();
            this.TB_SelfArg = new System.Windows.Forms.TextBox();
            this.TB_mtu = new System.Windows.Forms.TextBox();
            this.TB_netmask = new System.Windows.Forms.TextBox();
            this.TB_mac_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TB_Dirver_Path = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpSuperNode.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "N2N";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BT_Start,
            this.BT_SuperNode,
            this.BT_Setting,
            this.BT_SetupDirver,
            this.BT_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BT_Start
            // 
            this.BT_Start.Image = global::N2NWin.Properties.Resources.bullet_start;
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(60, 21);
            this.BT_Start.Text = "启动";
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // BT_SuperNode
            // 
            this.BT_SuperNode.Image = global::N2NWin.Properties.Resources.arrow_nw_ne_sw_se;
            this.BT_SuperNode.Name = "BT_SuperNode";
            this.BT_SuperNode.Size = new System.Drawing.Size(108, 21);
            this.BT_SuperNode.Text = "启动超级节点";
            this.BT_SuperNode.Click += new System.EventHandler(this.BT_SuperNode_Click);
            // 
            // BT_Setting
            // 
            this.BT_Setting.Image = global::N2NWin.Properties.Resources.advancedsettings2;
            this.BT_Setting.Name = "BT_Setting";
            this.BT_Setting.Size = new System.Drawing.Size(84, 21);
            this.BT_Setting.Text = "参数设置";
            this.BT_Setting.Click += new System.EventHandler(this.BT_Setting_Click);
            // 
            // BT_SetupDirver
            // 
            this.BT_SetupDirver.Image = global::N2NWin.Properties.Resources.building_link;
            this.BT_SetupDirver.Name = "BT_SetupDirver";
            this.BT_SetupDirver.Size = new System.Drawing.Size(84, 21);
            this.BT_SetupDirver.Text = "虚拟网卡";
            this.BT_SetupDirver.Click += new System.EventHandler(this.BT_SetupDirver_Click);
            // 
            // BT_About
            // 
            this.BT_About.Image = global::N2NWin.Properties.Resources.n2n;
            this.BT_About.Name = "BT_About";
            this.BT_About.Size = new System.Drawing.Size(60, 21);
            this.BT_About.Text = "关于";
            this.BT_About.Click += new System.EventHandler(this.BT_About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 508);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CB_N2NOther);
            this.tabPage1.Controls.Add(this.RB_N2NOther);
            this.tabPage1.Controls.Add(this.RB_N2NV21);
            this.tabPage1.Controls.Add(this.RB_N2NV2);
            this.tabPage1.Controls.Add(this.RB_N2NV1);
            this.tabPage1.Controls.Add(this.CB_N2NAuto);
            this.tabPage1.Controls.Add(this.N2NLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "N2N";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CB_N2NOther
            // 
            this.CB_N2NOther.FormattingEnabled = true;
            this.CB_N2NOther.Location = new System.Drawing.Point(257, 17);
            this.CB_N2NOther.Name = "CB_N2NOther";
            this.CB_N2NOther.Size = new System.Drawing.Size(121, 20);
            this.CB_N2NOther.TabIndex = 28;
            // 
            // RB_N2NOther
            // 
            this.RB_N2NOther.AutoSize = true;
            this.RB_N2NOther.Location = new System.Drawing.Point(237, 21);
            this.RB_N2NOther.Name = "RB_N2NOther";
            this.RB_N2NOther.Size = new System.Drawing.Size(14, 13);
            this.RB_N2NOther.TabIndex = 27;
            this.RB_N2NOther.UseVisualStyleBackColor = true;
            this.RB_N2NOther.CheckedChanged += new System.EventHandler(this.RB_N2NOther_CheckedChanged);
            // 
            // RB_N2NV21
            // 
            this.RB_N2NV21.AutoSize = true;
            this.RB_N2NV21.Location = new System.Drawing.Point(169, 20);
            this.RB_N2NV21.Name = "RB_N2NV21";
            this.RB_N2NV21.Size = new System.Drawing.Size(41, 16);
            this.RB_N2NV21.TabIndex = 26;
            this.RB_N2NV21.Text = "V21";
            this.RB_N2NV21.UseVisualStyleBackColor = true;
            this.RB_N2NV21.CheckedChanged += new System.EventHandler(this.RB_N2NV21_CheckedChanged);
            // 
            // RB_N2NV2
            // 
            this.RB_N2NV2.AutoSize = true;
            this.RB_N2NV2.Location = new System.Drawing.Point(91, 20);
            this.RB_N2NV2.Name = "RB_N2NV2";
            this.RB_N2NV2.Size = new System.Drawing.Size(35, 16);
            this.RB_N2NV2.TabIndex = 25;
            this.RB_N2NV2.Text = "V2";
            this.RB_N2NV2.UseVisualStyleBackColor = true;
            this.RB_N2NV2.CheckedChanged += new System.EventHandler(this.RB_N2NV2_CheckedChanged);
            // 
            // RB_N2NV1
            // 
            this.RB_N2NV1.AutoSize = true;
            this.RB_N2NV1.Checked = true;
            this.RB_N2NV1.Location = new System.Drawing.Point(23, 21);
            this.RB_N2NV1.Name = "RB_N2NV1";
            this.RB_N2NV1.Size = new System.Drawing.Size(35, 16);
            this.RB_N2NV1.TabIndex = 24;
            this.RB_N2NV1.TabStop = true;
            this.RB_N2NV1.Text = "V1";
            this.RB_N2NV1.UseVisualStyleBackColor = true;
            this.RB_N2NV1.CheckedChanged += new System.EventHandler(this.RB_N2NV1_CheckedChanged);
            // 
            // CB_N2NAuto
            // 
            this.CB_N2NAuto.AutoSize = true;
            this.CB_N2NAuto.Location = new System.Drawing.Point(414, 21);
            this.CB_N2NAuto.Name = "CB_N2NAuto";
            this.CB_N2NAuto.Size = new System.Drawing.Size(72, 16);
            this.CB_N2NAuto.TabIndex = 23;
            this.CB_N2NAuto.Text = "自动开始";
            this.CB_N2NAuto.UseVisualStyleBackColor = true;
            this.CB_N2NAuto.CheckedChanged += new System.EventHandler(this.CB_N2NAuto_CheckedChanged);
            // 
            // N2NLog
            // 
            this.N2NLog.Location = new System.Drawing.Point(2, 69);
            this.N2NLog.Multiline = true;
            this.N2NLog.Name = "N2NLog";
            this.N2NLog.Size = new System.Drawing.Size(540, 410);
            this.N2NLog.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CB_SNOther);
            this.tabPage2.Controls.Add(this.RB_SNOther);
            this.tabPage2.Controls.Add(this.RB_SNV21);
            this.tabPage2.Controls.Add(this.RB_SNV2);
            this.tabPage2.Controls.Add(this.RB_SNV1);
            this.tabPage2.Controls.Add(this.CB_SNAuto);
            this.tabPage2.Controls.Add(this.SNLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SuperNode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CB_SNOther
            // 
            this.CB_SNOther.FormattingEnabled = true;
            this.CB_SNOther.Location = new System.Drawing.Point(258, 21);
            this.CB_SNOther.Name = "CB_SNOther";
            this.CB_SNOther.Size = new System.Drawing.Size(121, 20);
            this.CB_SNOther.TabIndex = 31;
            // 
            // RB_SNOther
            // 
            this.RB_SNOther.AutoSize = true;
            this.RB_SNOther.Location = new System.Drawing.Point(238, 25);
            this.RB_SNOther.Name = "RB_SNOther";
            this.RB_SNOther.Size = new System.Drawing.Size(14, 13);
            this.RB_SNOther.TabIndex = 30;
            this.RB_SNOther.UseVisualStyleBackColor = true;
            this.RB_SNOther.CheckedChanged += new System.EventHandler(this.RB_SNOther_CheckedChanged);
            // 
            // RB_SNV21
            // 
            this.RB_SNV21.AutoSize = true;
            this.RB_SNV21.Location = new System.Drawing.Point(170, 23);
            this.RB_SNV21.Name = "RB_SNV21";
            this.RB_SNV21.Size = new System.Drawing.Size(41, 16);
            this.RB_SNV21.TabIndex = 29;
            this.RB_SNV21.Text = "V21";
            this.RB_SNV21.UseVisualStyleBackColor = true;
            this.RB_SNV21.CheckedChanged += new System.EventHandler(this.RB_SNV21_CheckedChanged);
            // 
            // RB_SNV2
            // 
            this.RB_SNV2.AutoSize = true;
            this.RB_SNV2.Location = new System.Drawing.Point(92, 23);
            this.RB_SNV2.Name = "RB_SNV2";
            this.RB_SNV2.Size = new System.Drawing.Size(35, 16);
            this.RB_SNV2.TabIndex = 28;
            this.RB_SNV2.Text = "V2";
            this.RB_SNV2.UseVisualStyleBackColor = true;
            this.RB_SNV2.CheckedChanged += new System.EventHandler(this.RB_SNV2_CheckedChanged);
            // 
            // RB_SNV1
            // 
            this.RB_SNV1.AutoSize = true;
            this.RB_SNV1.Checked = true;
            this.RB_SNV1.Location = new System.Drawing.Point(24, 24);
            this.RB_SNV1.Name = "RB_SNV1";
            this.RB_SNV1.Size = new System.Drawing.Size(35, 16);
            this.RB_SNV1.TabIndex = 27;
            this.RB_SNV1.TabStop = true;
            this.RB_SNV1.Text = "V1";
            this.RB_SNV1.UseVisualStyleBackColor = true;
            this.RB_SNV1.CheckedChanged += new System.EventHandler(this.RB_SNV1_CheckedChanged);
            // 
            // CB_SNAuto
            // 
            this.CB_SNAuto.AutoSize = true;
            this.CB_SNAuto.Location = new System.Drawing.Point(444, 25);
            this.CB_SNAuto.Name = "CB_SNAuto";
            this.CB_SNAuto.Size = new System.Drawing.Size(72, 16);
            this.CB_SNAuto.TabIndex = 22;
            this.CB_SNAuto.Text = "自动开始";
            this.CB_SNAuto.UseVisualStyleBackColor = true;
            this.CB_SNAuto.CheckedChanged += new System.EventHandler(this.CB_SNAuto_CheckedChanged);
            // 
            // SNLog
            // 
            this.SNLog.Location = new System.Drawing.Point(1, 69);
            this.SNLog.Multiline = true;
            this.SNLog.Name = "SNLog";
            this.SNLog.Size = new System.Drawing.Size(540, 410);
            this.SNLog.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CB_SettingOther);
            this.tabPage3.Controls.Add(this.RB_SettingOther);
            this.tabPage3.Controls.Add(this.RB_SettingV21);
            this.tabPage3.Controls.Add(this.RB_SettingV2);
            this.tabPage3.Controls.Add(this.BT_SettingSave);
            this.tabPage3.Controls.Add(this.RB_SettingV1);
            this.tabPage3.Controls.Add(this.CB_Min);
            this.tabPage3.Controls.Add(this.CB_Auto);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.gpSuperNode);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CB_SettingOther
            // 
            this.CB_SettingOther.FormattingEnabled = true;
            this.CB_SettingOther.Location = new System.Drawing.Point(259, 51);
            this.CB_SettingOther.Name = "CB_SettingOther";
            this.CB_SettingOther.Size = new System.Drawing.Size(121, 20);
            this.CB_SettingOther.TabIndex = 34;
            // 
            // RB_SettingOther
            // 
            this.RB_SettingOther.AutoSize = true;
            this.RB_SettingOther.Location = new System.Drawing.Point(239, 55);
            this.RB_SettingOther.Name = "RB_SettingOther";
            this.RB_SettingOther.Size = new System.Drawing.Size(14, 13);
            this.RB_SettingOther.TabIndex = 33;
            this.RB_SettingOther.UseVisualStyleBackColor = true;
            // 
            // RB_SettingV21
            // 
            this.RB_SettingV21.AutoSize = true;
            this.RB_SettingV21.Location = new System.Drawing.Point(168, 54);
            this.RB_SettingV21.Name = "RB_SettingV21";
            this.RB_SettingV21.Size = new System.Drawing.Size(41, 16);
            this.RB_SettingV21.TabIndex = 32;
            this.RB_SettingV21.Text = "V21";
            this.RB_SettingV21.UseVisualStyleBackColor = true;
            this.RB_SettingV21.CheckedChanged += new System.EventHandler(this.RB_SettingV21_CheckedChanged);
            // 
            // RB_SettingV2
            // 
            this.RB_SettingV2.AutoSize = true;
            this.RB_SettingV2.Location = new System.Drawing.Point(90, 54);
            this.RB_SettingV2.Name = "RB_SettingV2";
            this.RB_SettingV2.Size = new System.Drawing.Size(35, 16);
            this.RB_SettingV2.TabIndex = 31;
            this.RB_SettingV2.Text = "V2";
            this.RB_SettingV2.UseVisualStyleBackColor = true;
            this.RB_SettingV2.CheckedChanged += new System.EventHandler(this.RB_SettingV2_CheckedChanged);
            // 
            // BT_SettingSave
            // 
            this.BT_SettingSave.Location = new System.Drawing.Point(422, 44);
            this.BT_SettingSave.Name = "BT_SettingSave";
            this.BT_SettingSave.Size = new System.Drawing.Size(62, 36);
            this.BT_SettingSave.TabIndex = 13;
            this.BT_SettingSave.Text = "保存";
            this.BT_SettingSave.UseVisualStyleBackColor = true;
            this.BT_SettingSave.Click += new System.EventHandler(this.BT_SettingSave_Click);
            // 
            // RB_SettingV1
            // 
            this.RB_SettingV1.AutoSize = true;
            this.RB_SettingV1.Checked = true;
            this.RB_SettingV1.Location = new System.Drawing.Point(22, 55);
            this.RB_SettingV1.Name = "RB_SettingV1";
            this.RB_SettingV1.Size = new System.Drawing.Size(35, 16);
            this.RB_SettingV1.TabIndex = 30;
            this.RB_SettingV1.TabStop = true;
            this.RB_SettingV1.Text = "V1";
            this.RB_SettingV1.UseVisualStyleBackColor = true;
            this.RB_SettingV1.CheckedChanged += new System.EventHandler(this.RB_SettingV1_CheckedChanged);
            // 
            // CB_Min
            // 
            this.CB_Min.AutoSize = true;
            this.CB_Min.Location = new System.Drawing.Point(100, 20);
            this.CB_Min.Name = "CB_Min";
            this.CB_Min.Size = new System.Drawing.Size(72, 16);
            this.CB_Min.TabIndex = 21;
            this.CB_Min.Text = "自动隐藏";
            this.CB_Min.UseVisualStyleBackColor = true;
            this.CB_Min.CheckedChanged += new System.EventHandler(this.CB_Min_CheckedChanged);
            // 
            // CB_Auto
            // 
            this.CB_Auto.AutoSize = true;
            this.CB_Auto.Location = new System.Drawing.Point(22, 20);
            this.CB_Auto.Name = "CB_Auto";
            this.CB_Auto.Size = new System.Drawing.Size(72, 16);
            this.CB_Auto.TabIndex = 20;
            this.CB_Auto.Text = "开机启动";
            this.CB_Auto.UseVisualStyleBackColor = true;
            this.CB_Auto.CheckedChanged += new System.EventHandler(this.CB_Auto_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_SuperNode_Port);
            this.groupBox2.Controls.Add(this.TB_Local_Port);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.TB_passwd);
            this.groupBox2.Controls.Add(this.TB_N2NPath);
            this.groupBox2.Controls.Add(this.TB_Local_IP);
            this.groupBox2.Controls.Add(this.TB_SuperNode_IP);
            this.groupBox2.Controls.Add(this.TB_Group);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(22, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 147);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "N2N";
            // 
            // TB_SuperNode_Port
            // 
            this.TB_SuperNode_Port.Location = new System.Drawing.Point(270, 14);
            this.TB_SuperNode_Port.Name = "TB_SuperNode_Port";
            this.TB_SuperNode_Port.Size = new System.Drawing.Size(104, 21);
            this.TB_SuperNode_Port.TabIndex = 23;
            // 
            // TB_Local_Port
            // 
            this.TB_Local_Port.Location = new System.Drawing.Point(270, 41);
            this.TB_Local_Port.Name = "TB_Local_Port";
            this.TB_Local_Port.Size = new System.Drawing.Size(104, 21);
            this.TB_Local_Port.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "端口";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(235, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "端口";
            // 
            // TB_passwd
            // 
            this.TB_passwd.Location = new System.Drawing.Point(78, 95);
            this.TB_passwd.Name = "TB_passwd";
            this.TB_passwd.Size = new System.Drawing.Size(104, 21);
            this.TB_passwd.TabIndex = 19;
            // 
            // TB_N2NPath
            // 
            this.TB_N2NPath.Location = new System.Drawing.Point(77, 122);
            this.TB_N2NPath.Name = "TB_N2NPath";
            this.TB_N2NPath.Size = new System.Drawing.Size(232, 21);
            this.TB_N2NPath.TabIndex = 18;
            // 
            // TB_Local_IP
            // 
            this.TB_Local_IP.Location = new System.Drawing.Point(77, 41);
            this.TB_Local_IP.Name = "TB_Local_IP";
            this.TB_Local_IP.Size = new System.Drawing.Size(145, 21);
            this.TB_Local_IP.TabIndex = 17;
            // 
            // TB_SuperNode_IP
            // 
            this.TB_SuperNode_IP.Location = new System.Drawing.Point(77, 14);
            this.TB_SuperNode_IP.Name = "TB_SuperNode_IP";
            this.TB_SuperNode_IP.Size = new System.Drawing.Size(145, 21);
            this.TB_SuperNode_IP.TabIndex = 16;
            // 
            // TB_Group
            // 
            this.TB_Group.Location = new System.Drawing.Point(78, 68);
            this.TB_Group.Name = "TB_Group";
            this.TB_Group.Size = new System.Drawing.Size(104, 21);
            this.TB_Group.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "路径";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "组名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "本地地址";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "服务器地址";
            // 
            // gpSuperNode
            // 
            this.gpSuperNode.Controls.Add(this.TB_SN_Path);
            this.gpSuperNode.Controls.Add(this.TB_SN_IP);
            this.gpSuperNode.Controls.Add(this.label16);
            this.gpSuperNode.Controls.Add(this.TB_SN_Port);
            this.gpSuperNode.Controls.Add(this.label17);
            this.gpSuperNode.Controls.Add(this.label18);
            this.gpSuperNode.Location = new System.Drawing.Point(22, 379);
            this.gpSuperNode.Name = "gpSuperNode";
            this.gpSuperNode.Size = new System.Drawing.Size(509, 75);
            this.gpSuperNode.TabIndex = 17;
            this.gpSuperNode.TabStop = false;
            this.gpSuperNode.Text = "SuperNode";
            // 
            // TB_SN_Path
            // 
            this.TB_SN_Path.Location = new System.Drawing.Point(58, 43);
            this.TB_SN_Path.Name = "TB_SN_Path";
            this.TB_SN_Path.Size = new System.Drawing.Size(251, 21);
            this.TB_SN_Path.TabIndex = 18;
            // 
            // TB_SN_IP
            // 
            this.TB_SN_IP.Location = new System.Drawing.Point(58, 15);
            this.TB_SN_IP.Name = "TB_SN_IP";
            this.TB_SN_IP.Size = new System.Drawing.Size(164, 21);
            this.TB_SN_IP.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "路径";
            // 
            // TB_SN_Port
            // 
            this.TB_SN_Port.Location = new System.Drawing.Point(270, 15);
            this.TB_SN_Port.Name = "TB_SN_Port";
            this.TB_SN_Port.Size = new System.Drawing.Size(100, 21);
            this.TB_SN_Port.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(235, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "端口";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "IP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_verbose);
            this.groupBox3.Controls.Add(this.CB_packet_forwarding);
            this.groupBox3.Controls.Add(this.CB_http_tunneling);
            this.groupBox3.Controls.Add(this.CB_resolve_supernode);
            this.groupBox3.Controls.Add(this.TB_SelfArg);
            this.groupBox3.Controls.Add(this.TB_mtu);
            this.groupBox3.Controls.Add(this.TB_netmask);
            this.groupBox3.Controls.Add(this.TB_mac_address);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(22, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 134);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "高级设定";
            // 
            // CB_verbose
            // 
            this.CB_verbose.AutoSize = true;
            this.CB_verbose.Location = new System.Drawing.Point(315, 97);
            this.CB_verbose.Name = "CB_verbose";
            this.CB_verbose.Size = new System.Drawing.Size(108, 16);
            this.CB_verbose.TabIndex = 29;
            this.CB_verbose.Text = "启动详细数据报";
            this.CB_verbose.UseVisualStyleBackColor = true;
            // 
            // CB_packet_forwarding
            // 
            this.CB_packet_forwarding.AutoSize = true;
            this.CB_packet_forwarding.Location = new System.Drawing.Point(315, 70);
            this.CB_packet_forwarding.Name = "CB_packet_forwarding";
            this.CB_packet_forwarding.Size = new System.Drawing.Size(132, 16);
            this.CB_packet_forwarding.TabIndex = 28;
            this.CB_packet_forwarding.Text = "允许服务器转发数据";
            this.CB_packet_forwarding.UseVisualStyleBackColor = true;
            // 
            // CB_http_tunneling
            // 
            this.CB_http_tunneling.AutoSize = true;
            this.CB_http_tunneling.Location = new System.Drawing.Point(315, 43);
            this.CB_http_tunneling.Name = "CB_http_tunneling";
            this.CB_http_tunneling.Size = new System.Drawing.Size(96, 16);
            this.CB_http_tunneling.TabIndex = 27;
            this.CB_http_tunneling.Text = "使用HTTP隧道";
            this.CB_http_tunneling.UseVisualStyleBackColor = true;
            // 
            // CB_resolve_supernode
            // 
            this.CB_resolve_supernode.AutoSize = true;
            this.CB_resolve_supernode.Location = new System.Drawing.Point(315, 16);
            this.CB_resolve_supernode.Name = "CB_resolve_supernode";
            this.CB_resolve_supernode.Size = new System.Drawing.Size(120, 16);
            this.CB_resolve_supernode.TabIndex = 26;
            this.CB_resolve_supernode.Text = "周期检查是否连通";
            this.CB_resolve_supernode.UseVisualStyleBackColor = true;
            // 
            // TB_SelfArg
            // 
            this.TB_SelfArg.Location = new System.Drawing.Point(77, 95);
            this.TB_SelfArg.Name = "TB_SelfArg";
            this.TB_SelfArg.Size = new System.Drawing.Size(232, 21);
            this.TB_SelfArg.TabIndex = 25;
            // 
            // TB_mtu
            // 
            this.TB_mtu.Location = new System.Drawing.Point(77, 68);
            this.TB_mtu.Name = "TB_mtu";
            this.TB_mtu.Size = new System.Drawing.Size(232, 21);
            this.TB_mtu.TabIndex = 24;
            // 
            // TB_netmask
            // 
            this.TB_netmask.Location = new System.Drawing.Point(77, 41);
            this.TB_netmask.Name = "TB_netmask";
            this.TB_netmask.Size = new System.Drawing.Size(232, 21);
            this.TB_netmask.TabIndex = 23;
            // 
            // TB_mac_address
            // 
            this.TB_mac_address.Location = new System.Drawing.Point(77, 14);
            this.TB_mac_address.Name = "TB_mac_address";
            this.TB_mac_address.Size = new System.Drawing.Size(232, 21);
            this.TB_mac_address.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "自定义参数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "MTU";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "子网掩码";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "网卡MAC地址";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TB_Dirver_Path);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(544, 482);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "安装网卡";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TB_Dirver_Path
            // 
            this.TB_Dirver_Path.Location = new System.Drawing.Point(110, 19);
            this.TB_Dirver_Path.Name = "TB_Dirver_Path";
            this.TB_Dirver_Path.Size = new System.Drawing.Size(215, 21);
            this.TB_Dirver_Path.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "驱动路径";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.linkLabel2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.linkLabel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(544, 482);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "关于";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 72);
            this.label3.TabIndex = 9;
            this.label3.Text = "可以自由添加新的版本\r\n\r\nn2n最新版为V2.1\r\n\r\nBy 黑鸭子 251873581@qq.com 2018-03-16\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "QQ群";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(108, 58);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 12);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "256572040";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Github";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(108, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/meyerd/n2n";
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 548);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FromMain";
            this.Text = "N2N---by 黑鸭子";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromMain_FormClosing);
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.SizeChanged += new System.EventHandler(this.FromMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpSuperNode.ResumeLayout(false);
            this.gpSuperNode.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BT_Start;
        private System.Windows.Forms.ToolStripMenuItem BT_SuperNode;
        private System.Windows.Forms.ToolStripMenuItem BT_Setting;
        private System.Windows.Forms.ToolStripMenuItem BT_SetupDirver;
        private System.Windows.Forms.ToolStripMenuItem BT_About;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox N2NLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_Group;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_SettingSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gpSuperNode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_SN_Port;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SNLog;
        private System.Windows.Forms.CheckBox CB_SNAuto;
        private System.Windows.Forms.CheckBox CB_Auto;
        private System.Windows.Forms.RadioButton RB_N2NV21;
        private System.Windows.Forms.RadioButton RB_N2NV2;
        private System.Windows.Forms.RadioButton RB_N2NV1;
        private System.Windows.Forms.CheckBox CB_N2NAuto;
        private System.Windows.Forms.RadioButton RB_SNV21;
        private System.Windows.Forms.RadioButton RB_SNV2;
        private System.Windows.Forms.RadioButton RB_SNV1;
        private System.Windows.Forms.CheckBox CB_Min;
        private System.Windows.Forms.RadioButton RB_SettingV21;
        private System.Windows.Forms.RadioButton RB_SettingV2;
        private System.Windows.Forms.RadioButton RB_SettingV1;
        private System.Windows.Forms.TextBox TB_passwd;
        private System.Windows.Forms.TextBox TB_N2NPath;
        private System.Windows.Forms.TextBox TB_Local_IP;
        private System.Windows.Forms.TextBox TB_SuperNode_IP;
        private System.Windows.Forms.TextBox TB_SN_Path;
        private System.Windows.Forms.TextBox TB_SN_IP;
        private System.Windows.Forms.TextBox TB_SelfArg;
        private System.Windows.Forms.TextBox TB_mtu;
        private System.Windows.Forms.TextBox TB_netmask;
        private System.Windows.Forms.TextBox TB_mac_address;
        private System.Windows.Forms.TextBox TB_Dirver_Path;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_N2NOther;
        private System.Windows.Forms.RadioButton RB_N2NOther;
        private System.Windows.Forms.ComboBox CB_SNOther;
        private System.Windows.Forms.RadioButton RB_SNOther;
        private System.Windows.Forms.ComboBox CB_SettingOther;
        private System.Windows.Forms.RadioButton RB_SettingOther;
        private System.Windows.Forms.TextBox TB_SuperNode_Port;
        private System.Windows.Forms.TextBox TB_Local_Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CB_verbose;
        private System.Windows.Forms.CheckBox CB_packet_forwarding;
        private System.Windows.Forms.CheckBox CB_http_tunneling;
        private System.Windows.Forms.CheckBox CB_resolve_supernode;
    }
}

