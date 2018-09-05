namespace RobocopyWrapper
{
    partial class MainForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPagePaths = new System.Windows.Forms.TabPage();
            this.PanelPaths = new System.Windows.Forms.Panel();
            this.TextBoxDestination = new System.Windows.Forms.TextBox();
            this.TextBoxSource = new System.Windows.Forms.TextBox();
            this.LabelDestination = new System.Windows.Forms.Label();
            this.LabelSource = new System.Windows.Forms.Label();
            this.ButtonBrowseDestination = new System.Windows.Forms.Button();
            this.ButtonBrowseSource = new System.Windows.Forms.Button();
            this.TabPageSwitches = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLastLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.FolderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.TabControl.SuspendLayout();
            this.TabPagePaths.SuspendLayout();
            this.PanelPaths.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPagePaths);
            this.TabControl.Controls.Add(this.TabPageSwitches);
            this.TabControl.Location = new System.Drawing.Point(12, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(440, 368);
            this.TabControl.TabIndex = 0;
            // 
            // TabPagePaths
            // 
            this.TabPagePaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPagePaths.Controls.Add(this.PanelPaths);
            this.TabPagePaths.Location = new System.Drawing.Point(4, 22);
            this.TabPagePaths.Name = "TabPagePaths";
            this.TabPagePaths.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePaths.Size = new System.Drawing.Size(432, 342);
            this.TabPagePaths.TabIndex = 0;
            this.TabPagePaths.Text = "Paths";
            this.TabPagePaths.UseVisualStyleBackColor = true;
            // 
            // PanelPaths
            // 
            this.PanelPaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPaths.Controls.Add(this.TextBoxDestination);
            this.PanelPaths.Controls.Add(this.TextBoxSource);
            this.PanelPaths.Controls.Add(this.LabelDestination);
            this.PanelPaths.Controls.Add(this.LabelSource);
            this.PanelPaths.Controls.Add(this.ButtonBrowseDestination);
            this.PanelPaths.Controls.Add(this.ButtonBrowseSource);
            this.PanelPaths.Location = new System.Drawing.Point(6, 6);
            this.PanelPaths.Name = "PanelPaths";
            this.PanelPaths.Size = new System.Drawing.Size(420, 330);
            this.PanelPaths.TabIndex = 0;
            this.PanelPaths.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TextBoxDestination
            // 
            this.TextBoxDestination.Location = new System.Drawing.Point(24, 95);
            this.TextBoxDestination.Name = "TextBoxDestination";
            this.TextBoxDestination.Size = new System.Drawing.Size(262, 20);
            this.TextBoxDestination.TabIndex = 5;
            // 
            // TextBoxSource
            // 
            this.TextBoxSource.Location = new System.Drawing.Point(24, 35);
            this.TextBoxSource.Name = "TextBoxSource";
            this.TextBoxSource.Size = new System.Drawing.Size(262, 20);
            this.TextBoxSource.TabIndex = 4;
            // 
            // LabelDestination
            // 
            this.LabelDestination.AutoSize = true;
            this.LabelDestination.Location = new System.Drawing.Point(21, 79);
            this.LabelDestination.Name = "LabelDestination";
            this.LabelDestination.Size = new System.Drawing.Size(63, 13);
            this.LabelDestination.TabIndex = 3;
            this.LabelDestination.Text = "Destination:";
            // 
            // LabelSource
            // 
            this.LabelSource.AutoSize = true;
            this.LabelSource.Location = new System.Drawing.Point(21, 19);
            this.LabelSource.Name = "LabelSource";
            this.LabelSource.Size = new System.Drawing.Size(44, 13);
            this.LabelSource.TabIndex = 2;
            this.LabelSource.Text = "Source:";
            // 
            // ButtonBrowseDestination
            // 
            this.ButtonBrowseDestination.Location = new System.Drawing.Point(292, 93);
            this.ButtonBrowseDestination.Name = "ButtonBrowseDestination";
            this.ButtonBrowseDestination.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseDestination.TabIndex = 1;
            this.ButtonBrowseDestination.Text = "Browse...";
            this.ButtonBrowseDestination.UseVisualStyleBackColor = true;
            this.ButtonBrowseDestination.Click += new System.EventHandler(this.ButtonBrowseDestination_Click);
            // 
            // ButtonBrowseSource
            // 
            this.ButtonBrowseSource.Location = new System.Drawing.Point(292, 33);
            this.ButtonBrowseSource.Name = "ButtonBrowseSource";
            this.ButtonBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseSource.TabIndex = 0;
            this.ButtonBrowseSource.Text = "Browse...";
            this.ButtonBrowseSource.UseVisualStyleBackColor = true;
            this.ButtonBrowseSource.Click += new System.EventHandler(this.ButtonBrowseSource_Click);
            // 
            // TabPageSwitches
            // 
            this.TabPageSwitches.Location = new System.Drawing.Point(4, 22);
            this.TabPageSwitches.Name = "TabPageSwitches";
            this.TabPageSwitches.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSwitches.Size = new System.Drawing.Size(432, 342);
            this.TabPageSwitches.TabIndex = 1;
            this.TabPageSwitches.Text = "Switches";
            this.TabPageSwitches.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemSettings,
            this.ToolStripMenuItemLogs,
            this.ToolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScriptToolStripMenuItem,
            this.saveScriptToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // openScriptToolStripMenuItem
            // 
            this.openScriptToolStripMenuItem.Name = "openScriptToolStripMenuItem";
            this.openScriptToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openScriptToolStripMenuItem.Text = "Load Script";
            // 
            // saveScriptToolStripMenuItem
            // 
            this.saveScriptToolStripMenuItem.Name = "saveScriptToolStripMenuItem";
            this.saveScriptToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveScriptToolStripMenuItem.Text = "Save Script";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItemSettings.Text = "Settings";
            // 
            // ToolStripMenuItemLogs
            // 
            this.ToolStripMenuItemLogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLastLogToolStripMenuItem,
            this.viewAllLogsToolStripMenuItem,
            this.clearAllLogsToolStripMenuItem});
            this.ToolStripMenuItemLogs.Name = "ToolStripMenuItemLogs";
            this.ToolStripMenuItemLogs.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItemLogs.Text = "Logs";
            // 
            // viewLastLogToolStripMenuItem
            // 
            this.viewLastLogToolStripMenuItem.Name = "viewLastLogToolStripMenuItem";
            this.viewLastLogToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewLastLogToolStripMenuItem.Text = "View Last Log";
            // 
            // viewAllLogsToolStripMenuItem
            // 
            this.viewAllLogsToolStripMenuItem.Name = "viewAllLogsToolStripMenuItem";
            this.viewAllLogsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewAllLogsToolStripMenuItem.Text = "View All Logs";
            // 
            // clearAllLogsToolStripMenuItem
            // 
            this.clearAllLogsToolStripMenuItem.Name = "clearAllLogsToolStripMenuItem";
            this.clearAllLogsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.clearAllLogsToolStripMenuItem.Text = "Clear All Logs";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItemHelp.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(377, 407);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(296, 407);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ButtonRun.Size = new System.Drawing.Size(75, 23);
            this.ButtonRun.TabIndex = 3;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // FolderBrowserDialogSource
            // 
            this.FolderBrowserDialogSource.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowserDialogSource.SelectedPath = "%SYSTEMROOT%";
            this.FolderBrowserDialogSource.HelpRequest += new System.EventHandler(this.FolderBrowserDialogSource_HelpRequest);
            // 
            // FolderBrowserDialogDestination
            // 
            this.FolderBrowserDialogDestination.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowserDialogDestination.SelectedPath = "%SYSTEMROOT%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 442);
            this.Controls.Add(this.ButtonRun);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Robocopy Wrapper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPagePaths.ResumeLayout(false);
            this.PanelPaths.ResumeLayout(false);
            this.PanelPaths.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPagePaths;
        private System.Windows.Forms.TabPage TabPageSwitches;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogs;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.Panel PanelPaths;
        private System.Windows.Forms.TextBox TextBoxDestination;
        private System.Windows.Forms.TextBox TextBoxSource;
        private System.Windows.Forms.Label LabelDestination;
        private System.Windows.Forms.Label LabelSource;
        private System.Windows.Forms.Button ButtonBrowseDestination;
        private System.Windows.Forms.Button ButtonBrowseSource;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem openScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLastLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogSource;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogDestination;
    }
}

