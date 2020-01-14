using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning3_3
{
    public partial class btnMapp : Form
    {
        public btnMapp()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BackcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult colores = colorDialog1.ShowDialog();
            if(colores == DialogResult.OK)
            {
                btnFarg.BackColor = colorDialog1.Color;
            }
        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult colores = colorDialog2.ShowDialog();
            if(colores == DialogResult.OK)
            {
                btnFarg.ForeColor = colorDialog2.Color;
            }
        }

        private void AllColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult colores = colorDialog3.ShowDialog();
            if(colores == DialogResult.OK)
            {
                btnFarg.BackColor = colorDialog3.Color;
                btnFarg.ForeColor = colorDialog3.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f = folderBrowserDialog1.ShowDialog();
            if (f == DialogResult.OK)
            {
                btnFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnTecken_Click(object sender, EventArgs e)
        {
            DialogResult c = fontDialog1.ShowDialog();
            if (c == DialogResult.OK)
            {
                btnFont.Font = fontDialog1.Font;
            }
        }
    }
}
