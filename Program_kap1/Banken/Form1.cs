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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string _personNr = tbxPersonNr.Text;
            double _räntesats = double.Parse(tbxRantesats.Text);
            double _kredit = double.Parse(tbxKredit.Text);

            BankKonto Konto1 = new BankKonto(_personNr, _räntesats, _kredit);

        }

        private void btnInsattning_Click(object sender, EventArgs e)
        {
            double Belopp = double.Parse(tbxBelopp.Text);
        }
    }
}
