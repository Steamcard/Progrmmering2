﻿namespace Banken
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxInUt = new System.Windows.Forms.GroupBox();
            this.gbxOppna = new System.Windows.Forms.GroupBox();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnInsattning = new System.Windows.Forms.Button();
            this.btnUttag = new System.Windows.Forms.Button();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.tbxRantesats = new System.Windows.Forms.TextBox();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxInUt.SuspendLayout();
            this.gbxOppna.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInUt
            // 
            this.gbxInUt.Controls.Add(this.label1);
            this.gbxInUt.Controls.Add(this.tbxBelopp);
            this.gbxInUt.Controls.Add(this.btnUttag);
            this.gbxInUt.Controls.Add(this.btnInsattning);
            this.gbxInUt.Location = new System.Drawing.Point(12, 12);
            this.gbxInUt.Name = "gbxInUt";
            this.gbxInUt.Size = new System.Drawing.Size(227, 194);
            this.gbxInUt.TabIndex = 0;
            this.gbxInUt.TabStop = false;
            this.gbxInUt.Text = "Insättning / Uttag";
            // 
            // gbxOppna
            // 
            this.gbxOppna.Controls.Add(this.label4);
            this.gbxOppna.Controls.Add(this.label3);
            this.gbxOppna.Controls.Add(this.label2);
            this.gbxOppna.Controls.Add(this.tbxKredit);
            this.gbxOppna.Controls.Add(this.tbxRantesats);
            this.gbxOppna.Controls.Add(this.tbxPersonNr);
            this.gbxOppna.Controls.Add(this.btnReg);
            this.gbxOppna.Location = new System.Drawing.Point(256, 12);
            this.gbxOppna.Name = "gbxOppna";
            this.gbxOppna.Size = new System.Drawing.Size(234, 194);
            this.gbxOppna.TabIndex = 1;
            this.gbxOppna.TabStop = false;
            this.gbxOppna.Text = "Öppna konto";
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(539, 19);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(249, 134);
            this.lbxLista.TabIndex = 2;
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(539, 164);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(249, 23);
            this.btnUppdatera.TabIndex = 3;
            this.btnUppdatera.Text = "Uppdatera med årsränta";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(137, 151);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnInsattning
            // 
            this.btnInsattning.Location = new System.Drawing.Point(116, 105);
            this.btnInsattning.Name = "btnInsattning";
            this.btnInsattning.Size = new System.Drawing.Size(100, 23);
            this.btnInsattning.TabIndex = 0;
            this.btnInsattning.Text = "Insättning";
            this.btnInsattning.UseVisualStyleBackColor = true;
            this.btnInsattning.Click += new System.EventHandler(this.btnInsattning_Click);
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(116, 152);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(100, 23);
            this.btnUttag.TabIndex = 1;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(82, 35);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(134, 20);
            this.tbxBelopp.TabIndex = 2;
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(63, 28);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(149, 20);
            this.tbxPersonNr.TabIndex = 1;
            // 
            // tbxRantesats
            // 
            this.tbxRantesats.Location = new System.Drawing.Point(63, 59);
            this.tbxRantesats.Name = "tbxRantesats";
            this.tbxRantesats.Size = new System.Drawing.Size(149, 20);
            this.tbxRantesats.TabIndex = 2;
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(63, 91);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(149, 20);
            this.tbxKredit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Belopp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PersonNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Räntesats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kredit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 218);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.gbxOppna);
            this.Controls.Add(this.gbxInUt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInUt.ResumeLayout(false);
            this.gbxInUt.PerformLayout();
            this.gbxOppna.ResumeLayout(false);
            this.gbxOppna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInUt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnInsattning;
        private System.Windows.Forms.GroupBox gbxOppna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.TextBox tbxRantesats;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Button btnUppdatera;
    }
}

