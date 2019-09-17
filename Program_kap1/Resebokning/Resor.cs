using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokning
{
    class Resor
    {

        //Variabler
        public string kund;
        public string destination;
        public int dagar;


        //konsturktor
        public Resor(string k, string de, int d)
        {
            this.kund = k;
            this.destination = de;
            this.dagar = d;
        }

        public string Kund
        {
            get
            {
                return this.kund;
            }
        }

        public string Destination
        {
            get
            {
                return this.destination;
            }
        }

        public string Dagar
        {
            get
            {
                return this.dagar.ToString();
            }
        }



        public override string ToString()
        {
            return destination + ": " + dagar + " antal dagar"; 
        }
    }
}
