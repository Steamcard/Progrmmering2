namespace Skyttetavling
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
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxSok = new System.Windows.Forms.TextBox();
            this.tbxPoäng = new System.Windows.Forms.TextBox();
            this.lbxReg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSok = new System.Windows.Forms.GroupBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxSok.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(76, 25);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxNamn.TabIndex = 0;
            // 
            // tbxSok
            // 
            this.tbxSok.Location = new System.Drawing.Point(126, 51);
            this.tbxSok.Name = "tbxSok";
            this.tbxSok.Size = new System.Drawing.Size(146, 20);
            this.tbxSok.TabIndex = 1;
            // 
            // tbxPoäng
            // 
            this.tbxPoäng.Location = new System.Drawing.Point(76, 74);
            this.tbxPoäng.Name = "tbxPoäng";
            this.tbxPoäng.Size = new System.Drawing.Size(100, 20);
            this.tbxPoäng.TabIndex = 2;
            // 
            // lbxReg
            // 
            this.lbxReg.FormattingEnabled = true;
            this.lbxReg.Location = new System.Drawing.Point(6, 128);
            this.lbxReg.Name = "lbxReg";
            this.lbxReg.Size = new System.Drawing.Size(266, 199);
            this.lbxReg.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Poäng";
            // 
            // gbxSok
            // 
            this.gbxSok.Controls.Add(this.btnVisa);
            this.gbxSok.Controls.Add(this.lbxReg);
            this.gbxSok.Controls.Add(this.label2);
            this.gbxSok.Controls.Add(this.tbxSok);
            this.gbxSok.Location = new System.Drawing.Point(12, 104);
            this.gbxSok.Name = "gbxSok";
            this.gbxSok.Size = new System.Drawing.Size(278, 336);
            this.gbxSok.TabIndex = 6;
            this.gbxSok.TabStop = false;
            this.gbxSok.Text = "Sök poäng över";
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(126, 77);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(146, 23);
            this.btnVisa.TabIndex = 4;
            this.btnVisa.Text = "Visa urval";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.BtnVisa_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(191, 74);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(93, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Poäng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 448);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.gbxSok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPoäng);
            this.Controls.Add(this.tbxNamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSok.ResumeLayout(false);
            this.gbxSok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.TextBox tbxSok;
        private System.Windows.Forms.ListBox lbxReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSok;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPoäng;
    }
}

