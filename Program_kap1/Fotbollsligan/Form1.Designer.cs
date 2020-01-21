namespace Fotbollsligan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nyMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyBortalag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.molHemma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.molBorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMolRik = new System.Windows.Forms.Button();
            this.tbxMålrikast = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyMatch,
            this.nyBortalag,
            this.molHemma,
            this.molBorta});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridView1_UserAddedRow);
            // 
            // nyMatch
            // 
            this.nyMatch.HeaderText = "Match";
            this.nyMatch.Name = "nyMatch";
            this.nyMatch.Width = 200;
            // 
            // nyBortalag
            // 
            this.nyBortalag.HeaderText = "Bortalag";
            this.nyBortalag.Name = "nyBortalag";
            this.nyBortalag.Width = 200;
            // 
            // molHemma
            // 
            this.molHemma.HeaderText = "Mål (H)";
            this.molHemma.Name = "molHemma";
            // 
            // molBorta
            // 
            this.molBorta.HeaderText = "Mål (B)";
            this.molBorta.Name = "molBorta";
            // 
            // btnMolRik
            // 
            this.btnMolRik.Location = new System.Drawing.Point(12, 308);
            this.btnMolRik.Name = "btnMolRik";
            this.btnMolRik.Size = new System.Drawing.Size(92, 23);
            this.btnMolRik.TabIndex = 1;
            this.btnMolRik.Text = "Målrikast";
            this.btnMolRik.UseVisualStyleBackColor = true;
            this.btnMolRik.Click += new System.EventHandler(this.btnMolRik_Click);
            // 
            // tbxMålrikast
            // 
            this.tbxMålrikast.Location = new System.Drawing.Point(111, 310);
            this.tbxMålrikast.Name = "tbxMålrikast";
            this.tbxMålrikast.Size = new System.Drawing.Size(521, 20);
            this.tbxMålrikast.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 343);
            this.Controls.Add(this.tbxMålrikast);
            this.Controls.Add(this.btnMolRik);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyBortalag;
        private System.Windows.Forms.DataGridViewTextBoxColumn molHemma;
        private System.Windows.Forms.DataGridViewTextBoxColumn molBorta;
        private System.Windows.Forms.Button btnMolRik;
        private System.Windows.Forms.TextBox tbxMålrikast;
    }
}

