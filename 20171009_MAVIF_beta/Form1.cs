using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;

namespace _20171009_MAVIF_beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 获取应用图标
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon
            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
            [DllImport("shell32.dll")]
            public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);
        }
        // 引用完毕

        static string _M = "null", _A = "null", _V = "null", _F = "null";
        static string cmdOutput;
        static string aDir = "ApacheMonitor.exe", fDir = "FileZilla Server Interface.exe", vDir = "vmware.exe";

        private void btnMRun_Click(object sender, EventArgs e)
        {
            gMySQL.Text = " MySQL [ Starting Service... ]";
            gMySQL.Refresh();
            StartStopService(labMSNTxt.Text, "R");
            gMySQL.Text = " MySQL ";
            GetServiceInfo();
        }

        private void btnMStop_Click(object sender, EventArgs e)
        {
            gMySQL.Text = " MySQL [ Stopping Service... ]";
            gMySQL.Refresh();
            StartStopService(labMSNTxt.Text, "S");
            gMySQL.Text = " MySQL ";
            GetServiceInfo();
        }

        private void RunCMD(string cmdStr, string writeConsole)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
            p.Start();                                  //启动程序
            p.StandardInput.WriteLine(cmdStr + " &exit");
            p.StandardInput.AutoFlush = true;
            cmdOutput = p.StandardOutput.ReadToEnd();

            // 删去无用命令行代码
            cmdOutput = cmdOutput.Substring(cmdOutput.IndexOf("\r\n"));
            cmdOutput = cmdOutput.TrimStart("\r\n".ToCharArray());
            cmdOutput = cmdOutput.Substring(cmdOutput.IndexOf("\r\n"));
            cmdOutput = cmdOutput.TrimStart("\r\n".ToCharArray());
            cmdOutput = cmdOutput.Substring(cmdOutput.IndexOf("\r\n"));
            cmdOutput = cmdOutput.TrimStart("\r\n".ToCharArray());
            cmdOutput = cmdOutput.TrimEnd("\r\n".ToCharArray());

            p.WaitForExit();
            p.Close();
            if (writeConsole == "Y")
                PrintConsole(cmdOutput);
        }

        private void PrintConsole(string str)
        {
            textConsole.Text += "\r\n\r\n[ " + DateTime.Now.ToString() + " ]\r\n" + str;
        }

        private void btnARun_Click(object sender, EventArgs e)
        {
            gApache.Text = " Apache [ Starting Service... ]";
            gApache.Refresh();
            StartStopService(labASNTxt.Text, "R");
            gApache.Text = " Apache ";
            GetServiceInfo();
        }

        private void btnAStop_Click(object sender, EventArgs e)
        {
            gApache.Text = " Apache [ Stopping Service... ]";
            gApache.Refresh();
            StartStopService(labASNTxt.Text, "S");
            gApache.Text = " Apache ";
            GetServiceInfo();
        }

        private void btnFRun_Click(object sender, EventArgs e)
        {
            gFileZilla.Text = " FileZilla Server [ Starting Service... ]";
            gFileZilla.Refresh();
            StartStopService(labFSNTxt.Text, "R");
            gFileZilla.Text = " FileZilla Server ";
            GetServiceInfo();
        }

        private void btnFStop_Click(object sender, EventArgs e)
        {
            gFileZilla.Text = " FileZilla Server [ Stopping Service... ]";
            gFileZilla.Refresh();
            StartStopService(labFSNTxt.Text, "S");
            gFileZilla.Text = " FileZilla Server ";
            GetServiceInfo();
        }

        private void textConsole_TextChanged(object sender, EventArgs e)
        {
            textConsole.SelectionStart = textConsole.Text.Length;
            textConsole.ScrollToCaret();
        }

        private void btnRunServices_Click(object sender, EventArgs e)
        {
            RunCMD("services.msc", "Y");
            textConsole.Text += "Start Services.msc";
        }

        private void btnVNATRun_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Starting Service... ]";
            gVMware.Refresh();
            StartStopService(labVNATTxt.Text, "R");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVRemoteDisable_Click(object sender, EventArgs e)
        {
            RunCMD("sc config " + labVRemoteTxt.Text + " start= disabled", "Y");
            btnVRemoteDisable.Enabled = false;
        }

        private void btnVDHCPRun_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Starting Service... ]";
            gVMware.Refresh();
            StartStopService(labVDHCPTxt.Text, "R");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVUnityRun_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Starting Service... ]";
            gVMware.Refresh();
            StartStopService(labVUnityTxt.Text, "R");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVUSBRun_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Starting Service... ]";
            gVMware.Refresh();
            StartStopService(labVUSBTxt.Text, "R");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVNATStop_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Stopping Service... ]";
            gVMware.Refresh();
            StartStopService(labVNATTxt.Text, "S");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVDHCPStop_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Stopping Service... ]";
            gVMware.Refresh();
            StartStopService(labVDHCPTxt.Text, "S");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVUnityStop_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Stopping Service... ]";
            gVMware.Refresh();
            StartStopService(labVUnityTxt.Text, "S");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVUSBStop_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Stopping Service... ]";
            gVMware.Refresh();
            StartStopService(labVUSBTxt.Text, "S");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void btnVRemoteStop_Click(object sender, EventArgs e)
        {
            gVMware.Text = " VMware Workstation [ Stopping Service... ]";
            gVMware.Refresh();
            StartStopService(labVRemoteTxt.Text, "S");
            gVMware.Text = " VMware Workstation ";
            GetServiceInfo();
        }

        private void labVNATTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labVNATTxt.Text+"\"", "Y");
        }

        private void labVDHCPTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labVDHCPTxt.Text + "\"", "Y");
        }

        private void labVUnityTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labVUnityTxt.Text + "\"", "Y");
        }

        private void labVUSBTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labVUSBTxt.Text + "\"", "Y");
        }

        private void labVRemoteTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labVRemoteTxt.Text + "\"", "Y");
        }

        private void StartStopService(string serviceName, string strTarget)
        {
            if (strTarget == "R")
                RunCMD("net start \"" + serviceName + "\"", "Y");
            if (strTarget == "S")
                RunCMD("net stop \"" + serviceName + "\"", "Y");
        }

        private void labMSNTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labMSNTxt.Text + "\"", "Y");
        }

        private void labASNTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labASNTxt.Text + "\"", "Y");
        }

        private void labFSNTxt_DoubleClick(object sender, EventArgs e)
        {
            RunCMD("sc qdescription \"" + labFSNTxt.Text + "\"", "Y");
        }

        private void tBLanIP1_TextChanged(object sender, EventArgs e)
        {
            
            if (tBLanIP1.Text.Length>0 && tBLanIP1.Text.Substring(tBLanIP1.Text.Length - 1, 1) == ".")
            {
                tBLanIP1.Text = tBLanIP1.Text.Substring(0, tBLanIP1.Text.Length - 1);
                tBLanIP2.Focus();
            }
            tBLanIP1.Text = Regex.Replace(tBLanIP1.Text, @"[^\d]*", "");
            if (tBLanIP1.Text.Length >= 3)
            {
                if (int.Parse(tBLanIP1.Text) > 255)
                    tBLanIP1.Text = "255";
                tBLanIP2.Focus();
            }   
        }

        private void tBLanIP2_TextChanged(object sender, EventArgs e)
        {
            
            if (tBLanIP2.Text.Length > 0 && tBLanIP2.Text.Substring(tBLanIP2.Text.Length - 1, 1) == ".")
            {
                tBLanIP2.Text = tBLanIP2.Text.Substring(0, tBLanIP2.Text.Length - 1);
                tBLanIP3.Focus();
            }
            tBLanIP2.Text = Regex.Replace(tBLanIP2.Text, @"[^\d]*", "");
            if (tBLanIP2.Text.Length >= 3)
            {
                if (int.Parse(tBLanIP2.Text) > 255)
                    tBLanIP2.Text = "255";
                tBLanIP3.Focus();
            }
        }

        private void tBLanIP3_TextChanged(object sender, EventArgs e)
        {
            
            if (tBLanIP3.Text.Length > 0 && tBLanIP3.Text.Substring(tBLanIP3.Text.Length - 1, 1) == ".")
            {
                tBLanIP3.Text = tBLanIP3.Text.Substring(0, tBLanIP3.Text.Length - 1);
                tBLanIP4.Focus();
            }
            tBLanIP3.Text = Regex.Replace(tBLanIP3.Text, @"[^\d]*", "");
            if (tBLanIP3.Text.Length >= 3)
            {
                if (int.Parse(tBLanIP3.Text) > 255)
                    tBLanIP3.Text = "255";
                tBLanIP4.Focus();
            }
        }

        private void tBLanIP4_TextChanged(object sender, EventArgs e)
        {
            tBLanIP4.Text = Regex.Replace(tBLanIP4.Text, @"[^\d]*", "");
            if (tBLanIP4.Text.Length >= 3)
            {
                if (int.Parse(tBLanIP4.Text) > 255)
                    tBLanIP4.Text = "255";
                btnISetIP.Focus();
            }
        }

        private void btnRunNetwork_Click(object sender, EventArgs e)
        {
            RunCMD(@"%windir%\system32\control.exe /name Microsoft.NetworkAndSharingCenter", "N");
            PrintConsole("打开  网络与共享中心");
            //Process.Start("RunDLL32.exe", "shell32.dll,Control_RunDLL ncpa.cpl");
        }

        private void btnRunApache_Click(object sender, EventArgs e)
        {
            Process.Start(@aDir);
            PrintConsole("打开  Apache Monitor");
        }

        private void btnRunFileZilla_Click(object sender, EventArgs e)
        {
            Process.Start(@fDir);
            PrintConsole("打开  FileZilla Server");
        }

        private void cBoxI_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIPInfo(cBoxI.Text);
            if (labIStatus.Text != "已连接")
            {
                SetIPED("D");
                SetIPInputED("D");
                labIInfoTxt.Text = "---\r\n---\r\n---\r\n---";
                SetConfBtnColor(0);
            }
            //if (labIStatus.Text == "已连接" && labIInfoTxt.Text != "---\r\n---\r\n---\r\n---") 
            //{
            //    SetIPED("E");
            //}
            if (cBoxI.Text == "")
                timer1.Enabled = true;
        }

        private void btnRunVMware_Click(object sender, EventArgs e)
        {
            Process.Start(@vDir);
            PrintConsole("打开  VMware Workstation");
        }

        private void GetServiceInfo()
        {
            var serviceControllers = ServiceController.GetServices();
            foreach (var service in serviceControllers)
            {
                // MySQL
                if (service.DisplayName.Contains("MySQL"))
                {
                    _M = service.ServiceName;
                    labMSNTxt.ForeColor = SystemColors.ControlText;
                    labMSNTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labMSNTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString()=="Running")
                        labMStatusTxt.ForeColor = Color.Blue;
                    else
                        labMStatusTxt.ForeColor = Color.Red;
                    labMStatusTxt.Text = service.Status.ToString();

                    if (service.CanStop == true)
                    {
                        btnMStop.Enabled = true;
                        btnMRun.Enabled = false;
                    }
                    else
                    {
                        btnMStop.Enabled = false;
                        btnMRun.Enabled = true;
                    }
                }

                // Apache
                if (service.DisplayName.Contains("Apache"))
                {
                    _A = service.ServiceName;
                    labASNTxt.ForeColor = SystemColors.ControlText;
                    labASNTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labASNTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labAStatusTxt.ForeColor = Color.Blue;
                    else
                        labAStatusTxt.ForeColor = Color.Red;
                    labAStatusTxt.Text = service.Status.ToString();

                    if (service.CanStop == true)
                    {
                        btnAStop.Enabled = true;
                        btnARun.Enabled = false;
                    }
                    else
                    {
                        btnAStop.Enabled = false;
                        btnARun.Enabled = true;
                    }
                }

                // FileZilla Server
                if (service.DisplayName.Contains("FileZilla Server"))
                {
                    _F = service.ServiceName;
                    labFSNTxt.ForeColor = SystemColors.ControlText;
                    labFSNTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labFSNTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labFStatusTxt.ForeColor = Color.Blue;
                    else
                        labFStatusTxt.ForeColor = Color.Red;
                    labFStatusTxt.Text = service.Status.ToString();

                    if (service.CanStop == true)
                    {
                        btnFStop.Enabled = true;
                        btnFRun.Enabled = false;
                    }
                    else
                    {
                        btnFStop.Enabled = false;
                        btnFRun.Enabled = true;
                    }
                }

                // VMware Workstation - NAT
                if (service.DisplayName.Contains("VMware NAT"))
                {
                    _V = service.ServiceName;
                    labVNATTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labVNATTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labVNATTxt.ForeColor = Color.Blue;
                    else
                        labVNATTxt.ForeColor = Color.Red;

                    if (service.CanStop == true)
                    {
                        btnVNATStop.Enabled = true;
                        btnVNATRun.Enabled = false;
                    }
                    else
                    {
                        btnVNATStop.Enabled = false;
                        btnVNATRun.Enabled = true;
                    }
                }
                // VMware Workstation - DHCP
                if (service.DisplayName.Contains("VMware DHCP"))
                {
                    labVDHCPTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labVDHCPTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labVDHCPTxt.ForeColor = Color.Blue;
                    else
                        labVDHCPTxt.ForeColor = Color.Red;

                    if (service.CanStop == true)
                    {
                        btnVDHCPStop.Enabled = true;
                        btnVDHCPRun.Enabled = false;
                    }
                    else
                    {
                        btnVDHCPStop.Enabled = false;
                        btnVDHCPRun.Enabled = true;
                    }
                }
                // VMware Workstation - Unity
                if (service.DisplayName.Contains("VMware Authorization"))
                {
                    labVUnityTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labVUnityTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labVUnityTxt.ForeColor = Color.Blue;
                    else
                        labVUnityTxt.ForeColor = Color.Red;

                    if (service.CanStop == true)
                    {
                        btnVUnityStop.Enabled = true;
                        btnVUnityRun.Enabled = false;
                    }
                    else
                    {
                        btnVUnityStop.Enabled = false;
                        btnVUnityRun.Enabled = true;
                    }
                }
                // VMware Workstation - USB
                if (service.DisplayName.Contains("VMware USB"))
                {
                    labVUSBTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labVUSBTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labVUSBTxt.ForeColor = Color.Blue;
                    else
                        labVUSBTxt.ForeColor = Color.Red;

                    if (service.CanStop == true)
                    {
                        btnVUSBStop.Enabled = true;
                        btnVUSBRun.Enabled = false;
                    }
                    else
                    {
                        btnVUSBStop.Enabled = false;
                        btnVUSBRun.Enabled = true;
                    }
                }
                // VMware Workstation - Remote Access
                if (service.DisplayName.Contains("VMware Workstation"))
                {
                    labVRemoteTxt.Text = service.ServiceName;
                    toolTip1.SetToolTip(labVRemoteTxt, service.DisplayName + "，双击查看服务描述");
                    if (service.Status.ToString() == "Running")
                        labVRemoteTxt.ForeColor = Color.Blue;
                    else
                        labVRemoteTxt.ForeColor = Color.Red;

                    if (service.CanShutdown == true)
                        btnVRemoteStop.Enabled = true;
                }
            }
            if (_M=="null")
            {
                gMySQL.Text = " MySQL [ Service Not Found ]";
                gMySQL.Enabled = false;
            }
            if (_A == "null")
            {
                gApache.Text = " Apache [ Service Not Found ]";
                gApache.Enabled = false;
            }
            if (_F == "null")
            {
                gFileZilla.Text = " FileZilla Server [ Service Not Found ]";
                gFileZilla.Enabled = false;
            }
            if (_V == "null")
            {
                gVMware.Text = " VMware Workstation [ Service Not Found ]";
                gVMware.Enabled = false;
            }

        }

        static string[,] ipInfoStatic = new string[10, 4];

        private void btnIReFresh_Click(object sender, EventArgs e)
        {
            GetIPAddrInfo();
        }

        static int jsStatic;

        private void GetIPAddrInfo()
        {
            RunCMD("ipconfig","N");
            // ipconfig结果分割成数组
            string[] ipArr = cmdOutput.Split(Environment.NewLine.ToCharArray());
            // 记录每个适配器的行数范围 0:Name; 1:Start; 2:End.
            string[,] ipArrInfo = new string[10,3];

            int js = -1;
            for (int i=0; i<ipArr.Length; i++)
            {
                if (ipArr[i].Contains("适配器"))
                {
                    js++;
                    ipArrInfo[js, 0] = ipArr[i];
                    ipArrInfo[js, 1] = i.ToString();
                    if (js!=0)
                        ipArrInfo[js - 1, 2] = (i-1).ToString();
                }
            }
            ipArrInfo[js, 2] = (ipArr.Length-1).ToString();

            // 遍历IP信息 0:(W)LAN; 1:Name; 2:Status 3:Address
            string[,] ipInfo = new string[js + 1, 4];
            int js2 = -1;
            for (int i=0; i<=js; i++)
            {
                js2++;
                if (ipArrInfo[js2,0].Contains("以太网"))
                    ipInfo[js2, 0] = "LAN";
                if (ipArrInfo[js2, 0].Contains("无线"))
                    ipInfo[js2, 0] = "WLAN";
                string nameStr = ipArrInfo[js2, 0];
                ipInfo[js2, 1] = nameStr.Substring(nameStr.IndexOf(" ")+1, nameStr.IndexOf(":") - nameStr.IndexOf(" ") - 1);
                for (int k=int.Parse(ipArrInfo[js2,1]); k<=int.Parse(ipArrInfo[js2, 2]); k++)
                {
                    if (ipArr[k].Contains("已断开"))
                        ipInfo[js2, 2] = "Disconnected";
                    if (ipArr[k].Contains("IPv4"))
                    {
                        ipInfo[js2, 2] = "Connected";
                        ipInfo[js2, 3] = ipArr[k].Substring(ipArr[k].IndexOf(":") + 2, ipArr[k].Length - ipArr[k].IndexOf(":") - 2);
                    }
                }
            }
            ipArr = null;
            ipArrInfo = null;
            jsStatic = js;
            for (int i = 0; i <= jsStatic; i++)
                for (int j = 0; j < 4; j++)
                    ipInfoStatic[i, j] = ipInfo[i, j];
            ipInfo = null;

            string addItemStr = "";
            cBoxI.Items.Clear();

            string firstNetwork = "";
            for (int i=0; i<=js; i++)
            {
                if (ipInfoStatic[i,0]=="LAN" || ipInfoStatic[i,0]=="WLAN")//&& (ipInfo[i,1].Contains("以太网") || ipInfo[i,1].Contains("本地连接")))
                {
                    //comboBox1.Text = ipInfo[i, 1] + " " + ipInfo[i, 2] + " " + ipInfo[i, 3];
                    if (ipInfoStatic[i, 2] == "Connected")
                        addItemStr = "√ " + ipInfoStatic[i, 1];
                    else
                        addItemStr = "× " + ipInfoStatic[i, 1];
                    cBoxI.Items.Add(addItemStr);
                }
                //重写LAN/WLAN优先逻辑
                
                if ((ipInfoStatic[i, 1] == "WLAN" || ipInfoStatic[i, 1] == "Wi-Fi" || ipInfoStatic[i, 1] == "无线网络连接") && ipInfoStatic[i, 2] == "Connected")
                    if (firstNetwork == "")
                        firstNetwork = "√ " + ipInfoStatic[i, 1];
                if ((ipInfoStatic[i, 1] == "以太网" || ipInfoStatic[i, 1] == "本地连接") && ipInfoStatic[i, 2] == "Connected")
                    firstNetwork = "√ " + ipInfoStatic[i, 1];
            }
            cBoxI.Text = firstNetwork;

        }

        private void SetIPED(string eord)
        {
            if (eord == "D") 
                btnISetIP.Enabled = false;
            if (eord == "E") 
                btnISetIP.Enabled = true;
        }

        private void SetIPInputED(string eord)
        {
            if (eord == "D")
            {
                tBLanIP1.Text = "";
                tBLanIP2.Text = "";
                tBLanIP3.Text = "";
                tBLanIP4.Text = "";
                tBLanIP1.Enabled = false;
                tBLanIP2.Enabled = false;
                tBLanIP3.Enabled = false;
                tBLanIP4.Enabled = false;
            }
            if (eord == "E")
            {
                tBLanIP1.Enabled = true;
                tBLanIP2.Enabled = true;
                tBLanIP3.Enabled = true;
                tBLanIP4.Enabled = true;
            }
        }

        private void LoadIPInfo(string str)
        {
            str = str.Substring(str.IndexOf(" ") + 1, str.Length - str.IndexOf(" ") - 1);
            for (int i = 0; i < jsStatic; i++)
                if (ipInfoStatic[i, 1] == str)
                {
                    if (ipInfoStatic[i, 2] == "Connected")
                    {
                        labIStatus.Text = "已连接";
                        labIStatus.ForeColor = Color.Blue;
                        labIIP.Text = "IP: " + ipInfoStatic[i, 3];
                    }
                    else
                    {
                        labIStatus.Text = "未连接";
                        labIStatus.ForeColor = Color.Red;
                        labIIP.Text = "IP: NULL";
                    }
                    if (ipInfoStatic[i, 0] == "LAN")
                        labIType.Text = "有线网";
                    if (ipInfoStatic[i, 0] == "WLAN")
                        labIType.Text = "无线网";
                }
        }

        private void btnRunApp1_Click(object sender, EventArgs e)
        {
            Process.Start(AppPath1);
        }

        private void GetAppDir()
        {
            string[] qcInfo;
            RunCMD("sc qc \"" + labASNTxt.Text + "\"", "N");
            qcInfo = cmdOutput.Split(Environment.NewLine.ToCharArray());
            for (int i = 0; i < qcInfo.Length; i++)
                if (qcInfo[i].Contains("BINARY_PATH_NAME"))
                {
                    string str = qcInfo[i];
                    str = str.Substring(str.IndexOf(":") + 3, str.IndexOf(".exe") - str.IndexOf(":") - 3);
                    str = str.Substring(0, str.LastIndexOf(@"\") + 1);
                    aDir = str + aDir;
                    btnRunApache.Enabled = true;
                }
            qcInfo = null;

            RunCMD("sc qc \"" + labFSNTxt.Text + "\"", "N");
            qcInfo = cmdOutput.Split(Environment.NewLine.ToCharArray());
            for (int i = 0; i < qcInfo.Length; i++)
                if (qcInfo[i].Contains("BINARY_PATH_NAME")) 
                {
                    string str = qcInfo[i];
                    str = str.Substring(str.IndexOf(":") + 3, str.IndexOf(".exe") - str.IndexOf(":") - 3);
                    str = str.Substring(0, str.LastIndexOf(@"\") + 1);
                    fDir = str + fDir;
                    btnRunFileZilla.Enabled = true;
                }
            qcInfo = null;

            RunCMD("sc qc \"" + labVRemoteTxt.Text + "\"", "N");
            qcInfo = cmdOutput.Split(Environment.NewLine.ToCharArray());
            for (int i = 0; i < qcInfo.Length; i++)
                if (qcInfo[i].Contains("BINARY_PATH_NAME"))
                {
                    string str = qcInfo[i];
                    str = str.Substring(str.IndexOf(":") + 3, str.IndexOf(".exe") - str.IndexOf(":") - 3);
                    str = str.Substring(0, str.LastIndexOf(@"\") + 1);
                    vDir = str + vDir;
                    btnRunVMware.Enabled = true;
                }
            qcInfo = null;
        }

        private void btnRunApp1_Click_1(object sender, EventArgs e)
        {
            Process.Start(AppPath1);
            PrintConsole("打开  " + AppPath1);
        }

        private void btnRunApp2_Click(object sender, EventArgs e)
        {
            Process.Start(AppPath2);
            PrintConsole("打开  " + AppPath2);
        }

        static string[,] confArr = new string[7, 7];

        private void btnIConf_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.GetEnvironmentVariable("AppData") + @"\MAVIF\config.ini");
        }

        private void btnIConf1_Click(object sender, EventArgs e)
        {
            LoadCustomIP(1);
        }

        private void btnIConf2_Click(object sender, EventArgs e)
        {
            LoadCustomIP(2);
        }

        private void btnIConf3_Click(object sender, EventArgs e)
        {
            LoadCustomIP(3);
        }

        private void btnIConf4_Click(object sender, EventArgs e)
        {
            LoadCustomIP(4);
        }

        private void LoadConfigINI()
        {
            string destDir = Environment.GetEnvironmentVariable("AppData") + @"\MAVIF\config.ini";

            if (Directory.Exists(Environment.GetEnvironmentVariable("AppData") + @"\MAVIF") == false)
                Directory.CreateDirectory(Environment.GetEnvironmentVariable("AppData") + @"\MAVIF");

            if (!File.Exists(destDir))
            {
                if (File.Exists("config.ini"))
                {
                    File.Copy("config.ini", destDir, false);
                    if (File.Exists(destDir))
                        File.Delete("config.ini");
                    PrintConsole("config.ini copy OK!");
                }
                else
                {
                    string conf = "[MAVIF-CONFIG]\r\n[IP]\r\n[CONFIG-1]\r\nSTATE=OFF\r\nNAME=\r\nADDR=\r\nMASK=\r\nGATE=\r\n_DNS=\r\n[CONFIG-2]\r\nSTATE=OFF\r\nNAME=\r\nADDR=\r\nMASK=\r\nGATE=\r\n_DNS=\r\n[CONFIG-3]\r\nSTATE=OFF\r\nNAME=\r\nADDR=\r\nMASK=\r\nGATE=\r\n_DNS=\r\n[CONFIG-4]\r\nSTATE=OFF\r\nNAME=\r\nADDR=\r\nMASK=\r\nGATE=\r\n_DNS=\r\n[CUSTOMAPP]\r\n[APP-1]\r\nSTATE=OFF\r\nNAME=\r\nPATH=\r\n[APP-2]\r\nSTATE=OFF\r\nNAME=\r\nPATH=\r\n[END]\r\n\r\n[README]\r\n";
                    string confReadme = "*1.将此配置文件修改后与MAVIF.exe放置在同一目录下，运行MAVIF即可完成配置；\r\n 2.配置文件路径为 %AppData%\\config.ini；\r\n 3.STATE表示启用与否，设置为“OFF”即可停用该配置项；\r\n 4.NAME将显示在按钮表面，可自由填写以便识别；\r\n*5.IP设置中，采用固定地址请按要求填写，ADDR为IP地址，MASK为子网掩码，GATE为网关\r\n   如有双DNS，请按顺序用英文半角逗号分隔，如：8.8.8.8,4.4.4.4；\r\n*6.自定义APP设置中，文件PATH应填写.exe的完整路径，并用英文半角双引号括起来\r\n   推荐使用Windows资源管理器中的“复制路径”进行粘贴；\r\n 7.在使用中如发现Bug，欢迎您向chenxy5@sda.cn反馈，非常感谢！";
                    FileStream fs = new FileStream(destDir, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(conf + confReadme);
                    sw.Close();
                    fs.Close();
                    PrintConsole("config.ini init OK!");
                }
            }
            if (File.Exists(destDir))
            {
                string strLine;
                string[] strArr = new string[40];
                int i = 0;
                StreamReader sr = new StreamReader(destDir);
                while ((strLine = sr.ReadLine()) != null)
                {
                    strArr[i++] = strLine;
                    if (strLine == "[END]") break;
                }
                sr.Close();
                if (strArr[39] == "[END]")
                {
                    confArr = null;
                    confArr = new string[7, 7];
                    try
                    {
                        int j;
                        for (i = 0; i < 40; i++)
                        {
                            // strArr[] 1:State; 2:Name; 3:Addr/AppPath; 4:Mask; 5:Gate; 6:DNS1,DNS2
                            if (strArr[i].Contains("[CONFIG-"))
                            {
                                j = int.Parse(strArr[i].Substring(strArr[i].IndexOf("-") + 1, 1));
                                for (int k = 1; k <= 6; k++)
                                    confArr[j, k] = strArr[i + k].Substring(strArr[i + k].IndexOf("=") + 1);
                            }
                            if (strArr[i].Contains("[APP-"))
                            {
                                j = int.Parse(strArr[i].Substring(strArr[i].IndexOf("-") + 1, 1));
                                for (int k = 1; k <= 3; k++)
                                    confArr[4 + j, k] = strArr[i + k].Substring(strArr[i + k].IndexOf("=") + 1);
                            }
                        }

                    }
                    catch
                    {
                        confArr = null;
                        MessageBox.Show("Config.ini Format Error!");
                    }
                }
                else
                {
                    strArr = null;
                    MessageBox.Show("Config.ini Load Error!");
                }
            }

            btnIConf.Enabled = true;
            LoadCustomApp();
            LoadDefaultIP();
            LoadCustomIP(0);
            PrintConsole("config.ini load OK!");
            LoadCustomIP(1);
        }

        private void btnISetIP_Click(object sender, EventArgs e)
        {
            string interfaceName = cBoxI.Text.Substring(2);
            string[] ipConf = labIInfoTxt.Text.Split(Environment.NewLine.ToCharArray());
            string ipStr = tBLanIP1.Text + "." + tBLanIP2.Text + "." + tBLanIP3.Text + "." + tBLanIP4.Text;
            string mask = ipConf[2];
            string gate = ipConf[4];
            string dns1 = ipConf[6];
            string dns2 = null;
            if (ipConf.Length > 7)
                dns2 = ipConf[8];
            string ipSetStr;
            //DHCP
            if (ipStr=="...")
            {
                ipSetStr = "netsh interface ip set address name=\"" + interfaceName + "\" source=dhcp";
                RunCMD(ipSetStr, "N");
                ipSetStr= "netsh interface ip set dns name=\"" + interfaceName + "\" source=dhcp";
                RunCMD(ipSetStr, "N");
                ipSetStr = "ipconfig /flushdns";
                RunCMD(ipSetStr, "N");
                PrintConsole(interfaceName + " Setting DHCP ......");
            }
            //Static
            else
            {
                ipSetStr = "netsh interface ip set address name=\"" + interfaceName + "\"" +
                    " source=static addr=" + ipStr + " mask=" + mask + " gateway=" + gate;
                RunCMD(ipSetStr, "N");
                ipSetStr = "netsh interface ip delete dns \"" + interfaceName + "\" all";
                RunCMD(ipSetStr, "N");
                ipSetStr = "netsh interface ip set dns name=\"" + interfaceName + "\"" +
                    " source=static addr=" + dns1;
                RunCMD(ipSetStr, "N");

                if (dns2 != null)
                {
                    ipSetStr = "netsh interface ip add dns name=\"" + interfaceName + "\"" +
                   " addr=" + dns2;
                    RunCMD(ipSetStr, "N");
                }

                PrintConsole(interfaceName + " Setting Static ......\r\nIP地址=" + ipStr + " \r\n子网掩码=" + mask + "\r\n网关=" + gate + "\r\nDNS_1=" + dns1 + "\r\nDNS_2=" + dns2);
            }
            cBoxI.Focus();
            labIStatus.Text = "正在变更";
            labIStatus.ForeColor = Color.Red;
            labIIP.Text = "IP: 等待确认";
            GetIPAddrInfo();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cBoxI.Text == "")
            {
                btnISetIP.Enabled = false;
                GetIPAddrInfo();
            }
            else
            {
                timer1.Enabled = false;
                PrintConsole("SET OK!");
            }
        }

        private void btnIConfReload_Click(object sender, EventArgs e)
        {
            LoadConfigINI();
        }

        static string AppPath1, AppPath2;

        private void LoadCustomApp()
        {
            if (confArr[5, 1] == "ON" && confArr[5, 2] != "" && confArr[5, 3] != "" && File.Exists(AppPath1 = confArr[5, 3].ToString().Substring(1, confArr[5, 3].ToString().Length - 2)))
            {
                btnRunApp1.Visible = true;
                toolTip1.SetToolTip(btnRunApp1, "打开" + confArr[5, 2]);
                SHFILEINFO shinfo = new SHFILEINFO();
                Win32.SHGetFileInfo(AppPath1, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
                Icon myIcon = Icon.FromHandle(shinfo.hIcon);
                btnRunApp1.Image = myIcon.ToBitmap();
            }
            if (confArr[6, 1] == "ON" && confArr[6, 2] != "" && confArr[6, 3] != "" && File.Exists(AppPath2 = confArr[6, 3].ToString().Substring(1, confArr[6, 3].ToString().Length - 2)))
            {
                btnRunApp2.Visible = true;
                toolTip1.SetToolTip(btnRunApp2, "打开" + confArr[6, 2]);
                SHFILEINFO shinfo = new SHFILEINFO();
                Win32.SHGetFileInfo(AppPath2, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
                Icon myIcon = Icon.FromHandle(shinfo.hIcon);
                btnRunApp2.Image = myIcon.ToBitmap();
            }
            if (confArr[5, 1] != "ON")
                btnRunApp1.Visible = false;
            if (confArr[6, 1] != "ON")
                btnRunApp2.Visible = false;
        }
        private void LoadDefaultIP()
        {
            btnIConf1.Text = "IP Config 1";
            btnIConf2.Text = "IP Config 2";
            btnIConf3.Text = "IP Config 3";
            btnIConf4.Text = "IP Config 4";
            btnIConf1.Enabled = false;
            btnIConf2.Enabled = false;
            btnIConf3.Enabled = false;
            btnIConf4.Enabled = false;
            labIInfoTxt.Text = "---\r\n---\r\n---\r\n---";
        }

        private void LoadCustomIP(int confNo)
        {
            SetConfBtnColor(confNo);
            if (confNo == 0) 
            {
                if (confArr[1, 1] == "ON")
                {
                    btnIConf1.Text = confArr[1, 2];
                    btnIConf1.Enabled = true;
                }
                if (confArr[2, 1] == "ON")
                {
                    btnIConf2.Text = confArr[2, 2];
                    btnIConf2.Enabled = true;
                }
                if (confArr[3, 1] == "ON")
                {
                    btnIConf3.Text = confArr[3, 2];
                    btnIConf3.Enabled = true;
                }
                if (confArr[4, 1] == "ON")
                {
                    btnIConf4.Text = confArr[4, 2];
                    btnIConf4.Enabled = true;
                }
            }
            else if (confArr[confNo, 1] == "ON")
            {
                labIInfoTxt.Text = confArr[confNo, 2];
                if (confArr[confNo, 3] == "DHCP") 
                {
                    labIInfoTxt.Text = confArr[confNo, 2] + "\r\n---\r\n---\r\n---";
                    cBoxI.Focus();
                    if (labIStatus.Text == "已连接")
                    {
                        SetIPED("E");
                        btnISetIP.Focus();
                    }
                    SetIPInputED("D");
                }
                else
                {
                    bool isLegal = true;
                    string dns1="null", dns2="null";
                    if (confArr[confNo, 6].Contains(",")) 
                    {
                        dns1 = confArr[confNo, 6].Substring(0, confArr[confNo, 6].IndexOf(",")).Trim();
                        dns2 = confArr[confNo, 6].Substring(confArr[confNo, 6].IndexOf(",") + 1).Trim();
                    }
                    else
                    {
                        dns1 = confArr[confNo, 6].Trim();
                    }
                    if (IPAddress.TryParse(confArr[confNo, 3].Trim(), out IPAddress ip))
                    {
                        SetIPInputED("E");
                        string[] ipAddr = confArr[confNo, 3].Trim().Split('.');
                        tBLanIP1.Text = ipAddr[0];
                        tBLanIP2.Text = ipAddr[1];
                        tBLanIP3.Text = ipAddr[2];
                        tBLanIP4.Text = ipAddr[3];
                        if (IPAddress.TryParse(confArr[confNo, 4].Trim(), out ip))
                        {
                            labIInfoTxt.Text += "\r\n" + confArr[confNo, 4].Trim();
                            if (IPAddress.TryParse(confArr[confNo, 5].Trim(), out ip))
                            {
                                labIInfoTxt.Text += "\r\n" + confArr[confNo, 5].Trim();
                                if (IPAddress.TryParse(dns1, out ip))
                                {
                                    labIInfoTxt.Text += "\r\n" + dns1;
                                    if (dns2 != "null")
                                        if (IPAddress.TryParse(dns2, out ip))
                                            labIInfoTxt.Text += "\r\n" + dns2;
                                        else
                                        {
                                            MessageBox.Show("DNS2 Illegal!");
                                            isLegal = false;
                                        }
                                    if (labIStatus.Text == "已连接")
                                    {
                                        SetIPED("E");
                                        btnISetIP.Focus();
                                    }
                                    else
                                        cBoxI.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("DNS1 Illegal!");
                                    isLegal = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("GateWay Illegal!");
                                isLegal = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Subnet Mask Illegal!");
                            isLegal = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("IP Address Illegal!");
                        isLegal = false;
                    }

                    if (!isLegal)
                    {
                        SetIPED("D");
                        SetIPInputED("D");
                        labIInfoTxt.Text = "---\r\n---\r\n---\r\n---";
                        SetConfBtnColor(0);
                    }
                }

            }
            if (btnIConf1.Enabled == false && btnIConf2.Enabled == false && btnIConf3.Enabled == false && btnIConf4.Enabled == false)
            {
                SetIPInputED("D");
                btnISetIP.Enabled = false;
            }
        }

        private void SetConfBtnColor(int btnNo)
        {
            btnIConf1.ForeColor = SystemColors.ControlText;
            btnIConf2.ForeColor = SystemColors.ControlText;
            btnIConf3.ForeColor = SystemColors.ControlText;
            btnIConf4.ForeColor = SystemColors.ControlText;
            switch(btnNo) {
                case 1 :
                    btnIConf1.ForeColor = SystemColors.Highlight;
                    break;
                case 2 :
                    btnIConf2.ForeColor = SystemColors.Highlight;
                    break;
                case 3:
                    btnIConf3.ForeColor = SystemColors.Highlight;
                    break;
                case 4:
                    btnIConf4.ForeColor = SystemColors.Highlight;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textConsole.Text = "[ " + DateTime.Now.ToString() + " ]\r\n" +  labTitle1.Text + " Init OK.";
            GetServiceInfo();
            GetAppDir();
            GetIPAddrInfo();
            LoadConfigINI();
        }
    }
}
