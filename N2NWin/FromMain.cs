using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace N2NWin
{
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);

    public partial class FromMain : Form
    {
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        public event DelReadStdOutput ReadStdOutput1;
        public event DelReadErrOutput ReadErrOutput1;
        //Process CmdProcess = new Process();
        //Process CmdProcess1 = new Process();

        bool systype = false;//默认x86
        //edge
        string edge_Path = "";
        string SuperNode_IP = "";
        string SuperNode_Port = "";
        string Local_IP = "";
        string Local_Port = "";
        string Group = "";
        string passwd ="";
        string mac_address = "";
        string netmask = "";
        string mtu ="";
        string n2n_version = "";
        string http_tunneling = "";
        string packet_forwarding = "";
        string resolve_supernode = "";
        string verbose = "";
        string SelfArg = "";
        string Dirver_Path = "";
        string AutoStart = "";

        //SuperNode
        string SuperNode_Path="";
        string SuperNode_version = "";
        string SN_IP = "";
        string SN_Port = "";
        string SN_AutoStart = "";
        //cmd
        string CMD = "";

        public FromMain()
        {
            InitializeComponent();
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
            ReadStdOutput1 += new DelReadStdOutput(ReadStdOutputAction1);
            ReadErrOutput1 += new DelReadErrOutput(ReadErrOutputAction1);
        }
        private void ReadStdOutputAction(string result)
        {
            N2NLog.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            N2NLog.AppendText(result + "\r\n");
        }

        private void ReadStdOutputAction1(string result)
        {
            SNLog.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction1(string result)
        {
            SNLog.AppendText(result + "\r\n");
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void p_OutputDataReceived1(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput1, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived1(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput1, new object[] { e.Data });
            }
        }

        private void RealAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();

            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       
        }

        private void RealAction1(string StartFileName, string StartFileArg)
        {
            Process CmdProcess1 = new Process();
            CmdProcess1.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess1.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess1.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess1.StartInfo.UseShellExecute = false;
            CmdProcess1.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess1.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess1.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess1.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived1);
            CmdProcess1.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived1);

            CmdProcess1.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess1.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess1.Start();
            CmdProcess1.BeginOutputReadLine();
            CmdProcess1.BeginErrorReadLine();

            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
            //this.Invoke(ReadStdOutput, new object[] { "Start" + "\r\n" });
        }

        private void BT_Start_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            ReadSetting(n2n_version);
            string sys_Path = "";
            if (systype)
                sys_Path = "\\x64\\" + edge_Path;
            else
                sys_Path = "\\x86\\" + edge_Path;
            if (BT_Start.Text == "启动")
            {
                BT_Start.Text = "停止";
                //BT_SuperNode.Enabled = false;
                //BT_Setting.Enabled = false;
                BT_Start.Image = N2NWin.Properties.Resources.stop_green;
                //CMD = Application.StartupPath + edge_Path + " -a " + Local_IP + " -c " + Group + " -k " + passwd + " -l " + SuperNode_IP + ":" + SuperNode_Port;
                //Log.Text = ExecCMD.ExeCMD(CMD);
                string appFile = Application.StartupPath + sys_Path;
                string arg = " -a " + Local_IP + " -c " + Group + " -k " + passwd + " -l " + SuperNode_IP + ":" + SuperNode_Port;
                if (resolve_supernode == "1")
                    arg = arg + " -b ";
                if (!String.IsNullOrWhiteSpace(Local_Port) && Local_Port!="0")
                    arg = arg + " -p" + Local_Port;
                if (!String.IsNullOrWhiteSpace(netmask))
                    arg = arg + " -s " + netmask;
                if (!String.IsNullOrWhiteSpace(mac_address))
                    arg = arg + " -m " + mac_address;
                if (!String.IsNullOrWhiteSpace(mtu))
                    arg = arg + " -M " + mtu;
                if (http_tunneling == "1")
                    arg = arg + " -t";
                if (packet_forwarding == "1")
                    arg = arg + " -r";
                if (verbose == "1")
                    arg = arg + " -v";
                if (!String.IsNullOrWhiteSpace(SelfArg))
                    arg = arg + " " + SelfArg;
                RealAction(appFile, arg);
                Thread.Sleep(1000);
                RealAction(Application.StartupPath + "\\addroute.bat","");
                N2NLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + "Start" + "\r\n");
            }
            else 
            {
                BT_Start.Text = "启动";
                BT_Start.Image = N2NWin.Properties.Resources.bullet_start;
                killProcess(edge_Path);
                //CmdProcess.CancelOutputRead();
                //CmdProcess.CancelErrorRead();
                //CmdProcess.Close();
                //CmdProcess.Dispose();

                N2NLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + "Stop" + "\r\n");
            }
        }

        private void killProcess(string proName)
        {
            Process[] pro = Process.GetProcesses();//获取已开启的所有进程

            //遍历所有查找到的进程

            for (int i = 0; i < pro.Length; i++)
            {

                //判断此进程是否是要查找的进程
                if (pro[i].ProcessName.ToString().ToLower() == proName.ToLower().Replace(".exe",""))
                {
                    pro[i].Kill();//结束进程
                }
            }
        }

        private void ReadSetting(string Version)
        {
            SuperNode_IP = IniRead(Version, "SuperNode_IP");
            SuperNode_Port = IniRead(Version, "SuperNode_Port");
            Local_IP = IniRead(Version, "Local_IP");
            Local_Port = IniRead(Version, "Local_Port");
            Group = IniRead(Version, "Group");
            passwd = IniRead(Version, "passwd");
            mac_address = IniRead(Version, "mac_address");
            netmask = IniRead(Version, "netmask");
            mtu = IniRead(Version, "mtu");
            n2n_version = IniRead(Version, "n2n_version");
            http_tunneling = IniRead(Version, "http_tunneling");
            packet_forwarding = IniRead(Version, "packet_forwarding");
            resolve_supernode = IniRead(Version, "resolve_supernode");
            verbose = IniRead(Version, "verbose");
            SelfArg = IniRead(Version, "SelfArg");
            Dirver_Path = IniRead(Version, "Dirver_Path");
            AutoStart = IniRead(Version, "AutoStart");
            edge_Path = IniRead(Version, "Path");



            SuperNode_Path = IniRead(Version, "SN_Path");
            SuperNode_version = IniRead(Version, "n2n_version");
            SN_IP = IniRead(Version, "SN_IP");
            SN_Port = IniRead(Version, "SN_Port");
            SN_AutoStart = IniRead(Version, "SN_AutoStart");

            switch (Version)
            {
                case "V1":
                    RB_SettingV1.Checked = true;
                    break;
                case "V2":
                    RB_SettingV2.Checked = true;
                    break;
                case "V21":
                    RB_SettingV21.Checked = true;
                    break;
                default:
                    RB_SettingOther.Checked = true;
                    break;
            }
            
            TB_SuperNode_IP.Text = SuperNode_IP;
            TB_SuperNode_Port.Text = SuperNode_Port;
            TB_Local_IP.Text = Local_IP;
            TB_Local_Port.Text = Local_Port;
            TB_Group.Text = Group;
            TB_passwd.Text = passwd;
            TB_N2NPath.Text = edge_Path;

            TB_mac_address.Text = mac_address;
            TB_netmask.Text = netmask;
            TB_mtu.Text = mtu;
            TB_SelfArg.Text = SelfArg;

            if (resolve_supernode == "1")
                CB_resolve_supernode.Checked = true;
            else
                CB_resolve_supernode.Checked = false;
            if (http_tunneling == "1")
                CB_http_tunneling.Checked = true;
            else
                CB_http_tunneling.Checked = false;
            if (packet_forwarding == "1")
                CB_packet_forwarding.Checked = true;
            else
                CB_packet_forwarding.Checked = false;
            if (verbose == "1")
                CB_verbose.Checked = true;
            else
                CB_verbose.Checked = false;


            TB_SN_IP.Text = SN_IP;
            TB_SN_Port.Text = SN_Port;
            TB_SN_Path.Text = SuperNode_Path;
            //if (AutoStart == "1")
            //    CB_N2NAuto.Checked = true;
            //else
            //    CB_N2NAuto.Checked = false;

            //if (SN_AutoStart == "1")
            //    CB_SNAuto.Checked = true;
            //else
            //    CB_SNAuto.Checked = false;

            //switch (Version)
            //{
            //    case "V1":
            //        RB_N2NV1.Checked = true;
            //        RB_SNV1.Checked = true;
            //        RB_SettingV1.Checked = true;
            //        break;
            //    case "V2":
            //        RB_N2NV2.Checked = true;
            //        RB_SNV2.Checked = true;
            //        RB_SettingV2.Checked = true;
            //        break;
            //    case "V21":
            //        RB_N2NV21.Checked = true;
            //        RB_SNV21.Checked = true;
            //        RB_SettingV21.Checked = true;
            //        break;
            //    default:
            //        RB_N2NOther.Checked = true;
            //        RB_SNOther.Checked = true;
            //        RB_SettingOther.Checked = true;
            //        break;
            //} 

        }

        private void BT_SuperNode_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            if (BT_SuperNode.Text == "启动超级节点")
            {
                BT_SuperNode.Text = "停止超级节点";
                BT_SuperNode.Image = N2NWin.Properties.Resources.stop_green;
                //supernode -l 82 >> /volume1/log/v1 2>&1 &
                string sys_Path = "";
                if (systype)
                    sys_Path = "\\x64\\" + SuperNode_Path;
                else
                    sys_Path = "\\x86\\" + SuperNode_Path;

                //CMD = Application.StartupPath + SuperNode_Path + " -l " + Port;
                //Log.Text = ExecCMD.ExeCMD(CMD);
                string appFile = Application.StartupPath + sys_Path;
                string arg = " -l " + SN_Port;
                RealAction1(appFile, arg);
                SNLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + "SuperNode Start" + "\r\n");
            }
            else
            {
                BT_SuperNode.Text = "启动超级节点";
                BT_SuperNode.Image = N2NWin.Properties.Resources.arrow_nw_ne_sw_se;

                //CmdProcess1.CancelOutputRead();
                //CmdProcess1.CancelErrorRead();
                //CmdProcess1.Close();
                killProcess(SuperNode_Path);
                SNLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + "SuperNode Stop" + "\r\n");
            }
        }

        private void BT_Setting_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            //FormSetting FS = new FormSetting();
            //FS.ShowDialog();
        }

        private void FromMain_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
            else 
            { 
                this.ShowInTaskbar = true; 
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void FromMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                killProcess(edge_Path);
                killProcess(SuperNode_Path);
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            } 
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            systype = Environment.Is64BitOperatingSystem;//true是x64
            //开机启动
            if (IniRead("setting", "Auto").Trim() == "1")
                CB_Auto.Checked = true;
            else
                CB_Auto.Checked = false;
            //自动隐藏
            if (IniRead("setting", "AutoMin").Trim() == "1")
            {
                CB_Min.Checked = true;
                this.WindowState = FormWindowState.Minimized; 
            }
            else
                CB_Min.Checked = false;
            //
            n2n_version = IniRead("setting", "n2n_version");
            ReadSetting(n2n_version);
            switch (n2n_version)
            {
                case "V1":
                    RB_N2NV1.Checked = true;
                    break;
                case "V2":
                    RB_N2NV2.Checked = true;
                    break;
                case "V21":
                    RB_N2NV21.Checked = true;
                    break;
                default:
                    RB_N2NOther.Checked = true;
                    break;
            } 
            if (AutoStart == "1")
            {
                BT_Start_Click(sender,e);
            }
            SuperNode_version = IniRead("setting", "SN_version");
            ReadSetting(SuperNode_version);
            switch (SuperNode_version)
            {
                case "V1":
                    RB_SNV1.Checked = true;
                    break;
                case "V2":
                    RB_SNV2.Checked = true;
                    break;
                case "V21":
                    RB_SNV21.Checked = true;
                    break;
                default:
                    RB_SNOther.Checked = true;
                    break;
            } 
            if (SN_AutoStart == "1")
            {
                BT_SuperNode_Click(sender, e);
            }

        }

        private string IniRead (string Section,string Key)
        {
            string iniPath = Application.StartupPath + "\\n2n.ini";

            return INIHelper.Read(Section, Key, iniPath);
        }

        private void IniWrite(string Section, string Key, string Value)
        {
            string iniPath = Application.StartupPath + "\\n2n.ini";

            INIHelper.Write(Section, Key, Value, iniPath);
        }

        private void BT_SetupDirver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            //try
            //{
            //    n2n_version = IniRead("settings", "n2n_version");
            //    string Dirver_Path = IniRead(n2n_version, "Dirver_Path");
            //    Process pr = new Process();//声明一个进程类对象
            //    pr.StartInfo.FileName = Application.StartupPath + Dirver_Path;
            //    //if (systype)
            //    //    pr.StartInfo.FileName = Application.StartupPath + "\\driver\\NDIS6_x64\\tapinstall.exe";
            //    //else
            //    //    pr.StartInfo.FileName = Application.StartupPath + "\\driver\\NDIS6_x86\\tapinstall.exe";
            //    pr.Start();
            //}
            //catch (Exception ex)
            //{
            //    //Log.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + ex);
            //}
        }

        private void BT_About_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void CB_Auto_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Auto.Checked) //设置开机自启动  
            {
                MessageBox.Show("设置开机自启动，需要修改注册表", "提示");
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.SetValue("JcShutdown", path);
                rk2.Close();
                rk.Close();
                IniWrite("setting", "Auto", "1");
            }
            else //取消开机自启动  
            {
                MessageBox.Show("取消开机自启动，需要修改注册表", "提示");
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.DeleteValue("JcShutdown", false);
                rk2.Close();
                rk.Close();
                IniWrite("setting", "Auto", "0");
            }  
        }

        private void CB_Min_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Min.Checked)
                IniWrite("setting", "AutoMin", "1");
            else
                IniWrite("setting", "AutoMin", "0");
        }

        private void BT_SettingSave_Click(object sender, EventArgs e)
        {
            BT_Start.Text = "启动";
            BT_Start.Image = N2NWin.Properties.Resources.bullet_start;
            killProcess(edge_Path);

            BT_SuperNode.Text = "启动超级节点";
            BT_SuperNode.Image = N2NWin.Properties.Resources.arrow_nw_ne_sw_se;
            killProcess(SuperNode_Path);

            //SuperNode_IP = IniRead(Version, "SuperNode_IP");
            //SuperNode_Port = IniRead(Version, "SuperNode_Port");
            //Local_IP = IniRead(Version, "Local_IP");
            //Local_Port = IniRead(Version, "Local_Port");
            //Group = IniRead(Version, "Group");
            //passwd = IniRead(Version, "passwd");
            //mac_address = IniRead(Version, "mac_address");
            //netmask = IniRead(Version, "netmask");
            //mtu = IniRead(Version, "mtu");
            //n2n_version = IniRead(Version, "n2n_version");
            //http_tunneling = IniRead(Version, "http_tunneling");
            //packet_forwarding = IniRead(Version, "packet_forwarding");
            //resolve_supernode = IniRead(Version, "resolve_supernode");
            //verbose = IniRead(Version, "verbose");
            //SelfArg = IniRead(Version, "SelfArg");
            //Dirver_Path = IniRead(Version, "Dirver_Path");
            //AutoStart = IniRead(Version, "AutoStart");
            //edge_Path = IniRead(Version, "Path");



            //SuperNode_Path = IniRead(Version, "SN_Path");
            //SuperNode_version = IniRead(Version, "n2n_version");
            //SN_IP = IniRead(Version, "SN_IP");
            //SN_Port = IniRead(Version, "SN_Port");
            //SN_AutoStart = IniRead(Version, "SN_AutoStart");
            IniWrite(n2n_version, "SuperNode_IP", TB_SuperNode_IP.Text);
            IniWrite(n2n_version, "SuperNode_Port", TB_SuperNode_Port.Text);
            IniWrite(n2n_version, "Local_IP", TB_Local_IP.Text);
            IniWrite(n2n_version, "Local_Port", TB_Local_Port.Text);
            IniWrite(n2n_version, "Group", TB_Group.Text);
            IniWrite(n2n_version, "passwd", TB_passwd.Text);
            IniWrite(n2n_version, "mac_address", TB_mac_address.Text);
            IniWrite(n2n_version, "netmask", TB_netmask.Text);
            IniWrite(n2n_version, "mtu", TB_mtu.Text);
            IniWrite(n2n_version, "http_tunneling", CB_http_tunneling.Checked?"1":"0");
            IniWrite(n2n_version, "packet_forwarding", CB_packet_forwarding.Checked ? "1" : "0");
            IniWrite(n2n_version, "resolve_supernode", CB_resolve_supernode.Checked ? "1" : "0");
            IniWrite(n2n_version, "verbose", CB_verbose.Checked ? "1" : "0");
            IniWrite(n2n_version, "SelfArg", TB_SelfArg.Text);
            IniWrite(n2n_version, "Path", TB_N2NPath.Text);

            IniWrite(SuperNode_version, "SN_IP", TB_SN_IP.Text);
            IniWrite(SuperNode_version, "SN_Port", TB_SN_Port.Text);
            IniWrite(SuperNode_version, "SN_Path", TB_SN_Path.Text);

        }

        private void CB_N2NAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_N2NAuto.Checked)
                IniWrite(n2n_version,"AutoStart", "1");
            else
                IniWrite(n2n_version, "AutoStart", "0");
        }

        private void CB_SNAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_SNAuto.Checked)
                IniWrite(SuperNode_version, "SN_AutoStart", "1");
            else
                IniWrite(SuperNode_version, "SN_AutoStart", "0");
        }

        private void RB_N2NV1_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_N2NV1.Checked)
            {
                n2n_version = "V1";
                IniWrite("setting", "n2n_version", "V1");
                ReadSetting("V1");
                if (AutoStart == "1")
                    CB_N2NAuto.Checked = true;
                else
                    CB_N2NAuto.Checked = false;
            }
        }

        private void RB_N2NV2_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_N2NV2.Checked)
            {
                n2n_version = "V2";
                IniWrite("setting", "n2n_version", "V2");
                ReadSetting("V2");
                if (AutoStart == "1")
                    CB_N2NAuto.Checked = true;
                else
                    CB_N2NAuto.Checked = false;
            }
        }

        private void RB_N2NV21_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_N2NV21.Checked)
            {
                n2n_version = "V21";
                IniWrite("setting", "n2n_version", "V21");
                ReadSetting("V21");
                if (AutoStart == "1")
                    CB_N2NAuto.Checked = true;
                else
                    CB_N2NAuto.Checked = false;
            }
        }

        private void RB_N2NOther_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_N2NOther.Checked)
            {
                n2n_version = CB_N2NOther.Text;
                IniWrite("setting", "n2n_version", CB_N2NOther.Text);
                ReadSetting(CB_N2NOther.Text);
                if (AutoStart == "1")
                    CB_N2NAuto.Checked = true;
                else
                    CB_N2NAuto.Checked = false;
            }
        }

        private void RB_SNV1_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SNV1.Checked)
            {
                SuperNode_version = "V1";
                IniWrite("setting", "SN_version", "V1");
                ReadSetting("V1");
                if (SN_AutoStart == "1")
                    CB_SNAuto.Checked = true;
                else
                    CB_SNAuto.Checked = false;
            }
        }

        private void RB_SNV2_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SNV2.Checked)
            {
                SuperNode_version = "V2";
                IniWrite("setting", "SN_version", "V2");
                ReadSetting("V2");
                if (SN_AutoStart == "1")
                    CB_SNAuto.Checked = true;
                else
                    CB_SNAuto.Checked = false;
            }
        }

        private void RB_SNV21_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SNV21.Checked)
            {
                SuperNode_version = "V21";
                IniWrite("setting", "SN_version", "V21");
                ReadSetting("V21");
                if (SN_AutoStart == "1")
                    CB_SNAuto.Checked = true;
                else
                    CB_SNAuto.Checked = false;
            }
        }

        private void RB_SNOther_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SNOther.Checked)
            {
                SuperNode_version = CB_SNOther.Text;
                IniWrite("setting", "SN_version", CB_SNOther.Text);
                ReadSetting(CB_SNOther.Text);
                if (SN_AutoStart == "1")
                    CB_SNAuto.Checked = true;
                else
                    CB_SNAuto.Checked = false;
            }
        }

        private void RB_SettingV1_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SettingV1.Checked)
            {
                ReadSetting("V1");
            }
        }

        private void RB_SettingV2_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SettingV2.Checked)
            {
                ReadSetting("V2");
            }
        }

        private void RB_SettingV21_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_SettingV21.Checked)
            {
                ReadSetting("V21");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
