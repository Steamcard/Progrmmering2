namespace Bataljonen_3._8
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("AQ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("EA");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("FA");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GA");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("HA");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("QL", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("BQ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bataljon", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("RL");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grbNyEnhet = new System.Windows.Forms.GroupBox();
            this.btnNyEnhet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSoldater = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.grbTabort = new System.Windows.Forms.GroupBox();
            this.tbxVald = new System.Windows.Forms.TextBox();
            this.btnTabort = new System.Windows.Forms.Button();
            this.grbNyEnhet.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.grbTabort.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "AQ";
            treeNode1.Text = "AQ";
            treeNode2.Name = "EA";
            treeNode2.Text = "EA";
            treeNode3.Name = "FA";
            treeNode3.Text = "FA";
            treeNode4.Name = "GA";
            treeNode4.Text = "GA";
            treeNode5.Name = "HA";
            treeNode5.Text = "HA";
            treeNode6.Name = "QL";
            treeNode6.Text = "QL";
            treeNode7.Name = "BQ";
            treeNode7.Text = "BQ";
            treeNode8.Name = "Bataljon";
            treeNode8.Text = "Bataljon";
            treeNode9.Name = "RL";
            treeNode9.Text = "RL";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(195, 328);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // grbNyEnhet
            // 
            this.grbNyEnhet.Controls.Add(this.btnNyEnhet);
            this.grbNyEnhet.Controls.Add(this.label2);
            this.grbNyEnhet.Controls.Add(this.label1);
            this.grbNyEnhet.Controls.Add(this.tbxSoldater);
            this.grbNyEnhet.Controls.Add(this.tbxNamn);
            this.grbNyEnhet.Location = new System.Drawing.Point(193, 12);
            this.grbNyEnhet.Name = "grbNyEnhet";
            this.grbNyEnhet.Size = new System.Drawing.Size(258, 135);
            this.grbNyEnhet.TabIndex = 1;
            this.grbNyEnhet.TabStop = false;
            this.grbNyEnhet.Text = "Lägg till ny enhet";
            // 
            // btnNyEnhet
            // 
            this.btnNyEnhet.Location = new System.Drawing.Point(100, 86);
            this.btnNyEnhet.Name = "btnNyEnhet";
            this.btnNyEnhet.Size = new System.Drawing.Size(144, 34);
            this.btnNyEnhet.TabIndex = 4;
            this.btnNyEnhet.Text = "Ny Enhet";
            this.btnNyEnhet.UseVisualStyleBackColor = true;
            this.btnNyEnhet.Click += new System.EventHandler(this.BtnNyEnhet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal soldater:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn:";
            // 
            // tbxSoldater
            // 
            this.tbxSoldater.Location = new System.Drawing.Point(100, 60);
            this.tbxSoldater.Name = "tbxSoldater";
            this.tbxSoldater.Size = new System.Drawing.Size(144, 20);
            this.tbxSoldater.TabIndex = 1;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(100, 34);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(144, 20);
            this.tbxNamn.TabIndex = 0;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.tbxOutput);
            this.grbInfo.Location = new System.Drawing.Point(193, 153);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(258, 165);
            this.grbInfo.TabIndex = 2;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Information om vald enhet";
            // 
            // tbxOutput
            // 
            this.tbxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbxOutput.Location = new System.Drawing.Point(6, 19);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(246, 140);
            this.tbxOutput.TabIndex = 2;
            // 
            // grbTabort
            // 
            this.grbTabort.Controls.Add(this.tbxVald);
            this.grbTabort.Controls.Add(this.btnTabort);
            this.grbTabort.Location = new System.Drawing.Point(458, 13);
            this.grbTabort.Name = "grbTabort";
            this.grbTabort.Size = new System.Drawing.Size(134, 98);
            this.grbTabort.TabIndex = 3;
            this.grbTabort.TabStop = false;
            this.grbTabort.Text = "Ta bort vald enhet";
            // 
            // tbxVald
            // 
            this.tbxVald.Location = new System.Drawing.Point(7, 25);
            this.tbxVald.Name = "tbxVald";
            this.tbxVald.ReadOnly = true;
            this.tbxVald.Size = new System.Drawing.Size(120, 20);
            this.tbxVald.TabIndex = 1;
            // 
            // btnTabort
            // 
            this.btnTabort.Location = new System.Drawing.Point(6, 56);
            this.btnTabort.Name = "btnTabort";
            this.btnTabort.Size = new System.Drawing.Size(121, 23);
            this.btnTabort.TabIndex = 0;
            this.btnTabort.Text = "Ta bort";
            this.btnTabort.UseVisualStyleBackColor = true;
            this.btnTabort.Click += new System.EventHandler(this.BtnTabort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 325);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grbTabort);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.grbNyEnhet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbNyEnhet.ResumeLayout(false);
            this.grbNyEnhet.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbTabort.ResumeLayout(false);
            this.grbTabort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox grbNyEnhet;
        private System.Windows.Forms.Button btnNyEnhet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSoldater;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.GroupBox grbTabort;
        private System.Windows.Forms.Button btnTabort;
        private System.Windows.Forms.TextBox tbxVald;
    }
}

