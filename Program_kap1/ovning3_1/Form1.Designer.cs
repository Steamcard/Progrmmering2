﻿namespace ovning3_1
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(174, 96);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(425, 82);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "button1";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(174, 197);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(425, 73);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "button2";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(174, 296);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(425, 74);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "button3";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

