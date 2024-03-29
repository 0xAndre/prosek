﻿namespace prosek.ui
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuBar = new MenuStrip();
            toolMenu = new ToolStrip();
            toolMenuPlay = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            splitControl = new SplitContainer();
            processView = new TreeView();
            tabControl = new TabControl();
            tabPageDetails = new TabPage();
            groupBoxFileInfo = new GroupBox();
            lblCopyrightValue = new Label();
            lblLanguageValue = new Label();
            lblOriginalFilenameValue = new Label();
            lblProductVersionValue = new Label();
            lblProductNameValue = new Label();
            lblCopyright = new Label();
            lblLanguage = new Label();
            lblOriginalFileName = new Label();
            lblProductName = new Label();
            lblProductVersion = new Label();
            lblCompanyNameValue = new Label();
            lblCompanyName = new Label();
            lblDescriptionValue = new Label();
            lblDescription = new Label();
            lblFileVersionValue = new Label();
            lblFileVersion = new Label();
            groupBoxStats = new GroupBox();
            lblStatusMalicious = new Label();
            lblStatusUndetected = new Label();
            groupBoxProperties = new GroupBox();
            lblProcessIdValue = new Label();
            lblProcessId = new Label();
            lblSizeValue = new Label();
            lblSize = new Label();
            lblVhashValue = new Label();
            lblVhash = new Label();
            lblTlshValue = new Label();
            lblTlsh = new Label();
            lblTypeValue = new Label();
            lblType = new Label();
            lblSHA1Value = new Label();
            lblSHA1 = new Label();
            lblSHA256Value = new Label();
            lblSHA256 = new Label();
            lblProcessPathValue = new Label();
            lblProcessPath = new Label();
            lblProcessNameValue = new Label();
            lblProcessName = new Label();
            tabPageDetection = new TabPage();
            listViewDetection = new ListView();
            Engine = new ColumnHeader();
            Result = new ColumnHeader();
            MalwareName = new ColumnHeader();
            tabPageRelations = new TabPage();
            lstViewPEResourceChildren = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            lvlPEResourceChildren = new Label();
            lstViewContactedDomains = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblContactedDomains = new Label();
            lstViewExecutionParents = new ListView();
            Sanned = new ColumnHeader();
            Detect = new ColumnHeader();
            Type = new ColumnHeader();
            ExecName = new ColumnHeader();
            lblExecutionParents = new Label();
            lblContactedIPs = new Label();
            lstViewContactedIps = new ListView();
            IP = new ColumnHeader();
            Detections = new ColumnHeader();
            Country = new ColumnHeader();
            Owner = new ColumnHeader();
            LAD = new ColumnHeader();
            tabPageCommunity = new TabPage();
            dataGridComments = new DataGridView();
            imageList = new ImageList(components);
            Date = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Comment = new DataGridViewTextBoxColumn();
            menuBar.SuspendLayout();
            toolMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitControl).BeginInit();
            splitControl.Panel1.SuspendLayout();
            splitControl.Panel2.SuspendLayout();
            splitControl.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageDetails.SuspendLayout();
            groupBoxFileInfo.SuspendLayout();
            groupBoxStats.SuspendLayout();
            groupBoxProperties.SuspendLayout();
            tabPageDetection.SuspendLayout();
            tabPageRelations.SuspendLayout();
            tabPageCommunity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridComments).BeginInit();
            SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(203, 22);
            toolStripMenuItem1.Text = "Add VirusTotal X-Header";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // menuBar
            // 
            menuBar.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(1084, 24);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuBar";
            // 
            // toolMenu
            // 
            toolMenu.BackColor = SystemColors.ControlLightLight;
            toolMenu.Items.AddRange(new ToolStripItem[] { toolMenuPlay });
            toolMenu.Location = new Point(0, 24);
            toolMenu.Name = "toolMenu";
            toolMenu.Size = new Size(1084, 25);
            toolMenu.TabIndex = 1;
            toolMenu.Text = "toolMenu";
            // 
            // toolMenuPlay
            // 
            toolMenuPlay.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolMenuPlay.Image = (Image)resources.GetObject("toolMenuPlay.Image");
            toolMenuPlay.ImageTransparentColor = Color.Magenta;
            toolMenuPlay.Name = "toolMenuPlay";
            toolMenuPlay.Size = new Size(23, 22);
            toolMenuPlay.Text = "Scan";
            toolMenuPlay.Click += toolMenuPlay_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 789);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1084, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Prosek";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 16);
            // 
            // splitControl
            // 
            splitControl.Dock = DockStyle.Fill;
            splitControl.Location = new Point(0, 49);
            splitControl.Name = "splitControl";
            // 
            // splitControl.Panel1
            // 
            splitControl.Panel1.Controls.Add(processView);
            // 
            // splitControl.Panel2
            // 
            splitControl.Panel2.Controls.Add(tabControl);
            splitControl.Size = new Size(1084, 740);
            splitControl.SplitterDistance = 317;
            splitControl.TabIndex = 3;
            // 
            // processView
            // 
            processView.Dock = DockStyle.Fill;
            processView.Location = new Point(0, 0);
            processView.Name = "processView";
            processView.Size = new Size(317, 740);
            processView.TabIndex = 0;
            processView.AfterSelect += processView_AfterSelect;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageDetails);
            tabControl.Controls.Add(tabPageDetection);
            tabControl.Controls.Add(tabPageRelations);
            tabControl.Controls.Add(tabPageCommunity);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(763, 740);
            tabControl.TabIndex = 0;
            // 
            // tabPageDetails
            // 
            tabPageDetails.Controls.Add(groupBoxFileInfo);
            tabPageDetails.Controls.Add(groupBoxStats);
            tabPageDetails.Controls.Add(groupBoxProperties);
            tabPageDetails.Location = new Point(4, 24);
            tabPageDetails.Name = "tabPageDetails";
            tabPageDetails.Size = new Size(755, 712);
            tabPageDetails.TabIndex = 2;
            tabPageDetails.Text = "Details";
            tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileInfo
            // 
            groupBoxFileInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxFileInfo.Controls.Add(lblCopyrightValue);
            groupBoxFileInfo.Controls.Add(lblLanguageValue);
            groupBoxFileInfo.Controls.Add(lblOriginalFilenameValue);
            groupBoxFileInfo.Controls.Add(lblProductVersionValue);
            groupBoxFileInfo.Controls.Add(lblProductNameValue);
            groupBoxFileInfo.Controls.Add(lblCopyright);
            groupBoxFileInfo.Controls.Add(lblLanguage);
            groupBoxFileInfo.Controls.Add(lblOriginalFileName);
            groupBoxFileInfo.Controls.Add(lblProductName);
            groupBoxFileInfo.Controls.Add(lblProductVersion);
            groupBoxFileInfo.Controls.Add(lblCompanyNameValue);
            groupBoxFileInfo.Controls.Add(lblCompanyName);
            groupBoxFileInfo.Controls.Add(lblDescriptionValue);
            groupBoxFileInfo.Controls.Add(lblDescription);
            groupBoxFileInfo.Controls.Add(lblFileVersionValue);
            groupBoxFileInfo.Controls.Add(lblFileVersion);
            groupBoxFileInfo.Location = new Point(14, 453);
            groupBoxFileInfo.Name = "groupBoxFileInfo";
            groupBoxFileInfo.Size = new Size(733, 242);
            groupBoxFileInfo.TabIndex = 2;
            groupBoxFileInfo.TabStop = false;
            groupBoxFileInfo.Text = "Assembly Info";
            // 
            // lblCopyrightValue
            // 
            lblCopyrightValue.AutoSize = true;
            lblCopyrightValue.Location = new Point(90, 157);
            lblCopyrightValue.Name = "lblCopyrightValue";
            lblCopyrightValue.Size = new Size(59, 15);
            lblCopyrightValue.TabIndex = 15;
            lblCopyrightValue.Text = "Loading...";
            // 
            // lblLanguageValue
            // 
            lblLanguageValue.AutoSize = true;
            lblLanguageValue.Location = new Point(86, 140);
            lblLanguageValue.Name = "lblLanguageValue";
            lblLanguageValue.Size = new Size(59, 15);
            lblLanguageValue.TabIndex = 14;
            lblLanguageValue.Text = "Loading...";
            // 
            // lblOriginalFilenameValue
            // 
            lblOriginalFilenameValue.AutoSize = true;
            lblOriginalFilenameValue.Location = new Point(131, 124);
            lblOriginalFilenameValue.Name = "lblOriginalFilenameValue";
            lblOriginalFilenameValue.Size = new Size(59, 15);
            lblOriginalFilenameValue.TabIndex = 13;
            lblOriginalFilenameValue.Text = "Loading...";
            // 
            // lblProductVersionValue
            // 
            lblProductVersionValue.AutoSize = true;
            lblProductVersionValue.Location = new Point(123, 107);
            lblProductVersionValue.Name = "lblProductVersionValue";
            lblProductVersionValue.Size = new Size(59, 15);
            lblProductVersionValue.TabIndex = 12;
            lblProductVersionValue.Text = "Loading...";
            // 
            // lblProductNameValue
            // 
            lblProductNameValue.AutoSize = true;
            lblProductNameValue.Location = new Point(115, 90);
            lblProductNameValue.Name = "lblProductNameValue";
            lblProductNameValue.Size = new Size(59, 15);
            lblProductNameValue.TabIndex = 11;
            lblProductNameValue.Text = "Loading...";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCopyright.Location = new Point(27, 157);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(64, 15);
            lblCopyright.TabIndex = 10;
            lblCopyright.Text = "Copyright:";
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguage.Location = new Point(27, 140);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(63, 15);
            lblLanguage.TabIndex = 9;
            lblLanguage.Text = "Language:";
            // 
            // lblOriginalFileName
            // 
            lblOriginalFileName.AutoSize = true;
            lblOriginalFileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOriginalFileName.Location = new Point(27, 124);
            lblOriginalFileName.Name = "lblOriginalFileName";
            lblOriginalFileName.Size = new Size(106, 15);
            lblOriginalFileName.TabIndex = 8;
            lblOriginalFileName.Text = "Original Filename:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.Location = new Point(27, 91);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(90, 15);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Product Name:";
            // 
            // lblProductVersion
            // 
            lblProductVersion.AutoSize = true;
            lblProductVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductVersion.Location = new Point(27, 107);
            lblProductVersion.Name = "lblProductVersion";
            lblProductVersion.Size = new Size(98, 15);
            lblProductVersion.TabIndex = 6;
            lblProductVersion.Text = "Product Version:";
            // 
            // lblCompanyNameValue
            // 
            lblCompanyNameValue.AutoSize = true;
            lblCompanyNameValue.Location = new Point(123, 75);
            lblCompanyNameValue.Name = "lblCompanyNameValue";
            lblCompanyNameValue.Size = new Size(59, 15);
            lblCompanyNameValue.TabIndex = 5;
            lblCompanyNameValue.Text = "Loading...";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCompanyName.Location = new Point(27, 75);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(97, 15);
            lblCompanyName.TabIndex = 4;
            lblCompanyName.Text = "Company Name:";
            // 
            // lblDescriptionValue
            // 
            lblDescriptionValue.AutoSize = true;
            lblDescriptionValue.Location = new Point(99, 59);
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Size = new Size(59, 15);
            lblDescriptionValue.TabIndex = 3;
            lblDescriptionValue.Text = "Loading...";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(27, 59);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(74, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblFileVersionValue
            // 
            lblFileVersionValue.AutoSize = true;
            lblFileVersionValue.Location = new Point(99, 39);
            lblFileVersionValue.Name = "lblFileVersionValue";
            lblFileVersionValue.Size = new Size(59, 15);
            lblFileVersionValue.TabIndex = 1;
            lblFileVersionValue.Text = "Loading...";
            // 
            // lblFileVersion
            // 
            lblFileVersion.AutoSize = true;
            lblFileVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileVersion.Location = new Point(27, 39);
            lblFileVersion.Name = "lblFileVersion";
            lblFileVersion.Size = new Size(73, 15);
            lblFileVersion.TabIndex = 0;
            lblFileVersion.Text = "File Version:";
            // 
            // groupBoxStats
            // 
            groupBoxStats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStats.Controls.Add(lblStatusMalicious);
            groupBoxStats.Controls.Add(lblStatusUndetected);
            groupBoxStats.Location = new Point(14, 282);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(733, 150);
            groupBoxStats.TabIndex = 1;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Stats";
            // 
            // lblStatusMalicious
            // 
            lblStatusMalicious.AutoSize = true;
            lblStatusMalicious.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusMalicious.ForeColor = Color.Red;
            lblStatusMalicious.Location = new Point(20, 83);
            lblStatusMalicious.Name = "lblStatusMalicious";
            lblStatusMalicious.Size = new Size(482, 37);
            lblStatusMalicious.TabIndex = 1;
            lblStatusMalicious.Text = "0 vendors detected malware on this file";
            // 
            // lblStatusUndetected
            // 
            lblStatusUndetected.AutoSize = true;
            lblStatusUndetected.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusUndetected.ForeColor = Color.Green;
            lblStatusUndetected.Location = new Point(20, 33);
            lblStatusUndetected.Name = "lblStatusUndetected";
            lblStatusUndetected.Size = new Size(592, 37);
            lblStatusUndetected.TabIndex = 0;
            lblStatusUndetected.Text = "0 vendors have not detected malware on this file";
            // 
            // groupBoxProperties
            // 
            groupBoxProperties.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProperties.Controls.Add(lblProcessIdValue);
            groupBoxProperties.Controls.Add(lblProcessId);
            groupBoxProperties.Controls.Add(lblSizeValue);
            groupBoxProperties.Controls.Add(lblSize);
            groupBoxProperties.Controls.Add(lblVhashValue);
            groupBoxProperties.Controls.Add(lblVhash);
            groupBoxProperties.Controls.Add(lblTlshValue);
            groupBoxProperties.Controls.Add(lblTlsh);
            groupBoxProperties.Controls.Add(lblTypeValue);
            groupBoxProperties.Controls.Add(lblType);
            groupBoxProperties.Controls.Add(lblSHA1Value);
            groupBoxProperties.Controls.Add(lblSHA1);
            groupBoxProperties.Controls.Add(lblSHA256Value);
            groupBoxProperties.Controls.Add(lblSHA256);
            groupBoxProperties.Controls.Add(lblProcessPathValue);
            groupBoxProperties.Controls.Add(lblProcessPath);
            groupBoxProperties.Controls.Add(lblProcessNameValue);
            groupBoxProperties.Controls.Add(lblProcessName);
            groupBoxProperties.Location = new Point(14, 15);
            groupBoxProperties.Name = "groupBoxProperties";
            groupBoxProperties.Size = new Size(733, 250);
            groupBoxProperties.TabIndex = 0;
            groupBoxProperties.TabStop = false;
            groupBoxProperties.Text = "Properties";
            // 
            // lblProcessIdValue
            // 
            lblProcessIdValue.AutoSize = true;
            lblProcessIdValue.Location = new Point(84, 27);
            lblProcessIdValue.Name = "lblProcessIdValue";
            lblProcessIdValue.Size = new Size(59, 15);
            lblProcessIdValue.TabIndex = 17;
            lblProcessIdValue.Text = "Loading...";
            // 
            // lblProcessId
            // 
            lblProcessId.AutoSize = true;
            lblProcessId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProcessId.Location = new Point(20, 27);
            lblProcessId.Name = "lblProcessId";
            lblProcessId.Size = new Size(66, 15);
            lblProcessId.TabIndex = 16;
            lblProcessId.Text = "Process Id:";
            // 
            // lblSizeValue
            // 
            lblSizeValue.AutoSize = true;
            lblSizeValue.Location = new Point(52, 210);
            lblSizeValue.Name = "lblSizeValue";
            lblSizeValue.Size = new Size(59, 15);
            lblSizeValue.TabIndex = 15;
            lblSizeValue.Text = "Loading...";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(20, 210);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(33, 15);
            lblSize.TabIndex = 14;
            lblSize.Text = "Size:";
            // 
            // lblVhashValue
            // 
            lblVhashValue.AutoSize = true;
            lblVhashValue.Location = new Point(69, 188);
            lblVhashValue.Name = "lblVhashValue";
            lblVhashValue.Size = new Size(59, 15);
            lblVhashValue.TabIndex = 13;
            lblVhashValue.Text = "Loading...";
            // 
            // lblVhash
            // 
            lblVhash.AutoSize = true;
            lblVhash.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblVhash.Location = new Point(20, 188);
            lblVhash.Name = "lblVhash";
            lblVhash.Size = new Size(51, 15);
            lblVhash.TabIndex = 12;
            lblVhash.Text = "VHASH:";
            // 
            // lblTlshValue
            // 
            lblTlshValue.AutoSize = true;
            lblTlshValue.Location = new Point(58, 164);
            lblTlshValue.Name = "lblTlshValue";
            lblTlshValue.Size = new Size(59, 15);
            lblTlshValue.TabIndex = 11;
            lblTlshValue.Text = "Loading...";
            // 
            // lblTlsh
            // 
            lblTlsh.AutoSize = true;
            lblTlsh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTlsh.Location = new Point(20, 164);
            lblTlsh.Name = "lblTlsh";
            lblTlsh.Size = new Size(39, 15);
            lblTlsh.TabIndex = 10;
            lblTlsh.Text = "TLSH:";
            // 
            // lblTypeValue
            // 
            lblTypeValue.AutoSize = true;
            lblTypeValue.Location = new Point(60, 139);
            lblTypeValue.Name = "lblTypeValue";
            lblTypeValue.Size = new Size(59, 15);
            lblTypeValue.TabIndex = 9;
            lblTypeValue.Text = "Loading...";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(20, 139);
            lblType.Name = "lblType";
            lblType.Size = new Size(36, 15);
            lblType.TabIndex = 8;
            lblType.Text = "Type:";
            // 
            // lblSHA1Value
            // 
            lblSHA1Value.AutoSize = true;
            lblSHA1Value.Location = new Point(60, 115);
            lblSHA1Value.Name = "lblSHA1Value";
            lblSHA1Value.Size = new Size(59, 15);
            lblSHA1Value.TabIndex = 7;
            lblSHA1Value.Text = "Loading...";
            // 
            // lblSHA1
            // 
            lblSHA1.AutoSize = true;
            lblSHA1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSHA1.Location = new Point(20, 115);
            lblSHA1.Name = "lblSHA1";
            lblSHA1.Size = new Size(41, 15);
            lblSHA1.TabIndex = 6;
            lblSHA1.Text = "SHA1:";
            // 
            // lblSHA256Value
            // 
            lblSHA256Value.AutoSize = true;
            lblSHA256Value.Location = new Point(74, 92);
            lblSHA256Value.Name = "lblSHA256Value";
            lblSHA256Value.Size = new Size(59, 15);
            lblSHA256Value.TabIndex = 5;
            lblSHA256Value.Text = "Loading...";
            // 
            // lblSHA256
            // 
            lblSHA256.AutoSize = true;
            lblSHA256.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSHA256.Location = new Point(20, 92);
            lblSHA256.Name = "lblSHA256";
            lblSHA256.Size = new Size(55, 15);
            lblSHA256.TabIndex = 4;
            lblSHA256.Text = "SHA256:";
            // 
            // lblProcessPathValue
            // 
            lblProcessPathValue.AutoSize = true;
            lblProcessPathValue.Location = new Point(100, 68);
            lblProcessPathValue.Name = "lblProcessPathValue";
            lblProcessPathValue.Size = new Size(59, 15);
            lblProcessPathValue.TabIndex = 3;
            lblProcessPathValue.Text = "Loading...";
            // 
            // lblProcessPath
            // 
            lblProcessPath.AutoSize = true;
            lblProcessPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProcessPath.Location = new Point(20, 68);
            lblProcessPath.Name = "lblProcessPath";
            lblProcessPath.Size = new Size(80, 15);
            lblProcessPath.TabIndex = 2;
            lblProcessPath.Text = "Process Path:";
            // 
            // lblProcessNameValue
            // 
            lblProcessNameValue.AutoSize = true;
            lblProcessNameValue.Location = new Point(108, 47);
            lblProcessNameValue.Name = "lblProcessNameValue";
            lblProcessNameValue.Size = new Size(59, 15);
            lblProcessNameValue.TabIndex = 1;
            lblProcessNameValue.Text = "Loading...";
            // 
            // lblProcessName
            // 
            lblProcessName.AutoSize = true;
            lblProcessName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProcessName.Location = new Point(20, 47);
            lblProcessName.Name = "lblProcessName";
            lblProcessName.Size = new Size(88, 15);
            lblProcessName.TabIndex = 0;
            lblProcessName.Text = "Process Name:";
            // 
            // tabPageDetection
            // 
            tabPageDetection.Controls.Add(listViewDetection);
            tabPageDetection.Location = new Point(4, 24);
            tabPageDetection.Name = "tabPageDetection";
            tabPageDetection.Padding = new Padding(3);
            tabPageDetection.Size = new Size(755, 712);
            tabPageDetection.TabIndex = 0;
            tabPageDetection.Text = "Detection";
            tabPageDetection.UseVisualStyleBackColor = true;
            // 
            // listViewDetection
            // 
            listViewDetection.AllowColumnReorder = true;
            listViewDetection.Columns.AddRange(new ColumnHeader[] { Engine, Result, MalwareName });
            listViewDetection.Dock = DockStyle.Fill;
            listViewDetection.GridLines = true;
            listViewDetection.Location = new Point(3, 3);
            listViewDetection.Name = "listViewDetection";
            listViewDetection.RightToLeft = RightToLeft.No;
            listViewDetection.Size = new Size(749, 706);
            listViewDetection.TabIndex = 0;
            listViewDetection.UseCompatibleStateImageBehavior = false;
            // 
            // Engine
            // 
            Engine.Text = "Engine";
            Engine.Width = 200;
            // 
            // Result
            // 
            Result.Text = "Result";
            Result.Width = 180;
            // 
            // MalwareName
            // 
            MalwareName.Text = "Malware";
            MalwareName.Width = 240;
            // 
            // tabPageRelations
            // 
            tabPageRelations.Controls.Add(lstViewPEResourceChildren);
            tabPageRelations.Controls.Add(lvlPEResourceChildren);
            tabPageRelations.Controls.Add(lstViewContactedDomains);
            tabPageRelations.Controls.Add(lblContactedDomains);
            tabPageRelations.Controls.Add(lstViewExecutionParents);
            tabPageRelations.Controls.Add(lblExecutionParents);
            tabPageRelations.Controls.Add(lblContactedIPs);
            tabPageRelations.Controls.Add(lstViewContactedIps);
            tabPageRelations.Location = new Point(4, 24);
            tabPageRelations.Name = "tabPageRelations";
            tabPageRelations.Padding = new Padding(3);
            tabPageRelations.Size = new Size(755, 712);
            tabPageRelations.TabIndex = 1;
            tabPageRelations.Text = "Relations";
            tabPageRelations.UseVisualStyleBackColor = true;
            // 
            // lstViewPEResourceChildren
            // 
            lstViewPEResourceChildren.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstViewPEResourceChildren.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lstViewPEResourceChildren.Location = new Point(0, 561);
            lstViewPEResourceChildren.Name = "lstViewPEResourceChildren";
            lstViewPEResourceChildren.Size = new Size(755, 150);
            lstViewPEResourceChildren.TabIndex = 7;
            lstViewPEResourceChildren.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Scanned";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Detections";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Type";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "SHA256";
            columnHeader8.Width = 420;
            // 
            // lvlPEResourceChildren
            // 
            lvlPEResourceChildren.AutoSize = true;
            lvlPEResourceChildren.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lvlPEResourceChildren.Location = new Point(0, 543);
            lvlPEResourceChildren.Name = "lvlPEResourceChildren";
            lvlPEResourceChildren.Size = new Size(124, 15);
            lvlPEResourceChildren.TabIndex = 6;
            lvlPEResourceChildren.Text = "PE Resource Children";
            // 
            // lstViewContactedDomains
            // 
            lstViewContactedDomains.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstViewContactedDomains.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstViewContactedDomains.Location = new Point(0, 376);
            lstViewContactedDomains.Name = "lstViewContactedDomains";
            lstViewContactedDomains.Size = new Size(755, 150);
            lstViewContactedDomains.TabIndex = 5;
            lstViewContactedDomains.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Scanned";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Detections";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Created";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Registrar";
            columnHeader4.Width = 250;
            // 
            // lblContactedDomains
            // 
            lblContactedDomains.AutoSize = true;
            lblContactedDomains.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactedDomains.Location = new Point(0, 358);
            lblContactedDomains.Name = "lblContactedDomains";
            lblContactedDomains.Size = new Size(115, 15);
            lblContactedDomains.TabIndex = 4;
            lblContactedDomains.Text = "Contacted Domains";
            // 
            // lstViewExecutionParents
            // 
            lstViewExecutionParents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstViewExecutionParents.Columns.AddRange(new ColumnHeader[] { Sanned, Detect, Type, ExecName });
            lstViewExecutionParents.Location = new Point(1, 198);
            lstViewExecutionParents.Name = "lstViewExecutionParents";
            lstViewExecutionParents.Size = new Size(754, 143);
            lstViewExecutionParents.TabIndex = 3;
            lstViewExecutionParents.UseCompatibleStateImageBehavior = false;
            // 
            // Sanned
            // 
            Sanned.Text = "Scanned";
            Sanned.Width = 100;
            // 
            // Detect
            // 
            Detect.Text = "Detections";
            Detect.Width = 100;
            // 
            // Type
            // 
            Type.Text = "Type";
            // 
            // ExecName
            // 
            ExecName.Text = "Name";
            ExecName.Width = 350;
            // 
            // lblExecutionParents
            // 
            lblExecutionParents.AutoSize = true;
            lblExecutionParents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblExecutionParents.Location = new Point(3, 180);
            lblExecutionParents.Name = "lblExecutionParents";
            lblExecutionParents.Size = new Size(107, 15);
            lblExecutionParents.TabIndex = 2;
            lblExecutionParents.Text = "Execution Parents";
            // 
            // lblContactedIPs
            // 
            lblContactedIPs.AutoSize = true;
            lblContactedIPs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContactedIPs.Location = new Point(3, 15);
            lblContactedIPs.Name = "lblContactedIPs";
            lblContactedIPs.Size = new Size(142, 15);
            lblContactedIPs.TabIndex = 1;
            lblContactedIPs.Text = "Contacted IPs Addresses";
            // 
            // lstViewContactedIps
            // 
            lstViewContactedIps.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstViewContactedIps.Columns.AddRange(new ColumnHeader[] { IP, Detections, Country, Owner, LAD });
            lstViewContactedIps.Location = new Point(0, 33);
            lstViewContactedIps.Name = "lstViewContactedIps";
            lstViewContactedIps.Size = new Size(755, 126);
            lstViewContactedIps.TabIndex = 0;
            lstViewContactedIps.UseCompatibleStateImageBehavior = false;
            // 
            // IP
            // 
            IP.Text = "IP";
            IP.Width = 100;
            // 
            // Detections
            // 
            Detections.Text = "Detections";
            Detections.Width = 100;
            // 
            // Country
            // 
            Country.Text = "Country";
            // 
            // Owner
            // 
            Owner.Text = "Owner";
            Owner.Width = 250;
            // 
            // LAD
            // 
            LAD.Text = "Last Analysis";
            LAD.Width = 120;
            // 
            // tabPageCommunity
            // 
            tabPageCommunity.Controls.Add(dataGridComments);
            tabPageCommunity.Location = new Point(4, 24);
            tabPageCommunity.Name = "tabPageCommunity";
            tabPageCommunity.Size = new Size(755, 712);
            tabPageCommunity.TabIndex = 3;
            tabPageCommunity.Text = "Community";
            tabPageCommunity.UseVisualStyleBackColor = true;
            // 
            // dataGridComments
            // 
            dataGridComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridComments.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridComments.Columns.AddRange(new DataGridViewColumn[] { Date, User, Comment });
            dataGridComments.Location = new Point(0, 0);
            dataGridComments.Name = "dataGridComments";
            dataGridComments.RowTemplate.Height = 25;
            dataGridComments.Size = new Size(755, 713);
            dataGridComments.TabIndex = 0;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageSize = new Size(16, 16);
            imageList.TransparentColor = Color.Transparent;
            // 
            // Date
            // 
            Date.FillWeight = 15F;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // User
            // 
            User.FillWeight = 20F;
            User.HeaderText = "User";
            User.MinimumWidth = 50;
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // Comment
            // 
            Comment.FillWeight = 60F;
            Comment.HeaderText = "Comment";
            Comment.MinimumWidth = 200;
            Comment.Name = "Comment";
            Comment.ReadOnly = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 811);
            Controls.Add(splitControl);
            Controls.Add(statusStrip1);
            Controls.Add(toolMenu);
            Controls.Add(menuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBar;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prosek";
            Load += App_Load;
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            toolMenu.ResumeLayout(false);
            toolMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitControl.Panel1.ResumeLayout(false);
            splitControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitControl).EndInit();
            splitControl.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPageDetails.ResumeLayout(false);
            groupBoxFileInfo.ResumeLayout(false);
            groupBoxFileInfo.PerformLayout();
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            groupBoxProperties.ResumeLayout(false);
            groupBoxProperties.PerformLayout();
            tabPageDetection.ResumeLayout(false);
            tabPageRelations.ResumeLayout(false);
            tabPageRelations.PerformLayout();
            tabPageCommunity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridComments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private MenuStrip menuBar;
        private ToolStrip toolMenu;
        private ToolStripButton toolMenuPlay;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private SplitContainer splitControl;
        private TreeView processView;
        private ToolStripProgressBar toolStripProgressBar;
        private TabControl tabControl;
        private TabPage tabPageDetection;
        private TabPage tabPageRelations;
        private ListView listViewDetection;
        private ColumnHeader Engine;
        private ColumnHeader Result;
        private TabPage tabPageDetails;
        private GroupBox groupBoxProperties;
        private Label lblProcessNameValue;
        private Label lblProcessName;
        private Label lblProcessPathValue;
        private Label lblProcessPath;
        private Label lblSHA256Value;
        private Label lblSHA256;
        private Label lblSHA1Value;
        private Label lblSHA1;
        private Label lblTypeValue;
        private Label lblType;
        private Label lblTlshValue;
        private Label lblTlsh;
        private Label lblVhashValue;
        private Label lblVhash;
        private Label lblSizeValue;
        private Label lblSize;
        private Label lblProcessIdValue;
        private Label lblProcessId;
        private ImageList imageList;
        private ColumnHeader MalwareName;
        private GroupBox groupBoxStats;
        private Label lblStatusMalicious;
        private Label lblStatusUndetected;
        private GroupBox groupBoxFileInfo;
        private Label lblFileVersionValue;
        private Label lblFileVersion;
        private Label lblDescriptionValue;
        private Label lblDescription;
        private Label lblCompanyNameValue;
        private Label lblCompanyName;
        private Label lblProductName;
        private Label lblProductVersion;
        private Label lblCopyrightValue;
        private Label lblLanguageValue;
        private Label lblOriginalFilenameValue;
        private Label lblProductVersionValue;
        private Label lblProductNameValue;
        private Label lblCopyright;
        private Label lblLanguage;
        private Label lblOriginalFileName;
        private Label lblContactedIPs;
        private ListView lstViewContactedIps;
        private ColumnHeader IP;
        private ColumnHeader Detections;
        private ColumnHeader Country;
        private ColumnHeader Owner;
        private ColumnHeader LAD;
        private Label lblExecutionParents;
        private ListView lstViewExecutionParents;
        private ColumnHeader Sanned;
        private ColumnHeader Detect;
        private ColumnHeader Type;
        private ColumnHeader ExecName;
        private ListView lstViewContactedDomains;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblContactedDomains;
        private ListView lstViewPEResourceChildren;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label lvlPEResourceChildren;
        private TabPage tabPageCommunity;
        private DataGridView dataGridComments;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Comment;
    }
}