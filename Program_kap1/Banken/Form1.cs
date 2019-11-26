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
                Konto.Add(Lån1);
                lbxLista.Items.Add(Lån1);
            }
            catch
            {
                _kredit = 0;
                SparKonto Spar1 = new SparKonto(_personNr, _räntesats, belopp);
                Konto.Add(Spar1);
                lbxLista.Items.Add(Spar1);
            }

        }

        private void btnInsattning_Click(object sender, EventArgs e)
        {
            try
            {
                belopp = double.Parse(tbxBelopp.Text);
                BankKonto b = lbxLista.SelectedItem as BankKonto;
                b.Insättning(belopp);


                lbxLista.Items.Clear();

                foreach(BankKonto x in Konto)
                    {
                        lbxLista.Items.Add(x);
                    }

                
            }
            catch
            {
                MessageBox.Show("Vänligen makera på listan och skriv in rätt belopp!");
            }





        }

        private void btnUttag_Click(object sender, EventArgs e)
        {
            try
            {
                belopp = double.Parse(tbxBelopp.Text);
                BankKonto x = lbxLista.SelectedItem as BankKonto;
                if(x.Uttag(belopp) == true)
                {
                    MessageBox.Show("Uttaget funkar!");
                }
                else
                {
                    MessageBox.Show("Uttaget misslyckades");
                }
            }
            catch
            {
                MessageBox.Show("Vänligen makera på listan och skriv in rätt belopp!");
            }
        }

        private void rbtSpar_CheckedChanged(object sender, EventArgs e)
        {
            tbxKredit.Visible = false;
            lbxKredit.Visible = false;
        }

        private void rbtLon_CheckedChanged(object sender, EventArgs e)
        {
            tbxKredit.Visible = true;
            lbxKredit.Visible = true;
        }
    }
}