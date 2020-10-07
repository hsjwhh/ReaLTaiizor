﻿using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;

namespace ReaLTaiizor.UI
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            mnuMain = new ReaLTaiizor.Controls.CrownMenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            mnuView = new System.Windows.Forms.ToolStripMenuItem();
            mnuDialog = new System.Windows.Forms.ToolStripMenuItem();
            mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            checkableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkableWithIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            checkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkedWithIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            mnuProperties = new System.Windows.Forms.ToolStripMenuItem();
            mnuConsole = new System.Windows.Forms.ToolStripMenuItem();
            mnuLayers = new System.Windows.Forms.ToolStripMenuItem();
            mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            toolMain = new ReaLTaiizor.Controls.CrownToolStrip();
            btnNewFile = new System.Windows.Forms.ToolStripButton();
            stripMain = new ReaLTaiizor.Controls.CrownStatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            DockPanel = new ReaLTaiizor.Docking.Crown.DockPanel();
            CrownSeparator1 = new ReaLTaiizor.Controls.CrownSeparator();
            mnuMain.SuspendLayout();
            toolMain.SuspendLayout();
            stripMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            mnuMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuFile,
            mnuView,
            mnuTools,
            mnuWindow,
            mnuHelp});
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            mnuMain.Size = new System.Drawing.Size(944, 24);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "CrownMenuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuNewFile,
            toolStripSeparator1,
            mnuClose});
            mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuNewFile
            // 
            mnuNewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuNewFile.Image = global::ReaLTaiizor.UI.Properties.Resources.NewFile_6276;
            mnuNewFile.Name = "mnuNewFile";
            mnuNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            mnuNewFile.Size = new System.Drawing.Size(160, 22);
            mnuNewFile.Text = "&New file";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuClose
            // 
            mnuClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuClose.Image = global::ReaLTaiizor.UI.Properties.Resources.Close_16xLG;
            mnuClose.Name = "mnuClose";
            mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            mnuClose.Size = new System.Drawing.Size(160, 22);
            mnuClose.Text = "&Close";
            // 
            // mnuView
            // 
            mnuView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuDialog});
            mnuView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuView.Name = "mnuView";
            mnuView.Size = new System.Drawing.Size(44, 20);
            mnuView.Text = "&View";
            // 
            // mnuDialog
            // 
            mnuDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuDialog.Image = global::ReaLTaiizor.UI.Properties.Resources.properties_16xLG;
            mnuDialog.Name = "mnuDialog";
            mnuDialog.Size = new System.Drawing.Size(130, 22);
            mnuDialog.Text = "&Dialog test";
            // 
            // mnuTools
            // 
            mnuTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            checkableToolStripMenuItem,
            checkableWithIconToolStripMenuItem,
            toolStripSeparator2,
            checkedToolStripMenuItem,
            checkedWithIconToolStripMenuItem});
            mnuTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new System.Drawing.Size(46, 20);
            mnuTools.Text = "&Tools";
            // 
            // checkableToolStripMenuItem
            // 
            checkableToolStripMenuItem.CheckOnClick = true;
            checkableToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            checkableToolStripMenuItem.Name = "checkableToolStripMenuItem";
            checkableToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            checkableToolStripMenuItem.Text = "Checkable";
            // 
            // checkableWithIconToolStripMenuItem
            // 
            checkableWithIconToolStripMenuItem.CheckOnClick = true;
            checkableWithIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            checkableWithIconToolStripMenuItem.Image = global::ReaLTaiizor.UI.Properties.Resources.properties_16xLG;
            checkableWithIconToolStripMenuItem.Name = "checkableWithIconToolStripMenuItem";
            checkableWithIconToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            checkableWithIconToolStripMenuItem.Text = "Checkable with icon";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // checkedToolStripMenuItem
            // 
            checkedToolStripMenuItem.Checked = true;
            checkedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            checkedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            checkedToolStripMenuItem.Name = "checkedToolStripMenuItem";
            checkedToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            checkedToolStripMenuItem.Text = "Checked";
            // 
            // checkedWithIconToolStripMenuItem
            // 
            checkedWithIconToolStripMenuItem.Checked = true;
            checkedWithIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            checkedWithIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            checkedWithIconToolStripMenuItem.Image = global::ReaLTaiizor.UI.Properties.Resources.properties_16xLG;
            checkedWithIconToolStripMenuItem.Name = "checkedWithIconToolStripMenuItem";
            checkedWithIconToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            checkedWithIconToolStripMenuItem.Text = "Checked with icon";
            // 
            // mnuWindow
            // 
            mnuWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuProject,
            mnuProperties,
            mnuConsole,
            mnuLayers,
            mnuHistory});
            mnuWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new System.Drawing.Size(63, 20);
            mnuWindow.Text = "&Window";
            // 
            // mnuProject
            // 
            mnuProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuProject.Image = global::ReaLTaiizor.UI.Properties.Resources.application_16x;
            mnuProject.Name = "mnuProject";
            mnuProject.Size = new System.Drawing.Size(157, 22);
            mnuProject.Text = "&Project Explorer";
            // 
            // mnuProperties
            // 
            mnuProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuProperties.Image = global::ReaLTaiizor.UI.Properties.Resources.properties_16xLG;
            mnuProperties.Name = "mnuProperties";
            mnuProperties.Size = new System.Drawing.Size(157, 22);
            mnuProperties.Text = "P&roperties";
            // 
            // mnuConsole
            // 
            mnuConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuConsole.Image = global::ReaLTaiizor.UI.Properties.Resources.Console;
            mnuConsole.Name = "mnuConsole";
            mnuConsole.Size = new System.Drawing.Size(157, 22);
            mnuConsole.Text = "&Console";
            // 
            // mnuLayers
            // 
            mnuLayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuLayers.Image = global::ReaLTaiizor.UI.Properties.Resources.Collection_16xLG;
            mnuLayers.Name = "mnuLayers";
            mnuLayers.Size = new System.Drawing.Size(157, 22);
            mnuLayers.Text = "&Layers";
            // 
            // mnuHistory
            // 
            mnuHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuHistory.Image = ((System.Drawing.Image)(resources.GetObject("mnuHistory.Image")));
            mnuHistory.Name = "mnuHistory";
            mnuHistory.Size = new System.Drawing.Size(157, 22);
            mnuHistory.Text = "&History";
            // 
            // mnuHelp
            // 
            mnuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuAbout});
            mnuHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new System.Drawing.Size(44, 20);
            mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            mnuAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            mnuAbout.Image = global::ReaLTaiizor.UI.Properties.Resources.StatusAnnotations_Information_16xLG_color;
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new System.Drawing.Size(145, 22);
            mnuAbout.Text = "&About Crown";
            // 
            // toolMain
            // 
            toolMain.AutoSize = false;
            toolMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            toolMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            toolMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            btnNewFile});
            toolMain.Location = new System.Drawing.Point(0, 26);
            toolMain.Name = "toolMain";
            toolMain.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            toolMain.Size = new System.Drawing.Size(944, 28);
            toolMain.TabIndex = 1;
            toolMain.Text = "CrownToolStrip1";
            // 
            // btnNewFile
            // 
            btnNewFile.AutoSize = false;
            btnNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnNewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            btnNewFile.Image = global::ReaLTaiizor.UI.Properties.Resources.NewFile_6276;
            btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new System.Drawing.Size(24, 24);
            btnNewFile.Text = "New file";
            // 
            // stripMain
            // 
            stripMain.AutoSize = false;
            stripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            stripMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            stripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1,
            toolStripStatusLabel6,
            toolStripStatusLabel5});
            stripMain.Location = new System.Drawing.Point(0, 618);
            stripMain.Name = "stripMain";
            stripMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            stripMain.Size = new System.Drawing.Size(944, 24);
            stripMain.SizingGrip = false;
            stripMain.TabIndex = 2;
            stripMain.Text = "CrownStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 50, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(39, 16);
            toolStripStatusLabel1.Text = "Ready";
            toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(0, 0, 50, 2);
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new System.Drawing.Size(757, 14);
            toolStripStatusLabel6.Spring = true;
            toolStripStatusLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new System.Drawing.Size(46, 16);
            toolStripStatusLabel5.Text = "120 MB";
            toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DockPanel
            // 
            DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DockPanel.Location = new System.Drawing.Point(0, 54);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new System.Drawing.Size(944, 564);
            DockPanel.TabIndex = 3;
            // 
            // CrownSeparator1
            // 
            CrownSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            CrownSeparator1.Location = new System.Drawing.Point(0, 24);
            CrownSeparator1.Name = "CrownSeparator1";
            CrownSeparator1.Size = new System.Drawing.Size(944, 2);
            CrownSeparator1.TabIndex = 4;
            CrownSeparator1.Text = "CrownSeparator1";
            // 
            // Form21
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(944, 642);
            Controls.Add(DockPanel);
            Controls.Add(stripMain);
            Controls.Add(toolMain);
            Controls.Add(CrownSeparator1);
            Controls.Add(mnuMain);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MainMenuStrip = mnuMain;
            MinimumSize = new System.Drawing.Size(640, 480);
            Name = "Form21";
            Text = "Crown Theme";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            stripMain.ResumeLayout(false);
            stripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private CrownMenuStrip mnuMain;
        private CrownToolStrip toolMain;
        private CrownStatusStrip stripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DockPanel DockPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuConsole;
        private System.Windows.Forms.ToolStripMenuItem mnuLayers;
        private System.Windows.Forms.ToolStripMenuItem mnuHistory;
        private CrownSeparator CrownSeparator1;
        private System.Windows.Forms.ToolStripMenuItem checkableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkableWithIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedWithIconToolStripMenuItem;
    }
}

