using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Konsult : Anställda
    {
        double _timlon;
        double _aretadtid;
        double _beraknalon;

        public Konsult(string namn, double timlon, double arbetadtid, double beraknalon) : base(namn)
        {
            this._timlon = timlon;
            this._aretadtid = arbetadtid;
            this._beraknalon = beraknalon;
            MessageBox.Show("Konsulten är registrerad!");
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

        public string konsult
        {
            get
            {
                return " (Konsult)";
            }
        }

        public override string ToString()
        {
            return base._namn + " (Konsult): " + this._beraknalon;
        }
    }
}
