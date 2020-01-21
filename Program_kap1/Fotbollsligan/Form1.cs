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
        List<Match> matcher = new List<Match>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMolRik_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            string bortalag = "";
            int antalMål = 0;
            for (int i = 0; i < matcher.Count; i++)
            {
                if(matcher[i].MålHemmaLag + matcher[i].MålBortaLag > antalMål)
                {
                    hemmalag = matcher[i].HemmaLag;
                    bortalag = matcher[i].BortaLag;
                    antalMål = matcher[i].MålHemmaLag + matcher[i].MålBortaLag;
                }
            }
            tbxMålrikast.Text = hemmalag + " mot " + bortalag + ": " + antalMål; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; 

            if( e.ColumnIndex == 0)
            {
                matcher[i].HemmaLag = (string)dataGridView1.Rows[i].Cells[0].Value;
            }
            else if(e.ColumnIndex == 1)
            {
                matcher[i].BortaLag = (string)dataGridView1.Rows[i].Cells[1].Value;
            }
            else if(e.ColumnIndex == 2)
            {
                matcher[i].MålHemmaLag = int.Parse((string)dataGridView1.Rows[i].Cells[2].Value);
            }
            else if (e.ColumnIndex == 3)
            {
                matcher[i].MålBortaLag = int.Parse((string)dataGridView1.Rows[i].Cells[3].Value);
            }
        }

        private void DataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Match nyMatch = new Match();
            matcher.Add(nyMatch);
        }
    }

    public class Match
    {
        public string HemmaLag { get; set; }
        public string BortaLag { get; set; }
        public int MålHemmaLag { get; set; }
        public int MålBortaLag { get; set; }
    }
}
