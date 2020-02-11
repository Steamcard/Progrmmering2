namespace LasEnBok_4_1
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
            this.tbxData = new System.Windows.Forms.TextBox();
            this.tbxRad1 = new System.Windows.Forms.TextBox();
            this.tbxRad2 = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mspArkiv = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxData
            // 
            this.tbxData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxData.Location = new System.Drawing.Point(12, 63);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(644, 312);
            this.tbxData.TabIndex = 0;
            // 
            // tbxRad1
            // 
            this.tbxRad1.Location = new System.Drawing.Point(273, 37);
            this.tbxRad1.Name = "tbxRad1";
            this.tbxRad1.Size = new System.Drawing.Size(121, 20);
            this.tbxRad1.TabIndex = 1;
            // 
            // tbxRad2
            // 
            this.tbxRad2.Location = new System.Drawing.Point(435, 37);
            this.tbxRad2.Name = "tbxRad2";
            this.tbxRad2.Size = new System.Drawing.Size(121, 20);
            this.tbxRad2.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(568, 34);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(78, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Ersätt";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "--->";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspArkiv});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mspArkiv
            // 
            this.mspArkiv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.toolStripSeparator1,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.toolStripSeparator2,
            this.stängToolStripMenuItem});
            this.mspArkiv.Name = "mspArkiv";
            this.mspArkiv.Size = new System.Drawing.Size(46, 20);
            this.mspArkiv.Text = "Arkiv";
            this.mspArkiv.Click += new System.EventHandler(this.MspArkiv_Click);
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nyttToolStripMenuItem.Text = "Nytt";
            this.nyttToolStripMenuItem.Click += new System.EventHandler(this.NyttToolStripMenuItem_Click);
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.ÖppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.SparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.SparaSomToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.StängToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbxRad2);
            this.Controls.Add(this.tbxRad1);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxData;
        private System.Windows.Forms.TextBox tbxRad1;
        private System.Windows.Forms.TextBox tbxRad2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mspArkiv;
        private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}

