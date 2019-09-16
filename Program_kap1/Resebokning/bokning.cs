using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokning
{
    class Bokning
    {
        //Medelm

        string namn = "";
        string destination = "";
        int antalDagar = 0;
    }

    private Resa(string n, string d, int a)
    {
        this.namn = n;
        this.destination = d;
        this.antalDagar = a;
    }

    private void ResaUtdata(string n, string d, int a)
    {
        return n + " " + d + " " + a + " dagar";
    }
}
