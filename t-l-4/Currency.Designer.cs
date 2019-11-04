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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(22, 84);
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
            // 
            // textBox_Euro
            // 
            this.textBox_Euro.Location = new System.Drawing.Point(76, 75);
            this.textBox_Euro.Name = "textBox_Euro";
            this.textBox_Euro.Size = new System.Drawing.Size(188, 20);
            this.textBox_Euro.TabIndex = 5;
            // 
            // textBox_Dollar
            // 
            this.textBox_Dollar.Location = new System.Drawing.Point(76, 33);
            this.textBox_Dollar.Name = "textBox_Dollar";
            this.textBox_Dollar.Size = new System.Drawing.Size(188, 20);
            this.textBox_Dollar.TabIndex = 4;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(209, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Внести валюту";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(332, 24);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Gold;
        private System.Windows.Forms.TextBox textBox_Euro;
        private System.Windows.Forms.TextBox textBox_Dollar;
        private System.Windows.Forms.CheckBox checkBox_Gold;
        private System.Windows.Forms.CheckBox checkBox_Euro;
        private System.Windows.Forms.CheckBox checkBox_Dollar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}