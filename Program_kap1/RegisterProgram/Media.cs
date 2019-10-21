using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProgram
{
    class Media
    {
        string _BTitel;
        int _BSidor;

        string _LTitel;
        string _LSpeltid;

        String _FTitel;
        int _FSpeltid;
        string _FUpplösning;

        public BokRegister(string BTitel, int BSidor)
        {
            this._BTitel = BTitel;
            this._BSidor = BSidor;
        }

        public LjudspårRegister (string LTitel, String LSpeltid)
        {
            this._LTitel = LTitel;
            this._LSpeltid = LSpeltid;
        }

        public FilmRegister(string FTitel, int FSpeltid, string FUpplösning)
        {
            this._FTitel = FTitel;
            this._FSpeltid = FSpeltid;
            this._FUpplösning = FUpplösning;
        }
    }
}
