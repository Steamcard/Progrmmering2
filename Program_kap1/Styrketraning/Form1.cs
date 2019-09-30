using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styrketraning
{
    public partial class Form1 : Form
    {
        List<Ovningar> listor = new List<Ovningar>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSpara_Click(object sender, EventArgs e)
        {
            string _ovning = tbxOvning.Text;
            int _rep = int.Parse(tbxRep.Text);
            int _set = int.Parse(tbxSet.Text);
            int _vikt = int.Parse(tbxVikt.Text);
            int _total = _rep * _set * _vikt;

            Ovningar lista1 = new Ovningar(_ovning, _rep, _set, _vikt, _total);
            listor.Add(lista1);
        }

        private void BtnSok_Click(object sender, EventArgs e)
        {
            string ovningSok = tbxSok.Text;

            foreach(Ovningar s in listor)
            {
                if(ovningSok == s.Ovning)
                {
                    lbxSok.Items.Add(s.Total);
                }
            }
        }
    }
}
