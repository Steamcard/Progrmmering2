using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banken
{
    class BankKonto
    {
        string _personNr;
        double _räntesats;
        double _kredit;


        public BankKonto(string personNr, double räntesats, double kredit)
        {
            this._personNr = personNr;
            this._räntesats = räntesats;
            this._kredit = kredit;
            MessageBox.Show("Kontot har registrerats!");
        }
    }
}
