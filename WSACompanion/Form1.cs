using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSACompanion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowConnectDialog()
        {
            flowPanel.Enabled = new ADBConnectDialog().ShowDialog() == DialogResult.OK;
            if (flowPanel.Enabled)
            {
                MessageBox.Show("Ready");
                Data.CMD.OnDataReceived += (object sender, DataReceivedEventArgs e) =>
                {
                    if (e.Data == null || e.Data.StartsWith("PS")) return;
                    Invoke(new Action(() =>
                    {
                        tbLog.AppendText(e.Data + Environment.NewLine);
                    }));
                };
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ShowConnectDialog();
        }

        private void linkADB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gist.github.com/Pulimet/5013acf2cd5b28e55036c82c91bd56d8");
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            Data.CMD.Execute($"{Data.ADBPath} {tbCommand.Text}");
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (cbInstallKeepData.Checked)
                Data.CMD.Execute($"{Data.ADBPath} install -r \"{ofd.FileName}\"");
            else
                Data.CMD.Execute($"{Data.ADBPath} install \"{ofd.FileName}\"");
        }

        private void btnFilePush_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            WSAFileDialog wfd = new WSAFileDialog();
            if (wfd.ShowDialog() != DialogResult.OK) return;

            Data.CMD.Execute($"{Data.ADBPath} push \"{ofd.FileName}\" \"{wfd.Path}\"");
        }

        private void btnFilePull_Click(object sender, EventArgs e)
        {
            WSAFileDialog wfd = new WSAFileDialog();
            if (wfd.ShowDialog() != DialogResult.OK) return;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;

            Data.CMD.Execute($"{Data.ADBPath} pull \"{wfd.Path}\" \"{sfd.FileName}\"");
        }
    }
}
