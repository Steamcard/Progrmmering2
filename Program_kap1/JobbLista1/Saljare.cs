using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Saljare : Anställda
    {
        string _namn;
        double _provision;
        double _forsaljning;
        double _beraknalon;

        public Saljare(string namn, double provision, double forsaljning, double beraknalon)
        {
            this._namn = namn;
            this._provision = provision;
            this._forsaljning = forsaljning;
            this._beraknalon = beraknalon;
            MessageBox.Show("Säljaren är registrerad!");
        }

        public double Provision
        {
            get
            {
                return this._provision;
            }
        }

        public double Forsaljning
        {
            get
            {
                return this._forsaljning;
            }
        }

        public double BeraknaLon
        {
            get
            {
                return this.BeraknaLon;
            }
        }

        public override string ToString()
        {
            return this._namn + " (Säljare): " + this._beraknalon;
        }
    }
}
