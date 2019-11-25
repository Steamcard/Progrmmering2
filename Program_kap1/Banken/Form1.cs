using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banken
{
    public partial class Form1 : Form
    {

        List<BankKonto> Konto = new List<BankKonto>();
        List<LåneKonto> Lån = new List<LåneKonto>();
        List<SparKonto> Spar = new List<SparKonto>();
        double _kredit;
        double belopp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string _personNr = tbxPersonNr.Text;
            double _räntesats = double.Parse(tbxRantesats.Text);
            try
            {
               _kredit = double.Parse(tbxKredit.Text);
                LåneKonto Lån1 = new LåneKonto(_personNr, _räntesats, _kredit, belopp);
                lbxLista.Items.Add(Lån1);
            }
            catch
            {
                _kredit = 0;
                SparKonto Spar1 = new SparKonto(_personNr, _räntesats, belopp);
                lbxLista.Items.Add(Spar1);
            }

        }

        private void btnInsattning_Click(object sender, EventArgs e)
        {
            double belopp = double.Parse(tbxBelopp.Text);
            //if(lbxLista.SelectedItem == )
            //{
            //    lbxLista.SelectedItems.Add(belopp);
            //}
            //else
            //{

            //}

            //foreach()

        }
    }
}