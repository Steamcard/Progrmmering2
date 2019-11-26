using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banken
{
    class SparKonto : BankKonto
    {



        public SparKonto(string personnr, double räntesats, double belopp) : base(personnr, räntesats, belopp)
        {


            MessageBox.Show("Kontot har registrerats som Sparkonto!");
        }

        public override string ToString()
        {
            return "(Sparkonto) " + this._personr + ": " + this._belopp;
        }
    }
}
