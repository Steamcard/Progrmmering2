using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bataljonen_3._8
{
    public partial class Form1 : Form
    {
        const int BATALJON = 0, KOMPANI = 1, PLUTON = 2, GRUPP = 3;

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode valdNod = treeView1.SelectedNode;
            tbxVald.AppendText(valdNod.Name);
            tbxOutput.Text = info[valdNod.Level];
            tbxOutput.AppendText("\r\nNamn: " + valdNod.Text);

            if(valdNod.Level == GRUPP)
            {
                grbNyEnhet.Enabled = false;
            }
            else
            {
                grbNyEnhet.Enabled = true;
            }

            if(valdNod.Level == PLUTON)
            {
                tbxSoldater.Enabled = true;
            }
            else
            {
                tbxSoldater.Enabled = false;
            }
        }

        private void BtnTabort_Click(object sender, EventArgs e)
        {
            TreeNode valdNod = treeView1.SelectedNode;
            treeView1.Nodes.Remove(valdNod);
        }

        private void BtnNyEnhet_Click(object sender, EventArgs e)
        {
            TreeNode valdNod = treeView1.SelectedNode;
            if(valdNod != null)
            {
                TreeNode nyNod = new TreeNode(tbxNamn.Text);
                valdNod.Nodes.Add(nyNod);
                if (nyNod.Level == GRUPP) nyNod.Tag = int.Parse(tbxSoldater.Text);
            }
        }

        private string[] info = { "Bataljon", "Kompani", "Pluton", "Grupp" };
        public Form1()
        {
            InitializeComponent();
            treeView1.SelectedNode = treeView1.Nodes[0];
        }
    }
}
