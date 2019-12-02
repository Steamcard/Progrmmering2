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

        public void Insättning(double instättningsBelopp)
        {
            this._belopp += instättningsBelopp;
        }

        public virtual bool Uttag(double uttagBelopp)
        {
            if (uttagBelopp > this._belopp)
            {
                return false;
            }
            else
            {
                this._belopp -= uttagBelopp;
                return true;
                
            }        
           
        }



        public double Belopp
        {
            get
            {
                return this._belopp;
            }
            set
            {
                this.Belopp = value;
            }
        }

        public override string ToString()
        {
            return this._personr;
        }
    }
}
