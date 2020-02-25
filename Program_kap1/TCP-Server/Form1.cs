using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStarta_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();
            //Väntar på connect i klienten
            klient = lyssnare.AcceptTcpClient();

            byte[] inData = new byte[256];
            // väntar på Send i klienten
            int antalByte = klient.GetStream().Read(inData, 0, inData.Length);

            tbxInkorg.Text = Encoding.Unicode.GetString(inData, 0, antalByte);
            klient.Close();
            lyssnare.Stop();
        }
    }
}
