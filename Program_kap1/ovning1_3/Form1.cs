using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Skapa ett fält med pitchurebox-kontroller
            PictureBox[,] bilder = new PictureBox[5,5];

            //position och dimension för första bildrutan
            int x = 0, y = 0, bredd = 50, höjd = 50;

            for (int h = 0; h <= 4; h++)
            {
                for (int z = 0; z <=4; z++)
                {
                    bilder[h, z] = new PictureBox();
                    bilder[h, z].Left = x;
                    bilder[h, z].Top = y;
                    bilder[h, z].Width = bredd;
                    bilder[h, z].Height = höjd;
                    bilder[h, z].BackgroundImage = Image.FromFile("apple.jpg");
                    bilder[h, z].BackgroundImageLayout = ImageLayout.Stretch;


                    this.Controls.Add( bilder[h, z] );
                    x += bredd;
                }

                y += höjd;
                x = bredd - 50;
            }
        }
    }
}
