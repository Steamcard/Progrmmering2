using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterProgram
{
    class Media
    {
    }

    class Bok : Media
    {
        string _BTitel;
        int _BSidor;

        public Bok (string BTitel, int BSidor)
        {
            this._BTitel = BTitel;
            this._BSidor = BSidor;

            MessageBox.Show("Bok: " + this._BTitel + " har registrerats!");
        }

        public override string ToString()
        {
            return "Bok | " + "Titel: " + this._BTitel + " Sidor: " + this._BSidor;
        }
    }

    class Ljudspår : Media
    {
        string _LTitel;
        double _LSpeltid;

        public Ljudspår(string LTitel, double LSpeltid)
        {
            this._LTitel = LTitel;
            this._LSpeltid = LSpeltid;

            MessageBox.Show("Ljudspår: " + this._LTitel + " har registrerats!");
        }

        public override string ToString()
        {
            return "Ljudspår | "+ "Titel: " + this._LTitel + " Speltid:" + this._LSpeltid;
        }
    }

    class Film : Media
    {
        String _FTitel;
        double _FSpeltid;
        string _FUpplösning;


        public Film(string FTitel, double FSpeltid, string FUpplösning)
        {
            this._FTitel = FTitel;
            this._FSpeltid = FSpeltid;
            this._FUpplösning = FUpplösning;

            MessageBox.Show("Film: " + this._FTitel + " har registrerats!");
        }

        public override string ToString()
        {
            return "Film | "+ "Titel: " + this._FTitel + " Speltid: " + this._FSpeltid + " Upplösning: " + this._FUpplösning;
        }
    }
}
