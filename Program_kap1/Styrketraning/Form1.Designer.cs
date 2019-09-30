namespace Styrketraning
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
            this.tbxOvning = new System.Windows.Forms.TextBox();
            this.tbxSet = new System.Windows.Forms.TextBox();
            this.tbxVikt = new System.Windows.Forms.TextBox();
            this.tbxRep = new System.Windows.Forms.TextBox();
            this.tbxSok = new System.Windows.Forms.TextBox();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.lbxSok = new System.Windows.Forms.ListBox();
            this.gbxReg = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSet = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxReg.SuspendLayout();
            this.gbxSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxOvning
            // 
            this.tbxOvning.Location = new System.Drawing.Point(17, 53);
            this.tbxOvning.Name = "tbxOvning";
            this.tbxOvning.Size = new System.Drawing.Size(179, 20);
            this.tbxOvning.TabIndex = 0;
            // 
            // tbxSet
            // 
            this.tbxSet.Location = new System.Drawing.Point(17, 89);
            this.tbxSet.Name = "tbxSet";
            this.tbxSet.Size = new System.Drawing.Size(49, 20);
            this.tbxSet.TabIndex = 1;
            // 
            // tbxVikt
            // 
            this.tbxVikt.Location = new System.Drawing.Point(147, 89);
            this.tbxVikt.Name = "tbxVikt";
            this.tbxVikt.Size = new System.Drawing.Size(49, 20);
            this.tbxVikt.TabIndex = 2;
            // 
            // tbxRep
            // 
            this.tbxRep.Location = new System.Drawing.Point(82, 89);
            this.tbxRep.Name = "tbxRep";
            this.tbxRep.Size = new System.Drawing.Size(49, 20);
            this.tbxRep.TabIndex = 3;
            // 
            // tbxSok
            // 
            this.tbxSok.Location = new System.Drawing.Point(6, 52);
            this.tbxSok.Name = "tbxSok";
            this.tbxSok.Size = new System.Drawing.Size(223, 20);
            this.tbxSok.TabIndex = 4;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(17, 166);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(179, 23);
            this.btnSpara.TabIndex = 5;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.BtnSpara_Click);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(6, 86);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(97, 30);
            this.btnSok.TabIndex = 6;
            this.btnSok.Text = "Total vikt ->";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.BtnSok_Click);
            // 
            // lbxSok
            // 
            this.lbxSok.FormattingEnabled = true;
            this.lbxSok.Location = new System.Drawing.Point(109, 86);
            this.lbxSok.Name = "lbxSok";
            this.lbxSok.Size = new System.Drawing.Size(120, 30);
            this.lbxSok.TabIndex = 7;
            // 
            // gbxReg
            // 
            this.gbxReg.Controls.Add(this.label4);
            this.gbxReg.Controls.Add(this.label3);
            this.gbxReg.Controls.Add(this.label2);
            this.gbxReg.Controls.Add(this.label1);
            this.gbxReg.Controls.Add(this.tbxOvning);
            this.gbxReg.Controls.Add(this.tbxSet);
            this.gbxReg.Controls.Add(this.tbxRep);
            this.gbxReg.Controls.Add(this.btnSpara);
            this.gbxReg.Controls.Add(this.tbxVikt);
            this.gbxReg.Location = new System.Drawing.Point(12, 12);
            this.gbxReg.Name = "gbxReg";
            this.gbxReg.Size = new System.Drawing.Size(215, 220);
            this.gbxReg.TabIndex = 8;
            this.gbxReg.TabStop = false;
            this.gbxReg.Text = "Lägg in övning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Övning:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vikt";
            // 
            // gbxSet
            // 
            this.gbxSet.Controls.Add(this.label5);
            this.gbxSet.Controls.Add(this.tbxSok);
            this.gbxSet.Controls.Add(this.btnSok);
            this.gbxSet.Controls.Add(this.lbxSok);
            this.gbxSet.Location = new System.Drawing.Point(234, 13);
            this.gbxSet.Name = "gbxSet";
            this.gbxSet.Size = new System.Drawing.Size(235, 219);
            this.gbxSet.TabIndex = 9;
            this.gbxSet.TabStop = false;
            this.gbxSet.Text = "Sök på övning";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Övning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 242);
            this.Controls.Add(this.gbxSet);
            this.Controls.Add(this.gbxReg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxReg.ResumeLayout(false);
            this.gbxReg.PerformLayout();
            this.gbxSet.ResumeLayout(false);
            this.gbxSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOvning;
        private System.Windows.Forms.TextBox tbxSet;
        private System.Windows.Forms.TextBox tbxVikt;
        private System.Windows.Forms.TextBox tbxRep;
        private System.Windows.Forms.TextBox tbxSok;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.ListBox lbxSok;
        private System.Windows.Forms.GroupBox gbxReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSet;
        private System.Windows.Forms.Label label5;
    }
}

