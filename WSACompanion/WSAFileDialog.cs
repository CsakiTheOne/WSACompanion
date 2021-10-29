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
    public partial class WSAFileDialog : Form
    {
        public string Path { get => tbPath.Text; set => tbPath.Text = value; }

        public WSAFileDialog()
        {
            InitializeComponent();
        }

        private void treeFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeFolders.SelectedNode == null)
            {
                tbPath.Text = "\\" + tbFilename.Text;
            }
            else
            {
                tbPath.Text = treeFolders.SelectedNode.FullPath.Remove(0, 4) + "\\" + tbFilename.Text;
            }
        }

        private void tbFilename_TextChanged(object sender, EventArgs e)
        {
            if (treeFolders.SelectedNode == null)
            {
                tbPath.Text = "\\" + tbFilename.Text;
            }
            else
            {
                tbPath.Text = treeFolders.SelectedNode.FullPath.Remove(0, 4) + "\\" + tbFilename.Text;
            }
        }
    }
}
