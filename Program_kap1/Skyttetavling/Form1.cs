using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyttetavling
{
    public partial class Form1 : Form
    {
        List<SkytteLista> listor = new List<SkytteLista>();
       public Form1()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string _namn = tbxNamn.Text;
            int _poäng = int.Parse(tbxPoäng.Text);
            if(_poäng>50 || _poäng<0)
            {
                MessageBox.Show("Du får bara registrera mellan 0-50 i poäng");
            }
            else
            {
                SkytteLista list1 = new SkytteLista(_namn, _poäng);
                listor.Add(list1);
                lbxReg.Items.Add(list1);

            }
            
        }

        private void BtnVisa_Click(object sender, EventArgs e)
        {
            int sokPoäng = int.Parse(tbxSok.Text);
            lbxReg.Items.Clear();

            foreach (SkytteLista s in listor)
            {
                if (sokPoäng == s.Poäng)
                {
                    lbxReg.Items.Add(s);
                }
            }

        }
    }
}
