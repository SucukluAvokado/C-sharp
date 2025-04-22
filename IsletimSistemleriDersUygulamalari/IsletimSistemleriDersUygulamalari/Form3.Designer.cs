
namespace IsletimSistemleriDersUygulamalari
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 715);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(376, 34);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblSonuc.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(379, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 738);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Win32_Fan",
            "Win32_HeatPipe",
            "Win32_Refrigeration",
            "Win32_TemperatureProbe",
            "Win32_Keyboard",
            "Win32_PointingDevice",
            "Win32_AutochkSetting",
            "Win32_CDROMDrive",
            "Win32_DiskDrive",
            "Win32_FloppyDrive",
            "Win32_PhysicalMedia",
            "Win32_TapeDrive",
            "Win32_1394ControllerDevice",
            "Win32_AllocatedResource",
            "Win32_AssociatedProcessorMemory",
            "Win32_BaseBoard",
            "Win32_BIOS",
            "Win32_Bus",
            "Win32_CacheMemory",
            "Win32_ControllerHasHub",
            "Win32_DeviceBus",
            "Win32_DeviceMemoryAddress",
            "Win32_DeviceSettings",
            "Win32_DMAChannel",
            "Win32_FloppyController",
            "Win32_IDEController",
            "Win32_IDEControllerDevice",
            "Win32_InfraredDevice",
            "Win32_IRQResource",
            "Win32_MemoryArray",
            "Win32_MemoryArrayLocation",
            "Win32_MemoryDevice",
            "Win32_MemoryDeviceArray",
            "Win32_MemoryDeviceLocation",
            "Win32_MotherboardDevice",
            "Win32_OnBoardDevice",
            "Win32_ParallelPort",
            "Win32_PCMCIAController",
            "Win32_PhysicalMemory",
            "Win32_PhysicalMemoryArray",
            "Win32_PhysicalMemoryLocation",
            "Win32_PNPAllocatedResource",
            "Win32_PNPDevice",
            "Win32_PNPEntity",
            "Win32_PortConnector",
            "Win32_PortResource",
            "Win32_Processor",
            "Win32_SCSIController",
            "Win32_SCSIControllerDevice",
            "Win32_SerialPort",
            "Win32_SerialPortConfiguration",
            "Win32_SerialPortSetting",
            "Win32_SMBIOSMemory",
            "Win32_SoundDevice",
            "Win32_SystemBIOS",
            "Win32_SystemDriverPNPEntity",
            "Win32_SystemEnclosure",
            "Win32_SystemMemoryResource",
            "Win32_SystemSlot",
            "Win32_USBController",
            "Win32_USBControllerDevice",
            "Win32_USBHub",
            "Win32_NetworkAdapter",
            "Win32_NetworkAdapterConfiguration",
            "Win32_NetworkAdapterSetting",
            "Win32_Battery",
            "Win32_CurrentProbe",
            "Win32_PortableBattery",
            "Win32_PowerManagementEvent",
            "Win32_VoltageProbe",
            "Win32_DriverForDevice",
            "Win32_Printer",
            "Win32_PrinterConfiguration",
            "Win32_PrinterController",
            "Win32_PrinterDriver",
            "Win32_PrinterDriverDll",
            "Win32_PrinterSetting",
            "Win32_PrintJob",
            "Win32_TCPIPPrinterPort",
            "Win32_POTSModem",
            "Win32_POTSModemToSerialPort",
            "Win32_DesktopMonitor",
            "Win32_DisplayControllerConfiguration",
            "Win32_VideoController",
            "Win32_VideoSettings",
            "Win32_ClassicCOMApplicationClasses",
            "Win32_ClassicCOMClass",
            "Win32_ClassicCOMClassSettings",
            "Win32_ClientApplicationSetting",
            "Win32_COMApplication",
            "Win32_COMApplicationClasses",
            "Win32_COMApplicationSettings",
            "Win32_COMClass",
            "Win32_ComClassAutoEmulator",
            "Win32_ComClassEmulator",
            "Win32_ComponentCategory",
            "Win32_COMSetting",
            "Win32_DCOMApplication",
            "Win32_DCOMApplicationAccessAllowedSetting",
            "Win32_DCOMApplicationLaunchAllowedSetting",
            "Win32_DCOMApplicationSetting",
            "Win32_ImplementedCategory",
            "Win32_Desktop",
            "Win32_Environment",
            "Win32_TimeZone",
            "Win32_UserDesktop",
            "Win32_SystemDriver",
            "Win32_CIMLogicalDeviceCIMDataFile",
            "Win32_Directory",
            "Win32_DirectorySpecification",
            "Win32_DiskDriveToDiskPartition",
            "Win32_DiskPartition",
            "Win32_DiskQuota",
            "Win32_LogicalDisk",
            "Win32_LogicalDiskRootDirectory",
            "Win32_LogicalDiskToPartition",
            "Win32_MappedLogicalDisk",
            "Win32_OperatingSystemAutochkSetting",
            "Win32_QuotaSetting",
            "Win32_ShortcutFile",
            "Win32_SubDirectory",
            "Win32_SystemPartitions",
            "Win32_Volume",
            "Win32_VolumeQuota",
            "Win32_VolumeQuotaSetting",
            "Win32_VolumeUserQuota",
            "Win32_CollectionStatistics",
            "Win32_LUID",
            "Win32_LUIDandAttributes",
            "Win32_NamedJobObject",
            "Win32_NamedJobObjectActgInfo",
            "Win32_NamedJobObjectLimit",
            "Win32_NamedJobObjectLimitSetting",
            "Win32_NamedJobObjectProcess",
            "Win32_NamedJobObjectSecLimit",
            "Win32_NamedJobObjectSecLimitSetting",
            "Win32_NamedJobObjectStatistics",
            "Win32_SIDandAttributes",
            "Win32_TokenGroups",
            "Win32_TokenPrivileges",
            "Win32_PageFile",
            "Win32_PageFileElementSetting",
            "Win32_PageFileSetting",
            "Win32_PageFileUsage",
            "Win32_CodecFile",
            "Win32_ActiveRoute",
            "Win32_IP4PersistedRouteTable",
            "Win32_IP4RouteTable",
            "Win32_IP4RouteTableEvent",
            "Win32_NetworkClient",
            "Win32_NetworkConnection",
            "Win32_NetworkProtocol",
            "Win32_NTDomain",
            "Win32_PingStatus",
            "Win32_ProtocolBinding",
            "Win32_ComputerShutdownEvent",
            "Win32_ComputerSystemEvent",
            "Win32_DeviceChangeEvent",
            "Win32_ModuleLoadTrace",
            "Win32_ModuleTrace",
            "Win32_ProcessStartTrace",
            "Win32_ProcessStopTrace",
            "Win32_ProcessTrace",
            "Win32_SystemConfigurationChangeEvent",
            "Win32_SystemTrace",
            "Win32_ThreadStartTrace",
            "Win32_ThreadStopTrace",
            "Win32_ThreadTrace",
            "Win32_VolumeChangeEvent",
            "Win32_BootConfiguration",
            "Win32_ComputerSystem",
            "Win32_ComputerSystemProcessor",
            "Win32_ComputerSystemProduct",
            "Win32_DependentService",
            "Win32_LoadOrderGroup",
            "Win32_LoadOrderGroupServiceDependencies",
            "Win32_LoadOrderGroupServiceMembers",
            "Win32_OperatingSystem",
            "Win32_OperatingSystemQFE",
            "Win32_OSRecoveryConfiguration",
            "Win32_QuickFixEngineering",
            "Win32_StartupCommand",
            "Win32_SystemBootConfiguration",
            "Win32_SystemDesktop",
            "Win32_SystemDevices",
            "Win32_SystemLoadOrderGroups",
            "Win32_SystemNetworkConnections",
            "Win32_SystemOperatingSystem",
            "Win32_SystemProcesses",
            "Win32_SystemProgramGroups",
            "Win32_SystemResources",
            "Win32_SystemServices",
            "Win32_SystemSetting",
            "Win32_SystemSystemDriver",
            "Win32_SystemTimeZone",
            "Win32_SystemUsers",
            "Win32_Process",
            "Win32_ProcessStartup",
            "Win32_Thread",
            "Win32_Registry",
            "Win32_CurrentTime",
            "Win32_ScheduledJob",
            "Win32_LocalTime",
            "Win32_UTCTime",
            "Win32_AccountSID",
            "Win32_ACE",
            "Win32_LogicalFileAccess",
            "Win32_LogicalFileAuditing",
            "Win32_LogicalFileGroup",
            "Win32_LogicalFileOwner",
            "Win32_LogicalFileSecuritySetting",
            "Win32_LogicalShareAccess",
            "Win32_LogicalShareAuditing",
            "Win32_LogicalShareSecuritySetting",
            "Win32_PrivilegesStatus",
            "Win32_SecurityDescriptor",
            "Win32_SecuritySetting",
            "Win32_SecuritySettingAccess",
            "Win32_SecuritySettingAuditing",
            "Win32_SecuritySettingGroup",
            "Win32_SecuritySettingOfLogicalFile",
            "Win32_SecuritySettingOfLogicalShare",
            "Win32_SecuritySettingOfObject",
            "Win32_SecuritySettingOwner",
            "Win32_SID",
            "Win32_Trustee",
            "Win32_BaseService",
            "Win32_Service",
            "Win32_DFSNode",
            "Win32_DFSNodeTarget",
            "Win32_DFSTarget",
            "Win32_ServerConnection",
            "Win32_ServerSession",
            "Win32_ConnectionShare",
            "Win32_PrinterShare",
            "Win32_SessionConnection",
            "Win32_SessionProcess",
            "Win32_ShareToDirectory",
            "Win32_Share",
            "Win32_LogicalProgramGroup",
            "Win32_LogicalProgramGroupDirectory",
            "Win32_LogicalProgramGroupItem",
            "Win32_LogicalProgramGroupItemDataFile",
            "Win32_ProgramGroupContents",
            "Win32_ProgramGroupOrItem",
            "Win32_ShadowBy",
            "Win32_ShadowContext",
            "Win32_ShadowCopy",
            "Win32_ShadowDiffVolumeSupport",
            "Win32_ShadowFor",
            "Win32_ShadowOn",
            "Win32_ShadowProvider",
            "Win32_ShadowStorage",
            "Win32_ShadowVolumeSupport",
            "Win32_Volume",
            "Win32_VolumeUserQuota",
            "Win32_Account",
            "Win32_Group",
            "Win32_GroupInDomain",
            "Win32_GroupUser",
            "Win32_LogonSession",
            "Win32_LogonSessionMappedDisk",
            "Win32_NetworkLoginProfile",
            "Win32_SystemAccount",
            "Win32_UserAccount",
            "Win32_UserInDomain",
            "Windows Event Log",
            "Win32_NTEventlogFile",
            "Win32_NTLogEvent",
            "Win32_NTLogEventComputer",
            "Win32_NTLogEventLog",
            "Win32_NTLogEventUser",
            "Win32_ComputerSystemWindowsProductActivationSetting",
            "Win32_Proxy",
            "Win32_WindowsProductActivation",
            "Win32_Perf",
            "Win32_PerfFormattedData",
            "Win32_PerfRawData",
            "Win32_MethodParameterClass",
            "Win32_WMISetting",
            "Win32_WMIElementSetting"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 693);
            this.listBox1.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 762);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSonuc);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}