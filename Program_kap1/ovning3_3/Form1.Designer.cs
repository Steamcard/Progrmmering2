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
            this.button2 = new System.Windows.Forms.Button();
            this.btnTecken = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
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
            this.btnFarg.UseVisualStyleBackColor = true;
            this.btnFarg.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(405, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Välj en mapp";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnTecken
            // 
            this.btnTecken.Location = new System.Drawing.Point(176, 295);
            this.btnTecken.Name = "btnTecken";
            this.btnTecken.Size = new System.Drawing.Size(405, 83);
            this.btnTecken.TabIndex = 2;
            this.btnTecken.Text = "Välj teckensnitt";
            this.btnTecken.UseVisualStyleBackColor = true;
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
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontColorToolStripMenuItem.Text = "FontColor";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColorToolStripMenuItem_Click);
            // 
            // allColorToolStripMenuItem
            // 
            this.allColorToolStripMenuItem.Name = "allColorToolStripMenuItem";
            this.allColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allColorToolStripMenuItem.Text = "AllColor";
            this.allColorToolStripMenuItem.Click += new System.EventHandler(this.AllColorToolStripMenuItem_Click);
            // 
            // btnMapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnTecken);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFarg);
            this.Name = "btnMapp";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFarg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTecken;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backcolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
    }
}

