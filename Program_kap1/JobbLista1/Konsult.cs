using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Konsult
    {
        string _namn;
        double _timlon;
        double _aretadtid;
        double _beraknalon;

        public Konsult(string namn, double timlon, double arbetadtid, double beraknalon)
        {
            this._namn = namn;
            this._timlon = timlon;
            this._aretadtid = arbetadtid;
            this._beraknalon = beraknalon;
            MessageBox.Show("Konsulten är registrerad!");
        }

        public string Namn
        {
            get
            {
                return this._namn + " (Konsult)";
            }
        }

        public double TimLon
        {
            get
            {
                return this._timlon;
            }
        }

        public double ArbetadTid
        {
            get
            {
                return this._aretadtid;
            }
        }

        public double BeraknaLon
        {
            get
            {
                return this._beraknalon;
            }
        }

        public override string ToString()
        {
            return this._namn + " (Konsult): " + this._beraknalon;
        }
    }
}
