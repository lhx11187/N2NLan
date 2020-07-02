namespace N2NLan
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
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有IPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_Min = new System.Windows.Forms.CheckBox();
            this.TB_SuperNode_Port = new System.Windows.Forms.TextBox();
            this.CB_Auto = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Passwd = new System.Windows.Forms.TextBox();
            this.TB_Local_IP = new System.Windows.Forms.TextBox();
            this.TB_SuperNode_IP = new System.Windows.Forms.TextBox();
            this.TB_Group = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BT_Start = new System.Windows.Forms.Button();
            this.CB_Ping = new System.Windows.Forms.CheckBox();
            this.TB_PingIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_AutoIP = new System.Windows.Forms.CheckBox();
            this.CMS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.CMS;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "N2NLan";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.使用说明ToolStripMenuItem,
            this.所有IPToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.toolStripSeparator1,
            this.关闭ToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(125, 120);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 所有IPToolStripMenuItem
            // 
            this.所有IPToolStripMenuItem.Name = "所有IPToolStripMenuItem";
            this.所有IPToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.所有IPToolStripMenuItem.Text = "所有IP";
            this.所有IPToolStripMenuItem.Click += new System.EventHandler(this.所有IPToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_AutoIP);
            this.groupBox2.Controls.Add(this.TB_PingIP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CB_Ping);
            this.groupBox2.Controls.Add(this.CB_Min);
            this.groupBox2.Controls.Add(this.TB_SuperNode_Port);
            this.groupBox2.Controls.Add(this.CB_Auto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TB_Passwd);
            this.groupBox2.Controls.Add(this.TB_Local_IP);
            this.groupBox2.Controls.Add(this.TB_SuperNode_IP);
            this.groupBox2.Controls.Add(this.TB_Group);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 156);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // CB_Min
            // 
            this.CB_Min.AutoSize = true;
            this.CB_Min.Location = new System.Drawing.Point(192, 97);
            this.CB_Min.Name = "CB_Min";
            this.CB_Min.Size = new System.Drawing.Size(72, 16);
            this.CB_Min.TabIndex = 7;
            this.CB_Min.Text = "自动隐藏";
            this.CB_Min.UseVisualStyleBackColor = true;
            // 
            // TB_SuperNode_Port
            // 
            this.TB_SuperNode_Port.Location = new System.Drawing.Point(226, 14);
            this.TB_SuperNode_Port.Name = "TB_SuperNode_Port";
            this.TB_SuperNode_Port.Size = new System.Drawing.Size(47, 21);
            this.TB_SuperNode_Port.TabIndex = 1;
            // 
            // CB_Auto
            // 
            this.CB_Auto.AutoSize = true;
            this.CB_Auto.Location = new System.Drawing.Point(192, 70);
            this.CB_Auto.Name = "CB_Auto";
            this.CB_Auto.Size = new System.Drawing.Size(72, 16);
            this.CB_Auto.TabIndex = 6;
            this.CB_Auto.Text = "自动启动";
            this.CB_Auto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "端口";
            // 
            // TB_Passwd
            // 
            this.TB_Passwd.Location = new System.Drawing.Point(78, 95);
            this.TB_Passwd.Name = "TB_Passwd";
            this.TB_Passwd.Size = new System.Drawing.Size(104, 21);
            this.TB_Passwd.TabIndex = 5;
            // 
            // TB_Local_IP
            // 
            this.TB_Local_IP.Location = new System.Drawing.Point(77, 41);
            this.TB_Local_IP.Name = "TB_Local_IP";
            this.TB_Local_IP.Size = new System.Drawing.Size(105, 21);
            this.TB_Local_IP.TabIndex = 2;
            // 
            // TB_SuperNode_IP
            // 
            this.TB_SuperNode_IP.Location = new System.Drawing.Point(77, 14);
            this.TB_SuperNode_IP.Name = "TB_SuperNode_IP";
            this.TB_SuperNode_IP.Size = new System.Drawing.Size(105, 21);
            this.TB_SuperNode_IP.TabIndex = 0;
            this.TB_SuperNode_IP.TextChanged += new System.EventHandler(this.TB_SuperNode_IP_TextChanged);
            // 
            // TB_Group
            // 
            this.TB_Group.Location = new System.Drawing.Point(78, 68);
            this.TB_Group.Name = "TB_Group";
            this.TB_Group.Size = new System.Drawing.Size(104, 21);
            this.TB_Group.TabIndex = 4;
            this.TB_Group.TextChanged += new System.EventHandler(this.TB_Group_TextChanged);
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
            // BT_Start
            // 
            this.BT_Start.BackColor = System.Drawing.Color.Green;
            this.BT_Start.Location = new System.Drawing.Point(102, 174);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(120, 43);
            this.BT_Start.TabIndex = 0;
            this.BT_Start.Text = "启动";
            this.BT_Start.UseVisualStyleBackColor = false;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // CB_Ping
            // 
            this.CB_Ping.AutoSize = true;
            this.CB_Ping.Location = new System.Drawing.Point(192, 124);
            this.CB_Ping.Name = "CB_Ping";
            this.CB_Ping.Size = new System.Drawing.Size(72, 16);
            this.CB_Ping.TabIndex = 26;
            this.CB_Ping.Text = "自动ping";
            this.CB_Ping.UseVisualStyleBackColor = true;
            // 
            // TB_PingIP
            // 
            this.TB_PingIP.Location = new System.Drawing.Point(77, 122);
            this.TB_PingIP.Name = "TB_PingIP";
            this.TB_PingIP.Size = new System.Drawing.Size(104, 21);
            this.TB_PingIP.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "PingIP";
            // 
            // CB_AutoIP
            // 
            this.CB_AutoIP.AutoSize = true;
            this.CB_AutoIP.Location = new System.Drawing.Point(192, 43);
            this.CB_AutoIP.Name = "CB_AutoIP";
            this.CB_AutoIP.Size = new System.Drawing.Size(60, 16);
            this.CB_AutoIP.TabIndex = 29;
            this.CB_AutoIP.Text = "获取IP";
            this.CB_AutoIP.UseVisualStyleBackColor = true;
            this.CB_AutoIP.CheckedChanged += new System.EventHandler(this.CB_AutoIP_CheckedChanged);
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 229);
            this.Controls.Add(this.BT_Start);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FromMain";
            this.Text = "联机平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromMain_FormClosing);
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.SizeChanged += new System.EventHandler(this.FromMain_SizeChanged);
            this.CMS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_SuperNode_Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Passwd;
        private System.Windows.Forms.TextBox TB_Local_IP;
        private System.Windows.Forms.TextBox TB_SuperNode_IP;
        private System.Windows.Forms.TextBox TB_Group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox CB_Min;
        private System.Windows.Forms.CheckBox CB_Auto;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有IPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox CB_Ping;
        private System.Windows.Forms.TextBox TB_PingIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_AutoIP;
    }
}

