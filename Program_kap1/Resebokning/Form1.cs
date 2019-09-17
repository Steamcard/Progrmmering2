using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resebokning
{
    public partial class Form1 : Form
    {

        Resor[] resa = new Resor[1000];
        int antalResor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Indata
            string kund = tbxKund.Text;
            string destination = tbxDestination.Text;
            int dagar = int.Parse(tbxDagar.Text);


            //Utdata
            Resor resaSegment = new Resor(kund, destination, dagar);
            resa[antalResor++] = resaSegment;

            MessageBox.Show("Resan är bokad", "klart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            tbxDagar.Clear();
            tbxDestination.Clear();
            tbxKund.Clear();
        }

        private void BtnSok_Click(object sender, EventArgs e)
        {

            lbxSvar.Items.Clear();

            //indata
            string sokNamn = tbxSokNamn.Text;


            //utdata
            for (int i = 0; i < antalResor; i++)
            {
                if (sokNamn == resa[i].Kund)
                {
                    lbxSvar.Items.Add(resa[i]);
                }
            }
        }
    }
}
