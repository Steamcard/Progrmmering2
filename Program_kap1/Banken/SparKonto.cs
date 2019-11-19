using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class SparKonto : BankKonto
    {
        double _uttag;
        double _beraknaranta;

        public SparKonto(double uttag, double beraknaranta) : base(uttag, beraknaranta)
        {
            this._uttag = uttag;
            this._beraknaranta = beraknaranta;
        }
    }
}
