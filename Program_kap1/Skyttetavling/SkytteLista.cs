using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyttetavling
{
    class SkytteLista
    {
        string _namn;
        int _poäng;

        public SkytteLista(string namn, int poäng)
        {
            this._namn = namn;
            this._poäng = poäng;
            MessageBox.Show("Resultat registrerad ");

        }

        public string Namn
        {
            get
            {
                return this._namn;
            }
        }

        public int Poäng
        {
            get
            {
                return this._poäng;
            }
        }


        public override string ToString()
        {
            return "Namn: " + this._namn + " Poäng: " + this._poäng;
        }
    }

}
