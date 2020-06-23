namespace N2NWin
{
    partial class FormSetting
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
            this.gpSuperNode = new System.Windows.Forms.GroupBox();
            this.SuperNode_Save = new System.Windows.Forms.Button();
            this.SuperNode_Path = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuperNodePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuperNode_version = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.N2N_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.TextBox();
            this.n2n_version = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Local_Port = new System.Windows.Forms.TextBox();
            this.Local_IP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuperNode_Port = new System.Windows.Forms.TextBox();
            this.SuperNode_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SelfArg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.verbose = new System.Windows.Forms.CheckBox();
            this.packet_forwarding = new System.Windows.Forms.CheckBox();
            this.http_tunneling = new System.Windows.Forms.CheckBox();
            this.resolve_supernode = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Dirver_Path = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Dirver_version = new System.Windows.Forms.ComboBox();
            this.mtu = new System.Windows.Forms.TextBox();
            this.netmask = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mac_address = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpSuperNode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSuperNode
            // 
            this.gpSuperNode.Controls.Add(this.SuperNode_Save);
            this.gpSuperNode.Controls.Add(this.SuperNode_Path);
            this.gpSuperNode.Controls.Add(this.label16);
            this.gpSuperNode.Controls.Add(this.SuperNodePort);
            this.gpSuperNode.Controls.Add(this.label2);
            this.gpSuperNode.Controls.Add(this.label1);
            this.gpSuperNode.Controls.Add(this.SuperNode_version);
            this.gpSuperNode.Location = new System.Drawing.Point(12, 9);
            this.gpSuperNode.Name = "gpSuperNode";
            this.gpSuperNode.Size = new System.Drawing.Size(371, 68);
            this.gpSuperNode.TabIndex = 0;
            this.gpSuperNode.TabStop = false;
            this.gpSuperNode.Text = "SuperNode";
            // 
            // SuperNode_Save
            // 
            this.SuperNode_Save.Location = new System.Drawing.Point(315, 20);
            this.SuperNode_Save.Name = "SuperNode_Save";
            this.SuperNode_Save.Size = new System.Drawing.Size(50, 36);
            this.SuperNode_Save.TabIndex = 16;
            this.SuperNode_Save.Text = "保存";
            this.SuperNode_Save.UseVisualStyleBackColor = true;
            this.SuperNode_Save.Click += new System.EventHandler(this.SuperNode_Save_Click);
            // 
            // SuperNode_Path
            // 
            this.SuperNode_Path.Location = new System.Drawing.Point(43, 42);
            this.SuperNode_Path.Name = "SuperNode_Path";
            this.SuperNode_Path.Size = new System.Drawing.Size(266, 21);
            this.SuperNode_Path.TabIndex = 5;
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
            // SuperNodePort
            // 
            this.SuperNodePort.Location = new System.Drawing.Point(209, 15);
            this.SuperNodePort.Name = "SuperNodePort";
            this.SuperNodePort.Size = new System.Drawing.Size(100, 21);
            this.SuperNodePort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "版本";
            // 
            // SuperNode_version
            // 
            this.SuperNode_version.FormattingEnabled = true;
            this.SuperNode_version.Location = new System.Drawing.Point(43, 16);
            this.SuperNode_version.Name = "SuperNode_version";
            this.SuperNode_version.Size = new System.Drawing.Size(121, 20);
            this.SuperNode_version.TabIndex = 0;
            this.SuperNode_version.SelectedIndexChanged += new System.EventHandler(this.SuperNode_version_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Path);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.N2N_Save);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.passwd);
            this.groupBox2.Controls.Add(this.n2n_version);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Group);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Local_Port);
            this.groupBox2.Controls.Add(this.Local_IP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SuperNode_Port);
            this.groupBox2.Controls.Add(this.SuperNode_IP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "N2N";
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(261, 95);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(104, 21);
            this.Path.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "路径";
            // 
            // N2N_Save
            // 
            this.N2N_Save.Location = new System.Drawing.Point(303, 20);
            this.N2N_Save.Name = "N2N_Save";
            this.N2N_Save.Size = new System.Drawing.Size(62, 36);
            this.N2N_Save.TabIndex = 13;
            this.N2N_Save.Text = "保存";
            this.N2N_Save.UseVisualStyleBackColor = true;
            this.N2N_Save.Click += new System.EventHandler(this.N2N_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "版本";
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(77, 95);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(138, 21);
            this.passwd.TabIndex = 11;
            // 
            // n2n_version
            // 
            this.n2n_version.FormattingEnabled = true;
            this.n2n_version.Location = new System.Drawing.Point(261, 68);
            this.n2n_version.Name = "n2n_version";
            this.n2n_version.Size = new System.Drawing.Size(104, 20);
            this.n2n_version.TabIndex = 4;
            this.n2n_version.SelectedIndexChanged += new System.EventHandler(this.n2n_version_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "密码";
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(77, 68);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(138, 21);
            this.Group.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "组名";
            // 
            // Local_Port
            // 
            this.Local_Port.Location = new System.Drawing.Point(221, 41);
            this.Local_Port.Name = "Local_Port";
            this.Local_Port.Size = new System.Drawing.Size(72, 21);
            this.Local_Port.TabIndex = 8;
            // 
            // Local_IP
            // 
            this.Local_IP.Location = new System.Drawing.Point(77, 41);
            this.Local_IP.Name = "Local_IP";
            this.Local_IP.Size = new System.Drawing.Size(138, 21);
            this.Local_IP.TabIndex = 6;
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
            // SuperNode_Port
            // 
            this.SuperNode_Port.Location = new System.Drawing.Point(221, 14);
            this.SuperNode_Port.Name = "SuperNode_Port";
            this.SuperNode_Port.Size = new System.Drawing.Size(72, 21);
            this.SuperNode_Port.TabIndex = 5;
            // 
            // SuperNode_IP
            // 
            this.SuperNode_IP.Location = new System.Drawing.Point(77, 14);
            this.SuperNode_IP.Name = "SuperNode_IP";
            this.SuperNode_IP.Size = new System.Drawing.Size(138, 21);
            this.SuperNode_IP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务器地址";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SelfArg);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.verbose);
            this.groupBox3.Controls.Add(this.packet_forwarding);
            this.groupBox3.Controls.Add(this.http_tunneling);
            this.groupBox3.Controls.Add(this.resolve_supernode);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Dirver_Path);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Save);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Dirver_version);
            this.groupBox3.Controls.Add(this.mtu);
            this.groupBox3.Controls.Add(this.netmask);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.mac_address);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 181);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "高级设定";
            // 
            // SelfArg
            // 
            this.SelfArg.Location = new System.Drawing.Point(77, 152);
            this.SelfArg.Name = "SelfArg";
            this.SelfArg.Size = new System.Drawing.Size(215, 21);
            this.SelfArg.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "自定义参数";
            // 
            // verbose
            // 
            this.verbose.AutoSize = true;
            this.verbose.Location = new System.Drawing.Point(228, 92);
            this.verbose.Name = "verbose";
            this.verbose.Size = new System.Drawing.Size(108, 16);
            this.verbose.TabIndex = 20;
            this.verbose.Text = "启动详细数据报";
            this.verbose.UseVisualStyleBackColor = true;
            // 
            // packet_forwarding
            // 
            this.packet_forwarding.AutoSize = true;
            this.packet_forwarding.Location = new System.Drawing.Point(228, 68);
            this.packet_forwarding.Name = "packet_forwarding";
            this.packet_forwarding.Size = new System.Drawing.Size(132, 16);
            this.packet_forwarding.TabIndex = 19;
            this.packet_forwarding.Text = "允许服务器转发数据";
            this.packet_forwarding.UseVisualStyleBackColor = true;
            // 
            // http_tunneling
            // 
            this.http_tunneling.AutoSize = true;
            this.http_tunneling.Location = new System.Drawing.Point(228, 43);
            this.http_tunneling.Name = "http_tunneling";
            this.http_tunneling.Size = new System.Drawing.Size(96, 16);
            this.http_tunneling.TabIndex = 18;
            this.http_tunneling.Text = "使用HTTP隧道";
            this.http_tunneling.UseVisualStyleBackColor = true;
            // 
            // resolve_supernode
            // 
            this.resolve_supernode.AutoSize = true;
            this.resolve_supernode.Location = new System.Drawing.Point(228, 16);
            this.resolve_supernode.Name = "resolve_supernode";
            this.resolve_supernode.Size = new System.Drawing.Size(120, 16);
            this.resolve_supernode.TabIndex = 17;
            this.resolve_supernode.Text = "周期检查是否连通";
            this.resolve_supernode.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "驱动版本";
            // 
            // Dirver_Path
            // 
            this.Dirver_Path.Location = new System.Drawing.Point(77, 122);
            this.Dirver_Path.Name = "Dirver_Path";
            this.Dirver_Path.Size = new System.Drawing.Size(215, 21);
            this.Dirver_Path.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "驱动路径";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(298, 112);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(62, 36);
            this.Save.TabIndex = 13;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
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
            // Dirver_version
            // 
            this.Dirver_version.FormattingEnabled = true;
            this.Dirver_version.Location = new System.Drawing.Point(77, 95);
            this.Dirver_version.Name = "Dirver_version";
            this.Dirver_version.Size = new System.Drawing.Size(104, 20);
            this.Dirver_version.TabIndex = 4;
            this.Dirver_version.SelectedIndexChanged += new System.EventHandler(this.Dirver_version_SelectedIndexChanged);
            // 
            // mtu
            // 
            this.mtu.Location = new System.Drawing.Point(77, 68);
            this.mtu.Name = "mtu";
            this.mtu.Size = new System.Drawing.Size(104, 21);
            this.mtu.TabIndex = 8;
            // 
            // netmask
            // 
            this.netmask.Location = new System.Drawing.Point(77, 41);
            this.netmask.Name = "netmask";
            this.netmask.Size = new System.Drawing.Size(138, 21);
            this.netmask.TabIndex = 6;
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
            // mac_address
            // 
            this.mac_address.Location = new System.Drawing.Point(77, 14);
            this.mac_address.Name = "mac_address";
            this.mac_address.Size = new System.Drawing.Size(138, 21);
            this.mac_address.TabIndex = 4;
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
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpSuperNode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Text = "设定";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.gpSuperNode.ResumeLayout(false);
            this.gpSuperNode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSuperNode;
        private System.Windows.Forms.TextBox SuperNodePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SuperNode_version;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button N2N_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.ComboBox n2n_version;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Local_Port;
        private System.Windows.Forms.TextBox Local_IP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SuperNode_Port;
        private System.Windows.Forms.TextBox SuperNode_IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Dirver_Path;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Dirver_version;
        private System.Windows.Forms.TextBox mtu;
        private System.Windows.Forms.TextBox netmask;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mac_address;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox verbose;
        private System.Windows.Forms.CheckBox packet_forwarding;
        private System.Windows.Forms.CheckBox http_tunneling;
        private System.Windows.Forms.CheckBox resolve_supernode;
        private System.Windows.Forms.TextBox SuperNode_Path;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button SuperNode_Save;
        private System.Windows.Forms.TextBox SelfArg;
        private System.Windows.Forms.Label label11;
    }
}