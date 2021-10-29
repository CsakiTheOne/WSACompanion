namespace WSACompanion
{
    partial class WSAFileDialog
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Alarms");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("data");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("media");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("obb");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Android", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DCIM");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Documents");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Download");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Movies");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Music");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Notifications");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Pictures");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ringtones");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("sdcard", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ROOT", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.treeFolders = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(347, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(266, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // treeFolders
            // 
            this.treeFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFolders.Location = new System.Drawing.Point(12, 38);
            this.treeFolders.Name = "treeFolders";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Alarms";
            treeNode2.Name = "Node13";
            treeNode2.Text = "data";
            treeNode3.Name = "Node14";
            treeNode3.Text = "media";
            treeNode4.Name = "Node15";
            treeNode4.Text = "obb";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Android";
            treeNode6.Name = "Node5";
            treeNode6.Text = "DCIM";
            treeNode7.Name = "Node6";
            treeNode7.Text = "Documents";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Download";
            treeNode9.Name = "Node8";
            treeNode9.Text = "Movies";
            treeNode10.Name = "Node9";
            treeNode10.Text = "Music";
            treeNode11.Name = "Node10";
            treeNode11.Text = "Notifications";
            treeNode12.Name = "Node11";
            treeNode12.Text = "Pictures";
            treeNode13.Name = "Node12";
            treeNode13.Text = "Ringtones";
            treeNode14.Name = "Node1";
            treeNode14.Text = "sdcard";
            treeNode15.Name = "Node0";
            treeNode15.Text = "ROOT";
            this.treeFolders.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeFolders.Size = new System.Drawing.Size(320, 156);
            this.treeFolders.TabIndex = 1;
            this.treeFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolders_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected path:";
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(94, 12);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(328, 20);
            this.tbPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path end / Filename:";
            // 
            // tbFilename
            // 
            this.tbFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilename.Location = new System.Drawing.Point(124, 200);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(298, 20);
            this.tbFilename.TabIndex = 5;
            this.tbFilename.TextChanged += new System.EventHandler(this.tbFilename_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(338, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 156);
            this.label3.TabIndex = 6;
            this.label3.Text = "This tree view is\r\nnot representing\r\nthe real folder\r\nstructure of your\r\nAndroid " +
    "system.\r\nIt just makes the\r\npath choosing\r\neasier.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WSAFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeFolders);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "WSAFileDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "WSA File Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView treeFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Label label3;
    }
}