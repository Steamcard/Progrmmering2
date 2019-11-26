namespace Tidrapportering
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
            this.gbxReg = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAndra = new System.Windows.Forms.GroupBox();
            this.btnAndra = new System.Windows.Forms.Button();
            this.tbxNyttNamn = new System.Windows.Forms.TextBox();
            this.tbxGamNamn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxBerakna = new System.Windows.Forms.GroupBox();
            this.btnBer = new System.Windows.Forms.Button();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxTim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxReg = new System.Windows.Forms.ListBox();
            this.gbxReg.SuspendLayout();
            this.gbxAndra.SuspendLayout();
            this.gbxBerakna.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxReg
            // 
            this.gbxReg.Controls.Add(this.btnReg);
            this.gbxReg.Controls.Add(this.tbxTid);
            this.gbxReg.Controls.Add(this.tbxKund);
            this.gbxReg.Controls.Add(this.label2);
            this.gbxReg.Controls.Add(this.label1);
            this.gbxReg.Location = new System.Drawing.Point(23, 13);
            this.gbxReg.Name = "gbxReg";
            this.gbxReg.Size = new System.Drawing.Size(349, 107);
            this.gbxReg.TabIndex = 0;
            this.gbxReg.TabStop = false;
            this.gbxReg.Text = "Ny tidrapport";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(245, 67);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Lägg till";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(123, 72);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(100, 20);
            this.tbxTid.TabIndex = 3;
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(123, 35);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tid (min.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kund";
            // 
            // gbxAndra
            // 
            this.gbxAndra.Controls.Add(this.btnAndra);
            this.gbxAndra.Controls.Add(this.tbxNyttNamn);
            this.gbxAndra.Controls.Add(this.tbxGamNamn);
            this.gbxAndra.Controls.Add(this.label4);
            this.gbxAndra.Controls.Add(this.label3);
            this.gbxAndra.Location = new System.Drawing.Point(23, 137);
            this.gbxAndra.Name = "gbxAndra";
            this.gbxAndra.Size = new System.Drawing.Size(349, 107);
            this.gbxAndra.TabIndex = 1;
            this.gbxAndra.TabStop = false;
            this.gbxAndra.Text = "Ändra kundnamn";
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(245, 61);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(75, 23);
            this.btnAndra.TabIndex = 6;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.BtnAndra_Click);
            // 
            // tbxNyttNamn
            // 
            this.tbxNyttNamn.Location = new System.Drawing.Point(123, 63);
            this.tbxNyttNamn.Name = "tbxNyttNamn";
            this.tbxNyttNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNyttNamn.TabIndex = 5;
            // 
            // tbxGamNamn
            // 
            this.tbxGamNamn.Location = new System.Drawing.Point(123, 30);
            this.tbxGamNamn.Name = "tbxGamNamn";
            this.tbxGamNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxGamNamn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nytt namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gammalt namn";
            // 
            // gbxBerakna
            // 
            this.gbxBerakna.Controls.Add(this.btnBer);
            this.gbxBerakna.Controls.Add(this.tbxPris);
            this.gbxBerakna.Controls.Add(this.tbxTim);
            this.gbxBerakna.Controls.Add(this.label6);
            this.gbxBerakna.Controls.Add(this.label5);
            this.gbxBerakna.Location = new System.Drawing.Point(23, 263);
            this.gbxBerakna.Name = "gbxBerakna";
            this.gbxBerakna.Size = new System.Drawing.Size(349, 107);
            this.gbxBerakna.TabIndex = 2;
            this.gbxBerakna.TabStop = false;
            this.gbxBerakna.Text = "Beräkna pris på vald rapport";
            // 
            // btnBer
            // 
            this.btnBer.Location = new System.Drawing.Point(245, 62);
            this.btnBer.Name = "btnBer";
            this.btnBer.Size = new System.Drawing.Size(75, 23);
            this.btnBer.TabIndex = 8;
            this.btnBer.Text = "Beräkna";
            this.btnBer.UseVisualStyleBackColor = true;
            this.btnBer.Click += new System.EventHandler(this.BtnBer_Click);
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(123, 67);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 7;
            // 
            // tbxTim
            // 
            this.tbxTim.Location = new System.Drawing.Point(123, 31);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(100, 20);
            this.tbxTim.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pris";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timarvode";
            // 
            // lbxReg
            // 
            this.lbxReg.FormattingEnabled = true;
            this.lbxReg.Location = new System.Drawing.Point(388, 25);
            this.lbxReg.Name = "lbxReg";
            this.lbxReg.Size = new System.Drawing.Size(182, 342);
            this.lbxReg.TabIndex = 3;
            this.lbxReg.SelectedIndexChanged += new System.EventHandler(this.lbxReg_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 386);
            this.Controls.Add(this.lbxReg);
            this.Controls.Add(this.gbxBerakna);
            this.Controls.Add(this.gbxAndra);
            this.Controls.Add(this.gbxReg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxReg.ResumeLayout(false);
            this.gbxReg.PerformLayout();
            this.gbxAndra.ResumeLayout(false);
            this.gbxAndra.PerformLayout();
            this.gbxBerakna.ResumeLayout(false);
            this.gbxBerakna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAndra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxBerakna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.TextBox tbxNyttNamn;
        private System.Windows.Forms.Button btnBer;
        private System.Windows.Forms.TextBox tbxTim;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxGamNamn;
    }
}

