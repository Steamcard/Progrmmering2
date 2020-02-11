using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LasEnBok_4_1
{
    public partial class Form1 : Form
    {

        string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void MspArkiv_Click(object sender, EventArgs e)
        {
        }

        private void NyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxData.Clear();
            name = "";
        }

        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult open = dlgOpenFile.ShowDialog();
            if (open == DialogResult.OK)
            {
                FileStream inPower = new FileStream(dlgOpenFile.FileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(inPower);

                string textFile = reader.ReadToEnd();

                tbxData.Text = textFile;

                reader.Dispose();
            }
        }

        private void SparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(name == "")
            {
                DialogResult save = dlgSaveFile.ShowDialog();

                     if(save == DialogResult.OK)
                     {
                       FileStream outPower = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                       name = dlgSaveFile.FileName;
                       StreamWriter writer = new StreamWriter(outPower);



                       writer.Write(tbxData.Text);
                       writer.Dispose();
                     }
            }
            else
            {
                FileStream outPower = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outPower);
                writer.Write(tbxData.Text);
                writer.Dispose();
            }
            
        }

        private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult save = dlgSaveFile.ShowDialog();

            if (save == DialogResult.OK)
            {
                FileStream outPower = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                name = dlgSaveFile.FileName;
                StreamWriter writer = new StreamWriter(outPower);



                writer.Write(tbxData.Text);
                writer.Dispose();
            }
        }

        private void StängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
