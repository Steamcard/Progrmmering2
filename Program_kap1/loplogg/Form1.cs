using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loplogg
{
    public partial class Form1 : Form
    {
        List<lopning> sokDistans = new List<lopning>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            int _sträcka = int.Parse(tbxSträcka.Text);
            int _tid = int.Parse(tbxTid.Text);
            double _hastighet = (double)_sträcka/((double)_tid/60);
            lopning sokDistans1 = new lopning(_sträcka, _tid, _hastighet);

            sokDistans.Add(sokDistans1);

            tbxSträcka.Clear();
            tbxTid.Clear();
        }

        private void BtnTider_Click(object sender, EventArgs e)
        {
            lbxReg.Items.Clear();
            int sokSträcka = int.Parse(tbxSokKm.Text);

            foreach(lopning sok in sokDistans)
            {
                if(sokSträcka == sok.Sträcka)
                {
                    lbxReg.Items.Add(sok);
                }
            }

        }

        private void BtnHastig_Click(object sender, EventArgs e)
        {
            lbxReg.Items.Clear();
            
            int sokSträcka = int.Parse(tbxSokKm.Text);

            foreach (lopning sok in sokDistans)
            {
                if (sokSträcka == sok.Sträcka)
                {
                    lbxReg.Items.Add(sok.Hastighet + " km/h");
                }
            }

            tbxSokKm.Clear();
        }
    }
}
