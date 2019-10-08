namespace Bilregister
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
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.tbxMarke = new System.Windows.Forms.TextBox();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.gbxVisa = new System.Windows.Forms.GroupBox();
            this.rbtnMC = new System.Windows.Forms.RadioButton();
            this.rbtnBilar = new System.Windows.Forms.RadioButton();
            this.rbtnAlla = new System.Windows.Forms.RadioButton();
            this.lbxReg = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxVisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(95, 117);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(121, 20);
            this.tbxRegNr.TabIndex = 0;
            // 
            // tbxMarke
            // 
            this.tbxMarke.Location = new System.Drawing.Point(95, 151);
            this.tbxMarke.Name = "tbxMarke";
            this.tbxMarke.Size = new System.Drawing.Size(121, 20);
            this.tbxMarke.TabIndex = 0;
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(95, 185);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(121, 20);
            this.tbxModell.TabIndex = 0;
            // 
            // cbxTyp
            // 
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.cbxTyp.Location = new System.Drawing.Point(95, 213);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(121, 21);
            this.cbxTyp.TabIndex = 1;
            this.cbxTyp.SelectedIndexChanged += new System.EventHandler(this.CbxTyp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reg-nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Typ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bilregister.Properties.Resources.green_295144_640;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(95, 253);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(121, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // gbxVisa
            // 
            this.gbxVisa.Controls.Add(this.rbtnMC);
            this.gbxVisa.Controls.Add(this.rbtnBilar);
            this.gbxVisa.Controls.Add(this.rbtnAlla);
            this.gbxVisa.Location = new System.Drawing.Point(308, 271);
            this.gbxVisa.Name = "gbxVisa";
            this.gbxVisa.Size = new System.Drawing.Size(299, 42);
            this.gbxVisa.TabIndex = 5;
            this.gbxVisa.TabStop = false;
            this.gbxVisa.Text = "Visa";
            // 
            // rbtnMC
            // 
            this.rbtnMC.AutoSize = true;
            this.rbtnMC.Location = new System.Drawing.Point(239, 19);
            this.rbtnMC.Name = "rbtnMC";
            this.rbtnMC.Size = new System.Drawing.Size(41, 17);
            this.rbtnMC.TabIndex = 2;
            this.rbtnMC.TabStop = true;
            this.rbtnMC.Text = "MC";
            this.rbtnMC.UseVisualStyleBackColor = true;
            this.rbtnMC.CheckedChanged += new System.EventHandler(this.RbtnMC_CheckedChanged);
            // 
            // rbtnBilar
            // 
            this.rbtnBilar.AutoSize = true;
            this.rbtnBilar.Location = new System.Drawing.Point(132, 19);
            this.rbtnBilar.Name = "rbtnBilar";
            this.rbtnBilar.Size = new System.Drawing.Size(45, 17);
            this.rbtnBilar.TabIndex = 1;
            this.rbtnBilar.TabStop = true;
            this.rbtnBilar.Text = "Bilar";
            this.rbtnBilar.UseVisualStyleBackColor = true;
            this.rbtnBilar.CheckedChanged += new System.EventHandler(this.RbtnBilar_CheckedChanged);
            // 
            // rbtnAlla
            // 
            this.rbtnAlla.AutoSize = true;
            this.rbtnAlla.Location = new System.Drawing.Point(20, 19);
            this.rbtnAlla.Name = "rbtnAlla";
            this.rbtnAlla.Size = new System.Drawing.Size(42, 17);
            this.rbtnAlla.TabIndex = 0;
            this.rbtnAlla.TabStop = true;
            this.rbtnAlla.Text = "Alla";
            this.rbtnAlla.UseVisualStyleBackColor = true;
            this.rbtnAlla.CheckedChanged += new System.EventHandler(this.RbtnAlla_CheckedChanged);
            // 
            // lbxReg
            // 
            this.lbxReg.FormattingEnabled = true;
            this.lbxReg.Location = new System.Drawing.Point(308, 38);
            this.lbxReg.Name = "lbxReg";
            this.lbxReg.Size = new System.Drawing.Size(299, 225);
            this.lbxReg.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxReg);
            this.Controls.Add(this.gbxVisa);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.tbxMarke);
            this.Controls.Add(this.tbxRegNr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxVisa.ResumeLayout(false);
            this.gbxVisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRegNr;
        private System.Windows.Forms.TextBox tbxMarke;
        private System.Windows.Forms.TextBox tbxModell;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.GroupBox gbxVisa;
        private System.Windows.Forms.RadioButton rbtnMC;
        private System.Windows.Forms.RadioButton rbtnBilar;
        private System.Windows.Forms.RadioButton rbtnAlla;
        private System.Windows.Forms.ListBox lbxReg;
        private System.Windows.Forms.Label label5;
    }
}

