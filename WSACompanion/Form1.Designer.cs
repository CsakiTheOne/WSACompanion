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
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilePull = new System.Windows.Forms.Button();
            this.btnFilePush = new System.Windows.Forms.Button();
            this.linkADB = new System.Windows.Forms.LinkLabel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnCommand = new System.Windows.Forms.Button();
            this.cbInstallKeepData = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to device with ADB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInstallKeepData);
            this.groupBox1.Controls.Add(this.btnInstall);
            this.groupBox1.Location = new System.Drawing.Point(3, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Install app";
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
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Controls.Add(this.groupBox4);
            this.flowPanel.Controls.Add(this.groupBox1);
            this.flowPanel.Controls.Add(this.groupBox2);
            this.flowPanel.Enabled = false;
            this.flowPanel.Location = new System.Drawing.Point(12, 41);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(460, 194);
            this.flowPanel.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 120);
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
            this.tbLog.Size = new System.Drawing.Size(478, 101);
            this.tbLog.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ".\\adb";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "WSA Companion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
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
    }
}

