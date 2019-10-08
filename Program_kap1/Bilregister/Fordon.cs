using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilregister
{
    class Fordon
    {
        string _regnr;
        string _marke;
        string _modell;
        string _typ;


        public Fordon(string regnr, string marke, string modell, string typ)
        {
            this._regnr = regnr;
            
            for(int i=0; i<6; i++)
            {
                
            }
            this._marke = marke;
            this._modell = modell;
            this._typ = typ;

            if(typ == "bil")
            {
                MessageBox.Show("Bilen är registrerad");
            }
            else
            {
                MessageBox.Show("MC är registrerad");
            }
            
        }


        public string Regnr
        {
            get
            {
                return this._regnr;
            }
        }
         public string Marke
        {
            get
            {
                return this._marke;
            }
        }
        public string Modell
        {
            get
            {
                return this._modell;
            }
        }
        public string Typ
        {
            get
            {
                return this._typ;
            }
        }


        public override string ToString()
        {
            return this._typ + ": Model: " + this._modell + " Märke: " + this._marke + " Reg-nr: " + this._regnr;
        }
    }
}
