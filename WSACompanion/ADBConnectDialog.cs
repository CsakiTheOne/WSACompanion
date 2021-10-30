using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSACompanion
{
    public partial class ADBConnectDialog : Form
    {
        public ADBConnectDialog()
        {
            InitializeComponent();

            toolTip.SetToolTip(btnADB, Data.ADBPath);

            Data.CMD = new CMDSession();
            Data.CMD.OnDataReceived += CMD_OnDataReceived;
            Data.CMD.Start();
        }

        private void btnADB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ADB|adb.exe|Any file|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Data.ADBPath = ofd.FileName;
                toolTip.SetToolTip(btnADB, Data.ADBPath);
            }
        }

        private void tbIP_TextChanged(object sender, EventArgs e)
        {
            Data.IP = tbIP.Text;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Data.CMD.Execute($"{Data.ADBPath} connect {Data.IP}");
        }

        private void CMD_OnDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            Invoke(new Action(() => {
                if (e.Data.Length > 1)
                {
                    tbLog.AppendText(e.Data + Environment.NewLine);
                    tbLog.Select(tbLog.TextLength - 2, 1);
                }
                btnOk.Enabled = e.Data.Contains("connected to");
            }));
        }

        private void ADBConnectDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.CMD.OnDataReceived -= CMD_OnDataReceived;
        }
    }
}
