namespace Ovning3._6RichTextBox
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
            this.btnTecken = new System.Windows.Forms.Button();
            this.rbnLeft = new System.Windows.Forms.RadioButton();
            this.rbnCenter = new System.Windows.Forms.RadioButton();
            this.rbnRight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbColor = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rtfText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTecken
            // 
            this.btnTecken.Location = new System.Drawing.Point(29, 31);
            this.btnTecken.Name = "btnTecken";
            this.btnTecken.Size = new System.Drawing.Size(106, 23);
            this.btnTecken.TabIndex = 0;
            this.btnTecken.Text = "Teckensnitt";
            this.btnTecken.UseVisualStyleBackColor = true;
            this.btnTecken.Click += new System.EventHandler(this.btnTecken_Click);
            // 
            // rbnLeft
            // 
            this.rbnLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnLeft.AutoSize = true;
            this.rbnLeft.Checked = true;
            this.rbnLeft.Location = new System.Drawing.Point(162, 31);
            this.rbnLeft.Name = "rbnLeft";
            this.rbnLeft.Size = new System.Drawing.Size(53, 23);
            this.rbnLeft.TabIndex = 1;
            this.rbnLeft.TabStop = true;
            this.rbnLeft.Text = "Vänster";
            this.rbnLeft.UseVisualStyleBackColor = true;
            this.rbnLeft.CheckedChanged += new System.EventHandler(this.rbnLeft_CheckedChanged);
            // 
            // rbnCenter
            // 
            this.rbnCenter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnCenter.AutoSize = true;
            this.rbnCenter.Location = new System.Drawing.Point(221, 31);
            this.rbnCenter.Name = "rbnCenter";
            this.rbnCenter.Size = new System.Drawing.Size(48, 23);
            this.rbnCenter.TabIndex = 2;
            this.rbnCenter.Text = "Center";
            this.rbnCenter.UseVisualStyleBackColor = true;
            this.rbnCenter.CheckedChanged += new System.EventHandler(this.rbnCenter_CheckedChanged);
            // 
            // rbnRight
            // 
            this.rbnRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnRight.AutoSize = true;
            this.rbnRight.Location = new System.Drawing.Point(275, 31);
            this.rbnRight.Name = "rbnRight";
            this.rbnRight.Size = new System.Drawing.Size(46, 23);
            this.rbnRight.TabIndex = 3;
            this.rbnRight.Text = "Höger";
            this.rbnRight.UseVisualStyleBackColor = true;
            this.rbnRight.CheckedChanged += new System.EventHandler(this.rbnRight_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Textjustering";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ptbColor
            // 
            this.ptbColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ptbColor.Location = new System.Drawing.Point(343, 31);
            this.ptbColor.Name = "ptbColor";
            this.ptbColor.Size = new System.Drawing.Size(25, 23);
            this.ptbColor.TabIndex = 6;
            this.ptbColor.TabStop = false;
            this.ptbColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rtfText
            // 
            this.rtfText.Location = new System.Drawing.Point(12, 60);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(776, 288);
            this.rtfText.TabIndex = 7;
            this.rtfText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.rtfText);
            this.Controls.Add(this.ptbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnRight);
            this.Controls.Add(this.rbnCenter);
            this.Controls.Add(this.rbnLeft);
            this.Controls.Add(this.btnTecken);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTecken;
        private System.Windows.Forms.RadioButton rbnLeft;
        private System.Windows.Forms.RadioButton rbnCenter;
        private System.Windows.Forms.RadioButton rbnRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox rtfText;
    }
}

