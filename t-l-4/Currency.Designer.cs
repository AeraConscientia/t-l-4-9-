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
            this.checkBox_Dollar = new System.Windows.Forms.CheckBox();
            this.checkBox_Euro = new System.Windows.Forms.CheckBox();
            this.checkBox_Rub = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox_Rub);
            this.groupBox1.Controls.Add(this.checkBox_Euro);
            this.groupBox1.Controls.Add(this.checkBox_Dollar);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Валюта";
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
            // 
            // checkBox_Rub
            // 
            this.checkBox_Rub.AutoSize = true;
            this.checkBox_Rub.Location = new System.Drawing.Point(22, 119);
            this.checkBox_Rub.Name = "checkBox_Rub";
            this.checkBox_Rub.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Rub.TabIndex = 3;
            this.checkBox_Rub.Text = "₽";
            this.checkBox_Rub.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 212);
            this.Controls.Add(this.groupBox1);
            this.Name = "Currency";
            this.Text = "Currency";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_Rub;
        private System.Windows.Forms.CheckBox checkBox_Euro;
        private System.Windows.Forms.CheckBox checkBox_Dollar;
    }
}