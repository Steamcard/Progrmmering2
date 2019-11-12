using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Kontorist : Anställda
    {
        double _monadslon;

        public Kontorist(string namn, double monadslon) : base(namn)
        {
            this._monadslon = monadslon;
            MessageBox.Show("Kontoristen är registrerad!");
        }

        public double MonadsLon
        {
            get
            {
                return this._monadslon;
            }
        }

        public string kontorist
        {
            get
            {
                return " (Kontorist)";
            }
        }

        public override string ToString()
        {
            return base._namn + " (Kontorist): " + this._monadslon;
        }
    }
}
