namespace _20171009_MAVIF_beta
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMySQL = new System.Windows.Forms.GroupBox();
            this.btnMStop = new System.Windows.Forms.Button();
            this.btnMRun = new System.Windows.Forms.Button();
            this.labMSNTxt = new System.Windows.Forms.Label();
            this.labMStatusTxt = new System.Windows.Forms.Label();
            this.labMStatus = new System.Windows.Forms.Label();
            this.labMSN = new System.Windows.Forms.Label();
            this.labTitle1 = new System.Windows.Forms.Label();
            this.labTitle2 = new System.Windows.Forms.Label();
            this.btnMSetManual = new System.Windows.Forms.Button();
            this.gApache = new System.Windows.Forms.GroupBox();
            this.btnAStop = new System.Windows.Forms.Button();
            this.btnARun = new System.Windows.Forms.Button();
            this.labASNTxt = new System.Windows.Forms.Label();
            this.labAStatusTxt = new System.Windows.Forms.Label();
            this.labAStatus = new System.Windows.Forms.Label();
            this.labASN = new System.Windows.Forms.Label();
            this.gFileZilla = new System.Windows.Forms.GroupBox();
            this.btnFStop = new System.Windows.Forms.Button();
            this.btnFRun = new System.Windows.Forms.Button();
            this.labFSNTxt = new System.Windows.Forms.Label();
            this.labFStatusTxt = new System.Windows.Forms.Label();
            this.labFStatus = new System.Windows.Forms.Label();
            this.labFSN = new System.Windows.Forms.Label();
            this.gVMware = new System.Windows.Forms.GroupBox();
            this.btnVRemoteStop = new System.Windows.Forms.Button();
            this.btnVRemoteDisable = new System.Windows.Forms.Button();
            this.btnVUSBStop = new System.Windows.Forms.Button();
            this.btnVUSBRun = new System.Windows.Forms.Button();
            this.btnVUnityStop = new System.Windows.Forms.Button();
            this.btnVUnityRun = new System.Windows.Forms.Button();
            this.btnVDHCPStop = new System.Windows.Forms.Button();
            this.btnVDHCPRun = new System.Windows.Forms.Button();
            this.labVRemoteTxt = new System.Windows.Forms.Label();
            this.labVRemote = new System.Windows.Forms.Label();
            this.labVUSBTxt = new System.Windows.Forms.Label();
            this.labVUnityTxt = new System.Windows.Forms.Label();
            this.labVDHCPTxt = new System.Windows.Forms.Label();
            this.labVUSB = new System.Windows.Forms.Label();
            this.btnVNATStop = new System.Windows.Forms.Button();
            this.labVUnity = new System.Windows.Forms.Label();
            this.labVDHCP = new System.Windows.Forms.Label();
            this.btnVNATRun = new System.Windows.Forms.Button();
            this.labVNATTxt = new System.Windows.Forms.Label();
            this.labVNAT = new System.Windows.Forms.Label();
            this.textConsole = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRunFileZilla = new System.Windows.Forms.Button();
            this.btnRunVMware = new System.Windows.Forms.Button();
            this.btnRunApache = new System.Windows.Forms.Button();
            this.btnRunNetwork = new System.Windows.Forms.Button();
            this.btnRunServices = new System.Windows.Forms.Button();
            this.cBoxI = new System.Windows.Forms.ComboBox();
            this.gIP = new System.Windows.Forms.GroupBox();
            this.btnIReFresh = new System.Windows.Forms.Button();
            this.labIInfo = new System.Windows.Forms.Label();
            this.labIType = new System.Windows.Forms.Label();
            this.labIStatus = new System.Windows.Forms.Label();
            this.labIIP = new System.Windows.Forms.Label();
            this.btnIDHCP = new System.Windows.Forms.Button();
            this.btnISetIP = new System.Windows.Forms.Button();
            this.tBLanIP4 = new System.Windows.Forms.TextBox();
            this.tBLanIP3 = new System.Windows.Forms.TextBox();
            this.tBLanIP2 = new System.Windows.Forms.TextBox();
            this.tBLanIP1 = new System.Windows.Forms.TextBox();
            this.labI = new System.Windows.Forms.Label();
            this.labILanDot = new System.Windows.Forms.Label();
            this.gMySQL.SuspendLayout();
            this.gApache.SuspendLayout();
            this.gFileZilla.SuspendLayout();
            this.gVMware.SuspendLayout();
            this.gIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMySQL
            // 
            this.gMySQL.Controls.Add(this.btnMStop);
            this.gMySQL.Controls.Add(this.btnMRun);
            this.gMySQL.Controls.Add(this.labMSNTxt);
            this.gMySQL.Controls.Add(this.labMStatusTxt);
            this.gMySQL.Controls.Add(this.labMStatus);
            this.gMySQL.Controls.Add(this.labMSN);
            this.gMySQL.Location = new System.Drawing.Point(18, 65);
            this.gMySQL.Name = "gMySQL";
            this.gMySQL.Size = new System.Drawing.Size(293, 82);
            this.gMySQL.TabIndex = 4;
            this.gMySQL.TabStop = false;
            this.gMySQL.Text = " MySQL ";
            // 
            // btnMStop
            // 
            this.btnMStop.Enabled = false;
            this.btnMStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMStop.ForeColor = System.Drawing.Color.Red;
            this.btnMStop.Location = new System.Drawing.Point(231, 28);
            this.btnMStop.Name = "btnMStop";
            this.btnMStop.Size = new System.Drawing.Size(50, 43);
            this.btnMStop.TabIndex = 4;
            this.btnMStop.Text = "停止";
            this.btnMStop.UseVisualStyleBackColor = true;
            this.btnMStop.Click += new System.EventHandler(this.btnMStop_Click);
            // 
            // btnMRun
            // 
            this.btnMRun.Enabled = false;
            this.btnMRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnMRun.Location = new System.Drawing.Point(175, 28);
            this.btnMRun.Name = "btnMRun";
            this.btnMRun.Size = new System.Drawing.Size(50, 43);
            this.btnMRun.TabIndex = 3;
            this.btnMRun.Text = "启动";
            this.btnMRun.UseVisualStyleBackColor = true;
            this.btnMRun.Click += new System.EventHandler(this.btnMRun_Click);
            // 
            // labMSNTxt
            // 
            this.labMSNTxt.AutoSize = true;
            this.labMSNTxt.Location = new System.Drawing.Point(103, 28);
            this.labMSNTxt.Name = "labMSNTxt";
            this.labMSNTxt.Size = new System.Drawing.Size(23, 17);
            this.labMSNTxt.TabIndex = 3;
            this.labMSNTxt.Text = "---";
            this.labMSNTxt.DoubleClick += new System.EventHandler(this.labMSNTxt_DoubleClick);
            // 
            // labMStatusTxt
            // 
            this.labMStatusTxt.AutoSize = true;
            this.labMStatusTxt.Location = new System.Drawing.Point(103, 54);
            this.labMStatusTxt.Name = "labMStatusTxt";
            this.labMStatusTxt.Size = new System.Drawing.Size(23, 17);
            this.labMStatusTxt.TabIndex = 2;
            this.labMStatusTxt.Text = "---";
            // 
            // labMStatus
            // 
            this.labMStatus.AutoSize = true;
            this.labMStatus.Location = new System.Drawing.Point(15, 54);
            this.labMStatus.Name = "labMStatus";
            this.labMStatus.Size = new System.Drawing.Size(87, 17);
            this.labMStatus.TabIndex = 1;
            this.labMStatus.Text = "Server Status:";
            // 
            // labMSN
            // 
            this.labMSN.AutoSize = true;
            this.labMSN.Location = new System.Drawing.Point(15, 28);
            this.labMSN.Name = "labMSN";
            this.labMSN.Size = new System.Drawing.Size(87, 17);
            this.labMSN.TabIndex = 0;
            this.labMSN.Text = "Server Name:";
            // 
            // labTitle1
            // 
            this.labTitle1.AutoSize = true;
            this.labTitle1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle1.Location = new System.Drawing.Point(12, 9);
            this.labTitle1.Name = "labTitle1";
            this.labTitle1.Size = new System.Drawing.Size(299, 27);
            this.labTitle1.TabIndex = 1;
            this.labTitle1.Text = "MAVIF Controller v0.2 Alpha";
            // 
            // labTitle2
            // 
            this.labTitle2.AutoSize = true;
            this.labTitle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labTitle2.Location = new System.Drawing.Point(15, 34);
            this.labTitle2.Name = "labTitle2";
            this.labTitle2.Size = new System.Drawing.Size(279, 17);
            this.labTitle2.TabIndex = 2;
            this.labTitle2.Text = "For MySQL / Apache / VMware / IP Addr / FTP";
            // 
            // btnMSetManual
            // 
            this.btnMSetManual.Location = new System.Drawing.Point(330, 9);
            this.btnMSetManual.Name = "btnMSetManual";
            this.btnMSetManual.Size = new System.Drawing.Size(71, 50);
            this.btnMSetManual.TabIndex = 5;
            this.btnMSetManual.Text = "Set Manual";
            this.btnMSetManual.UseVisualStyleBackColor = true;
            this.btnMSetManual.Click += new System.EventHandler(this.btnMSetManual_Click);
            // 
            // gApache
            // 
            this.gApache.Controls.Add(this.btnAStop);
            this.gApache.Controls.Add(this.btnARun);
            this.gApache.Controls.Add(this.labASNTxt);
            this.gApache.Controls.Add(this.labAStatusTxt);
            this.gApache.Controls.Add(this.labAStatus);
            this.gApache.Controls.Add(this.labASN);
            this.gApache.Location = new System.Drawing.Point(19, 153);
            this.gApache.Name = "gApache";
            this.gApache.Size = new System.Drawing.Size(293, 82);
            this.gApache.TabIndex = 5;
            this.gApache.TabStop = false;
            this.gApache.Text = " Apache ";
            // 
            // btnAStop
            // 
            this.btnAStop.Enabled = false;
            this.btnAStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAStop.ForeColor = System.Drawing.Color.Red;
            this.btnAStop.Location = new System.Drawing.Point(231, 28);
            this.btnAStop.Name = "btnAStop";
            this.btnAStop.Size = new System.Drawing.Size(50, 43);
            this.btnAStop.TabIndex = 4;
            this.btnAStop.Text = "停止";
            this.btnAStop.UseVisualStyleBackColor = true;
            this.btnAStop.Click += new System.EventHandler(this.btnAStop_Click);
            // 
            // btnARun
            // 
            this.btnARun.Enabled = false;
            this.btnARun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnARun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnARun.Location = new System.Drawing.Point(175, 28);
            this.btnARun.Name = "btnARun";
            this.btnARun.Size = new System.Drawing.Size(50, 43);
            this.btnARun.TabIndex = 3;
            this.btnARun.Text = "启动";
            this.btnARun.UseVisualStyleBackColor = true;
            this.btnARun.Click += new System.EventHandler(this.btnARun_Click);
            // 
            // labASNTxt
            // 
            this.labASNTxt.AutoSize = true;
            this.labASNTxt.Location = new System.Drawing.Point(103, 28);
            this.labASNTxt.Name = "labASNTxt";
            this.labASNTxt.Size = new System.Drawing.Size(23, 17);
            this.labASNTxt.TabIndex = 3;
            this.labASNTxt.Text = "---";
            this.labASNTxt.DoubleClick += new System.EventHandler(this.labASNTxt_DoubleClick);
            // 
            // labAStatusTxt
            // 
            this.labAStatusTxt.AutoSize = true;
            this.labAStatusTxt.Location = new System.Drawing.Point(103, 54);
            this.labAStatusTxt.Name = "labAStatusTxt";
            this.labAStatusTxt.Size = new System.Drawing.Size(23, 17);
            this.labAStatusTxt.TabIndex = 2;
            this.labAStatusTxt.Text = "---";
            // 
            // labAStatus
            // 
            this.labAStatus.AutoSize = true;
            this.labAStatus.Location = new System.Drawing.Point(15, 54);
            this.labAStatus.Name = "labAStatus";
            this.labAStatus.Size = new System.Drawing.Size(87, 17);
            this.labAStatus.TabIndex = 1;
            this.labAStatus.Text = "Server Status:";
            // 
            // labASN
            // 
            this.labASN.AutoSize = true;
            this.labASN.Location = new System.Drawing.Point(15, 28);
            this.labASN.Name = "labASN";
            this.labASN.Size = new System.Drawing.Size(87, 17);
            this.labASN.TabIndex = 0;
            this.labASN.Text = "Server Name:";
            // 
            // gFileZilla
            // 
            this.gFileZilla.Controls.Add(this.btnFStop);
            this.gFileZilla.Controls.Add(this.btnFRun);
            this.gFileZilla.Controls.Add(this.labFSNTxt);
            this.gFileZilla.Controls.Add(this.labFStatusTxt);
            this.gFileZilla.Controls.Add(this.labFStatus);
            this.gFileZilla.Controls.Add(this.labFSN);
            this.gFileZilla.Location = new System.Drawing.Point(19, 241);
            this.gFileZilla.Name = "gFileZilla";
            this.gFileZilla.Size = new System.Drawing.Size(293, 82);
            this.gFileZilla.TabIndex = 6;
            this.gFileZilla.TabStop = false;
            this.gFileZilla.Text = "FileZilla Server";
            // 
            // btnFStop
            // 
            this.btnFStop.Enabled = false;
            this.btnFStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFStop.ForeColor = System.Drawing.Color.Red;
            this.btnFStop.Location = new System.Drawing.Point(231, 45);
            this.btnFStop.Name = "btnFStop";
            this.btnFStop.Size = new System.Drawing.Size(50, 26);
            this.btnFStop.TabIndex = 4;
            this.btnFStop.Text = "停止";
            this.btnFStop.UseVisualStyleBackColor = true;
            this.btnFStop.Click += new System.EventHandler(this.btnFStop_Click);
            // 
            // btnFRun
            // 
            this.btnFRun.Enabled = false;
            this.btnFRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnFRun.Location = new System.Drawing.Point(175, 45);
            this.btnFRun.Name = "btnFRun";
            this.btnFRun.Size = new System.Drawing.Size(50, 26);
            this.btnFRun.TabIndex = 3;
            this.btnFRun.Text = "启动";
            this.btnFRun.UseVisualStyleBackColor = true;
            this.btnFRun.Click += new System.EventHandler(this.btnFRun_Click);
            // 
            // labFSNTxt
            // 
            this.labFSNTxt.AutoSize = true;
            this.labFSNTxt.Location = new System.Drawing.Point(103, 28);
            this.labFSNTxt.Name = "labFSNTxt";
            this.labFSNTxt.Size = new System.Drawing.Size(23, 17);
            this.labFSNTxt.TabIndex = 3;
            this.labFSNTxt.Text = "---";
            this.labFSNTxt.DoubleClick += new System.EventHandler(this.labFSNTxt_DoubleClick);
            // 
            // labFStatusTxt
            // 
            this.labFStatusTxt.AutoSize = true;
            this.labFStatusTxt.Location = new System.Drawing.Point(103, 54);
            this.labFStatusTxt.Name = "labFStatusTxt";
            this.labFStatusTxt.Size = new System.Drawing.Size(23, 17);
            this.labFStatusTxt.TabIndex = 2;
            this.labFStatusTxt.Text = "---";
            // 
            // labFStatus
            // 
            this.labFStatus.AutoSize = true;
            this.labFStatus.Location = new System.Drawing.Point(15, 54);
            this.labFStatus.Name = "labFStatus";
            this.labFStatus.Size = new System.Drawing.Size(87, 17);
            this.labFStatus.TabIndex = 1;
            this.labFStatus.Text = "Server Status:";
            // 
            // labFSN
            // 
            this.labFSN.AutoSize = true;
            this.labFSN.Location = new System.Drawing.Point(15, 28);
            this.labFSN.Name = "labFSN";
            this.labFSN.Size = new System.Drawing.Size(87, 17);
            this.labFSN.TabIndex = 0;
            this.labFSN.Text = "Server Name:";
            // 
            // gVMware
            // 
            this.gVMware.Controls.Add(this.btnVRemoteStop);
            this.gVMware.Controls.Add(this.btnVRemoteDisable);
            this.gVMware.Controls.Add(this.btnVUSBStop);
            this.gVMware.Controls.Add(this.btnVUSBRun);
            this.gVMware.Controls.Add(this.btnVUnityStop);
            this.gVMware.Controls.Add(this.btnVUnityRun);
            this.gVMware.Controls.Add(this.btnVDHCPStop);
            this.gVMware.Controls.Add(this.btnVDHCPRun);
            this.gVMware.Controls.Add(this.labVRemoteTxt);
            this.gVMware.Controls.Add(this.labVRemote);
            this.gVMware.Controls.Add(this.labVUSBTxt);
            this.gVMware.Controls.Add(this.labVUnityTxt);
            this.gVMware.Controls.Add(this.labVDHCPTxt);
            this.gVMware.Controls.Add(this.labVUSB);
            this.gVMware.Controls.Add(this.btnVNATStop);
            this.gVMware.Controls.Add(this.labVUnity);
            this.gVMware.Controls.Add(this.labVDHCP);
            this.gVMware.Controls.Add(this.btnVNATRun);
            this.gVMware.Controls.Add(this.labVNATTxt);
            this.gVMware.Controls.Add(this.labVNAT);
            this.gVMware.Location = new System.Drawing.Point(330, 299);
            this.gVMware.Name = "gVMware";
            this.gVMware.Size = new System.Drawing.Size(321, 161);
            this.gVMware.TabIndex = 5;
            this.gVMware.TabStop = false;
            this.gVMware.Text = " VMware Workstation ";
            // 
            // btnVRemoteStop
            // 
            this.btnVRemoteStop.Enabled = false;
            this.btnVRemoteStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVRemoteStop.ForeColor = System.Drawing.Color.Red;
            this.btnVRemoteStop.Location = new System.Drawing.Point(201, 129);
            this.btnVRemoteStop.Name = "btnVRemoteStop";
            this.btnVRemoteStop.Size = new System.Drawing.Size(50, 23);
            this.btnVRemoteStop.TabIndex = 21;
            this.btnVRemoteStop.Text = "停止";
            this.btnVRemoteStop.UseVisualStyleBackColor = true;
            this.btnVRemoteStop.Click += new System.EventHandler(this.btnVRemoteStop_Click);
            // 
            // btnVRemoteDisable
            // 
            this.btnVRemoteDisable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVRemoteDisable.ForeColor = System.Drawing.Color.Red;
            this.btnVRemoteDisable.Location = new System.Drawing.Point(257, 129);
            this.btnVRemoteDisable.Name = "btnVRemoteDisable";
            this.btnVRemoteDisable.Size = new System.Drawing.Size(50, 23);
            this.btnVRemoteDisable.TabIndex = 20;
            this.btnVRemoteDisable.Text = "禁用";
            this.btnVRemoteDisable.UseVisualStyleBackColor = true;
            this.btnVRemoteDisable.Click += new System.EventHandler(this.btnVRemoteDisable_Click);
            // 
            // btnVUSBStop
            // 
            this.btnVUSBStop.Enabled = false;
            this.btnVUSBStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVUSBStop.ForeColor = System.Drawing.Color.Red;
            this.btnVUSBStop.Location = new System.Drawing.Point(257, 103);
            this.btnVUSBStop.Name = "btnVUSBStop";
            this.btnVUSBStop.Size = new System.Drawing.Size(50, 23);
            this.btnVUSBStop.TabIndex = 18;
            this.btnVUSBStop.Text = "停止";
            this.btnVUSBStop.UseVisualStyleBackColor = true;
            this.btnVUSBStop.Click += new System.EventHandler(this.btnVUSBStop_Click);
            // 
            // btnVUSBRun
            // 
            this.btnVUSBRun.Enabled = false;
            this.btnVUSBRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVUSBRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVUSBRun.Location = new System.Drawing.Point(201, 103);
            this.btnVUSBRun.Name = "btnVUSBRun";
            this.btnVUSBRun.Size = new System.Drawing.Size(50, 23);
            this.btnVUSBRun.TabIndex = 17;
            this.btnVUSBRun.Text = "启动";
            this.btnVUSBRun.UseVisualStyleBackColor = true;
            this.btnVUSBRun.Click += new System.EventHandler(this.btnVUSBRun_Click);
            // 
            // btnVUnityStop
            // 
            this.btnVUnityStop.Enabled = false;
            this.btnVUnityStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVUnityStop.ForeColor = System.Drawing.Color.Red;
            this.btnVUnityStop.Location = new System.Drawing.Point(257, 77);
            this.btnVUnityStop.Name = "btnVUnityStop";
            this.btnVUnityStop.Size = new System.Drawing.Size(50, 23);
            this.btnVUnityStop.TabIndex = 16;
            this.btnVUnityStop.Text = "停止";
            this.btnVUnityStop.UseVisualStyleBackColor = true;
            this.btnVUnityStop.Click += new System.EventHandler(this.btnVUnityStop_Click);
            // 
            // btnVUnityRun
            // 
            this.btnVUnityRun.Enabled = false;
            this.btnVUnityRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVUnityRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVUnityRun.Location = new System.Drawing.Point(201, 77);
            this.btnVUnityRun.Name = "btnVUnityRun";
            this.btnVUnityRun.Size = new System.Drawing.Size(50, 23);
            this.btnVUnityRun.TabIndex = 15;
            this.btnVUnityRun.Text = "启动";
            this.btnVUnityRun.UseVisualStyleBackColor = true;
            this.btnVUnityRun.Click += new System.EventHandler(this.btnVUnityRun_Click);
            // 
            // btnVDHCPStop
            // 
            this.btnVDHCPStop.Enabled = false;
            this.btnVDHCPStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVDHCPStop.ForeColor = System.Drawing.Color.Red;
            this.btnVDHCPStop.Location = new System.Drawing.Point(257, 51);
            this.btnVDHCPStop.Name = "btnVDHCPStop";
            this.btnVDHCPStop.Size = new System.Drawing.Size(50, 23);
            this.btnVDHCPStop.TabIndex = 14;
            this.btnVDHCPStop.Text = "停止";
            this.btnVDHCPStop.UseVisualStyleBackColor = true;
            this.btnVDHCPStop.Click += new System.EventHandler(this.btnVDHCPStop_Click);
            // 
            // btnVDHCPRun
            // 
            this.btnVDHCPRun.Enabled = false;
            this.btnVDHCPRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVDHCPRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVDHCPRun.Location = new System.Drawing.Point(201, 51);
            this.btnVDHCPRun.Name = "btnVDHCPRun";
            this.btnVDHCPRun.Size = new System.Drawing.Size(50, 23);
            this.btnVDHCPRun.TabIndex = 13;
            this.btnVDHCPRun.Text = "启动";
            this.btnVDHCPRun.UseVisualStyleBackColor = true;
            this.btnVDHCPRun.Click += new System.EventHandler(this.btnVDHCPRun_Click);
            // 
            // labVRemoteTxt
            // 
            this.labVRemoteTxt.AutoSize = true;
            this.labVRemoteTxt.Location = new System.Drawing.Point(65, 132);
            this.labVRemoteTxt.Name = "labVRemoteTxt";
            this.labVRemoteTxt.Size = new System.Drawing.Size(23, 17);
            this.labVRemoteTxt.TabIndex = 12;
            this.labVRemoteTxt.Text = "---";
            this.labVRemoteTxt.DoubleClick += new System.EventHandler(this.labVRemoteTxt_DoubleClick);
            // 
            // labVRemote
            // 
            this.labVRemote.AutoSize = true;
            this.labVRemote.Location = new System.Drawing.Point(15, 132);
            this.labVRemote.Name = "labVRemote";
            this.labVRemote.Size = new System.Drawing.Size(32, 17);
            this.labVRemote.TabIndex = 11;
            this.labVRemote.Text = "R_A:";
            // 
            // labVUSBTxt
            // 
            this.labVUSBTxt.AutoSize = true;
            this.labVUSBTxt.Location = new System.Drawing.Point(65, 106);
            this.labVUSBTxt.Name = "labVUSBTxt";
            this.labVUSBTxt.Size = new System.Drawing.Size(23, 17);
            this.labVUSBTxt.TabIndex = 10;
            this.labVUSBTxt.Text = "---";
            this.labVUSBTxt.DoubleClick += new System.EventHandler(this.labVUSBTxt_DoubleClick);
            // 
            // labVUnityTxt
            // 
            this.labVUnityTxt.AutoSize = true;
            this.labVUnityTxt.Location = new System.Drawing.Point(65, 80);
            this.labVUnityTxt.Name = "labVUnityTxt";
            this.labVUnityTxt.Size = new System.Drawing.Size(23, 17);
            this.labVUnityTxt.TabIndex = 9;
            this.labVUnityTxt.Text = "---";
            this.labVUnityTxt.DoubleClick += new System.EventHandler(this.labVUnityTxt_DoubleClick);
            // 
            // labVDHCPTxt
            // 
            this.labVDHCPTxt.AutoSize = true;
            this.labVDHCPTxt.Location = new System.Drawing.Point(65, 54);
            this.labVDHCPTxt.Name = "labVDHCPTxt";
            this.labVDHCPTxt.Size = new System.Drawing.Size(23, 17);
            this.labVDHCPTxt.TabIndex = 8;
            this.labVDHCPTxt.Text = "---";
            this.labVDHCPTxt.DoubleClick += new System.EventHandler(this.labVDHCPTxt_DoubleClick);
            // 
            // labVUSB
            // 
            this.labVUSB.AutoSize = true;
            this.labVUSB.Location = new System.Drawing.Point(15, 106);
            this.labVUSB.Name = "labVUSB";
            this.labVUSB.Size = new System.Drawing.Size(35, 17);
            this.labVUSB.TabIndex = 7;
            this.labVUSB.Text = "USB:";
            // 
            // btnVNATStop
            // 
            this.btnVNATStop.Enabled = false;
            this.btnVNATStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVNATStop.ForeColor = System.Drawing.Color.Red;
            this.btnVNATStop.Location = new System.Drawing.Point(257, 25);
            this.btnVNATStop.Name = "btnVNATStop";
            this.btnVNATStop.Size = new System.Drawing.Size(50, 23);
            this.btnVNATStop.TabIndex = 4;
            this.btnVNATStop.Text = "停止";
            this.btnVNATStop.UseVisualStyleBackColor = true;
            this.btnVNATStop.Click += new System.EventHandler(this.btnVNATStop_Click);
            // 
            // labVUnity
            // 
            this.labVUnity.AutoSize = true;
            this.labVUnity.Location = new System.Drawing.Point(15, 80);
            this.labVUnity.Name = "labVUnity";
            this.labVUnity.Size = new System.Drawing.Size(40, 17);
            this.labVUnity.TabIndex = 6;
            this.labVUnity.Text = "Unity:";
            // 
            // labVDHCP
            // 
            this.labVDHCP.AutoSize = true;
            this.labVDHCP.Location = new System.Drawing.Point(15, 54);
            this.labVDHCP.Name = "labVDHCP";
            this.labVDHCP.Size = new System.Drawing.Size(44, 17);
            this.labVDHCP.TabIndex = 5;
            this.labVDHCP.Text = "DHCP:";
            // 
            // btnVNATRun
            // 
            this.btnVNATRun.Enabled = false;
            this.btnVNATRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnVNATRun.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnVNATRun.Location = new System.Drawing.Point(201, 25);
            this.btnVNATRun.Name = "btnVNATRun";
            this.btnVNATRun.Size = new System.Drawing.Size(50, 23);
            this.btnVNATRun.TabIndex = 3;
            this.btnVNATRun.Text = "启动";
            this.btnVNATRun.UseVisualStyleBackColor = true;
            this.btnVNATRun.Click += new System.EventHandler(this.btnVNATRun_Click);
            // 
            // labVNATTxt
            // 
            this.labVNATTxt.AutoSize = true;
            this.labVNATTxt.Location = new System.Drawing.Point(65, 28);
            this.labVNATTxt.Name = "labVNATTxt";
            this.labVNATTxt.Size = new System.Drawing.Size(23, 17);
            this.labVNATTxt.TabIndex = 3;
            this.labVNATTxt.Text = "---";
            this.labVNATTxt.DoubleClick += new System.EventHandler(this.labVNATTxt_DoubleClick);
            // 
            // labVNAT
            // 
            this.labVNAT.AutoSize = true;
            this.labVNAT.Location = new System.Drawing.Point(15, 28);
            this.labVNAT.Name = "labVNAT";
            this.labVNAT.Size = new System.Drawing.Size(36, 17);
            this.labVNAT.TabIndex = 0;
            this.labVNAT.Text = "NAT:";
            // 
            // textConsole
            // 
            this.textConsole.BackColor = System.Drawing.Color.Black;
            this.textConsole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConsole.ForeColor = System.Drawing.Color.White;
            this.textConsole.Location = new System.Drawing.Point(20, 329);
            this.textConsole.Multiline = true;
            this.textConsole.Name = "textConsole";
            this.textConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textConsole.Size = new System.Drawing.Size(292, 131);
            this.textConsole.TabIndex = 7;
            this.textConsole.TextChanged += new System.EventHandler(this.textConsole_TextChanged);
            // 
            // btnRunFileZilla
            // 
            this.btnRunFileZilla.Enabled = false;
            this.btnRunFileZilla.Image = global::_20171009_MAVIF_beta.Properties.Resources.FileZilla_Server_exe_10_;
            this.btnRunFileZilla.Location = new System.Drawing.Point(473, 12);
            this.btnRunFileZilla.Name = "btnRunFileZilla";
            this.btnRunFileZilla.Size = new System.Drawing.Size(40, 40);
            this.btnRunFileZilla.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnRunFileZilla, "打开FileZilla Server Interface");
            this.btnRunFileZilla.UseVisualStyleBackColor = true;
            this.btnRunFileZilla.Click += new System.EventHandler(this.btnRunFileZilla_Click);
            // 
            // btnRunVMware
            // 
            this.btnRunVMware.Enabled = false;
            this.btnRunVMware.Image = global::_20171009_MAVIF_beta.Properties.Resources.vmware_exe_1_;
            this.btnRunVMware.Location = new System.Drawing.Point(519, 12);
            this.btnRunVMware.Name = "btnRunVMware";
            this.btnRunVMware.Size = new System.Drawing.Size(40, 40);
            this.btnRunVMware.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnRunVMware, "打开VMware Workstation");
            this.btnRunVMware.UseVisualStyleBackColor = true;
            this.btnRunVMware.Click += new System.EventHandler(this.btnRunVMware_Click);
            // 
            // btnRunApache
            // 
            this.btnRunApache.Enabled = false;
            this.btnRunApache.Image = global::_20171009_MAVIF_beta.Properties.Resources.ApacheMonitor_exe_106_;
            this.btnRunApache.Location = new System.Drawing.Point(427, 12);
            this.btnRunApache.Name = "btnRunApache";
            this.btnRunApache.Size = new System.Drawing.Size(40, 40);
            this.btnRunApache.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnRunApache, "打开Apache Monitor");
            this.btnRunApache.UseVisualStyleBackColor = true;
            this.btnRunApache.Click += new System.EventHandler(this.btnRunApache_Click);
            // 
            // btnRunNetwork
            // 
            this.btnRunNetwork.Image = global::_20171009_MAVIF_beta.Properties.Resources.shell32_dll_273_;
            this.btnRunNetwork.Location = new System.Drawing.Point(565, 12);
            this.btnRunNetwork.Name = "btnRunNetwork";
            this.btnRunNetwork.Size = new System.Drawing.Size(40, 40);
            this.btnRunNetwork.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnRunNetwork, "打开网络和共享中心");
            this.btnRunNetwork.UseVisualStyleBackColor = true;
            this.btnRunNetwork.Click += new System.EventHandler(this.btnRunNetwork_Click);
            // 
            // btnRunServices
            // 
            this.btnRunServices.Image = global::_20171009_MAVIF_beta.Properties.Resources.filemgmt_dll_236_;
            this.btnRunServices.Location = new System.Drawing.Point(611, 12);
            this.btnRunServices.Name = "btnRunServices";
            this.btnRunServices.Size = new System.Drawing.Size(40, 40);
            this.btnRunServices.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnRunServices, "打开系统服务");
            this.btnRunServices.UseVisualStyleBackColor = true;
            this.btnRunServices.Click += new System.EventHandler(this.btnRunServices_Click);
            // 
            // cBoxI
            // 
            this.cBoxI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxI.FormattingEnabled = true;
            this.cBoxI.ItemHeight = 17;
            this.cBoxI.Location = new System.Drawing.Point(67, 25);
            this.cBoxI.Name = "cBoxI";
            this.cBoxI.Size = new System.Drawing.Size(240, 25);
            this.cBoxI.TabIndex = 1;
            this.cBoxI.SelectedIndexChanged += new System.EventHandler(this.cBoxI_SelectedIndexChanged);
            // 
            // gIP
            // 
            this.gIP.Controls.Add(this.btnIReFresh);
            this.gIP.Controls.Add(this.labIInfo);
            this.gIP.Controls.Add(this.labIType);
            this.gIP.Controls.Add(this.labIStatus);
            this.gIP.Controls.Add(this.labIIP);
            this.gIP.Controls.Add(this.btnIDHCP);
            this.gIP.Controls.Add(this.btnISetIP);
            this.gIP.Controls.Add(this.tBLanIP4);
            this.gIP.Controls.Add(this.tBLanIP3);
            this.gIP.Controls.Add(this.tBLanIP2);
            this.gIP.Controls.Add(this.tBLanIP1);
            this.gIP.Controls.Add(this.labI);
            this.gIP.Controls.Add(this.cBoxI);
            this.gIP.Controls.Add(this.labILanDot);
            this.gIP.Location = new System.Drawing.Point(331, 65);
            this.gIP.Name = "gIP";
            this.gIP.Size = new System.Drawing.Size(320, 228);
            this.gIP.TabIndex = 3;
            this.gIP.TabStop = false;
            this.gIP.Text = " IP Settings ";
            // 
            // btnIReFresh
            // 
            this.btnIReFresh.Location = new System.Drawing.Point(17, 87);
            this.btnIReFresh.Name = "btnIReFresh";
            this.btnIReFresh.Size = new System.Drawing.Size(41, 72);
            this.btnIReFresh.TabIndex = 33;
            this.btnIReFresh.Text = "刷新\r\n网络\r\n信息";
            this.btnIReFresh.UseVisualStyleBackColor = true;
            this.btnIReFresh.Click += new System.EventHandler(this.btnIReFresh_Click);
            // 
            // labIInfo
            // 
            this.labIInfo.AutoSize = true;
            this.labIInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIInfo.Location = new System.Drawing.Point(64, 118);
            this.labIInfo.Name = "labIInfo";
            this.labIInfo.Size = new System.Drawing.Size(175, 56);
            this.labIInfo.TabIndex = 32;
            this.labIInfo.Text = "   Mask: 255.255.255.255\r\nGateway: 255.255.255.255\r\n    DNS: 255.255.255.255\r\n   " +
    "      255.255.255.255";
            // 
            // labIType
            // 
            this.labIType.AutoSize = true;
            this.labIType.BackColor = System.Drawing.SystemColors.Control;
            this.labIType.ForeColor = System.Drawing.Color.Blue;
            this.labIType.Location = new System.Drawing.Point(14, 60);
            this.labIType.Name = "labIType";
            this.labIType.Size = new System.Drawing.Size(44, 17);
            this.labIType.TabIndex = 30;
            this.labIType.Text = "有线网";
            // 
            // labIStatus
            // 
            this.labIStatus.AutoSize = true;
            this.labIStatus.ForeColor = System.Drawing.Color.Red;
            this.labIStatus.Location = new System.Drawing.Point(64, 60);
            this.labIStatus.Name = "labIStatus";
            this.labIStatus.Size = new System.Drawing.Size(44, 17);
            this.labIStatus.TabIndex = 19;
            this.labIStatus.Text = "未连接";
            // 
            // labIIP
            // 
            this.labIIP.AutoSize = true;
            this.labIIP.Location = new System.Drawing.Point(119, 60);
            this.labIIP.Name = "labIIP";
            this.labIIP.Size = new System.Drawing.Size(119, 17);
            this.labIIP.TabIndex = 18;
            this.labIIP.Text = "IP: 255.255.255.255";
            // 
            // btnIDHCP
            // 
            this.btnIDHCP.Enabled = false;
            this.btnIDHCP.Location = new System.Drawing.Point(244, 56);
            this.btnIDHCP.Name = "btnIDHCP";
            this.btnIDHCP.Size = new System.Drawing.Size(63, 25);
            this.btnIDHCP.TabIndex = 2;
            this.btnIDHCP.Text = "DHCP";
            this.btnIDHCP.UseVisualStyleBackColor = true;
            // 
            // btnISetIP
            // 
            this.btnISetIP.BackColor = System.Drawing.Color.OrangeRed;
            this.btnISetIP.Enabled = false;
            this.btnISetIP.ForeColor = System.Drawing.Color.White;
            this.btnISetIP.Location = new System.Drawing.Point(244, 87);
            this.btnISetIP.Name = "btnISetIP";
            this.btnISetIP.Size = new System.Drawing.Size(63, 25);
            this.btnISetIP.TabIndex = 3;
            this.btnISetIP.Text = "设定IP";
            this.btnISetIP.UseVisualStyleBackColor = false;
            // 
            // tBLanIP4
            // 
            this.tBLanIP4.Location = new System.Drawing.Point(199, 88);
            this.tBLanIP4.Name = "tBLanIP4";
            this.tBLanIP4.Size = new System.Drawing.Size(36, 23);
            this.tBLanIP4.TabIndex = 15;
            this.tBLanIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBLanIP4.TextChanged += new System.EventHandler(this.tBLanIP4_TextChanged);
            // 
            // tBLanIP3
            // 
            this.tBLanIP3.Location = new System.Drawing.Point(155, 88);
            this.tBLanIP3.Name = "tBLanIP3";
            this.tBLanIP3.Size = new System.Drawing.Size(36, 23);
            this.tBLanIP3.TabIndex = 14;
            this.tBLanIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBLanIP3.TextChanged += new System.EventHandler(this.tBLanIP3_TextChanged);
            // 
            // tBLanIP2
            // 
            this.tBLanIP2.Location = new System.Drawing.Point(111, 88);
            this.tBLanIP2.Name = "tBLanIP2";
            this.tBLanIP2.Size = new System.Drawing.Size(36, 23);
            this.tBLanIP2.TabIndex = 13;
            this.tBLanIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBLanIP2.TextChanged += new System.EventHandler(this.tBLanIP2_TextChanged);
            // 
            // tBLanIP1
            // 
            this.tBLanIP1.Location = new System.Drawing.Point(67, 88);
            this.tBLanIP1.Name = "tBLanIP1";
            this.tBLanIP1.Size = new System.Drawing.Size(36, 23);
            this.tBLanIP1.TabIndex = 12;
            this.tBLanIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBLanIP1.TextChanged += new System.EventHandler(this.tBLanIP1_TextChanged);
            // 
            // labI
            // 
            this.labI.AutoSize = true;
            this.labI.Location = new System.Drawing.Point(14, 28);
            this.labI.Name = "labI";
            this.labI.Size = new System.Drawing.Size(44, 17);
            this.labI.TabIndex = 10;
            this.labI.Text = "适配器";
            this.labI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labILanDot
            // 
            this.labILanDot.AutoSize = true;
            this.labILanDot.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labILanDot.Location = new System.Drawing.Point(53, 93);
            this.labILanDot.Name = "labILanDot";
            this.labILanDot.Size = new System.Drawing.Size(149, 20);
            this.labILanDot.TabIndex = 29;
            this.labILanDot.Text = "            .          .          .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 474);
            this.Controls.Add(this.btnRunFileZilla);
            this.Controls.Add(this.btnRunVMware);
            this.Controls.Add(this.btnRunApache);
            this.Controls.Add(this.btnRunNetwork);
            this.Controls.Add(this.gIP);
            this.Controls.Add(this.btnRunServices);
            this.Controls.Add(this.textConsole);
            this.Controls.Add(this.gVMware);
            this.Controls.Add(this.gFileZilla);
            this.Controls.Add(this.gApache);
            this.Controls.Add(this.btnMSetManual);
            this.Controls.Add(this.labTitle2);
            this.Controls.Add(this.labTitle1);
            this.Controls.Add(this.gMySQL);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAVIF 0.2 Alpha By Ty.Chen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gMySQL.ResumeLayout(false);
            this.gMySQL.PerformLayout();
            this.gApache.ResumeLayout(false);
            this.gApache.PerformLayout();
            this.gFileZilla.ResumeLayout(false);
            this.gFileZilla.PerformLayout();
            this.gVMware.ResumeLayout(false);
            this.gVMware.PerformLayout();
            this.gIP.ResumeLayout(false);
            this.gIP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gMySQL;
        private System.Windows.Forms.Label labTitle1;
        private System.Windows.Forms.Label labTitle2;
        private System.Windows.Forms.Label labMStatus;
        private System.Windows.Forms.Label labMSN;
        private System.Windows.Forms.Label labMStatusTxt;
        private System.Windows.Forms.Label labMSNTxt;
        private System.Windows.Forms.Button btnMStop;
        private System.Windows.Forms.Button btnMRun;
        private System.Windows.Forms.Button btnMSetManual;
        private System.Windows.Forms.GroupBox gApache;
        private System.Windows.Forms.Button btnAStop;
        private System.Windows.Forms.Button btnARun;
        private System.Windows.Forms.Label labASNTxt;
        private System.Windows.Forms.Label labAStatusTxt;
        private System.Windows.Forms.Label labAStatus;
        private System.Windows.Forms.Label labASN;
        private System.Windows.Forms.GroupBox gFileZilla;
        private System.Windows.Forms.Button btnFStop;
        private System.Windows.Forms.Button btnFRun;
        private System.Windows.Forms.Label labFSNTxt;
        private System.Windows.Forms.Label labFStatusTxt;
        private System.Windows.Forms.Label labFStatus;
        private System.Windows.Forms.Label labFSN;
        private System.Windows.Forms.GroupBox gVMware;
        private System.Windows.Forms.Label labVUSBTxt;
        private System.Windows.Forms.Label labVUnityTxt;
        private System.Windows.Forms.Label labVDHCPTxt;
        private System.Windows.Forms.Label labVUSB;
        private System.Windows.Forms.Label labVUnity;
        private System.Windows.Forms.Label labVDHCP;
        private System.Windows.Forms.Label labVNATTxt;
        private System.Windows.Forms.Label labVNAT;
        private System.Windows.Forms.Button btnVNATStop;
        private System.Windows.Forms.Button btnVNATRun;
        private System.Windows.Forms.Label labVRemoteTxt;
        private System.Windows.Forms.Label labVRemote;
        private System.Windows.Forms.Button btnVRemoteDisable;
        private System.Windows.Forms.Button btnVUSBStop;
        private System.Windows.Forms.Button btnVUSBRun;
        private System.Windows.Forms.Button btnVUnityStop;
        private System.Windows.Forms.Button btnVUnityRun;
        private System.Windows.Forms.Button btnVDHCPStop;
        private System.Windows.Forms.Button btnVDHCPRun;
        private System.Windows.Forms.Button btnVRemoteStop;
        private System.Windows.Forms.TextBox textConsole;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRunServices;
        private System.Windows.Forms.ComboBox cBoxI;
        private System.Windows.Forms.GroupBox gIP;
        private System.Windows.Forms.Label labI;
        private System.Windows.Forms.TextBox tBLanIP4;
        private System.Windows.Forms.TextBox tBLanIP3;
        private System.Windows.Forms.TextBox tBLanIP2;
        private System.Windows.Forms.TextBox tBLanIP1;
        private System.Windows.Forms.Button btnISetIP;
        private System.Windows.Forms.Label labIStatus;
        private System.Windows.Forms.Label labIIP;
        private System.Windows.Forms.Button btnIDHCP;
        private System.Windows.Forms.Label labILanDot;
        private System.Windows.Forms.Button btnRunNetwork;
        private System.Windows.Forms.Button btnRunApache;
        private System.Windows.Forms.Button btnRunVMware;
        private System.Windows.Forms.Button btnRunFileZilla;
        private System.Windows.Forms.Label labIType;
        private System.Windows.Forms.Label labIInfo;
        private System.Windows.Forms.Button btnIReFresh;
    }
}

