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
            double _provision = double.Parse(tbxProvision.Text);
            double _forsaljning = double.Parse(tbxForsaljning.Text);
            double _beraknalon = _provision * _forsaljning;

            Saljare SaljareLista1 = new Saljare(_namn, _provision, _forsaljning, _beraknalon);
            SaljareLista.Add(SaljareLista1);
            lbxRegister.Items.Add(_namn + SaljareLista1.saljare);

        }

        private void btnKonsultReg_Click(object sender, EventArgs e)
        {
            string _namn = tbxKonsultNamn.Text;
            double _timlon = double.Parse(tbxTimlon.Text);
            double _arbetadTid = double.Parse(tbxArbetadTid.Text);
            double _beraknalon = _timlon * _arbetadTid;

            Konsult KonsultLista1 = new Konsult(_namn, _timlon, _arbetadTid, _beraknalon);
            KonsultLista.Add(KonsultLista1);
            lbxRegister.Items.Add(_namn + KonsultLista1.konsult);
        }

        private void btnKontoristReg_Click(object sender, EventArgs e)
        {
            string _namn = tbxKontoristNamn.Text;
            double _monadslon = double.Parse(tbxManadLon.Text);

            Kontorist KontoristLista1 = new Kontorist(_namn, _monadslon);
            KontoristLista.Add(KontoristLista1);
            lbxRegister.Items.Add(_namn + KontoristLista1.kontorist);
        }

        private void btnBeraknaLon_Click(object sender, EventArgs e)
        {
            try
            {
                lbxLoner.Items.Clear();

                foreach (Saljare a in SaljareLista)
                {
                    lbxLoner.Items.Add(a.ToString());
                }

                foreach (Konsult a in KonsultLista)
                {
                    lbxLoner.Items.Add(a.ToString());
                }

                foreach (Kontorist a in KontoristLista)
                {
                    lbxLoner.Items.Add(a.ToString());
                }
            }
            catch
            {
                lbxLoner.Items.Add("error");
            }

            try
            {
                double totalt = 0;
                foreach (Saljare a in SaljareLista)
                {
                    totalt = totalt + a.BeraknaLon;
                }
                foreach (Konsult a in KonsultLista)
                {
                    totalt = totalt + a.BeraknaLon;
                }
                foreach (Kontorist a in KontoristLista)
                {
                    totalt = totalt + a.MonadsLon;
                }

                lbxTotLon.Items.Add(totalt);
            }
            catch
            {
                MessageBox.Show("Error med Total lön");
            }
        }
    }
}
