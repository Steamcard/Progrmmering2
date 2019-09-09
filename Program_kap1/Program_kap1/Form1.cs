using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_kap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKör_Click(object sender, EventArgs e)
        {
            FontStyle stil = FontStyle.Regular; // Inga flaggor satta

            //sätt fetstil-flagga
            if (cbxFet.Checked) stil = stil | FontStyle.Bold;

            //sätt krusiv-flagga
            if (cbxKursiv.Checked) stil = stil | FontStyle.Italic;

            //sätt Understrucket-flagga
            if (cbxUnder.Checked) stil = stil | FontStyle.Underline;

            //Font font = new Font (tbxTecken.Text,, tbxTyp.Text, stil);
            string teckensnitt = tbxTyp.Text;
            float storlek = float.Parse(tbxTecken.Text);
            Font font = new Font(teckensnitt, storlek, stil);

            tbxReg.Font = font;
        }
    }
}
