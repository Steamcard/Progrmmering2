using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tidrapportering
{
    class Tidslön
    {
        string _kund;
        int _tid;



        public Tidslön(string kund, int tid)
        {
            this._kund = kund;
            this._tid = tid;


            MessageBox.Show("Kunden har registrerats");
        }


        public string Kund
        {
            get
            {
                return this._kund;
            }

            set
            {
                this._kund = value;
            }
        }

        public int Tid
        {
            get
            {
                return this._tid;
            }
        }




        public override string ToString()
        {
            return this._kund + ": " + this._tid;
        }
    }
}
