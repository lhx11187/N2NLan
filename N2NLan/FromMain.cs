using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace N2NLan
{
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);
    public partial class FromMain : Form
    {
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        bool systype = false;
        public FromMain()
        {
            InitializeComponent();
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }
        private void ReadStdOutputAction(string result)
        {
            //N2NLog.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            //N2NLog.AppendText(result + "\r\n");
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

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
            //this.Invoke(ReadStdOutput, new object[] { "Start" + "\r\n" });
        }

        private string IniRead(string Section, string Key)
        {
            string iniPath = Application.StartupPath + "\\n2n.ini";

            return INIHelper.Read(Section, Key, iniPath);
        }

        private void IniWrite(string Section, string Key, string Value)
        {
            string iniPath = Application.StartupPath + "\\n2n.ini";

            INIHelper.Write(Section, Key, Value, iniPath);
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            if (IntPtr.Size == 8)
            {
                systype = true;//64 bit
            }
            else if (IntPtr.Size == 4)
            {
                systype = false;//32 bit
            }
            else
            {
                //...NotSupport
            }


            //systype = Environment.Is64BitOperatingSystem;//true是x64
            TB_SuperNode_IP.Text = IniRead("setting", "SuperNode_IP");
            TB_SuperNode_Port.Text = IniRead("setting", "SuperNode_Port");
            TB_Local_IP.Text = IniRead("setting", "Local_IP");
            TB_Local_Port.Text = IniRead("setting", "Local_Port");
            TB_Group.Text = IniRead("setting", "Group");
            TB_Passwd.Text = IniRead("setting", "Passwd");
            //开机启动
            if (IniRead("setting", "Auto").Trim() == "1")
            {
                CB_Auto.Checked = true;
                BT_Start_Click(sender, e);
            }
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

        }

        private void FromMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                killProcess("edge.exe");
                //killProcess(SuperNode_Path);
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void BT_Start_Click(object sender, EventArgs e)
        {
            killProcess("edge.exe");
            string sys_Path = "";
            if (systype)
                sys_Path = "\\x64\\edge.exe";
            else
                sys_Path = "\\x86\\edge.exe";
            if (BT_Start.Text == "启动")
            {
                BT_Start.Text = "停止";
                BT_Start.BackColor = Color.Red;

                //CMD = Application.StartupPath + edge_Path + " -a " + Local_IP + " -c " + Group + " -k " + passwd + " -l " + SuperNode_IP + ":" + SuperNode_Port;
                //Log.Text = ExecCMD.ExeCMD(CMD);

                string Local_IP = TB_Local_IP.Text;
                string Group = TB_Group.Text;
                string Passwd = TB_Passwd.Text;
                string SuperNode_IP = TB_SuperNode_IP.Text;
                string SuperNode_Port = TB_SuperNode_Port.Text;
                string netmask = IniRead("setting", "netmask");
                string mtu = IniRead("setting", "mtu");
                string mac_address = IniRead("setting", "mac_address");
                string verbose = IniRead("setting", "verbose");
                string packet_forwarding = IniRead("setting", "packet_forwarding");
                string Local_Port = TB_Local_Port.Text;

                string appFile = Application.StartupPath + sys_Path;
                string arg = " -a " + Local_IP + " -c " + Group + " -k " + Passwd + " -l " + SuperNode_IP + ":" + SuperNode_Port;

                if (!String.IsNullOrEmpty(netmask))
                    arg = arg + " -s " + netmask;
                if (!String.IsNullOrEmpty(Local_Port) && Local_Port != "0")
                    arg = arg + " -p" + Local_Port;
                if (!String.IsNullOrEmpty(mtu))
                    arg = arg + " -M " + mtu;
                if (!String.IsNullOrEmpty(mac_address))
                    arg = arg + " -m " + mac_address;
                if (verbose == "1")
                    arg = arg + " -v";
                if (packet_forwarding == "1")
                    arg = arg + " -r";
                /*
                if (resolve_supernode == "1")
                    arg = arg + " -b ";
                if (http_tunneling == "1")
                    arg = arg + " -t";
                if (!String.IsNullOrWhiteSpace(SelfArg))
                    arg = arg + " " + SelfArg;
                 */
                RealAction(appFile, arg);
                //N2NLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + "Start" + "\r\n");
            }
            else
            {
                BT_Start.Text = "启动";
                BT_Start.BackColor = Color.Green;

                killProcess("edge.exe");
                //N2NLog.AppendText(DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss:") + "Stop" + "\r\n");
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("", TB_Local_IP.Text);
            string msg = HttpHelper.GetResponseString(HttpHelper.CreatePostHttpResponse("http://n2n.gearhostpreview.com/api/N2N/", dic));

        }

        private void killProcess(string proName)
        {
            try
            {
                Process[] pro = Process.GetProcesses();//获取已开启的所有进程

                //遍历所有查找到的进程

                for (int i = 0; i < pro.Length; i++)
                {

                    //判断此进程是否是要查找的进程
                    if (pro[i].ProcessName.ToString().ToLower() == proName.ToLower().Replace(".exe", ""))
                    {
                        pro[i].Kill();//结束进程
                    }
                }
            }
            catch (Exception e)
            { 

            }
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            IniWrite("setting", "SuperNode_IP", TB_SuperNode_IP.Text.Trim());
            IniWrite("setting", "SuperNode_Port", TB_SuperNode_Port.Text.Trim());
            IniWrite("setting", "Local_IP", TB_Local_IP.Text.Trim());
            IniWrite("setting", "Local_Port", TB_Local_Port.Text.Trim());
            IniWrite("setting", "Group", TB_Group.Text.Trim());
            IniWrite("setting", "Passwd", TB_Passwd.Text.Trim());

            IniWrite("setting", "Auto", CB_Auto.Checked ?"1":"0");
            IniWrite("setting", "AutoMin", CB_Min.Checked ? "1" : "0");
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CMS.Show();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            killProcess("edge.exe");
            this.Dispose();
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("QQ群256572040", "关于");
            if (dr == DialogResult.OK)
            {
                Process.Start("https://jq.qq.com/?_wv=1027&k=XNoS1gbD");
            }

        }

        private void BT_Random_Click(object sender, EventArgs e)
        {
            string ip = HttpHelper.GetResponseString(HttpHelper.CreateGetHttpResponse("http://n2n.gearhostpreview.com/api/N2N/"));
            TB_Local_IP.Text = ip.Trim().Replace("\"", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
            BT_Save_Click(sender, e);
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://n2n.gearhostpreview.com/readme.html");
        }
    }
}
