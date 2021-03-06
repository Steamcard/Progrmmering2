﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterProgram
{

    public partial class Form1 : Form
    {
        List<Media> MediaRegister = new List<Media>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegBok_Click(object sender, EventArgs e)
        {
            string BTitel = tbxTitelBok.Text;
            int BSidor = int.Parse(tbxSidorBok.Text);

            Media BokLista = new Bok(BTitel, BSidor);
            MediaRegister.Add(BokLista);
            lbxReg.Items.Add(BokLista);
        }

        private void BtnRegLjud_Click(object sender, EventArgs e)
        {
            string LTitel = tbxTitelLjud.Text;
            double LSpeltid = int.Parse(tbxSpeltidLjud.Text);

            Media LjudLista = new Ljudspår (LTitel, LSpeltid);
            MediaRegister.Add(LjudLista);
            lbxReg.Items.Add(LjudLista);
        }

        private void TbnRegFilm_Click(object sender, EventArgs e)
        {
            string FTitel = tbxTitelFilm.Text;
            double FSpeltid = int.Parse(tbxSpeltidFilm.Text);
            string FUpplösning = tbxUppFilm.Text;

            Media FilmLista = new Film (FTitel, FSpeltid, FUpplösning);
            MediaRegister.Add(FilmLista);
            lbxReg.Items.Add(FilmLista);
        }
    }
}
