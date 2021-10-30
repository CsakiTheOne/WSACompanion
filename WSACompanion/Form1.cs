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
            menuItemConnect.Text = flowPanel.Enabled ? $"Connected to {Data.IP}" : "Connect to Android with ADB";
            if (flowPanel.Enabled)
            {
                Data.CMD.OnDataReceived += (object sender, DataReceivedEventArgs e) =>
                {
                    Invoke(new Action(() =>
                    {
                        tbLog.AppendText(e.Data + Environment.NewLine);
                    }));
                };
            }
        }

        private void menuItemConnect_Click(object sender, EventArgs e)
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
            ofd.Filter = "APK|*.apk|Any file|*.*";
            if (ofd.ShowDialog() != DialogResult.OK) return;

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
