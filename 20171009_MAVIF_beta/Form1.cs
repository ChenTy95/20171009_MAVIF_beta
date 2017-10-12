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

namespace _20171009_MAVIF_beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void btnMSetManual_Click(object sender, EventArgs e)
        {
            
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
            if (writeConsole=="Y")
                textConsole.Text += "\r\n\r\n[ " + DateTime.Now.ToString() +" ]\r\n" + cmdOutput;
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
                btnILanSetIP.Focus();
            }
        }

        private void btnRunNetwork_Click(object sender, EventArgs e)
        {
            RunCMD(@"%windir%\system32\control.exe /name Microsoft.NetworkAndSharingCenter", "N");
            //Process.Start("RunDLL32.exe", "shell32.dll,Control_RunDLL ncpa.cpl");
        }

        private void btnRunApache_Click(object sender, EventArgs e)
        {
            Process.Start(@aDir);
        }

        private void btnRunFileZilla_Click(object sender, EventArgs e)
        {
            Process.Start(@fDir);
        }

        private void cBoxI_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIPInfo(cBoxI.Text);
        }

        private void btnRunVMware_Click(object sender, EventArgs e)
        {
            Process.Start(@vDir);
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
                if ((ipInfoStatic[i, 1] == "以太网" || ipInfoStatic[i, 1] == "本地连接") && ipInfoStatic[i, 2] == "Connected")
                    cBoxI.Text = "√ " + ipInfoStatic[i, 1];
                else if ((ipInfoStatic[i, 1] == "WLAN" || ipInfoStatic[i, 1] == "Wi-Fi" || ipInfoStatic[i, 1] == "无线网络连接") && ipInfoStatic[i, 2] == "Connected")
                    cBoxI.Text = "√ " + ipInfoStatic[i, 1];
            }

            // To Be Continued.

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
                    Console.WriteLine(str);
                    fDir = str + fDir;
                    Console.WriteLine(fDir);
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
                    Console.WriteLine(str);
                    vDir = str + vDir;
                    Console.WriteLine(fDir);
                    btnRunVMware.Enabled = true;
                }
            qcInfo = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textConsole.Text = "[ " + DateTime.Now.ToString() + " ]\r\n" +  labTitle1.Text + " Init OK.";
            GetServiceInfo();
            GetAppDir();
            GetIPAddrInfo();
        }
        
    }
}
