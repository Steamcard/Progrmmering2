using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tidrapportering
{
    public partial class Form1 : Form
    {

        List<Tidslön> tidslönsLista = new List<Tidslön>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string _kund = tbxKund.Text;
            int _tid = int.Parse(tbxTid.Text);
                       
            Tidslön t = new Tidslön(_kund, _tid);
            tidslönsLista.Add(t);
            lbxReg.Items.Add(t);
        }

        private void BtnAndra_Click(object sender, EventArgs e)
        {
            string gammaltNamn = tbxGamNamn.Text;
            string nyttNamn = tbxNyttNamn.Text;


            foreach(Tidslön s in tidslönsLista)
            {
                if(gammaltNamn == s.Kund)
                {
                    s.Kund = nyttNamn;

                    lbxReg.Items.Clear();

                    //skapa en loop som loppar om listan
                }
            }

        }

        private void BtnBer_Click(object sender, EventArgs e)
        {

        }
    }
}
