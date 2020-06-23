using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace N2NWin
{
    public partial class FormSetting : Form
    {
        bool systype = false;//默认x86
        //edge
        //string edge_Path = "";
        //string SuperNode_IP = "";
        //string SuperNode_Port = "";
        //string Local_IP = "";
        //string Local_Port = "";
        //string Group = "";
        //string passwd = "";
        //string mac_address = "";
        //string netmask = "";
        //string mtu = "";
        //string n2n_version = "";
        //string http_tunneling = "";
        //string packet_forwarding = "";
        //string resolve_supernode = "";
        //string verbose = "";
        //string SN_Port = "";
        //string SN_Auto = "";

        ////SuperNode
        //string SuperNode_Path = "";
        //string SuperNode_version = "";
        //string IP = "";
        //string Port = "";

        public FormSetting()
        {
            InitializeComponent();
        }

        private void SuperNode_Save_Click(object sender, EventArgs e)
        {
            IniWrite("SuperNode", "SuperNode_version", SuperNode_version.Text.Trim());
            IniWrite("SuperNode", "Port", SuperNodePort.Text.Trim());
            IniWrite(SuperNode_version.Text, "SuperNode_Path", SuperNode_Path.Text.Trim());
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {

            List<string> version = INIHelper.GetAllSectionNames(Application.StartupPath + "\\n2n.ini");
            version.Remove("settings");
            version.Remove("SuperNode");
            SuperNode_version.Items.AddRange(version.ToArray());
            n2n_version.Items.AddRange(version.ToArray());
            Dirver_version.Items.AddRange(version.ToArray());

            SuperNode_version.SelectedText = IniRead("SuperNode", "SuperNode_version");
            SuperNodePort.Text = IniRead("SuperNode", "Port");
            SuperNode_Path.Text = IniRead(SuperNode_version.Text, "SuperNode_Path");

            SuperNode_IP.Text = IniRead("settings", "SuperNode_IP");
            SuperNode_Port.Text = IniRead("settings", "SuperNode_Port");
            Local_IP.Text = IniRead("settings", "Local_IP");
            Local_Port.Text = IniRead("settings", "Local_Port");
            Group.Text = IniRead("settings", "Group");
            passwd.Text = IniRead("settings", "passwd");
            mac_address.Text = IniRead("settings", "mac_address");
            netmask.Text = IniRead("settings", "netmask");
            mtu.Text = IniRead("settings", "mtu");
            n2n_version.SelectedText = IniRead("settings", "n2n_version");
            http_tunneling.Checked = IniRead("settings", "http_tunneling")=="1"?true:false;
            packet_forwarding.Checked = IniRead("settings", "packet_forwarding") == "1" ? true : false;
            resolve_supernode.Checked = IniRead("settings", "resolve_supernode") == "1" ? true : false;
            verbose.Checked = IniRead("settings", "verbose") == "1" ? true : false;
            Path.Text = IniRead(n2n_version.Text, "Path");

            Dirver_version.SelectedText = IniRead("settings", "n2n_version");
            Dirver_Path.Text = IniRead(Dirver_version.Text, "Dirver_Path");

            SelfArg.Text = IniRead("settings", "SelfArg");

        }

        private string IniRead(string Section, string Key)
        {
            string iniPath = Application.StartupPath + "\\n2n.ini";

            return INIHelper.Read(Section, Key, iniPath);
        }

        private void IniWrite(string Section,string Key,string Value)
        {
            string iniPath = Application.StartupPath + "\\n2n.ini";

            INIHelper.Write(Section, Key,Value,iniPath);
        }

        private void N2N_Save_Click(object sender, EventArgs e)
        {
            IniWrite("settings", "SuperNode_IP", SuperNode_IP.Text.Trim());
            IniWrite("settings", "SuperNode_Port", SuperNode_Port.Text.Trim());
            IniWrite("settings", "Local_IP", Local_IP.Text.Trim());
            IniWrite("settings", "Local_Port", Local_Port.Text.Trim());
            IniWrite("settings", "Group", Group.Text.Trim());
            IniWrite("settings", "passwd", passwd.Text.Trim());
            IniWrite("settings", "n2n_version", n2n_version.Text.Trim());
            IniWrite(n2n_version.Text, "Path", Path.Text.Trim());
        }

        private void Save_Click(object sender, EventArgs e)
        {
            IniWrite("settings", "mac_address", mac_address.Text.Trim());
            IniWrite("settings", "netmask", netmask.Text.Trim());
            IniWrite("settings", "mtu", mtu.Text.Trim());
            IniWrite("settings", "http_tunneling", http_tunneling.Checked ? "1" : "0");
            IniWrite("settings", "packet_forwarding", packet_forwarding.Checked ? "1" : "0");
            IniWrite("settings", "resolve_supernode", resolve_supernode.Checked ? "1" : "0");
            IniWrite("settings", "verbose", verbose.Checked ? "1" : "0");
            IniWrite(n2n_version.Text,"Dirver_Path", Dirver_Path.Text.Trim());
            IniWrite("settings", "SelfArg", SelfArg.Text.Trim());
        }

        private void SuperNode_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuperNode_Path.Text = IniRead(SuperNode_version.Text, "SuperNode_Path");
        }

        private void n2n_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            Path.Text = IniRead(n2n_version.Text, "Path");

            Dirver_version.Text = n2n_version.Text;
            Dirver_Path.Text = IniRead(Dirver_version.Text, "Dirver_Path");
        }

        private void Dirver_version_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dirver_Path.Text = IniRead(Dirver_version.Text, "Dirver_Path");

            n2n_version.Text = n2n_version.Text;
            Path.Text = IniRead(n2n_version.Text, "Path");

        }
    }
}
