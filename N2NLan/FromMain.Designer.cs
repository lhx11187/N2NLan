﻿namespace N2NLan
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
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BT_Random = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.CB_Min = new System.Windows.Forms.CheckBox();
            this.TB_SuperNode_Port = new System.Windows.Forms.TextBox();
            this.CB_Auto = new System.Windows.Forms.CheckBox();
            this.TB_Local_Port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_Passwd = new System.Windows.Forms.TextBox();
            this.TB_Local_IP = new System.Windows.Forms.TextBox();
            this.TB_SuperNode_IP = new System.Windows.Forms.TextBox();
            this.TB_Group = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BT_Start = new System.Windows.Forms.Button();
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
            this.关闭ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(101, 70);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_Random);
            this.groupBox2.Controls.Add(this.BT_Save);
            this.groupBox2.Controls.Add(this.CB_Min);
            this.groupBox2.Controls.Add(this.TB_SuperNode_Port);
            this.groupBox2.Controls.Add(this.CB_Auto);
            this.groupBox2.Controls.Add(this.TB_Local_Port);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label15);
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
            this.groupBox2.Size = new System.Drawing.Size(331, 126);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // BT_Random
            // 
            this.BT_Random.Location = new System.Drawing.Point(192, 39);
            this.BT_Random.Name = "BT_Random";
            this.BT_Random.Size = new System.Drawing.Size(37, 23);
            this.BT_Random.TabIndex = 25;
            this.BT_Random.Text = "随机";
            this.BT_Random.UseVisualStyleBackColor = true;
            this.BT_Random.Click += new System.EventHandler(this.BT_Random_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(270, 80);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(47, 23);
            this.BT_Save.TabIndex = 24;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
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
            this.TB_SuperNode_Port.Location = new System.Drawing.Point(270, 14);
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
            // TB_Local_Port
            // 
            this.TB_Local_Port.Location = new System.Drawing.Point(270, 41);
            this.TB_Local_Port.Name = "TB_Local_Port";
            this.TB_Local_Port.Size = new System.Drawing.Size(47, 21);
            this.TB_Local_Port.TabIndex = 3;
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
            // 
            // TB_Group
            // 
            this.TB_Group.Location = new System.Drawing.Point(78, 68);
            this.TB_Group.Name = "TB_Group";
            this.TB_Group.Size = new System.Drawing.Size(104, 21);
            this.TB_Group.TabIndex = 4;
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
            this.BT_Start.Location = new System.Drawing.Point(114, 159);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(120, 43);
            this.BT_Start.TabIndex = 0;
            this.BT_Start.Text = "启动";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 229);
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
        private System.Windows.Forms.TextBox TB_Local_Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
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
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button BT_Random;
    }
}

