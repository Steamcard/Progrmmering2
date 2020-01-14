using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog();
            if(r==DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            DialogResult f = folderBrowserDialog1.ShowDialog();
            if(f == DialogResult.OK)
            {
                btnFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            DialogResult c = fontDialog1.ShowDialog();
            if(c == DialogResult.OK)
            {
                btnFont.Font = fontDialog1.Font;
            }
        }
    }
}
