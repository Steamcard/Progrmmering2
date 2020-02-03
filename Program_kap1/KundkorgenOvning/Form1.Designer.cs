namespace KundkorgenOvning
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
            this.tbxVara1 = new System.Windows.Forms.TextBox();
            this.tbxPrisVara1 = new System.Windows.Forms.TextBox();
            this.tbxPrisVara2 = new System.Windows.Forms.TextBox();
            this.tbxVara2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxVara1
            // 
            this.tbxVara1.Location = new System.Drawing.Point(40, 42);
            this.tbxVara1.Name = "tbxVara1";
            this.tbxVara1.Size = new System.Drawing.Size(146, 20);
            this.tbxVara1.TabIndex = 0;
            // 
            // tbxPrisVara1
            // 
            this.tbxPrisVara1.Location = new System.Drawing.Point(206, 42);
            this.tbxPrisVara1.Name = "tbxPrisVara1";
            this.tbxPrisVara1.Size = new System.Drawing.Size(100, 20);
            this.tbxPrisVara1.TabIndex = 1;
            // 
            // tbxPrisVara2
            // 
            this.tbxPrisVara2.Location = new System.Drawing.Point(206, 79);
            this.tbxPrisVara2.Name = "tbxPrisVara2";
            this.tbxPrisVara2.Size = new System.Drawing.Size(100, 20);
            this.tbxPrisVara2.TabIndex = 3;
            // 
            // tbxVara2
            // 
            this.tbxVara2.Location = new System.Drawing.Point(40, 79);
            this.tbxVara2.Name = "tbxVara2";
            this.tbxVara2.Size = new System.Drawing.Size(146, 20);
            this.tbxVara2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 20);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 187);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxPrisVara2);
            this.Controls.Add(this.tbxVara2);
            this.Controls.Add(this.tbxPrisVara1);
            this.Controls.Add(this.tbxVara1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxVara1;
        private System.Windows.Forms.TextBox tbxPrisVara1;
        private System.Windows.Forms.TextBox tbxPrisVara2;
        private System.Windows.Forms.TextBox tbxVara2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

