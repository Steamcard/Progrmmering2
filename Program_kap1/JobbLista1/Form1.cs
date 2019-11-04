using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    public partial class Form1 : Form
    {
        List<Anställda> AnställdaLista = new List<Anställda>();
        List<Saljare> SaljareLista = new List<Saljare>();
        List<Konsult> KonsultLista = new List<Konsult>();
        List<Kontorist> KontoristLista = new List<Kontorist>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaljareReg_Click(object sender, EventArgs e)
        {
            string _namn = tbxSaljareNamn.Text;
            string _provision = tbxProvision.Text;
            int _forsaljning = int.Parse(tbxForsaljning.Text);

            Saljare SaljareLista1 = new Saljare(_namn, _provision, _forsaljning);
            SaljareLista.Add(SaljareLista1);

        }
    }
}
