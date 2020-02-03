namespace UserControl_3_11
{
    partial class LimitedTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxData1 = new System.Windows.Forms.TextBox();
            this.lblTextCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxData1
            // 
            this.tbxData1.Location = new System.Drawing.Point(34, 37);
            this.tbxData1.MaxLength = 140;
            this.tbxData1.Multiline = true;
            this.tbxData1.Name = "tbxData1";
            this.tbxData1.Size = new System.Drawing.Size(319, 69);
            this.tbxData1.TabIndex = 0;
            // 
            // lblTextCounter
            // 
            this.lblTextCounter.AutoSize = true;
            this.lblTextCounter.Location = new System.Drawing.Point(319, 109);
            this.lblTextCounter.Name = "lblTextCounter";
            this.lblTextCounter.Size = new System.Drawing.Size(31, 13);
            this.lblTextCounter.TabIndex = 1;
            this.lblTextCounter.Text = "(140)";
            this.lblTextCounter.Click += new System.EventHandler(this.lblTextCounter_Click);
            // 
            // LimitedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTextCounter);
            this.Controls.Add(this.tbxData1);
            this.Name = "LimitedTextBox";
            this.Size = new System.Drawing.Size(388, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxData1;
        private System.Windows.Forms.Label lblTextCounter;
    }
}
