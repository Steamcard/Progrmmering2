using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTag_Click(object sender, EventArgs e)
        {
            int postnummer = int.Parse(tbxPostnummer.Text);
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(postnummer);
            byte[] inström = client.Receive(ref klientEndPoint);
            tbxMeddelande.Text = Encoding.Unicode.GetString(inström);
        }
    }
}
