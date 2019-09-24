namespace loplogg
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxSträcka = new System.Windows.Forms.TextBox();
            this.tbxTid = new System.Windows.Forms.TextBox();
            this.tbxSokKm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnTider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastig = new System.Windows.Forms.Button();
            this.lbxReg = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sträcka (km)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxReg);
            this.groupBox1.Controls.Add(this.btnHastig);
            this.groupBox1.Controls.Add(this.btnTider);
            this.groupBox1.Controls.Add(this.tbxSokKm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök på sträcka";
            // 
            // tbxSträcka
            // 
            this.tbxSträcka.Location = new System.Drawing.Point(106, 30);
            this.tbxSträcka.Name = "tbxSträcka";
            this.tbxSträcka.Size = new System.Drawing.Size(100, 20);
            this.tbxSträcka.TabIndex = 2;
            // 
            // tbxTid
            // 
            this.tbxTid.Location = new System.Drawing.Point(106, 67);
            this.tbxTid.Name = "tbxTid";
            this.tbxTid.Size = new System.Drawing.Size(100, 20);
            this.tbxTid.TabIndex = 2;
            // 
            // tbxSokKm
            // 
            this.tbxSokKm.Location = new System.Drawing.Point(116, 38);
            this.tbxSokKm.Name = "tbxSokKm";
            this.tbxSokKm.Size = new System.Drawing.Size(159, 20);
            this.tbxSokKm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tid (min)";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(212, 65);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(82, 23);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // btnTider
            // 
            this.btnTider.Location = new System.Drawing.Point(116, 64);
            this.btnTider.Name = "btnTider";
            this.btnTider.Size = new System.Drawing.Size(159, 23);
            this.btnTider.TabIndex = 4;
            this.btnTider.Text = "Visa alla tider";
            this.btnTider.UseVisualStyleBackColor = true;
            this.btnTider.Click += new System.EventHandler(this.BtnTider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sträcka (km)";
            // 
            // btnHastig
            // 
            this.btnHastig.Location = new System.Drawing.Point(116, 93);
            this.btnHastig.Name = "btnHastig";
            this.btnHastig.Size = new System.Drawing.Size(159, 23);
            this.btnHastig.TabIndex = 4;
            this.btnHastig.Text = "Visa alla hastigheter";
            this.btnHastig.UseVisualStyleBackColor = true;
            this.btnHastig.Click += new System.EventHandler(this.BtnHastig_Click);
            // 
            // lbxReg
            // 
            this.lbxReg.FormattingEnabled = true;
            this.lbxReg.Location = new System.Drawing.Point(6, 125);
            this.lbxReg.Name = "lbxReg";
            this.lbxReg.Size = new System.Drawing.Size(269, 173);
            this.lbxReg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 417);
            this.Controls.Add(this.tbxTid);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbxSträcka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxReg;
        private System.Windows.Forms.Button btnHastig;
        private System.Windows.Forms.Button btnTider;
        private System.Windows.Forms.TextBox tbxSokKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSträcka;
        private System.Windows.Forms.TextBox tbxTid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReg;
    }
}

