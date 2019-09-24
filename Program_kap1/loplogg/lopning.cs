using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loplogg
{
    class lopning
    {
        int _sträcka;
        int _tid;
        double _hastighet;

        public lopning(int  sträcka, int tid, double hastighet)
        {
            this._sträcka = sträcka;
            this._tid = tid;
            this._hastighet = hastighet;
            MessageBox.Show("Registreringen lyckades!");
        }

        public int Sträcka
        {
            get
            {
                return this._sträcka;
            }
        }

        public int Tid
        {
            get
            {
                return this._tid;
            }
        }

        public double Hastighet
        {
            get
            {
                return this._hastighet;
            }
        }



        public override string ToString()
        {
            return "Tid: " + this._tid;
        }

        //public override string hastighet()
        //{
        //    return "Hastighet " + this._hastighet;
        //}
    }
}
