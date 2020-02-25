namespace TCP_Server
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
            this.btnStarta = new System.Windows.Forms.Button();
            this.gbxInkorg = new System.Windows.Forms.GroupBox();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.gbxInkorg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(104, 30);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(108, 23);
            this.btnStarta.TabIndex = 0;
            this.btnStarta.Text = "Starta Server";
            this.btnStarta.UseVisualStyleBackColor = true;
            this.btnStarta.Click += new System.EventHandler(this.BtnStarta_Click);
            // 
            // gbxInkorg
            // 
            this.gbxInkorg.Controls.Add(this.tbxInkorg);
            this.gbxInkorg.Location = new System.Drawing.Point(12, 80);
            this.gbxInkorg.Name = "gbxInkorg";
            this.gbxInkorg.Size = new System.Drawing.Size(200, 100);
            this.gbxInkorg.TabIndex = 1;
            this.gbxInkorg.TabStop = false;
            this.gbxInkorg.Text = "Inkorg";
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(6, 19);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.Size = new System.Drawing.Size(188, 75);
            this.tbxInkorg.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 193);
            this.Controls.Add(this.gbxInkorg);
            this.Controls.Add(this.btnStarta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInkorg.ResumeLayout(false);
            this.gbxInkorg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStarta;
        private System.Windows.Forms.GroupBox gbxInkorg;
        private System.Windows.Forms.TextBox tbxInkorg;
    }
}

