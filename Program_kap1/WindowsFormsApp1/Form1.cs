﻿using System;
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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int port = int.Parse(tbxPost.Text);
            byte[] message = Encoding.Unicode.GetBytes(tbxMeddelande.Text);

            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint destiantion = new IPEndPoint(serverIP, port);

            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destiantion);
        }
    }
}
