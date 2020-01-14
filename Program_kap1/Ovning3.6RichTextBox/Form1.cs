using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovning3._6RichTextBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTecken_Click(object sender, EventArgs e)
        {
            DialogResult c = fontDialog1.ShowDialog();
            if (c == DialogResult.OK)
            {
                rtfText.SelectionFont = fontDialog1.Font;
            }
        }

        private void rbnCenter_CheckedChanged(object sender, EventArgs e)
        {
            rtfText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rbnLeft_CheckedChanged(object sender, EventArgs e)
        {
            rtfText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rbnRight_CheckedChanged(object sender, EventArgs e)
        {
            rtfText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult colores = colorDialog1.ShowDialog();
            if (colores == DialogResult.OK)
            {
                rtfText.SelectionColor = colorDialog1.Color;
                ptbColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
