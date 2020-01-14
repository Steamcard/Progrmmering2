namespace ovning3_3
{
    partial class btnMapp
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
            this.btnFarg = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFarg
            // 
            this.btnFarg.ContextMenuStrip = this.contextMenuStrip1;
            this.btnFarg.Location = new System.Drawing.Point(176, 71);
            this.btnFarg.Name = "btnFarg";
            this.btnFarg.Size = new System.Drawing.Size(405, 70);
            this.btnFarg.TabIndex = 0;
            this.btnFarg.Text = "Välj en färg";
            this.toolTip1.SetToolTip(this.btnFarg, "Välj en färg");
            this.btnFarg.UseVisualStyleBackColor = true;
            this.btnFarg.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backcolorToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.allColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // backcolorToolStripMenuItem
            // 
            this.backcolorToolStripMenuItem.Name = "backcolorToolStripMenuItem";
            this.backcolorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.backcolorToolStripMenuItem.Text = "Backcolor";
            this.backcolorToolStripMenuItem.Click += new System.EventHandler(this.BackcolorToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fontColorToolStripMenuItem.Text = "FontColor";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColorToolStripMenuItem_Click);
            // 
            // allColorToolStripMenuItem
            // 
            this.allColorToolStripMenuItem.Name = "allColorToolStripMenuItem";
            this.allColorToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.allColorToolStripMenuItem.Text = "AllColor";
            this.allColorToolStripMenuItem.Click += new System.EventHandler(this.AllColorToolStripMenuItem_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(176, 178);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(405, 78);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Välj en mapp";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(176, 295);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(405, 83);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Välj teckensnitt";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnTecken_Click);
            // 
            // btnMapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnFarg);
            this.Name = "btnMapp";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFarg;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backcolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

