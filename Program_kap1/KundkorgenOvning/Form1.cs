using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundkorgenOvning
{
    public partial class Form1 : Form
    {
        List<TextBox> Varor = new List<TextBox>();
        List<TextBox> Priser = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }
        int locationVara = 79;
        int size = 306;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            locationVara += 37;
            TextBox tempVara = new TextBox();
            TextBox tempPriser = new TextBox();

            tempVara.Location = new Point(40, locationVara);
            tempVara.Size = new Size(146, 20);

            tempPriser.Location = new Point(206, locationVara);
            tempPriser.Size = new Size(100, 20);

            this.Controls.Add(tempVara);
            this.Controls.Add(tempPriser);

            Varor.Add(tempVara);
            Priser.Add(tempPriser);

            btnAdd.Location = new Point(313, locationVara);

            size += 37;
            this.Size = new Size(392, size);
        }
    }
}
