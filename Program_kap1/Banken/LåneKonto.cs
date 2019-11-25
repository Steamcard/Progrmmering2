using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banken
{
    class LåneKonto : BankKonto
    {
        double _kredit;

        public LåneKonto(string personnr, double räntesats, double kredit, double belopp) : base(personnr, räntesats, belopp)
        {
            this._kredit = kredit;
            MessageBox.Show("Kontot har registrerats som Lånekonto!");
        }

        public override string ToString()
        {
            return "Lånekonto " + this._personr + " :"+ this._belopp;
        }
    }
}
