namespace t_l_4
{
    partial class Currency
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
            this.textBox_Gold = new System.Windows.Forms.TextBox();
            this.textBox_Euro = new System.Windows.Forms.TextBox();
            this.textBox_Dollar = new System.Windows.Forms.TextBox();
            this.checkBox_Gold = new System.Windows.Forms.CheckBox();
            this.checkBox_Euro = new System.Windows.Forms.CheckBox();
            this.checkBox_Dollar = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_Sur = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Gold);
            this.groupBox1.Controls.Add(this.textBox_Euro);
            this.groupBox1.Controls.Add(this.textBox_Dollar);
            this.groupBox1.Controls.Add(this.checkBox_Gold);
            this.groupBox1.Controls.Add(this.checkBox_Euro);
            this.groupBox1.Controls.Add(this.checkBox_Dollar);
            this.groupBox1.Location = new System.Drawing.Point(252, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Валюта";
            // 
            // textBox_Gold
            // 
            this.textBox_Gold.Location = new System.Drawing.Point(76, 117);
            this.textBox_Gold.Name = "textBox_Gold";
            this.textBox_Gold.Size = new System.Drawing.Size(188, 20);
            this.textBox_Gold.TabIndex = 6;
            this.textBox_Gold.Text = "0";
            // 
            // textBox_Euro
            // 
            this.textBox_Euro.Location = new System.Drawing.Point(76, 75);
            this.textBox_Euro.Name = "textBox_Euro";
            this.textBox_Euro.Size = new System.Drawing.Size(188, 20);
            this.textBox_Euro.TabIndex = 5;
            this.textBox_Euro.Text = "0";
            // 
            // textBox_Dollar
            // 
            this.textBox_Dollar.Location = new System.Drawing.Point(76, 33);
            this.textBox_Dollar.Name = "textBox_Dollar";
            this.textBox_Dollar.Size = new System.Drawing.Size(188, 20);
            this.textBox_Dollar.TabIndex = 4;
            this.textBox_Dollar.Text = "0";
            // 
            // checkBox_Gold
            // 
            this.checkBox_Gold.AutoSize = true;
            this.checkBox_Gold.Location = new System.Drawing.Point(22, 119);
            this.checkBox_Gold.Name = "checkBox_Gold";
            this.checkBox_Gold.Size = new System.Drawing.Size(48, 17);
            this.checkBox_Gold.TabIndex = 3;
            this.checkBox_Gold.Text = "Gold";
            this.checkBox_Gold.UseVisualStyleBackColor = true;
            this.checkBox_Gold.CheckedChanged += new System.EventHandler(this.checkBox_Gold_CheckedChanged);
            // 
            // checkBox_Euro
            // 
            this.checkBox_Euro.AutoSize = true;
            this.checkBox_Euro.Location = new System.Drawing.Point(22, 77);
            this.checkBox_Euro.Name = "checkBox_Euro";
            this.checkBox_Euro.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Euro.TabIndex = 2;
            this.checkBox_Euro.Text = "€";
            this.checkBox_Euro.UseVisualStyleBackColor = true;
            this.checkBox_Euro.CheckedChanged += new System.EventHandler(this.checkBox_Euro_CheckedChanged);
            // 
            // checkBox_Dollar
            // 
            this.checkBox_Dollar.AutoSize = true;
            this.checkBox_Dollar.Location = new System.Drawing.Point(22, 35);
            this.checkBox_Dollar.Name = "checkBox_Dollar";
            this.checkBox_Dollar.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Dollar.TabIndex = 1;
            this.checkBox_Dollar.Text = "$";
            this.checkBox_Dollar.UseVisualStyleBackColor = true;
            this.checkBox_Dollar.CheckedChanged += new System.EventHandler(this.checkBox_Dollar_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Sur);
            this.groupBox2.Location = new System.Drawing.Point(20, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 164);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фамилия";
            // 
            // listBox_Sur
            // 
            this.listBox_Sur.FormattingEnabled = true;
            this.listBox_Sur.Items.AddRange(new object[] {
            "Иванов",
            "Петров",
            "Сидоров"});
            this.listBox_Sur.Location = new System.Drawing.Point(14, 19);
            this.listBox_Sur.Name = "listBox_Sur";
            this.listBox_Sur.Size = new System.Drawing.Size(181, 134);
            this.listBox_Sur.TabIndex = 0;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Currency";
            this.Text = "Currency";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Gold;
        private System.Windows.Forms.CheckBox checkBox_Euro;
        private System.Windows.Forms.CheckBox checkBox_Dollar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox_Gold;
        public System.Windows.Forms.TextBox textBox_Euro;
        public System.Windows.Forms.TextBox textBox_Dollar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox listBox_Sur;
    }
}