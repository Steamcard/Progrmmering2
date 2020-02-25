namespace UDPConnect
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
            this.components = new System.ComponentModel.Container();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.tbxPostnummer = new System.Windows.Forms.TextBox();
            this.gbxInkorg = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTag = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxInkorg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(6, 19);
            this.tbxMeddelande.Multiline = true;
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(236, 75);
            this.tbxMeddelande.TabIndex = 0;
            // 
            // tbxPostnummer
            // 
            this.tbxPostnummer.Location = new System.Drawing.Point(144, 30);
            this.tbxPostnummer.Name = "tbxPostnummer";
            this.tbxPostnummer.Size = new System.Drawing.Size(113, 20);
            this.tbxPostnummer.TabIndex = 1;
            // 
            // gbxInkorg
            // 
            this.gbxInkorg.Controls.Add(this.tbxMeddelande);
            this.gbxInkorg.Location = new System.Drawing.Point(15, 60);
            this.gbxInkorg.Name = "gbxInkorg";
            this.gbxInkorg.Size = new System.Drawing.Size(248, 100);
            this.gbxInkorg.TabIndex = 2;
            this.gbxInkorg.TabStop = false;
            this.gbxInkorg.Text = "Inkorg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serverns portnummer";
            // 
            // btnTag
            // 
            this.btnTag.Location = new System.Drawing.Point(15, 166);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(248, 23);
            this.btnTag.TabIndex = 4;
            this.btnTag.Text = "Tag emot";
            this.btnTag.UseVisualStyleBackColor = true;
            this.btnTag.Click += new System.EventHandler(this.BtnTag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 198);
            this.Controls.Add(this.btnTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxInkorg);
            this.Controls.Add(this.tbxPostnummer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInkorg.ResumeLayout(false);
            this.gbxInkorg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.TextBox tbxPostnummer;
        private System.Windows.Forms.GroupBox gbxInkorg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTag;
        private System.Windows.Forms.Timer timer1;
    }
}

