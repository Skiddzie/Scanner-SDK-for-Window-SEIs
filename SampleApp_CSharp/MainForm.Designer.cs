namespace Scanner_SDK_Sample_Application
{
    partial class frmScannerApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScannerApp));
            this.grpTrigger = new System.Windows.Forms.GroupBox();
            this.btnReleaseTrigger = new System.Windows.Forms.Button();
            this.btnPullTrigger = new System.Windows.Forms.Button();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblSlctScnnr = new System.Windows.Forms.Label();
            this.combSlcrScnr = new System.Windows.Forms.ComboBox();
            this.grpScanners = new System.Windows.Forms.GroupBox();
            this.lstvScanners = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFrmwr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMnftrd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGetScanners = new System.Windows.Forms.Button();
            this.openFileDialogFW = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNewEpcId = new System.Windows.Forms.TextBox();
            this.chkAutoIncrement = new System.Windows.Forms.CheckBox();
            this.openFileDialogAttr = new System.Windows.Forms.OpenFileDialog();
            this.stStripResult = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblIbmhid = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblSnapi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIBMTT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblHidkb = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblSsi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLblNxmdb = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveImgFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogWavFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogDADF = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogBarcodePath = new System.Windows.Forms.FolderBrowserDialog();
            this.tabXml = new System.Windows.Forms.TabPage();
            this.btnClearXmlArea = new System.Windows.Forms.Button();
            this.btnClearLogsArea = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.grpOutXml = new System.Windows.Forms.GroupBox();
            this.txtOutXml = new System.Windows.Forms.TextBox();
            this.tabSSW = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEpcId = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtUserBank = new System.Windows.Forms.TextBox();
            this.txtUpcaBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.rdoASCII = new System.Windows.Forms.RadioButton();
            this.btnVerifyTag = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteTag = new System.Windows.Forms.Button();
            this.cmbPartition = new System.Windows.Forms.ComboBox();
            this.cmbFilterValue = new System.Windows.Forms.ComboBox();
            this.statusIcon = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblUserBank = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.grpMiscOther = new System.Windows.Forms.GroupBox();
            this.grpSCdcSwitch = new System.Windows.Forms.GroupBox();
            this.btnSCdcSwitchDevices = new System.Windows.Forms.Button();
            this.chkSCdcSIsPermanent = new System.Windows.Forms.CheckBox();
            this.chkSCdcSIsSilent = new System.Windows.Forms.CheckBox();
            this.comboSCdcSHostMode = new System.Windows.Forms.ComboBox();
            this.lblSCdcSHostMode = new System.Windows.Forms.Label();
            this.grpMiscCmd = new System.Windows.Forms.GroupBox();
            this.btnGetDevTopology = new System.Windows.Forms.Button();
            this.btnSdkVersion = new System.Windows.Forms.Button();
            this.grpAsync = new System.Windows.Forms.GroupBox();
            this.chkAsync = new System.Windows.Forms.CheckBox();
            this.tabScan2Connect = new System.Windows.Forms.TabPage();
            this.grpScan2Connect = new System.Windows.Forms.GroupBox();
            this.btnSaveBarcode = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbHostName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbScannerType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picBBarcode = new System.Windows.Forms.PictureBox();
            this.cmbImageSize = new System.Windows.Forms.ComboBox();
            this.cmbDefaultOption = new System.Windows.Forms.ComboBox();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.grpCustomDecodeTone = new System.Windows.Forms.GroupBox();
            this.btnEraseTone = new System.Windows.Forms.Button();
            this.buttonWavFileUpload = new System.Windows.Forms.Button();
            this.textBoxWavFile = new System.Windows.Forms.TextBox();
            this.buttonWavFileBrowse = new System.Windows.Forms.Button();
            this.filterScnrs = new System.Windows.Forms.GroupBox();
            this.comboFilterScnrs = new System.Windows.Forms.ComboBox();
            this.grpFrmWrUpdate = new System.Windows.Forms.GroupBox();
            this.grpFWoptns = new System.Windows.Forms.GroupBox();
            this.chkBulk = new System.Windows.Forms.CheckBox();
            this.btnAbortFWUpdate = new System.Windows.Forms.Button();
            this.btnFWUpdate = new System.Windows.Forms.Button();
            this.btnLaunchNewFW = new System.Windows.Forms.Button();
            this.progressBarFWUpdate = new System.Windows.Forms.ProgressBar();
            this.buttonFWBrowse = new System.Windows.Forms.Button();
            this.txtFWFile = new System.Windows.Forms.TextBox();
            this.grpScannerProp = new System.Windows.Forms.GroupBox();
            this.chkClaim = new System.Windows.Forms.CheckBox();
            this.grpElectricFenceCustomTone = new System.Windows.Forms.GroupBox();
            this.btnElectricFenceEraseTone = new System.Windows.Forms.Button();
            this.buttonElectricFenceWavFileUpload = new System.Windows.Forms.Button();
            this.textBoxElectricFenceWaveFile = new System.Windows.Forms.TextBox();
            this.buttonElectricFenceWavFileBrowse = new System.Windows.Forms.Button();
            this.tabBarcode = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScriptEditor = new System.Windows.Forms.Button();
            this.btnBrowseScript = new System.Windows.Forms.Button();
            this.chkBoxAppADF = new System.Windows.Forms.CheckBox();
            this.grpBoxLanguage = new System.Windows.Forms.GroupBox();
            this.chkBoxEmulation = new System.Windows.Forms.CheckBox();
            this.cmbEmulation = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.grpboxBarcodeLbl = new System.Windows.Forms.GroupBox();
            this.lblSyblogy = new System.Windows.Forms.Label();
            this.txtSyblogy = new System.Windows.Forms.TextBox();
            this.lblDecdBarCde = new System.Windows.Forms.Label();
            this.txtBarcodeLbl = new System.Windows.Forms.TextBox();
            this.btnAbortMacroPdf = new System.Windows.Forms.Button();
            this.btnBarcodeClear = new System.Windows.Forms.Button();
            this.btnFlushMacroPdf = new System.Windows.Forms.Button();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.grpTrigger.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpScanners.SuspendLayout();
            this.stStripResult.SuspendLayout();
            this.tabXml.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.grpOutXml.SuspendLayout();
            this.tabSSW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).BeginInit();
            this.tabMisc.SuspendLayout();
            this.grpMiscOther.SuspendLayout();
            this.grpSCdcSwitch.SuspendLayout();
            this.grpMiscCmd.SuspendLayout();
            this.grpAsync.SuspendLayout();
            this.tabScan2Connect.SuspendLayout();
            this.grpScan2Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarcode)).BeginInit();
            this.tabConfig.SuspendLayout();
            this.grpCustomDecodeTone.SuspendLayout();
            this.filterScnrs.SuspendLayout();
            this.grpFrmWrUpdate.SuspendLayout();
            this.grpFWoptns.SuspendLayout();
            this.grpScannerProp.SuspendLayout();
            this.grpElectricFenceCustomTone.SuspendLayout();
            this.tabBarcode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxLanguage.SuspendLayout();
            this.grpboxBarcodeLbl.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTrigger
            // 
            this.grpTrigger.Controls.Add(this.btnReleaseTrigger);
            this.grpTrigger.Controls.Add(this.btnPullTrigger);
            this.grpTrigger.Location = new System.Drawing.Point(8, 435);
            this.grpTrigger.Name = "grpTrigger";
            this.grpTrigger.Size = new System.Drawing.Size(446, 53);
            this.grpTrigger.TabIndex = 3;
            this.grpTrigger.TabStop = false;
            this.grpTrigger.Text = "Soft Trigger";
            // 
            // btnReleaseTrigger
            // 
            this.btnReleaseTrigger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReleaseTrigger.Location = new System.Drawing.Point(290, 19);
            this.btnReleaseTrigger.Name = "btnReleaseTrigger";
            this.btnReleaseTrigger.Size = new System.Drawing.Size(110, 23);
            this.btnReleaseTrigger.TabIndex = 1;
            this.btnReleaseTrigger.Text = "Release Trigger";
            this.btnReleaseTrigger.UseVisualStyleBackColor = false;
            this.btnReleaseTrigger.Click += new System.EventHandler(this.btnReleaseTrigger_Click);
            // 
            // btnPullTrigger
            // 
            this.btnPullTrigger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPullTrigger.Location = new System.Drawing.Point(32, 19);
            this.btnPullTrigger.Name = "btnPullTrigger";
            this.btnPullTrigger.Size = new System.Drawing.Size(110, 23);
            this.btnPullTrigger.TabIndex = 0;
            this.btnPullTrigger.Text = "Pull Trigger";
            this.btnPullTrigger.UseVisualStyleBackColor = false;
            this.btnPullTrigger.Click += new System.EventHandler(this.btnPullTrigger_Click);
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Location = new System.Drawing.Point(0, 0);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(200, 100);
            this.gbAdvanced.TabIndex = 0;
            this.gbAdvanced.TabStop = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblSlctScnnr);
            this.grpGeneral.Controls.Add(this.grpTrigger);
            this.grpGeneral.Controls.Add(this.combSlcrScnr);
            this.grpGeneral.Controls.Add(this.grpScanners);
            this.grpGeneral.Controls.Add(this.btnGetScanners);
            this.grpGeneral.Location = new System.Drawing.Point(7, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(460, 494);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Selected Scanners";
            // 
            // lblSlctScnnr
            // 
            this.lblSlctScnnr.AutoSize = true;
            this.lblSlctScnnr.Location = new System.Drawing.Point(153, 52);
            this.lblSlctScnnr.Name = "lblSlctScnnr";
            this.lblSlctScnnr.Size = new System.Drawing.Size(80, 13);
            this.lblSlctScnnr.TabIndex = 66;
            this.lblSlctScnnr.Text = "Select Scanner";
            // 
            // combSlcrScnr
            // 
            this.combSlcrScnr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSlcrScnr.FormattingEnabled = true;
            this.combSlcrScnr.Location = new System.Drawing.Point(246, 50);
            this.combSlcrScnr.Name = "combSlcrScnr";
            this.combSlcrScnr.Size = new System.Drawing.Size(183, 21);
            this.combSlcrScnr.TabIndex = 1;
            // 
            // grpScanners
            // 
            this.grpScanners.Controls.Add(this.lstvScanners);
            this.grpScanners.Location = new System.Drawing.Point(8, 91);
            this.grpScanners.Name = "grpScanners";
            this.grpScanners.Size = new System.Drawing.Size(446, 338);
            this.grpScanners.TabIndex = 2;
            this.grpScanners.TabStop = false;
            this.grpScanners.Text = "Connected Scanners";
            // 
            // lstvScanners
            // 
            this.lstvScanners.BackColor = System.Drawing.Color.White;
            this.lstvScanners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmType,
            this.clmModel,
            this.clmFrmwr,
            this.clmMnftrd,
            this.clmSerial,
            this.clmGuid});
            this.lstvScanners.FullRowSelect = true;
            this.lstvScanners.GridLines = true;
            this.lstvScanners.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvScanners.HideSelection = false;
            this.lstvScanners.Location = new System.Drawing.Point(6, 19);
            this.lstvScanners.MultiSelect = false;
            this.lstvScanners.Name = "lstvScanners";
            this.lstvScanners.ShowItemToolTips = true;
            this.lstvScanners.Size = new System.Drawing.Size(434, 313);
            this.lstvScanners.TabIndex = 0;
            this.lstvScanners.UseCompatibleStateImageBehavior = false;
            this.lstvScanners.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "#";
            this.clmId.Width = 30;
            // 
            // clmType
            // 
            this.clmType.Text = "Com Interface";
            this.clmType.Width = 94;
            // 
            // clmModel
            // 
            this.clmModel.Text = "Model #";
            this.clmModel.Width = 132;
            // 
            // clmFrmwr
            // 
            this.clmFrmwr.Text = "Firmware";
            this.clmFrmwr.Width = 119;
            // 
            // clmMnftrd
            // 
            this.clmMnftrd.Text = "Built";
            // 
            // clmSerial
            // 
            this.clmSerial.Text = "Serial # or Port #";
            this.clmSerial.Width = 120;
            // 
            // clmGuid
            // 
            this.clmGuid.Text = "GUID";
            this.clmGuid.Width = 110;
            // 
            // btnGetScanners
            // 
            this.btnGetScanners.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGetScanners.Location = new System.Drawing.Point(26, 48);
            this.btnGetScanners.Name = "btnGetScanners";
            this.btnGetScanners.Size = new System.Drawing.Size(124, 23);
            this.btnGetScanners.TabIndex = 0;
            this.btnGetScanners.Text = "Discover Scanners";
            this.btnGetScanners.UseVisualStyleBackColor = false;
            this.btnGetScanners.Click += new System.EventHandler(this.btnGetScanners_Click);
            // 
            // openFileDialogFW
            // 
            this.openFileDialogFW.Filter = "Firmware files (*.dat)|*.dat|Plugin Files (*.SCNPLG)|*.SCNPLG";
            // 
            // txtNewEpcId
            // 
            this.txtNewEpcId.BackColor = System.Drawing.Color.White;
            this.txtNewEpcId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewEpcId.Location = new System.Drawing.Point(94, 80);
            this.txtNewEpcId.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewEpcId.Name = "txtNewEpcId";
            this.txtNewEpcId.ReadOnly = true;
            this.txtNewEpcId.Size = new System.Drawing.Size(193, 20);
            this.txtNewEpcId.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNewEpcId, "SGTIN 96 encoded");
            // 
            // chkAutoIncrement
            // 
            this.chkAutoIncrement.AutoSize = true;
            this.chkAutoIncrement.Location = new System.Drawing.Point(408, 107);
            this.chkAutoIncrement.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoIncrement.Name = "chkAutoIncrement";
            this.chkAutoIncrement.Size = new System.Drawing.Size(97, 17);
            this.chkAutoIncrement.TabIndex = 8;
            this.chkAutoIncrement.Text = "Auto increment";
            this.toolTip1.SetToolTip(this.chkAutoIncrement, "Increment provided serial number and write tags continuously.");
            this.chkAutoIncrement.UseVisualStyleBackColor = true;
            // 
            // openFileDialogAttr
            // 
            this.openFileDialogAttr.Filter = "xml files (*.xml)|*.xml";
            // 
            // stStripResult
            // 
            this.stStripResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stStripResult.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl,
            this.toolStripStatusLblTotal,
            this.toolStripStatusLblIbmhid,
            this.toolStripStatusLblSnapi,
            this.toolStripStatusIBMTT,
            this.toolStripStatusLblHidkb,
            this.toolStripStatusLblSsi,
            this.toolStripStatusLblNxmdb});
            this.stStripResult.Location = new System.Drawing.Point(0, 509);
            this.stStripResult.Name = "stStripResult";
            this.stStripResult.Size = new System.Drawing.Size(992, 22);
            this.stStripResult.TabIndex = 2;
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLbl.Size = new System.Drawing.Size(319, 17);
            this.toolStripStatusLbl.Text = "                                                                                 " +
    "                       ";
            // 
            // toolStripStatusLblTotal
            // 
            this.toolStripStatusLblTotal.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLblTotal.Name = "toolStripStatusLblTotal";
            this.toolStripStatusLblTotal.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblTotal.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLblTotal.Text = "Total = 0";
            // 
            // toolStripStatusLblIbmhid
            // 
            this.toolStripStatusLblIbmhid.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblIbmhid.Name = "toolStripStatusLblIbmhid";
            this.toolStripStatusLblIbmhid.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblIbmhid.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLblIbmhid.Text = "IBMHID = 0";
            // 
            // toolStripStatusLblSnapi
            // 
            this.toolStripStatusLblSnapi.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblSnapi.Name = "toolStripStatusLblSnapi";
            this.toolStripStatusLblSnapi.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblSnapi.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLblSnapi.Text = "SNAPI = 0";
            // 
            // toolStripStatusIBMTT
            // 
            this.toolStripStatusIBMTT.Name = "toolStripStatusIBMTT";
            this.toolStripStatusIBMTT.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusIBMTT.Text = "IBMTT = 0";
            // 
            // toolStripStatusLblHidkb
            // 
            this.toolStripStatusLblHidkb.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblHidkb.Name = "toolStripStatusLblHidkb";
            this.toolStripStatusLblHidkb.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblHidkb.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLblHidkb.Text = "HIDKB = 0";
            // 
            // toolStripStatusLblSsi
            // 
            this.toolStripStatusLblSsi.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblSsi.Name = "toolStripStatusLblSsi";
            this.toolStripStatusLblSsi.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblSsi.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLblSsi.Text = "SSI = 0";
            // 
            // toolStripStatusLblNxmdb
            // 
            this.toolStripStatusLblNxmdb.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLblNxmdb.Name = "toolStripStatusLblNxmdb";
            this.toolStripStatusLblNxmdb.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusLblNxmdb.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLblNxmdb.Text = "NXMODB = 0";
            // 
            // openFileDialogWavFile
            // 
            this.openFileDialogWavFile.FileName = "openFileDialogWavFile";
            this.openFileDialogWavFile.Filter = "Wav files (*.wav)|*.wav";
            // 
            // openFileDialogDADF
            // 
            this.openFileDialogDADF.Filter = "Driver ADF Script files (*.dadf)|*.dadf";
            // 
            // tabXml
            // 
            this.tabXml.Controls.Add(this.btnClearXmlArea);
            this.tabXml.Controls.Add(this.btnClearLogsArea);
            this.tabXml.Controls.Add(this.grpResult);
            this.tabXml.Controls.Add(this.grpOutXml);
            this.tabXml.Location = new System.Drawing.Point(4, 22);
            this.tabXml.Name = "tabXml";
            this.tabXml.Size = new System.Drawing.Size(511, 468);
            this.tabXml.TabIndex = 7;
            this.tabXml.Text = "Logs";
            this.tabXml.UseVisualStyleBackColor = true;
            // 
            // btnClearXmlArea
            // 
            this.btnClearXmlArea.Location = new System.Drawing.Point(306, 436);
            this.btnClearXmlArea.Name = "btnClearXmlArea";
            this.btnClearXmlArea.Size = new System.Drawing.Size(91, 23);
            this.btnClearXmlArea.TabIndex = 3;
            this.btnClearXmlArea.Text = "Clear XML Log";
            this.btnClearXmlArea.UseVisualStyleBackColor = true;
            this.btnClearXmlArea.Click += new System.EventHandler(this.btnClearXmlArea_Click);
            // 
            // btnClearLogsArea
            // 
            this.btnClearLogsArea.Location = new System.Drawing.Point(124, 436);
            this.btnClearLogsArea.Name = "btnClearLogsArea";
            this.btnClearLogsArea.Size = new System.Drawing.Size(96, 23);
            this.btnClearLogsArea.TabIndex = 2;
            this.btnClearLogsArea.Text = "Clear Event Log";
            this.btnClearLogsArea.UseVisualStyleBackColor = true;
            this.btnClearLogsArea.Click += new System.EventHandler(this.btnClearLogsArea_Click);
            // 
            // grpResult
            // 
            this.grpResult.BackColor = System.Drawing.SystemColors.Window;
            this.grpResult.Controls.Add(this.txtResults);
            this.grpResult.Location = new System.Drawing.Point(4, 3);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(490, 177);
            this.grpResult.TabIndex = 0;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Event Log";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.White;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(8, 19);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(476, 152);
            this.txtResults.TabIndex = 0;
            // 
            // grpOutXml
            // 
            this.grpOutXml.BackColor = System.Drawing.SystemColors.Window;
            this.grpOutXml.Controls.Add(this.txtOutXml);
            this.grpOutXml.Location = new System.Drawing.Point(4, 186);
            this.grpOutXml.Name = "grpOutXml";
            this.grpOutXml.Size = new System.Drawing.Size(490, 244);
            this.grpOutXml.TabIndex = 1;
            this.grpOutXml.TabStop = false;
            this.grpOutXml.Text = "XML Log";
            // 
            // txtOutXml
            // 
            this.txtOutXml.BackColor = System.Drawing.Color.White;
            this.txtOutXml.Location = new System.Drawing.Point(8, 16);
            this.txtOutXml.Multiline = true;
            this.txtOutXml.Name = "txtOutXml";
            this.txtOutXml.ReadOnly = true;
            this.txtOutXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutXml.Size = new System.Drawing.Size(476, 219);
            this.txtOutXml.TabIndex = 0;
            // 
            // tabSSW
            // 
            this.tabSSW.Controls.Add(this.btnClear);
            this.tabSSW.Controls.Add(this.txtEpcId);
            this.tabSSW.Controls.Add(this.txtSerialNumber);
            this.tabSSW.Controls.Add(this.txtUserBank);
            this.tabSSW.Controls.Add(this.txtNewEpcId);
            this.tabSSW.Controls.Add(this.txtUpcaBarcode);
            this.tabSSW.Controls.Add(this.label14);
            this.tabSSW.Controls.Add(this.rdoHex);
            this.tabSSW.Controls.Add(this.rdoASCII);
            this.tabSSW.Controls.Add(this.btnVerifyTag);
            this.tabSSW.Controls.Add(this.label7);
            this.tabSSW.Controls.Add(this.btnWriteTag);
            this.tabSSW.Controls.Add(this.cmbPartition);
            this.tabSSW.Controls.Add(this.cmbFilterValue);
            this.tabSSW.Controls.Add(this.statusIcon);
            this.tabSSW.Controls.Add(this.label21);
            this.tabSSW.Controls.Add(this.label22);
            this.tabSSW.Controls.Add(this.chkAutoIncrement);
            this.tabSSW.Controls.Add(this.lblUserBank);
            this.tabSSW.Controls.Add(this.label25);
            this.tabSSW.Controls.Add(this.label23);
            this.tabSSW.Location = new System.Drawing.Point(4, 22);
            this.tabSSW.Margin = new System.Windows.Forms.Padding(2);
            this.tabSSW.Name = "tabSSW";
            this.tabSSW.Size = new System.Drawing.Size(511, 468);
            this.tabSSW.TabIndex = 11;
            this.tabSSW.Text = "Scan Scan Write";
            this.tabSSW.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 103);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 24);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtEpcId
            // 
            this.txtEpcId.BackColor = System.Drawing.Color.White;
            this.txtEpcId.Location = new System.Drawing.Point(94, 53);
            this.txtEpcId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEpcId.Name = "txtEpcId";
            this.txtEpcId.ReadOnly = true;
            this.txtEpcId.Size = new System.Drawing.Size(193, 20);
            this.txtEpcId.TabIndex = 33;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(408, 80);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(90, 20);
            this.txtSerialNumber.TabIndex = 7;
            this.txtSerialNumber.TextChanged += new System.EventHandler(this.txtSerialNumber_TextChanged);
            this.txtSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNumber_KeyPress);
            // 
            // txtUserBank
            // 
            this.txtUserBank.BackColor = System.Drawing.Color.White;
            this.txtUserBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBank.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserBank.Location = new System.Drawing.Point(94, 150);
            this.txtUserBank.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserBank.Multiline = true;
            this.txtUserBank.Name = "txtUserBank";
            this.txtUserBank.ReadOnly = true;
            this.txtUserBank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserBank.Size = new System.Drawing.Size(193, 81);
            this.txtUserBank.TabIndex = 9;
            // 
            // txtUpcaBarcode
            // 
            this.txtUpcaBarcode.BackColor = System.Drawing.Color.White;
            this.txtUpcaBarcode.Location = new System.Drawing.Point(94, 25);
            this.txtUpcaBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpcaBarcode.Name = "txtUpcaBarcode";
            this.txtUpcaBarcode.ReadOnly = true;
            this.txtUpcaBarcode.Size = new System.Drawing.Size(193, 20);
            this.txtUpcaBarcode.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Existing EPC Id";
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdoHex.Location = new System.Drawing.Point(152, 233);
            this.rdoHex.Margin = new System.Windows.Forms.Padding(2);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(44, 17);
            this.rdoHex.TabIndex = 32;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            this.rdoHex.CheckedChanged += new System.EventHandler(this.rdoASCII_Binary_CheckedChanged);
            // 
            // rdoASCII
            // 
            this.rdoASCII.AutoSize = true;
            this.rdoASCII.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdoASCII.Location = new System.Drawing.Point(95, 232);
            this.rdoASCII.Margin = new System.Windows.Forms.Padding(2);
            this.rdoASCII.Name = "rdoASCII";
            this.rdoASCII.Size = new System.Drawing.Size(52, 17);
            this.rdoASCII.TabIndex = 31;
            this.rdoASCII.TabStop = true;
            this.rdoASCII.Text = "ASCII";
            this.rdoASCII.UseVisualStyleBackColor = true;
            this.rdoASCII.CheckedChanged += new System.EventHandler(this.rdoASCII_Binary_CheckedChanged);
            // 
            // btnVerifyTag
            // 
            this.btnVerifyTag.Location = new System.Drawing.Point(160, 103);
            this.btnVerifyTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerifyTag.Name = "btnVerifyTag";
            this.btnVerifyTag.Size = new System.Drawing.Size(72, 24);
            this.btnVerifyTag.TabIndex = 30;
            this.btnVerifyTag.Text = "Verify Tag";
            this.btnVerifyTag.UseVisualStyleBackColor = true;
            this.btnVerifyTag.Click += new System.EventHandler(this.btnVerifyTag_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Serial Number";
            // 
            // btnWriteTag
            // 
            this.btnWriteTag.Location = new System.Drawing.Point(94, 103);
            this.btnWriteTag.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteTag.Name = "btnWriteTag";
            this.btnWriteTag.Size = new System.Drawing.Size(63, 24);
            this.btnWriteTag.TabIndex = 27;
            this.btnWriteTag.Text = "Write Tag";
            this.btnWriteTag.UseVisualStyleBackColor = true;
            this.btnWriteTag.Click += new System.EventHandler(this.btnWriteTag_Click);
            // 
            // cmbPartition
            // 
            this.cmbPartition.FormattingEnabled = true;
            this.cmbPartition.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbPartition.Location = new System.Drawing.Point(408, 52);
            this.cmbPartition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPartition.Name = "cmbPartition";
            this.cmbPartition.Size = new System.Drawing.Size(92, 21);
            this.cmbPartition.TabIndex = 25;
            this.cmbPartition.SelectedIndexChanged += new System.EventHandler(this.cmbPartition_SelectedIndexChanged);
            // 
            // cmbFilterValue
            // 
            this.cmbFilterValue.FormattingEnabled = true;
            this.cmbFilterValue.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbFilterValue.Location = new System.Drawing.Point(408, 24);
            this.cmbFilterValue.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterValue.Name = "cmbFilterValue";
            this.cmbFilterValue.Size = new System.Drawing.Size(92, 21);
            this.cmbFilterValue.TabIndex = 24;
            this.cmbFilterValue.SelectedIndexChanged += new System.EventHandler(this.cmbFilterValue_SelectedIndexChanged);
            // 
            // statusIcon
            // 
            this.statusIcon.ErrorImage = null;
            this.statusIcon.InitialImage = null;
            this.statusIcon.Location = new System.Drawing.Point(291, 80);
            this.statusIcon.Margin = new System.Windows.Forms.Padding(2);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(17, 19);
            this.statusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.statusIcon.TabIndex = 23;
            this.statusIcon.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(332, 55);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Partition";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(332, 28);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Filter value";
            // 
            // lblUserBank
            // 
            this.lblUserBank.AutoSize = true;
            this.lblUserBank.Location = new System.Drawing.Point(14, 150);
            this.lblUserBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserBank.Name = "lblUserBank";
            this.lblUserBank.Size = new System.Drawing.Size(56, 13);
            this.lblUserBank.TabIndex = 12;
            this.lblUserBank.Text = "User bank";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 83);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "New EPC Id";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Scan barcode";
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.grpMiscOther);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Size = new System.Drawing.Size(511, 468);
            this.tabMisc.TabIndex = 4;
            this.tabMisc.Text = "Miscellaneous";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // grpMiscOther
            // 
            this.grpMiscOther.Controls.Add(this.grpSCdcSwitch);
            this.grpMiscOther.Controls.Add(this.grpMiscCmd);
            this.grpMiscOther.Controls.Add(this.grpAsync);
            this.grpMiscOther.Location = new System.Drawing.Point(3, 3);
            this.grpMiscOther.Name = "grpMiscOther";
            this.grpMiscOther.Size = new System.Drawing.Size(500, 459);
            this.grpMiscOther.TabIndex = 28;
            this.grpMiscOther.TabStop = false;
            this.grpMiscOther.Text = "Miscellaneous";
            // 
            // grpSCdcSwitch
            // 
            this.grpSCdcSwitch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpSCdcSwitch.Controls.Add(this.btnSCdcSwitchDevices);
            this.grpSCdcSwitch.Controls.Add(this.chkSCdcSIsPermanent);
            this.grpSCdcSwitch.Controls.Add(this.chkSCdcSIsSilent);
            this.grpSCdcSwitch.Controls.Add(this.comboSCdcSHostMode);
            this.grpSCdcSwitch.Controls.Add(this.lblSCdcSHostMode);
            this.grpSCdcSwitch.Location = new System.Drawing.Point(10, 109);
            this.grpSCdcSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.grpSCdcSwitch.Name = "grpSCdcSwitch";
            this.grpSCdcSwitch.Padding = new System.Windows.Forms.Padding(2);
            this.grpSCdcSwitch.Size = new System.Drawing.Size(485, 101);
            this.grpSCdcSwitch.TabIndex = 4;
            this.grpSCdcSwitch.TabStop = false;
            this.grpSCdcSwitch.Text = "CDC Switching";
            // 
            // btnSCdcSwitchDevices
            // 
            this.btnSCdcSwitchDevices.Location = new System.Drawing.Point(266, 62);
            this.btnSCdcSwitchDevices.Name = "btnSCdcSwitchDevices";
            this.btnSCdcSwitchDevices.Size = new System.Drawing.Size(120, 23);
            this.btnSCdcSwitchDevices.TabIndex = 4;
            this.btnSCdcSwitchDevices.Text = "Switch CDC Devices";
            this.btnSCdcSwitchDevices.UseVisualStyleBackColor = true;
            this.btnSCdcSwitchDevices.Click += new System.EventHandler(this.btnSCdcSwitchDevices_Click);
            // 
            // chkSCdcSIsPermanent
            // 
            this.chkSCdcSIsPermanent.AutoSize = true;
            this.chkSCdcSIsPermanent.Location = new System.Drawing.Point(340, 29);
            this.chkSCdcSIsPermanent.Margin = new System.Windows.Forms.Padding(2);
            this.chkSCdcSIsPermanent.Name = "chkSCdcSIsPermanent";
            this.chkSCdcSIsPermanent.Size = new System.Drawing.Size(88, 17);
            this.chkSCdcSIsPermanent.TabIndex = 3;
            this.chkSCdcSIsPermanent.Text = "Is Permanent";
            this.chkSCdcSIsPermanent.UseVisualStyleBackColor = true;
            // 
            // chkSCdcSIsSilent
            // 
            this.chkSCdcSIsSilent.AutoSize = true;
            this.chkSCdcSIsSilent.Location = new System.Drawing.Point(266, 28);
            this.chkSCdcSIsSilent.Margin = new System.Windows.Forms.Padding(2);
            this.chkSCdcSIsSilent.Name = "chkSCdcSIsSilent";
            this.chkSCdcSIsSilent.Size = new System.Drawing.Size(63, 17);
            this.chkSCdcSIsSilent.TabIndex = 2;
            this.chkSCdcSIsSilent.Text = "Is Silent";
            this.chkSCdcSIsSilent.UseVisualStyleBackColor = true;
            // 
            // comboSCdcSHostMode
            // 
            this.comboSCdcSHostMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSCdcSHostMode.FormattingEnabled = true;
            this.comboSCdcSHostMode.Items.AddRange(new object[] {
            "USB-IBMHID",
            "USB-IBMTT",
            "USB-HIDKB",
            "USB-OPOS",
            "USB-SNAPI with Imaging",
            "USB-SNAPI without Imaging",
            "USB-CDC Serial Emulation",
            "USB-SSI over CDC"});
            this.comboSCdcSHostMode.Location = new System.Drawing.Point(75, 27);
            this.comboSCdcSHostMode.Margin = new System.Windows.Forms.Padding(2);
            this.comboSCdcSHostMode.Name = "comboSCdcSHostMode";
            this.comboSCdcSHostMode.Size = new System.Drawing.Size(143, 21);
            this.comboSCdcSHostMode.TabIndex = 1;
            // 
            // lblSCdcSHostMode
            // 
            this.lblSCdcSHostMode.AutoSize = true;
            this.lblSCdcSHostMode.Location = new System.Drawing.Point(6, 29);
            this.lblSCdcSHostMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSCdcSHostMode.Name = "lblSCdcSHostMode";
            this.lblSCdcSHostMode.Size = new System.Drawing.Size(62, 13);
            this.lblSCdcSHostMode.TabIndex = 0;
            this.lblSCdcSHostMode.Text = "Host Mode ";
            // 
            // grpMiscCmd
            // 
            this.grpMiscCmd.BackColor = System.Drawing.SystemColors.Window;
            this.grpMiscCmd.Controls.Add(this.btnGetDevTopology);
            this.grpMiscCmd.Controls.Add(this.btnSdkVersion);
            this.grpMiscCmd.Location = new System.Drawing.Point(10, 26);
            this.grpMiscCmd.Name = "grpMiscCmd";
            this.grpMiscCmd.Size = new System.Drawing.Size(280, 66);
            this.grpMiscCmd.TabIndex = 0;
            this.grpMiscCmd.TabStop = false;
            this.grpMiscCmd.Text = "Miscellaneous Commands";
            // 
            // btnGetDevTopology
            // 
            this.btnGetDevTopology.Location = new System.Drawing.Point(143, 26);
            this.btnGetDevTopology.Name = "btnGetDevTopology";
            this.btnGetDevTopology.Size = new System.Drawing.Size(119, 23);
            this.btnGetDevTopology.TabIndex = 1;
            this.btnGetDevTopology.Text = "Get Device Topology";
            this.btnGetDevTopology.UseVisualStyleBackColor = true;
            this.btnGetDevTopology.Click += new System.EventHandler(this.btnGetDevTopology_Click);
            // 
            // btnSdkVersion
            // 
            this.btnSdkVersion.Location = new System.Drawing.Point(19, 26);
            this.btnSdkVersion.Name = "btnSdkVersion";
            this.btnSdkVersion.Size = new System.Drawing.Size(118, 23);
            this.btnSdkVersion.TabIndex = 0;
            this.btnSdkVersion.Text = "CoreScanner Version";
            this.btnSdkVersion.UseVisualStyleBackColor = true;
            this.btnSdkVersion.Click += new System.EventHandler(this.btnSdkVersion_Click);
            // 
            // grpAsync
            // 
            this.grpAsync.BackColor = System.Drawing.SystemColors.Window;
            this.grpAsync.Controls.Add(this.chkAsync);
            this.grpAsync.Location = new System.Drawing.Point(326, 25);
            this.grpAsync.Name = "grpAsync";
            this.grpAsync.Size = new System.Drawing.Size(150, 63);
            this.grpAsync.TabIndex = 1;
            this.grpAsync.TabStop = false;
            this.grpAsync.Text = "Command Mode";
            // 
            // chkAsync
            // 
            this.chkAsync.AutoSize = true;
            this.chkAsync.Location = new System.Drawing.Point(19, 19);
            this.chkAsync.Name = "chkAsync";
            this.chkAsync.Size = new System.Drawing.Size(93, 17);
            this.chkAsync.TabIndex = 0;
            this.chkAsync.Text = "Asynchronous";
            this.chkAsync.UseVisualStyleBackColor = true;
            // 
            // tabScan2Connect
            // 
            this.tabScan2Connect.Controls.Add(this.grpScan2Connect);
            this.tabScan2Connect.Location = new System.Drawing.Point(4, 22);
            this.tabScan2Connect.Name = "tabScan2Connect";
            this.tabScan2Connect.Size = new System.Drawing.Size(511, 468);
            this.tabScan2Connect.TabIndex = 10;
            this.tabScan2Connect.Text = "ScanToConnect";
            this.tabScan2Connect.UseVisualStyleBackColor = true;
            // 
            // grpScan2Connect
            // 
            this.grpScan2Connect.Controls.Add(this.btnSaveBarcode);
            this.grpScan2Connect.Controls.Add(this.label13);
            this.grpScan2Connect.Controls.Add(this.cmbHostName);
            this.grpScan2Connect.Controls.Add(this.label12);
            this.grpScan2Connect.Controls.Add(this.label11);
            this.grpScan2Connect.Controls.Add(this.cmbScannerType);
            this.grpScan2Connect.Controls.Add(this.label10);
            this.grpScan2Connect.Controls.Add(this.label9);
            this.grpScan2Connect.Controls.Add(this.label8);
            this.grpScan2Connect.Controls.Add(this.picBBarcode);
            this.grpScan2Connect.Controls.Add(this.cmbImageSize);
            this.grpScan2Connect.Controls.Add(this.cmbDefaultOption);
            this.grpScan2Connect.Controls.Add(this.cmbProtocol);
            this.grpScan2Connect.Location = new System.Drawing.Point(3, 15);
            this.grpScan2Connect.Name = "grpScan2Connect";
            this.grpScan2Connect.Size = new System.Drawing.Size(505, 450);
            this.grpScan2Connect.TabIndex = 4;
            this.grpScan2Connect.TabStop = false;
            this.grpScan2Connect.Text = "ScanToConnect Barcode";
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.Location = new System.Drawing.Point(384, 274);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.Size = new System.Drawing.Size(104, 23);
            this.btnSaveBarcode.TabIndex = 21;
            this.btnSaveBarcode.Text = "Save Barcode";
            this.btnSaveBarcode.UseVisualStyleBackColor = true;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Host Name";
            // 
            // cmbHostName
            // 
            this.cmbHostName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHostName.FormattingEnabled = true;
            this.cmbHostName.Items.AddRange(new object[] {
            "SSI BT Classic (Non-Discoverable)"});
            this.cmbHostName.Location = new System.Drawing.Point(98, 119);
            this.cmbHostName.Name = "cmbHostName";
            this.cmbHostName.Size = new System.Drawing.Size(167, 21);
            this.cmbHostName.TabIndex = 19;
            this.cmbHostName.SelectedIndexChanged += new System.EventHandler(this.cmbHostName_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Received Barcode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Scanner Type";
            // 
            // cmbScannerType
            // 
            this.cmbScannerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScannerType.FormattingEnabled = true;
            this.cmbScannerType.Items.AddRange(new object[] {
            "Legacy",
            "New"});
            this.cmbScannerType.Location = new System.Drawing.Point(98, 27);
            this.cmbScannerType.Name = "cmbScannerType";
            this.cmbScannerType.Size = new System.Drawing.Size(167, 21);
            this.cmbScannerType.TabIndex = 15;
            this.cmbScannerType.SelectedIndexChanged += new System.EventHandler(this.cmbScannerType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Image Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Default Option";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Protocol Name";
            // 
            // picBBarcode
            // 
            this.picBBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBBarcode.Location = new System.Drawing.Point(6, 305);
            this.picBBarcode.Name = "picBBarcode";
            this.picBBarcode.Size = new System.Drawing.Size(493, 135);
            this.picBBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBBarcode.TabIndex = 10;
            this.picBBarcode.TabStop = false;
            // 
            // cmbImageSize
            // 
            this.cmbImageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageSize.FormattingEnabled = true;
            this.cmbImageSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbImageSize.Location = new System.Drawing.Point(98, 211);
            this.cmbImageSize.Name = "cmbImageSize";
            this.cmbImageSize.Size = new System.Drawing.Size(76, 21);
            this.cmbImageSize.TabIndex = 9;
            this.cmbImageSize.SelectedIndexChanged += new System.EventHandler(this.cmbImageSize_SelectedIndexChanged);
            // 
            // cmbDefaultOption
            // 
            this.cmbDefaultOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultOption.FormattingEnabled = true;
            this.cmbDefaultOption.Items.AddRange(new object[] {
            "No Defaults",
            "Set Factory Defaults",
            "Restore Factory Defaults"});
            this.cmbDefaultOption.Location = new System.Drawing.Point(98, 165);
            this.cmbDefaultOption.Name = "cmbDefaultOption";
            this.cmbDefaultOption.Size = new System.Drawing.Size(167, 21);
            this.cmbDefaultOption.TabIndex = 2;
            this.cmbDefaultOption.SelectedIndexChanged += new System.EventHandler(this.cmbDefaultOption_SelectedIndexChanged);
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Items.AddRange(new object[] {
            "Simple Serial Interface (SSI)",
            "Serial Port Profile (SPP)",
            "Human Interface Device (HID)"});
            this.cmbProtocol.Location = new System.Drawing.Point(98, 73);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(190, 21);
            this.cmbProtocol.TabIndex = 1;
            this.cmbProtocol.SelectedIndexChanged += new System.EventHandler(this.cmbProtocol_SelectedIndexChanged);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.grpCustomDecodeTone);
            this.tabConfig.Controls.Add(this.filterScnrs);
            this.tabConfig.Controls.Add(this.grpFrmWrUpdate);
            this.tabConfig.Controls.Add(this.grpScannerProp);
            this.tabConfig.Controls.Add(this.grpElectricFenceCustomTone);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(511, 468);
            this.tabConfig.TabIndex = 3;
            this.tabConfig.Text = "Advanced";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // grpCustomDecodeTone
            // 
            this.grpCustomDecodeTone.BackColor = System.Drawing.SystemColors.Window;
            this.grpCustomDecodeTone.Controls.Add(this.btnEraseTone);
            this.grpCustomDecodeTone.Controls.Add(this.buttonWavFileUpload);
            this.grpCustomDecodeTone.Controls.Add(this.textBoxWavFile);
            this.grpCustomDecodeTone.Controls.Add(this.buttonWavFileBrowse);
            this.grpCustomDecodeTone.Location = new System.Drawing.Point(16, 208);
            this.grpCustomDecodeTone.Margin = new System.Windows.Forms.Padding(2);
            this.grpCustomDecodeTone.Name = "grpCustomDecodeTone";
            this.grpCustomDecodeTone.Padding = new System.Windows.Forms.Padding(2);
            this.grpCustomDecodeTone.Size = new System.Drawing.Size(468, 89);
            this.grpCustomDecodeTone.TabIndex = 3;
            this.grpCustomDecodeTone.TabStop = false;
            this.grpCustomDecodeTone.Text = "Custom Good Decode Tone";
            // 
            // btnEraseTone
            // 
            this.btnEraseTone.Location = new System.Drawing.Point(339, 51);
            this.btnEraseTone.Name = "btnEraseTone";
            this.btnEraseTone.Size = new System.Drawing.Size(113, 25);
            this.btnEraseTone.TabIndex = 3;
            this.btnEraseTone.Text = "Erase Tone";
            this.btnEraseTone.UseVisualStyleBackColor = true;
            this.btnEraseTone.Click += new System.EventHandler(this.btnEraseTone_Click);
            // 
            // buttonWavFileUpload
            // 
            this.buttonWavFileUpload.Location = new System.Drawing.Point(209, 51);
            this.buttonWavFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWavFileUpload.Name = "buttonWavFileUpload";
            this.buttonWavFileUpload.Size = new System.Drawing.Size(125, 25);
            this.buttonWavFileUpload.TabIndex = 2;
            this.buttonWavFileUpload.Text = "Upload To Scanner";
            this.buttonWavFileUpload.UseVisualStyleBackColor = true;
            this.buttonWavFileUpload.Click += new System.EventHandler(this.buttonWavFileUpload_Click);
            // 
            // textBoxWavFile
            // 
            this.textBoxWavFile.Location = new System.Drawing.Point(8, 24);
            this.textBoxWavFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWavFile.Name = "textBoxWavFile";
            this.textBoxWavFile.Size = new System.Drawing.Size(354, 20);
            this.textBoxWavFile.TabIndex = 0;
            // 
            // buttonWavFileBrowse
            // 
            this.buttonWavFileBrowse.Location = new System.Drawing.Point(375, 20);
            this.buttonWavFileBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWavFileBrowse.Name = "buttonWavFileBrowse";
            this.buttonWavFileBrowse.Size = new System.Drawing.Size(77, 26);
            this.buttonWavFileBrowse.TabIndex = 1;
            this.buttonWavFileBrowse.Text = "Browse";
            this.buttonWavFileBrowse.UseVisualStyleBackColor = true;
            this.buttonWavFileBrowse.Click += new System.EventHandler(this.buttonWavFileBrowse_Click);
            // 
            // filterScnrs
            // 
            this.filterScnrs.Controls.Add(this.comboFilterScnrs);
            this.filterScnrs.Location = new System.Drawing.Point(321, 152);
            this.filterScnrs.Name = "filterScnrs";
            this.filterScnrs.Size = new System.Drawing.Size(163, 51);
            this.filterScnrs.TabIndex = 2;
            this.filterScnrs.TabStop = false;
            this.filterScnrs.Text = "Protocol Select";
            // 
            // comboFilterScnrs
            // 
            this.comboFilterScnrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterScnrs.FormattingEnabled = true;
            this.comboFilterScnrs.Items.AddRange(new object[] {
            "ALL",
            "HID KEYBOARD",
            "IBM HANDHELD",
            "SNAPI"});
            this.comboFilterScnrs.Location = new System.Drawing.Point(33, 17);
            this.comboFilterScnrs.Name = "comboFilterScnrs";
            this.comboFilterScnrs.Size = new System.Drawing.Size(121, 21);
            this.comboFilterScnrs.TabIndex = 0;
            this.comboFilterScnrs.SelectedIndexChanged += new System.EventHandler(this.comboFilterScnrs_SelectedIndexChanged);
            // 
            // grpFrmWrUpdate
            // 
            this.grpFrmWrUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.grpFrmWrUpdate.Controls.Add(this.grpFWoptns);
            this.grpFrmWrUpdate.Controls.Add(this.progressBarFWUpdate);
            this.grpFrmWrUpdate.Controls.Add(this.buttonFWBrowse);
            this.grpFrmWrUpdate.Controls.Add(this.txtFWFile);
            this.grpFrmWrUpdate.Location = new System.Drawing.Point(16, 14);
            this.grpFrmWrUpdate.Name = "grpFrmWrUpdate";
            this.grpFrmWrUpdate.Size = new System.Drawing.Size(468, 130);
            this.grpFrmWrUpdate.TabIndex = 0;
            this.grpFrmWrUpdate.TabStop = false;
            this.grpFrmWrUpdate.Text = "Firmware Operations";
            // 
            // grpFWoptns
            // 
            this.grpFWoptns.Controls.Add(this.chkBulk);
            this.grpFWoptns.Controls.Add(this.btnAbortFWUpdate);
            this.grpFWoptns.Controls.Add(this.btnFWUpdate);
            this.grpFWoptns.Controls.Add(this.btnLaunchNewFW);
            this.grpFWoptns.Location = new System.Drawing.Point(23, 56);
            this.grpFWoptns.Name = "grpFWoptns";
            this.grpFWoptns.Size = new System.Drawing.Size(435, 44);
            this.grpFWoptns.TabIndex = 28;
            this.grpFWoptns.TabStop = false;
            // 
            // chkBulk
            // 
            this.chkBulk.AutoSize = true;
            this.chkBulk.Checked = true;
            this.chkBulk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBulk.Location = new System.Drawing.Point(37, 19);
            this.chkBulk.Name = "chkBulk";
            this.chkBulk.Size = new System.Drawing.Size(85, 17);
            this.chkBulk.TabIndex = 0;
            this.chkBulk.Text = "Bulk Update";
            this.chkBulk.UseVisualStyleBackColor = true;
            // 
            // btnAbortFWUpdate
            // 
            this.btnAbortFWUpdate.Location = new System.Drawing.Point(340, 13);
            this.btnAbortFWUpdate.Name = "btnAbortFWUpdate";
            this.btnAbortFWUpdate.Size = new System.Drawing.Size(89, 23);
            this.btnAbortFWUpdate.TabIndex = 2;
            this.btnAbortFWUpdate.Text = "Abort";
            this.btnAbortFWUpdate.UseVisualStyleBackColor = true;
            this.btnAbortFWUpdate.Click += new System.EventHandler(this.btnAbortFWUpdate_Click);
            // 
            // btnFWUpdate
            // 
            this.btnFWUpdate.Location = new System.Drawing.Point(157, 13);
            this.btnFWUpdate.Name = "btnFWUpdate";
            this.btnFWUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnFWUpdate.TabIndex = 1;
            this.btnFWUpdate.Text = "Update";
            this.btnFWUpdate.UseVisualStyleBackColor = true;
            this.btnFWUpdate.Click += new System.EventHandler(this.btnFWUpdate_Click);
            // 
            // btnLaunchNewFW
            // 
            this.btnLaunchNewFW.Location = new System.Drawing.Point(244, 13);
            this.btnLaunchNewFW.Name = "btnLaunchNewFW";
            this.btnLaunchNewFW.Size = new System.Drawing.Size(90, 23);
            this.btnLaunchNewFW.TabIndex = 3;
            this.btnLaunchNewFW.Text = "Launch";
            this.btnLaunchNewFW.UseVisualStyleBackColor = true;
            this.btnLaunchNewFW.Click += new System.EventHandler(this.btnStartNewFW_Click);
            // 
            // progressBarFWUpdate
            // 
            this.progressBarFWUpdate.BackColor = System.Drawing.Color.White;
            this.progressBarFWUpdate.Location = new System.Drawing.Point(23, 111);
            this.progressBarFWUpdate.Name = "progressBarFWUpdate";
            this.progressBarFWUpdate.Size = new System.Drawing.Size(435, 13);
            this.progressBarFWUpdate.TabIndex = 17;
            // 
            // buttonFWBrowse
            // 
            this.buttonFWBrowse.Location = new System.Drawing.Point(375, 24);
            this.buttonFWBrowse.Name = "buttonFWBrowse";
            this.buttonFWBrowse.Size = new System.Drawing.Size(77, 23);
            this.buttonFWBrowse.TabIndex = 1;
            this.buttonFWBrowse.Text = "Browse";
            this.buttonFWBrowse.UseVisualStyleBackColor = true;
            this.buttonFWBrowse.Click += new System.EventHandler(this.buttonFWBrowse_Click);
            // 
            // txtFWFile
            // 
            this.txtFWFile.BackColor = System.Drawing.Color.White;
            this.txtFWFile.Location = new System.Drawing.Point(23, 27);
            this.txtFWFile.Name = "txtFWFile";
            this.txtFWFile.Size = new System.Drawing.Size(339, 20);
            this.txtFWFile.TabIndex = 0;
            // 
            // grpScannerProp
            // 
            this.grpScannerProp.Controls.Add(this.chkClaim);
            this.grpScannerProp.Location = new System.Drawing.Point(16, 152);
            this.grpScannerProp.Name = "grpScannerProp";
            this.grpScannerProp.Size = new System.Drawing.Size(218, 44);
            this.grpScannerProp.TabIndex = 1;
            this.grpScannerProp.TabStop = false;
            this.grpScannerProp.Text = "Exclusively Claim Selected Scanner";
            // 
            // chkClaim
            // 
            this.chkClaim.AutoSize = true;
            this.chkClaim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkClaim.Location = new System.Drawing.Point(18, 19);
            this.chkClaim.Name = "chkClaim";
            this.chkClaim.Size = new System.Drawing.Size(94, 17);
            this.chkClaim.TabIndex = 0;
            this.chkClaim.Text = "Claim Scanner";
            this.chkClaim.UseVisualStyleBackColor = false;
            this.chkClaim.CheckedChanged += new System.EventHandler(this.OnClaimScanner);
            // 
            // grpElectricFenceCustomTone
            // 
            this.grpElectricFenceCustomTone.BackColor = System.Drawing.SystemColors.Window;
            this.grpElectricFenceCustomTone.Controls.Add(this.btnElectricFenceEraseTone);
            this.grpElectricFenceCustomTone.Controls.Add(this.buttonElectricFenceWavFileUpload);
            this.grpElectricFenceCustomTone.Controls.Add(this.textBoxElectricFenceWaveFile);
            this.grpElectricFenceCustomTone.Controls.Add(this.buttonElectricFenceWavFileBrowse);
            this.grpElectricFenceCustomTone.Location = new System.Drawing.Point(16, 318);
            this.grpElectricFenceCustomTone.Margin = new System.Windows.Forms.Padding(2);
            this.grpElectricFenceCustomTone.Name = "grpElectricFenceCustomTone";
            this.grpElectricFenceCustomTone.Padding = new System.Windows.Forms.Padding(2);
            this.grpElectricFenceCustomTone.Size = new System.Drawing.Size(468, 89);
            this.grpElectricFenceCustomTone.TabIndex = 4;
            this.grpElectricFenceCustomTone.TabStop = false;
            this.grpElectricFenceCustomTone.Text = "Electric Fence Custom Tone";
            // 
            // btnElectricFenceEraseTone
            // 
            this.btnElectricFenceEraseTone.Location = new System.Drawing.Point(339, 51);
            this.btnElectricFenceEraseTone.Name = "btnElectricFenceEraseTone";
            this.btnElectricFenceEraseTone.Size = new System.Drawing.Size(113, 25);
            this.btnElectricFenceEraseTone.TabIndex = 3;
            this.btnElectricFenceEraseTone.Text = "Erase Tone";
            this.btnElectricFenceEraseTone.UseVisualStyleBackColor = true;
            this.btnElectricFenceEraseTone.Click += new System.EventHandler(this.btnElectricFenceEraseTone_Click);
            // 
            // buttonElectricFenceWavFileUpload
            // 
            this.buttonElectricFenceWavFileUpload.Location = new System.Drawing.Point(209, 51);
            this.buttonElectricFenceWavFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonElectricFenceWavFileUpload.Name = "buttonElectricFenceWavFileUpload";
            this.buttonElectricFenceWavFileUpload.Size = new System.Drawing.Size(125, 25);
            this.buttonElectricFenceWavFileUpload.TabIndex = 2;
            this.buttonElectricFenceWavFileUpload.Text = "Upload To Scanner";
            this.buttonElectricFenceWavFileUpload.UseVisualStyleBackColor = true;
            this.buttonElectricFenceWavFileUpload.Click += new System.EventHandler(this.buttonElectricFenceWavFileUpload_Click);
            // 
            // textBoxElectricFenceWaveFile
            // 
            this.textBoxElectricFenceWaveFile.Location = new System.Drawing.Point(8, 24);
            this.textBoxElectricFenceWaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxElectricFenceWaveFile.Name = "textBoxElectricFenceWaveFile";
            this.textBoxElectricFenceWaveFile.Size = new System.Drawing.Size(354, 20);
            this.textBoxElectricFenceWaveFile.TabIndex = 0;
            // 
            // buttonElectricFenceWavFileBrowse
            // 
            this.buttonElectricFenceWavFileBrowse.Location = new System.Drawing.Point(375, 20);
            this.buttonElectricFenceWavFileBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonElectricFenceWavFileBrowse.Name = "buttonElectricFenceWavFileBrowse";
            this.buttonElectricFenceWavFileBrowse.Size = new System.Drawing.Size(77, 26);
            this.buttonElectricFenceWavFileBrowse.TabIndex = 1;
            this.buttonElectricFenceWavFileBrowse.Text = "Browse";
            this.buttonElectricFenceWavFileBrowse.UseVisualStyleBackColor = true;
            this.buttonElectricFenceWavFileBrowse.Click += new System.EventHandler(this.buttonElectricFenceWavFileBrowse_Click);
            // 
            // tabBarcode
            // 
            this.tabBarcode.AutoScroll = true;
            this.tabBarcode.BackColor = System.Drawing.Color.AliceBlue;
            this.tabBarcode.Controls.Add(this.groupBox1);
            this.tabBarcode.Controls.Add(this.grpBoxLanguage);
            this.tabBarcode.Controls.Add(this.txtBarcode);
            this.tabBarcode.Controls.Add(this.grpboxBarcodeLbl);
            this.tabBarcode.Location = new System.Drawing.Point(4, 22);
            this.tabBarcode.Name = "tabBarcode";
            this.tabBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.tabBarcode.Size = new System.Drawing.Size(511, 468);
            this.tabBarcode.TabIndex = 0;
            this.tabBarcode.Text = "Barcode";
            this.tabBarcode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnScriptEditor);
            this.groupBox1.Controls.Add(this.btnBrowseScript);
            this.groupBox1.Controls.Add(this.chkBoxAppADF);
            this.groupBox1.Location = new System.Drawing.Point(19, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application ADF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "File Path...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScriptEditor
            // 
            this.btnScriptEditor.Location = new System.Drawing.Point(205, 16);
            this.btnScriptEditor.Name = "btnScriptEditor";
            this.btnScriptEditor.Size = new System.Drawing.Size(103, 23);
            this.btnScriptEditor.TabIndex = 2;
            this.btnScriptEditor.Text = "Script Editor ...";
            this.btnScriptEditor.UseVisualStyleBackColor = true;
            this.btnScriptEditor.Click += new System.EventHandler(this.btnScriptEditor_Click);
            // 
            // btnBrowseScript
            // 
            this.btnBrowseScript.Location = new System.Drawing.Point(96, 16);
            this.btnBrowseScript.Name = "btnBrowseScript";
            this.btnBrowseScript.Size = new System.Drawing.Size(103, 23);
            this.btnBrowseScript.TabIndex = 1;
            this.btnBrowseScript.Text = "Browse Script ...";
            this.btnBrowseScript.UseVisualStyleBackColor = true;
            this.btnBrowseScript.Click += new System.EventHandler(this.btnBrowseScript_Click);
            // 
            // chkBoxAppADF
            // 
            this.chkBoxAppADF.AutoSize = true;
            this.chkBoxAppADF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkBoxAppADF.Enabled = false;
            this.chkBoxAppADF.Location = new System.Drawing.Point(18, 22);
            this.chkBoxAppADF.Name = "chkBoxAppADF";
            this.chkBoxAppADF.Size = new System.Drawing.Size(62, 17);
            this.chkBoxAppADF.TabIndex = 0;
            this.chkBoxAppADF.Text = "Not Set";
            this.chkBoxAppADF.UseVisualStyleBackColor = false;
            this.chkBoxAppADF.CheckedChanged += new System.EventHandler(this.OnChkChangedDADF);
            // 
            // grpBoxLanguage
            // 
            this.grpBoxLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.grpBoxLanguage.Controls.Add(this.chkBoxEmulation);
            this.grpBoxLanguage.Controls.Add(this.cmbEmulation);
            this.grpBoxLanguage.Location = new System.Drawing.Point(19, 365);
            this.grpBoxLanguage.Name = "grpBoxLanguage";
            this.grpBoxLanguage.Size = new System.Drawing.Size(468, 50);
            this.grpBoxLanguage.TabIndex = 2;
            this.grpBoxLanguage.TabStop = false;
            this.grpBoxLanguage.Text = "Keyboard Emulation and Language/Locale Details";
            // 
            // chkBoxEmulation
            // 
            this.chkBoxEmulation.AutoSize = true;
            this.chkBoxEmulation.Location = new System.Drawing.Point(18, 22);
            this.chkBoxEmulation.Name = "chkBoxEmulation";
            this.chkBoxEmulation.Size = new System.Drawing.Size(108, 17);
            this.chkBoxEmulation.TabIndex = 0;
            this.chkBoxEmulation.Text = "Enable Emulation";
            this.chkBoxEmulation.UseVisualStyleBackColor = true;
            this.chkBoxEmulation.CheckedChanged += new System.EventHandler(this.chkBoxEmulation_CheckedChanged);
            // 
            // cmbEmulation
            // 
            this.cmbEmulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmulation.FormattingEnabled = true;
            this.cmbEmulation.Items.AddRange(new object[] {
            "DEFAULT",
            "FRENCH",
            "ENGLISH"});
            this.cmbEmulation.Location = new System.Drawing.Point(163, 20);
            this.cmbEmulation.Name = "cmbEmulation";
            this.cmbEmulation.Size = new System.Drawing.Size(151, 21);
            this.cmbEmulation.TabIndex = 1;
            this.cmbEmulation.SelectedIndexChanged += new System.EventHandler(this.cmbEmulation_SelectedIndexChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Location = new System.Drawing.Point(19, 10);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBarcode.Size = new System.Drawing.Size(468, 248);
            this.txtBarcode.TabIndex = 0;
            // 
            // grpboxBarcodeLbl
            // 
            this.grpboxBarcodeLbl.BackColor = System.Drawing.SystemColors.Window;
            this.grpboxBarcodeLbl.Controls.Add(this.lblSyblogy);
            this.grpboxBarcodeLbl.Controls.Add(this.txtSyblogy);
            this.grpboxBarcodeLbl.Controls.Add(this.lblDecdBarCde);
            this.grpboxBarcodeLbl.Controls.Add(this.txtBarcodeLbl);
            this.grpboxBarcodeLbl.Controls.Add(this.btnAbortMacroPdf);
            this.grpboxBarcodeLbl.Controls.Add(this.btnBarcodeClear);
            this.grpboxBarcodeLbl.Controls.Add(this.btnFlushMacroPdf);
            this.grpboxBarcodeLbl.Location = new System.Drawing.Point(19, 264);
            this.grpboxBarcodeLbl.Name = "grpboxBarcodeLbl";
            this.grpboxBarcodeLbl.Size = new System.Drawing.Size(468, 98);
            this.grpboxBarcodeLbl.TabIndex = 1;
            this.grpboxBarcodeLbl.TabStop = false;
            this.grpboxBarcodeLbl.Text = "Barcode Scanning";
            // 
            // lblSyblogy
            // 
            this.lblSyblogy.AutoSize = true;
            this.lblSyblogy.Location = new System.Drawing.Point(49, 46);
            this.lblSyblogy.Name = "lblSyblogy";
            this.lblSyblogy.Size = new System.Drawing.Size(58, 13);
            this.lblSyblogy.TabIndex = 39;
            this.lblSyblogy.Text = "Symbology";
            // 
            // txtSyblogy
            // 
            this.txtSyblogy.BackColor = System.Drawing.Color.White;
            this.txtSyblogy.Location = new System.Drawing.Point(121, 44);
            this.txtSyblogy.Name = "txtSyblogy";
            this.txtSyblogy.ReadOnly = true;
            this.txtSyblogy.Size = new System.Drawing.Size(332, 20);
            this.txtSyblogy.TabIndex = 1;
            // 
            // lblDecdBarCde
            // 
            this.lblDecdBarCde.AutoSize = true;
            this.lblDecdBarCde.Location = new System.Drawing.Point(11, 21);
            this.lblDecdBarCde.Name = "lblDecdBarCde";
            this.lblDecdBarCde.Size = new System.Drawing.Size(94, 13);
            this.lblDecdBarCde.TabIndex = 0;
            this.lblDecdBarCde.Text = "Decoded Barcode";
            // 
            // txtBarcodeLbl
            // 
            this.txtBarcodeLbl.BackColor = System.Drawing.Color.White;
            this.txtBarcodeLbl.Location = new System.Drawing.Point(121, 19);
            this.txtBarcodeLbl.Multiline = true;
            this.txtBarcodeLbl.Name = "txtBarcodeLbl";
            this.txtBarcodeLbl.Size = new System.Drawing.Size(331, 20);
            this.txtBarcodeLbl.TabIndex = 0;
            // 
            // btnAbortMacroPdf
            // 
            this.btnAbortMacroPdf.Location = new System.Drawing.Point(224, 71);
            this.btnAbortMacroPdf.Name = "btnAbortMacroPdf";
            this.btnAbortMacroPdf.Size = new System.Drawing.Size(104, 23);
            this.btnAbortMacroPdf.TabIndex = 3;
            this.btnAbortMacroPdf.Text = "Abort Macro PDF";
            this.btnAbortMacroPdf.UseVisualStyleBackColor = true;
            this.btnAbortMacroPdf.Click += new System.EventHandler(this.btnAbortMacroPdf_Click);
            // 
            // btnBarcodeClear
            // 
            this.btnBarcodeClear.Location = new System.Drawing.Point(349, 71);
            this.btnBarcodeClear.Name = "btnBarcodeClear";
            this.btnBarcodeClear.Size = new System.Drawing.Size(103, 23);
            this.btnBarcodeClear.TabIndex = 4;
            this.btnBarcodeClear.Text = "Clear";
            this.btnBarcodeClear.UseVisualStyleBackColor = true;
            this.btnBarcodeClear.Click += new System.EventHandler(this.btnBarcodeClear_Click);
            // 
            // btnFlushMacroPdf
            // 
            this.btnFlushMacroPdf.Location = new System.Drawing.Point(95, 71);
            this.btnFlushMacroPdf.Name = "btnFlushMacroPdf";
            this.btnFlushMacroPdf.Size = new System.Drawing.Size(104, 23);
            this.btnFlushMacroPdf.TabIndex = 2;
            this.btnFlushMacroPdf.Text = "Flush Macro PDF";
            this.btnFlushMacroPdf.UseVisualStyleBackColor = true;
            this.btnFlushMacroPdf.Click += new System.EventHandler(this.btnFlushMacroPdf_Click);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabBarcode);
            this.tabCtrl.Controls.Add(this.tabConfig);
            this.tabCtrl.Controls.Add(this.tabScan2Connect);
            this.tabCtrl.Controls.Add(this.tabMisc);
            this.tabCtrl.Controls.Add(this.tabSSW);
            this.tabCtrl.Controls.Add(this.tabXml);
            this.tabCtrl.Location = new System.Drawing.Point(473, 12);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(519, 494);
            this.tabCtrl.TabIndex = 1;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
            // 
            // frmScannerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(992, 531);
            this.Controls.Add(this.stStripResult);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmScannerApp";
            this.Text = "Scanner SDK C# Sample Application";
            this.Load += new System.EventHandler(this.frmScannerApp_Load);
            this.grpTrigger.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpScanners.ResumeLayout(false);
            this.stStripResult.ResumeLayout(false);
            this.stStripResult.PerformLayout();
            this.tabXml.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.grpOutXml.ResumeLayout(false);
            this.grpOutXml.PerformLayout();
            this.tabSSW.ResumeLayout(false);
            this.tabSSW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).EndInit();
            this.tabMisc.ResumeLayout(false);
            this.grpMiscOther.ResumeLayout(false);
            this.grpSCdcSwitch.ResumeLayout(false);
            this.grpSCdcSwitch.PerformLayout();
            this.grpMiscCmd.ResumeLayout(false);
            this.grpAsync.ResumeLayout(false);
            this.grpAsync.PerformLayout();
            this.tabScan2Connect.ResumeLayout(false);
            this.grpScan2Connect.ResumeLayout(false);
            this.grpScan2Connect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBarcode)).EndInit();
            this.tabConfig.ResumeLayout(false);
            this.grpCustomDecodeTone.ResumeLayout(false);
            this.grpCustomDecodeTone.PerformLayout();
            this.filterScnrs.ResumeLayout(false);
            this.grpFrmWrUpdate.ResumeLayout(false);
            this.grpFrmWrUpdate.PerformLayout();
            this.grpFWoptns.ResumeLayout(false);
            this.grpFWoptns.PerformLayout();
            this.grpScannerProp.ResumeLayout(false);
            this.grpScannerProp.PerformLayout();
            this.grpElectricFenceCustomTone.ResumeLayout(false);
            this.grpElectricFenceCustomTone.PerformLayout();
            this.tabBarcode.ResumeLayout(false);
            this.tabBarcode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxLanguage.ResumeLayout(false);
            this.grpBoxLanguage.PerformLayout();
            this.grpboxBarcodeLbl.ResumeLayout(false);
            this.grpboxBarcodeLbl.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        /// <summary>
        /// This method allows only digits to be entered as pager motor duration
        /// Sends DEVICE_PAGE_MOTOR_CONTROL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPagerMotorDuration_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            PerformPagerMotorTxtKeyPress(sender, e);
        }

        #endregion
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.GroupBox grpTrigger;
        private System.Windows.Forms.Button btnReleaseTrigger;
        private System.Windows.Forms.Button btnPullTrigger;
        private System.Windows.Forms.Button btnGetScanners;
        private System.Windows.Forms.GroupBox grpScanners;
        private System.Windows.Forms.ListView lstvScanners;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.ColumnHeader clmSerial;
        private System.Windows.Forms.ColumnHeader clmModel;
        private System.Windows.Forms.ColumnHeader clmGuid;
        private System.Windows.Forms.OpenFileDialog openFileDialogFW;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogAttr;
        private System.Windows.Forms.StatusStrip stStripResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblTotal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblSnapi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblSsi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblIbmhid;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblHidkb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblNxmdb;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.ComboBox combSlcrScnr;
        private System.Windows.Forms.SaveFileDialog saveImgFileDialog;
        private System.Windows.Forms.Label lblSlctScnnr;
        private System.Windows.Forms.ColumnHeader clmFrmwr;
        private System.Windows.Forms.ColumnHeader clmMnftrd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIBMTT;
        private System.Windows.Forms.OpenFileDialog openFileDialogWavFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogDADF;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBarcodePath;
        private System.Windows.Forms.TabPage tabXml;
        private System.Windows.Forms.Button btnClearXmlArea;
        private System.Windows.Forms.Button btnClearLogsArea;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.GroupBox grpOutXml;
        private System.Windows.Forms.TextBox txtOutXml;
        private System.Windows.Forms.TabPage tabSSW;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtEpcId;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtUserBank;
        private System.Windows.Forms.TextBox txtNewEpcId;
        private System.Windows.Forms.TextBox txtUpcaBarcode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.RadioButton rdoASCII;
        private System.Windows.Forms.Button btnVerifyTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteTag;
        private System.Windows.Forms.ComboBox cmbPartition;
        private System.Windows.Forms.ComboBox cmbFilterValue;
        private System.Windows.Forms.PictureBox statusIcon;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkAutoIncrement;
        private System.Windows.Forms.Label lblUserBank;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.GroupBox grpMiscOther;
        private System.Windows.Forms.GroupBox grpSCdcSwitch;
        private System.Windows.Forms.Button btnSCdcSwitchDevices;
        private System.Windows.Forms.CheckBox chkSCdcSIsPermanent;
        private System.Windows.Forms.CheckBox chkSCdcSIsSilent;
        private System.Windows.Forms.ComboBox comboSCdcSHostMode;
        private System.Windows.Forms.Label lblSCdcSHostMode;
        private System.Windows.Forms.GroupBox grpMiscCmd;
        private System.Windows.Forms.Button btnGetDevTopology;
        private System.Windows.Forms.Button btnSdkVersion;
        private System.Windows.Forms.GroupBox grpAsync;
        private System.Windows.Forms.CheckBox chkAsync;
        private System.Windows.Forms.TabPage tabScan2Connect;
        private System.Windows.Forms.GroupBox grpScan2Connect;
        private System.Windows.Forms.Button btnSaveBarcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbHostName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbScannerType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBBarcode;
        private System.Windows.Forms.ComboBox cmbImageSize;
        private System.Windows.Forms.ComboBox cmbDefaultOption;
        private System.Windows.Forms.ComboBox cmbProtocol;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.GroupBox grpCustomDecodeTone;
        private System.Windows.Forms.Button btnEraseTone;
        private System.Windows.Forms.Button buttonWavFileUpload;
        private System.Windows.Forms.TextBox textBoxWavFile;
        private System.Windows.Forms.Button buttonWavFileBrowse;
        private System.Windows.Forms.GroupBox filterScnrs;
        private System.Windows.Forms.ComboBox comboFilterScnrs;
        private System.Windows.Forms.GroupBox grpFrmWrUpdate;
        private System.Windows.Forms.GroupBox grpFWoptns;
        private System.Windows.Forms.CheckBox chkBulk;
        private System.Windows.Forms.Button btnAbortFWUpdate;
        private System.Windows.Forms.Button btnFWUpdate;
        private System.Windows.Forms.Button btnLaunchNewFW;
        private System.Windows.Forms.ProgressBar progressBarFWUpdate;
        private System.Windows.Forms.Button buttonFWBrowse;
        private System.Windows.Forms.TextBox txtFWFile;
        private System.Windows.Forms.GroupBox grpScannerProp;
        private System.Windows.Forms.CheckBox chkClaim;
        private System.Windows.Forms.GroupBox grpElectricFenceCustomTone;
        private System.Windows.Forms.Button btnElectricFenceEraseTone;
        private System.Windows.Forms.Button buttonElectricFenceWavFileUpload;
        private System.Windows.Forms.TextBox textBoxElectricFenceWaveFile;
        private System.Windows.Forms.Button buttonElectricFenceWavFileBrowse;
        private System.Windows.Forms.TabPage tabBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScriptEditor;
        private System.Windows.Forms.Button btnBrowseScript;
        private System.Windows.Forms.CheckBox chkBoxAppADF;
        private System.Windows.Forms.GroupBox grpBoxLanguage;
        private System.Windows.Forms.CheckBox chkBoxEmulation;
        private System.Windows.Forms.ComboBox cmbEmulation;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox grpboxBarcodeLbl;
        private System.Windows.Forms.Label lblSyblogy;
        private System.Windows.Forms.TextBox txtSyblogy;
        private System.Windows.Forms.Label lblDecdBarCde;
        private System.Windows.Forms.TextBox txtBarcodeLbl;
        private System.Windows.Forms.Button btnAbortMacroPdf;
        private System.Windows.Forms.Button btnBarcodeClear;
        private System.Windows.Forms.Button btnFlushMacroPdf;
        private System.Windows.Forms.TabControl tabCtrl;
    }
}

