using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styrketraning
{
    class Ovningar
    {
        string _ovning;
        int _rep;
        int _set;
        int _vikt;
        int _total;


        public Ovningar(string ovning, int rep, int set, int vikt, int total)
        {
            this._ovning = ovning;
            this._rep = rep;
            this._set = set;
            this._vikt = vikt;
            this._total = total;
            

            MessageBox.Show("Övning sparad");
        }


        public string Ovning
        {
            get
            {
                return this._ovning;
            }
        }

        public int Rep
        {
            get
            {
                return this._rep;
            }
        }

        public int Set
        {
            get
            {
                return this._set;
            }
        }

        public int Vikt
        {
            get
            {
                return this._vikt;
            }
        }

        public int Total
        {
            get
            {
                return this._total;
            }
        }

    }
}
