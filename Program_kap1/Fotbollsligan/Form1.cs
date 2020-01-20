using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotbollsligan
{
    public partial class Form1 : Form
    {
        List<Match> matcher = new List<Match>;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMolRik_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string hemmalag = "";
            string bortalag = "";
            int antalMål = 0;

        }
    }

    public class Match
    {

    }
}
