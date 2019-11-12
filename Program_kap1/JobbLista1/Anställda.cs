using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Anställda
    {
      protected  string _namn;

        public Anställda(string namn)
        {
            this._namn = namn;
        }

        public string Namn
        {
            get
            {
                return this._namn;
            }
        }

        public override string ToString()
        {
            return this._namn;
        }
    }
}
