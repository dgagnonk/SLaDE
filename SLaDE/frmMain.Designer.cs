﻿namespace SLaDE
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tsControls = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnClips = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.panConsoleArea = new System.Windows.Forms.Panel();
            this.panInput = new System.Windows.Forms.Panel();
            this.lnkClearConsole = new System.Windows.Forms.LinkLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkScriptTaskStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeIconsByIcons8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ssData = new System.Windows.Forms.StatusStrip();
            this.lblCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrMouse = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tmrBackup = new System.Windows.Forms.Timer(this.components);
            this.tsControls.SuspendLayout();
            this.panConsoleArea.SuspendLayout();
            this.panInput.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).BeginInit();
            this.ssData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.DimGray;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(528, 137);
            this.txtOutput.TabIndex = 14;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(87, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(363, 22);
            this.txtInput.TabIndex = 7;
            // 
            // btnInput
            // 
            this.btnInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInput.Location = new System.Drawing.Point(453, 0);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 27);
            this.btnInput.TabIndex = 8;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tsControls
            // 
            this.tsControls.AutoSize = false;
            this.tsControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnSettings,
            this.toolStripSeparator4,
            this.btnNew,
            this.btnSave,
            this.btnOpen,
            this.btnClips,
            this.toolStripSeparator2,
            this.btnRun,
            this.toolStripSeparator3,
            this.lblStatus});
            this.tsControls.Location = new System.Drawing.Point(0, 24);
            this.tsControls.Name = "tsControls";
            this.tsControls.Size = new System.Drawing.Size(528, 36);
            this.tsControls.TabIndex = 9;
            this.tsControls.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 33);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::SLaDE.Properties.Resources.Add_New_16px;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(32, 32);
            this.btnNew.Text = "New";
            this.btnNew.ToolTipText = "New Script";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::SLaDE.Properties.Resources.Save_16px;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save Script";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = false;
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::SLaDE.Properties.Resources.Open_16px;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(32, 32);
            this.btnOpen.Text = "Open";
            this.btnOpen.ToolTipText = "Open Script";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClips
            // 
            this.btnClips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClips.Image = ((System.Drawing.Image)(resources.GetObject("btnClips.Image")));
            this.btnClips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClips.Name = "btnClips";
            this.btnClips.Size = new System.Drawing.Size(71, 33);
            this.btnClips.Text = "Clip Library";
            this.btnClips.Click += new System.EventHandler(this.btnClips_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = false;
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = global::SLaDE.Properties.Resources.Play_16px;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(32, 32);
            this.btnRun.Text = "Run Script";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 33);
            this.lblStatus.Text = "Status: Idle";
            this.lblStatus.ToolTipText = "Current Status";
            // 
            // panConsoleArea
            // 
            this.panConsoleArea.Controls.Add(this.txtOutput);
            this.panConsoleArea.Controls.Add(this.panInput);
            this.panConsoleArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panConsoleArea.Location = new System.Drawing.Point(0, 0);
            this.panConsoleArea.Name = "panConsoleArea";
            this.panConsoleArea.Size = new System.Drawing.Size(528, 164);
            this.panConsoleArea.TabIndex = 11;
            // 
            // panInput
            // 
            this.panInput.Controls.Add(this.lnkClearConsole);
            this.panInput.Controls.Add(this.txtInput);
            this.panInput.Controls.Add(this.btnInput);
            this.panInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panInput.Location = new System.Drawing.Point(0, 137);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(528, 27);
            this.panInput.TabIndex = 2;
            // 
            // lnkClearConsole
            // 
            this.lnkClearConsole.AutoSize = true;
            this.lnkClearConsole.Location = new System.Drawing.Point(3, 5);
            this.lnkClearConsole.Name = "lnkClearConsole";
            this.lnkClearConsole.Size = new System.Drawing.Size(78, 13);
            this.lnkClearConsole.TabIndex = 9;
            this.lnkClearConsole.TabStop = true;
            this.lnkClearConsole.Text = "Clear Console";
            this.lnkClearConsole.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearConsole_LinkClicked);
            // 
            // msMenu
            // 
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.licensingToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(528, 24);
            this.msMenu.TabIndex = 13;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkScriptTaskStatusToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // checkScriptTaskStatusToolStripMenuItem
            // 
            this.checkScriptTaskStatusToolStripMenuItem.Name = "checkScriptTaskStatusToolStripMenuItem";
            this.checkScriptTaskStatusToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.checkScriptTaskStatusToolStripMenuItem.Text = "Check script thread status";
            this.checkScriptTaskStatusToolStripMenuItem.Click += new System.EventHandler(this.checkScriptTaskStatusToolStripMenuItem_Click);
            // 
            // licensingToolStripMenuItem
            // 
            this.licensingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeIconsByIcons8ToolStripMenuItem});
            this.licensingToolStripMenuItem.Name = "licensingToolStripMenuItem";
            this.licensingToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.licensingToolStripMenuItem.Text = "&Licensing";
            // 
            // freeIconsByIcons8ToolStripMenuItem
            // 
            this.freeIconsByIcons8ToolStripMenuItem.Name = "freeIconsByIcons8ToolStripMenuItem";
            this.freeIconsByIcons8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.freeIconsByIcons8ToolStripMenuItem.Text = "Free Icons by Icons8";
            this.freeIconsByIcons8ToolStripMenuItem.Click += new System.EventHandler(this.freeIconsByIcons8ToolStripMenuItem_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.AutoCompleteBrackets = true;
            this.txtEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtEditor.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtEditor.BackBrush = null;
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditor.CharHeight = 15;
            this.txtEditor.CharWidth = 7;
            this.txtEditor.CurrentLineColor = System.Drawing.Color.DarkGray;
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditor.DescriptionFile = "";
            this.txtEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtEditor.IsReplaceMode = false;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEditor.ServiceColors")));
            this.txtEditor.ShowFoldingLines = true;
            this.txtEditor.Size = new System.Drawing.Size(528, 215);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.Zoom = 100;
            // 
            // ssData
            // 
            this.ssData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordinates});
            this.ssData.Location = new System.Drawing.Point(0, 443);
            this.ssData.Name = "ssData";
            this.ssData.Size = new System.Drawing.Size(528, 22);
            this.ssData.TabIndex = 10;
            this.ssData.Text = "statusStrip1";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(61, 17);
            this.lblCoordinates.Text = "0000, 0000";
            // 
            // tmrMouse
            // 
            this.tmrMouse.Enabled = true;
            this.tmrMouse.Interval = 15;
            this.tmrMouse.Tick += new System.EventHandler(this.tmrMouseCoords_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtEditor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panConsoleArea);
            this.splitContainer1.Size = new System.Drawing.Size(528, 383);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 15;
            // 
            // tmrBackup
            // 
            this.tmrBackup.Tick += new System.EventHandler(this.tmrBackup_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 465);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsControls);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.ssData);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMain";
            this.Text = "SLaDE";
            this.tsControls.ResumeLayout(false);
            this.tsControls.PerformLayout();
            this.panConsoleArea.ResumeLayout(false);
            this.panConsoleArea.PerformLayout();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).EndInit();
            this.ssData.ResumeLayout(false);
            this.ssData.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ToolStrip tsControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.Windows.Forms.Panel panConsoleArea;
        private System.Windows.Forms.Panel panInput;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeIconsByIcons8ToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private System.Windows.Forms.LinkLabel lnkClearConsole;
        private System.Windows.Forms.ToolStripButton btnClips;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkScriptTaskStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip ssData;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordinates;
        private System.Windows.Forms.Timer tmrMouse;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Timer tmrBackup;
    }
}
