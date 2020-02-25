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

namespace TCP_Klient
{
    public partial class Form1 : Form
    {

        TcpClient klient;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(tbxPort.Text);
            klient = new TcpClient();
            klient.NoDelay = true;
            klient.Connect(adress, port);

            if(klient.Connected)
            {
                byte[] utData = Encoding.Unicode.GetBytes("Hej!");
                klient.GetStream().Write(utData, 0, utData.Length);
                klient.Close();
            }
        }
    }
}
