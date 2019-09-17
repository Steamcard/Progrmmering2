namespace Resebokning
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
            this.lbxSvar = new System.Windows.Forms.ListBox();
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxDagar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxSokNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxSvar
            // 
            this.lbxSvar.FormattingEnabled = true;
            this.lbxSvar.Location = new System.Drawing.Point(6, 69);
            this.lbxSvar.Name = "lbxSvar";
            this.lbxSvar.Size = new System.Drawing.Size(202, 134);
            this.lbxSvar.TabIndex = 0;
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(79, 30);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 1;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(79, 69);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(100, 20);
            this.tbxDestination.TabIndex = 2;
            // 
            // tbxDagar
            // 
            this.tbxDagar.Location = new System.Drawing.Point(79, 117);
            this.tbxDagar.Name = "tbxDagar";
            this.tbxDagar.Size = new System.Drawing.Size(100, 20);
            this.tbxDagar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxSokNamn);
            this.groupBox1.Controls.Add(this.lbxSvar);
            this.groupBox1.Location = new System.Drawing.Point(16, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök kund";
            // 
            // tbxSokNamn
            // 
            this.tbxSokNamn.Location = new System.Drawing.Point(48, 29);
            this.tbxSokNamn.Name = "tbxSokNamn";
            this.tbxSokNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxSokNamn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Antal dagar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Boka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(154, 29);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(54, 23);
            this.btnSok.TabIndex = 3;
            this.btnSok.Text = "Sök";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.BtnSok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxDagar);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.tbxKund);
            this.Name = "Form1";
            this.Text = "Resebokning";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSvar;
        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxDagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSokNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.Button button1;
    }
}

