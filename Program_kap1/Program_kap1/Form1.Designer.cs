namespace Program_kap1
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
            this.tbxReg = new System.Windows.Forms.TextBox();
            this.tbxTecken = new System.Windows.Forms.TextBox();
            this.cbxKursiv = new System.Windows.Forms.CheckBox();
            this.cbxUnder = new System.Windows.Forms.CheckBox();
            this.tbxTyp = new System.Windows.Forms.TextBox();
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxReg
            // 
            this.tbxReg.Location = new System.Drawing.Point(12, 12);
            this.tbxReg.Multiline = true;
            this.tbxReg.Name = "tbxReg";
            this.tbxReg.Size = new System.Drawing.Size(455, 210);
            this.tbxReg.TabIndex = 0;
            // 
            // tbxTecken
            // 
            this.tbxTecken.Location = new System.Drawing.Point(49, 320);
            this.tbxTecken.Name = "tbxTecken";
            this.tbxTecken.Size = new System.Drawing.Size(100, 20);
            this.tbxTecken.TabIndex = 1;
            // 
            // cbxKursiv
            // 
            this.cbxKursiv.AutoSize = true;
            this.cbxKursiv.Location = new System.Drawing.Point(49, 382);
            this.cbxKursiv.Name = "cbxKursiv";
            this.cbxKursiv.Size = new System.Drawing.Size(55, 17);
            this.cbxKursiv.TabIndex = 2;
            this.cbxKursiv.Text = "Kursiv";
            this.cbxKursiv.UseVisualStyleBackColor = true;
            // 
            // cbxUnder
            // 
            this.cbxUnder.AutoSize = true;
            this.cbxUnder.Location = new System.Drawing.Point(49, 407);
            this.cbxUnder.Name = "cbxUnder";
            this.cbxUnder.Size = new System.Drawing.Size(87, 17);
            this.cbxUnder.TabIndex = 3;
            this.cbxUnder.Text = "Understruket";
            this.cbxUnder.UseVisualStyleBackColor = true;
            // 
            // tbxTyp
            // 
            this.tbxTyp.Location = new System.Drawing.Point(49, 259);
            this.tbxTyp.Name = "tbxTyp";
            this.tbxTyp.Size = new System.Drawing.Size(100, 20);
            this.tbxTyp.TabIndex = 4;
            // 
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Location = new System.Drawing.Point(49, 359);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(41, 17);
            this.cbxFet.TabIndex = 5;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(346, 359);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(101, 68);
            this.btnKör.TabIndex = 6;
            this.btnKör.Text = "OK";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.BtnKör_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teckensnitt";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Typsnitt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.tbxTyp);
            this.Controls.Add(this.cbxUnder);
            this.Controls.Add(this.cbxKursiv);
            this.Controls.Add(this.tbxTecken);
            this.Controls.Add(this.tbxReg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxReg;
        private System.Windows.Forms.TextBox tbxTecken;
        private System.Windows.Forms.CheckBox cbxKursiv;
        private System.Windows.Forms.CheckBox cbxUnder;
        private System.Windows.Forms.TextBox tbxTyp;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

