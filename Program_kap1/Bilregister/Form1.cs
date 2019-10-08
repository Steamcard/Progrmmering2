using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilregister
{
    public partial class Form1 : Form
    {

        List<Fordon> FordonRegister = new List<Fordon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CbxTyp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string regnr = tbxRegNr.Text;
            string marke = tbxMarke.Text;
            string modell = tbxModell.Text;
            string typ = cbxTyp.Text;
            Fordon lista = new Fordon(regnr, marke, modell, typ);
            FordonRegister.Add(lista);
            lbxReg.Items.Add(lista);
        }

        private void RbtnBilar_CheckedChanged(object sender, EventArgs e)
        {
            lbxReg.Items.Clear();

            foreach(Fordon s in FordonRegister)
            {
                if(s.Typ == "Bil")
                {
                    lbxReg.Items.Add(s);
                }
            }
        }

        private void RbtnAlla_CheckedChanged(object sender, EventArgs e)
        {
            lbxReg.Items.Clear();

            foreach(Fordon s in FordonRegister)
            {
                lbxReg.Items.Add(s);
            }
        }

        private void RbtnMC_CheckedChanged(object sender, EventArgs e)
        {
            lbxReg.Items.Clear();

            foreach(Fordon s in FordonRegister)
            {
                if(s.Typ == "MC")
                {
                    lbxReg.Items.Add(s);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
