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
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            double _kredit = 0;
            string _personNr = tbxPersonNr.Text;
            double _räntesats = double.Parse(tbxRantesats.Text);
            try
            {
                _kredit = double.Parse(tbxKredit.Text);
                BankKonto Konto1 = new BankKonto(_personNr, _räntesats, _kredit);
                lbxLista.Items.Add(Konto1);
                Konto.Add(Konto1);
            }
            catch
            {
                BankKonto Konto1 = new BankKonto(_personNr, _räntesats, _kredit);
                lbxLista.Items.Add(Konto1);
                Konto.Add(Konto1);
            }



        }

        private void btnInsattning_Click(object sender, EventArgs e)
        {

        }
    }
}