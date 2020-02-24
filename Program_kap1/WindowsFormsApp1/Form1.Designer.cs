namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.tbxPost = new System.Windows.Forms.TextBox();
            this.gbxUtkorg = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.gbxUtkorg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servens IP-adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serverns portnummer";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(165, 44);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 20);
            this.tbxIP.TabIndex = 2;
            // 
            // tbxPost
            // 
            this.tbxPost.Location = new System.Drawing.Point(165, 85);
            this.tbxPost.Name = "tbxPost";
            this.tbxPost.Size = new System.Drawing.Size(100, 20);
            this.tbxPost.TabIndex = 3;
            // 
            // gbxUtkorg
            // 
            this.gbxUtkorg.Controls.Add(this.tbxMeddelande);
            this.gbxUtkorg.Controls.Add(this.btnSend);
            this.gbxUtkorg.Location = new System.Drawing.Point(12, 132);
            this.gbxUtkorg.Name = "gbxUtkorg";
            this.gbxUtkorg.Size = new System.Drawing.Size(299, 158);
            this.gbxUtkorg.TabIndex = 4;
            this.gbxUtkorg.TabStop = false;
            this.gbxUtkorg.Text = "Utkorg";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 127);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(287, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Sänd";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(6, 19);
            this.tbxMeddelande.Multiline = true;
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(287, 102);
            this.tbxMeddelande.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 299);
            this.Controls.Add(this.gbxUtkorg);
            this.Controls.Add(this.tbxPost);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxUtkorg.ResumeLayout(false);
            this.gbxUtkorg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.TextBox tbxPost;
        private System.Windows.Forms.GroupBox gbxUtkorg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMeddelande;
    }
}

