namespace WSACompanion
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbInstallKeepData = new System.Windows.Forms.CheckBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilePull = new System.Windows.Forms.Button();
            this.btnFilePush = new System.Windows.Forms.Button();
            this.linkADB = new System.Windows.Forms.LinkLabel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lblInstallDrop = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInstallDrop);
            this.groupBox1.Controls.Add(this.cbInstallKeepData);
            this.groupBox1.Controls.Add(this.btnInstall);
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Install app";
            // 
            // cbInstallKeepData
            // 
            this.cbInstallKeepData.AutoSize = true;
            this.cbInstallKeepData.Location = new System.Drawing.Point(6, 23);
            this.cbInstallKeepData.Name = "cbInstallKeepData";
            this.cbInstallKeepData.Size = new System.Drawing.Size(192, 17);
            this.cbInstallKeepData.TabIndex = 1;
            this.cbInstallKeepData.Text = "Keep data if app is already installed";
            this.cbInstallKeepData.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.Location = new System.Drawing.Point(6, 48);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(188, 23);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Choose APK and install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilePull);
            this.groupBox2.Controls.Add(this.btnFilePush);
            this.groupBox2.Location = new System.Drawing.Point(209, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer files (not working yet)";
            // 
            // btnFilePull
            // 
            this.btnFilePull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilePull.Location = new System.Drawing.Point(6, 48);
            this.btnFilePull.Name = "btnFilePull";
            this.btnFilePull.Size = new System.Drawing.Size(188, 23);
            this.btnFilePull.TabIndex = 1;
            this.btnFilePull.Text = "Pull file from device";
            this.btnFilePull.UseVisualStyleBackColor = true;
            this.btnFilePull.Click += new System.EventHandler(this.btnFilePull_Click);
            // 
            // btnFilePush
            // 
            this.btnFilePush.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilePush.Location = new System.Drawing.Point(6, 19);
            this.btnFilePush.Name = "btnFilePush";
            this.btnFilePush.Size = new System.Drawing.Size(188, 23);
            this.btnFilePush.TabIndex = 0;
            this.btnFilePush.Text = "Choose file and push to device";
            this.btnFilePush.UseVisualStyleBackColor = true;
            this.btnFilePush.Click += new System.EventHandler(this.btnFilePush_Click);
            // 
            // linkADB
            // 
            this.linkADB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkADB.AutoSize = true;
            this.linkADB.Location = new System.Drawing.Point(6, 50);
            this.linkADB.Name = "linkADB";
            this.linkADB.Size = new System.Drawing.Size(105, 13);
            this.linkADB.TabIndex = 3;
            this.linkADB.TabStop = true;
            this.linkADB.Text = "See ADB commands";
            this.linkADB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkADB_LinkClicked);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Controls.Add(this.groupBox4);
            this.flowPanel.Controls.Add(this.groupBox1);
            this.flowPanel.Controls.Add(this.groupBox2);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Enabled = false;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(484, 200);
            this.flowPanel.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCommand);
            this.groupBox4.Controls.Add(this.tbCommand);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.linkADB);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Execute ADB command";
            // 
            // btnCommand
            // 
            this.btnCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommand.Location = new System.Drawing.Point(325, 45);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(75, 23);
            this.btnCommand.TabIndex = 2;
            this.btnCommand.Text = "Run";
            this.btnCommand.UseVisualStyleBackColor = true;
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommand.Location = new System.Drawing.Point(45, 19);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(355, 20);
            this.tbCommand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ".\\adb";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(3, 16);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(478, 114);
            this.tbLog.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConnect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemConnect
            // 
            this.menuItemConnect.Name = "menuItemConnect";
            this.menuItemConnect.Size = new System.Drawing.Size(176, 20);
            this.menuItemConnect.Text = "Connect to Android with ADB";
            this.menuItemConnect.Click += new System.EventHandler(this.menuItemConnect_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flowPanel);
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer.Panel2MinSize = 20;
            this.splitContainer.Size = new System.Drawing.Size(484, 337);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 6;
            // 
            // lblInstallDrop
            // 
            this.lblInstallDrop.AllowDrop = true;
            this.lblInstallDrop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblInstallDrop.Location = new System.Drawing.Point(6, 74);
            this.lblInstallDrop.Name = "lblInstallDrop";
            this.lblInstallDrop.Size = new System.Drawing.Size(188, 33);
            this.lblInstallDrop.TabIndex = 2;
            this.lblInstallDrop.Text = "Drop here an APK to install";
            this.lblInstallDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInstallDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblInstallDrop_DragDrop);
            this.lblInstallDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblInstallDrop_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WSA Companion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnFilePull;
        private System.Windows.Forms.Button btnFilePush;
        private System.Windows.Forms.LinkLabel linkADB;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbInstallKeepData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemConnect;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblInstallDrop;
    }
}

