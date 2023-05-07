namespace prosek.ui
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
            tabPage1 = new TabPage();
            listViewDetection = new ListView();
            Engine = new ColumnHeader();
            Result = new ColumnHeader();
            tabPage2 = new TabPage();
            menuBar.SuspendLayout();
            toolMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitControl).BeginInit();
            splitControl.Panel1.SuspendLayout();
            splitControl.Panel2.SuspendLayout();
            splitControl.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
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
            menuBar.Size = new Size(951, 24);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuBar";
            // 
            // toolMenu
            // 
            toolMenu.BackColor = SystemColors.ControlLightLight;
            toolMenu.Items.AddRange(new ToolStripItem[] { toolMenuPlay });
            toolMenu.Location = new Point(0, 24);
            toolMenu.Name = "toolMenu";
            toolMenu.Size = new Size(951, 25);
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
            statusStrip1.Location = new Point(0, 551);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(951, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Prosek";
            toolStripStatusLabel.Click += toolStripStatusLabel1_Click;
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
            splitControl.Size = new Size(951, 502);
            splitControl.SplitterDistance = 317;
            splitControl.TabIndex = 3;
            // 
            // processView
            // 
            processView.Dock = DockStyle.Fill;
            processView.Location = new Point(0, 0);
            processView.Name = "processView";
            processView.Size = new Size(317, 502);
            processView.TabIndex = 0;
            processView.AfterSelect += processView_AfterSelect;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(630, 502);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewDetection);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(622, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detection";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewDetection
            // 
            listViewDetection.AllowColumnReorder = true;
            listViewDetection.Columns.AddRange(new ColumnHeader[] { Engine, Result });
            listViewDetection.Dock = DockStyle.Fill;
            listViewDetection.GridLines = true;
            listViewDetection.Location = new Point(3, 3);
            listViewDetection.Name = "listViewDetection";
            listViewDetection.RightToLeft = RightToLeft.No;
            listViewDetection.Size = new Size(616, 468);
            listViewDetection.TabIndex = 0;
            listViewDetection.UseCompatibleStateImageBehavior = false;
            listViewDetection.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(622, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Relations";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 573);
            Controls.Add(splitControl);
            Controls.Add(statusStrip1);
            Controls.Add(toolMenu);
            Controls.Add(menuBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBar;
            Name = "App";
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
            tabPage1.ResumeLayout(false);
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listViewDetection;
        private ColumnHeader Engine;
        private ColumnHeader Result;
    }
}