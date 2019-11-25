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
        protected string _personr;
        protected double _räntesats;
        protected double _belopp;

        public BankKonto(string persnr, double räntesats, double belopp )
        {
            this._personr = persnr;
            this._räntesats = räntesats;
            this._belopp = belopp;
        }


        public override string ToString()
        {
            return this._personr;
        }
    }
}
