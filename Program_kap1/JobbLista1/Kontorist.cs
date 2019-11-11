using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Kontorist
    {
        string _namn;
        double _monadslon;

        public Kontorist(string namn, double monadslon)
        {
            this._namn = namn;
            this._monadslon = monadslon;
            MessageBox.Show("Kontoristen är registrerad!");
        }

        public string Namn
        {
            get
            {
                return this._namn + " (Kontorist)";
            }
        }

        public double MonadsLon
        {
            get
            {
                return this._monadslon;
            }
        }

        public override string ToString()
        {
            return this._namn + " (Kontorist): " + this._monadslon;
        }
    }
}
