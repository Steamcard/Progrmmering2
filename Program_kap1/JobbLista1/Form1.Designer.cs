namespace JobbLista1
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
            this.gbxSaljare = new System.Windows.Forms.GroupBox();
            this.gbxKonsult = new System.Windows.Forms.GroupBox();
            this.gbxKontorist = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxSaljareNamn = new System.Windows.Forms.TextBox();
            this.tbxProvision = new System.Windows.Forms.TextBox();
            this.tbxForsaljning = new System.Windows.Forms.TextBox();
            this.tbxKonsultNamn = new System.Windows.Forms.TextBox();
            this.tbxTimlon = new System.Windows.Forms.TextBox();
            this.tbxArbetadTid = new System.Windows.Forms.TextBox();
            this.tbxKontoristNamn = new System.Windows.Forms.TextBox();
            this.tbxManadLon = new System.Windows.Forms.TextBox();
            this.btnBeraknaLon = new System.Windows.Forms.Button();
            this.btnSaljareReg = new System.Windows.Forms.Button();
            this.btnKonsultReg = new System.Windows.Forms.Button();
            this.btnKontoristReg = new System.Windows.Forms.Button();
            this.lbxRegister = new System.Windows.Forms.ListBox();
            this.lbxLoner = new System.Windows.Forms.ListBox();
            this.lbxTotLon = new System.Windows.Forms.ListBox();
            this.gbxSaljare.SuspendLayout();
            this.gbxKonsult.SuspendLayout();
            this.gbxKontorist.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSaljare
            // 
            this.gbxSaljare.Controls.Add(this.btnSaljareReg);
            this.gbxSaljare.Controls.Add(this.tbxForsaljning);
            this.gbxSaljare.Controls.Add(this.tbxProvision);
            this.gbxSaljare.Controls.Add(this.tbxSaljareNamn);
            this.gbxSaljare.Controls.Add(this.label);
            this.gbxSaljare.Controls.Add(this.label2);
            this.gbxSaljare.Controls.Add(this.label1);
            this.gbxSaljare.Location = new System.Drawing.Point(12, 12);
            this.gbxSaljare.Name = "gbxSaljare";
            this.gbxSaljare.Size = new System.Drawing.Size(230, 298);
            this.gbxSaljare.TabIndex = 0;
            this.gbxSaljare.TabStop = false;
            this.gbxSaljare.Text = "Säljare";
            // 
            // gbxKonsult
            // 
            this.gbxKonsult.Controls.Add(this.btnKonsultReg);
            this.gbxKonsult.Controls.Add(this.tbxArbetadTid);
            this.gbxKonsult.Controls.Add(this.tbxTimlon);
            this.gbxKonsult.Controls.Add(this.tbxKonsultNamn);
            this.gbxKonsult.Controls.Add(this.label6);
            this.gbxKonsult.Controls.Add(this.label5);
            this.gbxKonsult.Controls.Add(this.label4);
            this.gbxKonsult.Location = new System.Drawing.Point(268, 13);
            this.gbxKonsult.Name = "gbxKonsult";
            this.gbxKonsult.Size = new System.Drawing.Size(217, 297);
            this.gbxKonsult.TabIndex = 1;
            this.gbxKonsult.TabStop = false;
            this.gbxKonsult.Text = "Konsult";
            this.gbxKonsult.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gbxKontorist
            // 
            this.gbxKontorist.Controls.Add(this.btnKontoristReg);
            this.gbxKontorist.Controls.Add(this.tbxManadLon);
            this.gbxKontorist.Controls.Add(this.tbxKontoristNamn);
            this.gbxKontorist.Controls.Add(this.label8);
            this.gbxKontorist.Controls.Add(this.label7);
            this.gbxKontorist.Location = new System.Drawing.Point(511, 13);
            this.gbxKontorist.Name = "gbxKontorist";
            this.gbxKontorist.Size = new System.Drawing.Size(227, 297);
            this.gbxKontorist.TabIndex = 2;
            this.gbxKontorist.TabStop = false;
            this.gbxKontorist.Text = "Kontorist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provision";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(41, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Försäljning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Namn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Timlön";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Arbetad tid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Namn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Månadslön";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total lönekostnad";
            // 
            // tbxSaljareNamn
            // 
            this.tbxSaljareNamn.Location = new System.Drawing.Point(108, 39);
            this.tbxSaljareNamn.Name = "tbxSaljareNamn";
            this.tbxSaljareNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxSaljareNamn.TabIndex = 3;
            // 
            // tbxProvision
            // 
            this.tbxProvision.Location = new System.Drawing.Point(108, 83);
            this.tbxProvision.Name = "tbxProvision";
            this.tbxProvision.Size = new System.Drawing.Size(100, 20);
            this.tbxProvision.TabIndex = 4;
            // 
            // tbxForsaljning
            // 
            this.tbxForsaljning.Location = new System.Drawing.Point(108, 126);
            this.tbxForsaljning.Name = "tbxForsaljning";
            this.tbxForsaljning.Size = new System.Drawing.Size(100, 20);
            this.tbxForsaljning.TabIndex = 5;
            // 
            // tbxKonsultNamn
            // 
            this.tbxKonsultNamn.Location = new System.Drawing.Point(95, 38);
            this.tbxKonsultNamn.Name = "tbxKonsultNamn";
            this.tbxKonsultNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxKonsultNamn.TabIndex = 3;
            // 
            // tbxTimlon
            // 
            this.tbxTimlon.Location = new System.Drawing.Point(95, 82);
            this.tbxTimlon.Name = "tbxTimlon";
            this.tbxTimlon.Size = new System.Drawing.Size(100, 20);
            this.tbxTimlon.TabIndex = 4;
            // 
            // tbxArbetadTid
            // 
            this.tbxArbetadTid.Location = new System.Drawing.Point(95, 125);
            this.tbxArbetadTid.Name = "tbxArbetadTid";
            this.tbxArbetadTid.Size = new System.Drawing.Size(100, 20);
            this.tbxArbetadTid.TabIndex = 5;
            // 
            // tbxKontoristNamn
            // 
            this.tbxKontoristNamn.Location = new System.Drawing.Point(106, 38);
            this.tbxKontoristNamn.Name = "tbxKontoristNamn";
            this.tbxKontoristNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxKontoristNamn.TabIndex = 3;
            // 
            // tbxManadLon
            // 
            this.tbxManadLon.Location = new System.Drawing.Point(106, 82);
            this.tbxManadLon.Name = "tbxManadLon";
            this.tbxManadLon.Size = new System.Drawing.Size(100, 20);
            this.tbxManadLon.TabIndex = 4;
            // 
            // btnBeraknaLon
            // 
            this.btnBeraknaLon.Location = new System.Drawing.Point(511, 337);
            this.btnBeraknaLon.Name = "btnBeraknaLon";
            this.btnBeraknaLon.Size = new System.Drawing.Size(227, 23);
            this.btnBeraknaLon.TabIndex = 3;
            this.btnBeraknaLon.Text = "Beräkna löner";
            this.btnBeraknaLon.UseVisualStyleBackColor = true;
            // 
            // btnSaljareReg
            // 
            this.btnSaljareReg.Location = new System.Drawing.Point(44, 265);
            this.btnSaljareReg.Name = "btnSaljareReg";
            this.btnSaljareReg.Size = new System.Drawing.Size(151, 23);
            this.btnSaljareReg.TabIndex = 6;
            this.btnSaljareReg.Text = "Registrera försäljning";
            this.btnSaljareReg.UseVisualStyleBackColor = true;
            this.btnSaljareReg.Click += new System.EventHandler(this.btnSaljareReg_Click);
            // 
            // btnKonsultReg
            // 
            this.btnKonsultReg.Location = new System.Drawing.Point(39, 264);
            this.btnKonsultReg.Name = "btnKonsultReg";
            this.btnKonsultReg.Size = new System.Drawing.Size(144, 23);
            this.btnKonsultReg.TabIndex = 6;
            this.btnKonsultReg.Text = "Registrera arbetspass";
            this.btnKonsultReg.UseVisualStyleBackColor = true;
            // 
            // btnKontoristReg
            // 
            this.btnKontoristReg.Location = new System.Drawing.Point(47, 264);
            this.btnKontoristReg.Name = "btnKontoristReg";
            this.btnKontoristReg.Size = new System.Drawing.Size(146, 23);
            this.btnKontoristReg.TabIndex = 5;
            this.btnKontoristReg.Text = "Registrera månadslön";
            this.btnKontoristReg.UseVisualStyleBackColor = true;
            // 
            // lbxRegister
            // 
            this.lbxRegister.FormattingEnabled = true;
            this.lbxRegister.Location = new System.Drawing.Point(11, 337);
            this.lbxRegister.Name = "lbxRegister";
            this.lbxRegister.Size = new System.Drawing.Size(231, 186);
            this.lbxRegister.TabIndex = 4;
            // 
            // lbxLoner
            // 
            this.lbxLoner.FormattingEnabled = true;
            this.lbxLoner.Location = new System.Drawing.Point(268, 337);
            this.lbxLoner.Name = "lbxLoner";
            this.lbxLoner.Size = new System.Drawing.Size(217, 186);
            this.lbxLoner.TabIndex = 5;
            // 
            // lbxTotLon
            // 
            this.lbxTotLon.FormattingEnabled = true;
            this.lbxTotLon.Location = new System.Drawing.Point(511, 428);
            this.lbxTotLon.Name = "lbxTotLon";
            this.lbxTotLon.Size = new System.Drawing.Size(227, 30);
            this.lbxTotLon.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 555);
            this.Controls.Add(this.lbxTotLon);
            this.Controls.Add(this.lbxLoner);
            this.Controls.Add(this.lbxRegister);
            this.Controls.Add(this.btnBeraknaLon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbxKontorist);
            this.Controls.Add(this.gbxKonsult);
            this.Controls.Add(this.gbxSaljare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSaljare.ResumeLayout(false);
            this.gbxSaljare.PerformLayout();
            this.gbxKonsult.ResumeLayout(false);
            this.gbxKonsult.PerformLayout();
            this.gbxKontorist.ResumeLayout(false);
            this.gbxKontorist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSaljare;
        private System.Windows.Forms.GroupBox gbxKonsult;
        private System.Windows.Forms.Button btnSaljareReg;
        private System.Windows.Forms.TextBox tbxForsaljning;
        private System.Windows.Forms.TextBox tbxProvision;
        private System.Windows.Forms.TextBox tbxSaljareNamn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKonsultReg;
        private System.Windows.Forms.TextBox tbxArbetadTid;
        private System.Windows.Forms.TextBox tbxTimlon;
        private System.Windows.Forms.TextBox tbxKonsultNamn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxKontorist;
        private System.Windows.Forms.Button btnKontoristReg;
        private System.Windows.Forms.TextBox tbxManadLon;
        private System.Windows.Forms.TextBox tbxKontoristNamn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBeraknaLon;
        private System.Windows.Forms.ListBox lbxRegister;
        private System.Windows.Forms.ListBox lbxLoner;
        private System.Windows.Forms.ListBox lbxTotLon;
    }
}

