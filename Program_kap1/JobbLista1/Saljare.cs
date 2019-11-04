using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobbLista1
{
    class Saljare
    {
        string _namn;
        string _provision;
        int _forsaljning;
    }

    public Saljare(string namn, string provision, int forsaljning)
    {
        this._namn = namn;
        this._provision = provision;
        this._forsaljning = forsaljning;
        MessageBox.Show(namn + " är registrerad som säljare");
    }
}
