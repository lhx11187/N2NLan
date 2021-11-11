using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using N2NLan;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace N2NService
{
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
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
            /*
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                Invoke(ReadStdOutput, new object[] { e.Data });
            }
            */
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            /*
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
            */
        }
        private void RealAction(string StartFileName, string StartFileArg)
        {
            try
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
                //  }
            }
            catch (Exception ex)
            {

            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Start();
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            Start();
            await base.StartAsync(cancellationToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            Stop();
            _logger.LogError($"Worker stopped at: {DateTime.Now}");
            await base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            Stop();
            _logger.LogInformation($"Worker disposed at: {DateTime.Now}");

            base.Dispose();
        }

        private void Start()
        {
            bool systype = false;
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
            killProcess("edge.exe");
            string sys_Path = "";
            if (systype)
                sys_Path = "\\x64\\edge.exe";
            else
                sys_Path = "\\x86\\edge.exe";
            string SuperNode_IP = IniRead("setting", "SuperNode_IP");
            //自动IP
            string Local_IP = "";
            if (IniRead("setting", "AutoIP").Trim() == "1")
            {
                Local_IP = GetIPByApi(SuperNode_IP);
                if (string.IsNullOrWhiteSpace(Local_IP))
                { 
                    Local_IP = IniRead("setting", "Local_IP"); 
                }
            }
            else
            { 
                Local_IP = IniRead("setting", "Local_IP"); 
            }
            string Group = IniRead("setting", "Group");
            string Passwd = IniRead("setting", "Passwd");

            string SuperNode_Port = IniRead("setting", "SuperNode_Port");
            string netmask = IniRead("setting", "netmask");
            string mtu = IniRead("setting", "mtu");
            string mac_address = IniRead("setting", "mac_address");
            string verbose = IniRead("setting", "verbose");
            string packet_forwarding = IniRead("setting", "packet_forwarding");
            string Local_Port = IniRead("setting", "Local_Port");
            string SelfArg = IniRead("setting", "SelfArg");
            string PIP = IniRead("setting", "PingIP");

            string appFile = AppDomain.CurrentDomain.BaseDirectory + sys_Path;
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
            if (!String.IsNullOrEmpty(SelfArg))
                arg = arg + " " + SelfArg;
            /*
            if (resolve_supernode == "1")
                arg = arg + " -b ";
            if (http_tunneling == "1")
                arg = arg + " -t";
             */
            RealAction(appFile, arg);
            Thread.Sleep(5000);
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\addroute.bat");
            //PingIP(PIP);

            try
            {
                string msg = HttpHelper.Post("https://cron.blackduck.workers.dev/n2n/setip/" + SuperNode_IP, Local_IP);
            }
            catch (Exception ex)
            {
            }
        }

        private void Stop()
        {
            killProcess("edge.exe");
            Thread.Sleep(5000);
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\stop.bat");
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

        private string IniRead(string Section, string Key)
        {
            string iniPath = AppDomain.CurrentDomain.BaseDirectory + "\\n2n.ini";

            return INIHelper.Read(Section, Key, iniPath);
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
            //this.Invoke(ReadStdOutput, new object[] { "Start" + "\r\n" });
        }
        private void PingIP(string PingIP)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\pingip.bat", "TIMEOUT /T 10 \r\n ping " + PingIP.Trim() + " -t\r\n");
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\pingip.bat");
        }

        private string GetIPByApi(string SuperNode_IP)
        {
            try
            {
                string ip = HttpHelper.GetResponseString(HttpHelper.CreateGetHttpResponse("https://cron.blackduck.workers.dev/n2n/getip/" + SuperNode_IP));
                return ip.Trim().Replace("\"", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
            }
            catch (Exception e) { }
            return "";
        }
    }
}
