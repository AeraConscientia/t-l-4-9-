namespace t_l_4
{
    partial class Dollars_Single
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dollar = new System.Windows.Forms.TextBox();
            this.listBox_Sur = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Dollar);
            this.groupBox1.Location = new System.Drawing.Point(33, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(345, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // textBox_Dollar
            // 
            this.textBox_Dollar.Location = new System.Drawing.Point(64, 23);
            this.textBox_Dollar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Dollar.Name = "textBox_Dollar";
            this.textBox_Dollar.Size = new System.Drawing.Size(249, 22);
            this.textBox_Dollar.TabIndex = 4;
            // 
            // listBox_Sur
            // 
            this.listBox_Sur.FormattingEnabled = true;
            this.listBox_Sur.ItemHeight = 16;
            this.listBox_Sur.Items.AddRange(new object[] {
            "Иванов",
            "Петров",
            "Сидоров"});
            this.listBox_Sur.Location = new System.Drawing.Point(35, 42);
            this.listBox_Sur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Sur.Name = "listBox_Sur";
            this.listBox_Sur.Size = new System.Drawing.Size(344, 52);
            this.listBox_Sur.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.exit_ToolStripMenuItem.Text = "Внести и закрыть";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // Dollars_Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 181);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox_Sur);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dollars_Single";
            this.Text = "Dollars_Single";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox_Dollar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox_Sur;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
    }
}