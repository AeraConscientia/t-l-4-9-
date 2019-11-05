namespace t_l_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contibution_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Currency_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Currency_Dollar_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Currency_Euro_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rub_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийСчетБанкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Dollar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Euro = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Rub = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Gold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Currency = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_Total = new System.Windows.Forms.DataGridView();
            this.Column_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Dollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Euro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Rub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_All_int_Rub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gold_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Total)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_ToolStripMenuItem,
            this.Contibution_ToolStripMenuItem,
            this.общийСчетБанкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.Exit_ToolStripMenuItem.Text = "Выход";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Contibution_ToolStripMenuItem
            // 
            this.Contibution_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Currency_ToolStripMenuItem,
            this.Rub_ToolStripMenuItem});
            this.Contibution_ToolStripMenuItem.Name = "Contibution_ToolStripMenuItem";
            this.Contibution_ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.Contibution_ToolStripMenuItem.Text = "Внос средств";
            // 
            // Currency_ToolStripMenuItem
            // 
            this.Currency_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Currency_Dollar_ToolStripMenuItem,
            this.Currency_Euro_ToolStripMenuItem,
            this.Gold_ToolStripMenuItem});
            this.Currency_ToolStripMenuItem.Name = "Currency_ToolStripMenuItem";
            this.Currency_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Currency_ToolStripMenuItem.Text = "Валюта";
            // 
            // Currency_Dollar_ToolStripMenuItem
            // 
            this.Currency_Dollar_ToolStripMenuItem.Name = "Currency_Dollar_ToolStripMenuItem";
            this.Currency_Dollar_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Currency_Dollar_ToolStripMenuItem.Text = "Доллары";
            this.Currency_Dollar_ToolStripMenuItem.Click += new System.EventHandler(this.Currency_Dollar_ToolStripMenuItem_Click);
            // 
            // Currency_Euro_ToolStripMenuItem
            // 
            this.Currency_Euro_ToolStripMenuItem.Name = "Currency_Euro_ToolStripMenuItem";
            this.Currency_Euro_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Currency_Euro_ToolStripMenuItem.Text = "Евро";
            this.Currency_Euro_ToolStripMenuItem.Click += new System.EventHandler(this.Currency_Euro_ToolStripMenuItem_Click);
            // 
            // Rub_ToolStripMenuItem
            // 
            this.Rub_ToolStripMenuItem.Name = "Rub_ToolStripMenuItem";
            this.Rub_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Rub_ToolStripMenuItem.Text = "Рубли";
            this.Rub_ToolStripMenuItem.Click += new System.EventHandler(this.Rub_ToolStripMenuItem_Click);
            // 
            // общийСчетБанкаToolStripMenuItem
            // 
            this.общийСчетБанкаToolStripMenuItem.Name = "общийСчетБанкаToolStripMenuItem";
            this.общийСчетБанкаToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.общийСчетБанкаToolStripMenuItem.Text = "Общий счет банка";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Dollar,
            this.toolStripButton_Euro,
            this.toolStripButton_Rub,
            this.toolStripButton_Gold,
            this.toolStripButton_Currency});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(731, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_Dollar
            // 
            this.toolStripButton_Dollar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Dollar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Dollar.Image")));
            this.toolStripButton_Dollar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Dollar.Name = "toolStripButton_Dollar";
            this.toolStripButton_Dollar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Dollar.Text = "toolStripButton1";
            this.toolStripButton_Dollar.Click += new System.EventHandler(this.toolStripButton_Dollar_Click);
            // 
            // toolStripButton_Euro
            // 
            this.toolStripButton_Euro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Euro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Euro.Image")));
            this.toolStripButton_Euro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Euro.Name = "toolStripButton_Euro";
            this.toolStripButton_Euro.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Euro.Text = "toolStripButton2";
            this.toolStripButton_Euro.Click += new System.EventHandler(this.toolStripButton_Euro_Click);
            // 
            // toolStripButton_Rub
            // 
            this.toolStripButton_Rub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Rub.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Rub.Image")));
            this.toolStripButton_Rub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rub.Name = "toolStripButton_Rub";
            this.toolStripButton_Rub.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Rub.Text = "toolStripButton3";
            this.toolStripButton_Rub.Click += new System.EventHandler(this.toolStripButton_Rub_Click);
            // 
            // toolStripButton_Gold
            // 
            this.toolStripButton_Gold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Gold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Gold.Image")));
            this.toolStripButton_Gold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Gold.Name = "toolStripButton_Gold";
            this.toolStripButton_Gold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Gold.Text = "toolStripButton4";
            this.toolStripButton_Gold.Click += new System.EventHandler(this.toolStripButton_Gold_Click);
            // 
            // toolStripButton_Currency
            // 
            this.toolStripButton_Currency.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Currency.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Currency.Image")));
            this.toolStripButton_Currency.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Currency.Name = "toolStripButton_Currency";
            this.toolStripButton_Currency.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Currency.Text = "toolStripButton5";
            this.toolStripButton_Currency.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // dataGridView_Total
            // 
            this.dataGridView_Total.AllowUserToOrderColumns = true;
            this.dataGridView_Total.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Total.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Surname,
            this.Column_Dollar,
            this.Column_Euro,
            this.Column_Rub,
            this.Column_Gold,
            this.Column_All_int_Rub});
            this.dataGridView_Total.Location = new System.Drawing.Point(23, 71);
            this.dataGridView_Total.Name = "dataGridView_Total";
            this.dataGridView_Total.Size = new System.Drawing.Size(684, 344);
            this.dataGridView_Total.TabIndex = 2;
            // 
            // Column_Surname
            // 
            this.Column_Surname.HeaderText = "Фамилия";
            this.Column_Surname.Name = "Column_Surname";
            // 
            // Column_Dollar
            // 
            this.Column_Dollar.HeaderText = "Dollar";
            this.Column_Dollar.Name = "Column_Dollar";
            // 
            // Column_Euro
            // 
            this.Column_Euro.HeaderText = "Euro";
            this.Column_Euro.Name = "Column_Euro";
            // 
            // Column_Rub
            // 
            this.Column_Rub.HeaderText = "Rub";
            this.Column_Rub.Name = "Column_Rub";
            // 
            // Column_Gold
            // 
            this.Column_Gold.HeaderText = "Gold";
            this.Column_Gold.Name = "Column_Gold";
            // 
            // Column_All_int_Rub
            // 
            this.Column_All_int_Rub.HeaderText = "Всего в рублях";
            this.Column_All_int_Rub.Name = "Column_All_int_Rub";
            // 
            // Gold_ToolStripMenuItem
            // 
            this.Gold_ToolStripMenuItem.Name = "Gold_ToolStripMenuItem";
            this.Gold_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Gold_ToolStripMenuItem.Text = "Золото";
            this.Gold_ToolStripMenuItem.Click += new System.EventHandler(this.Gold_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(731, 436);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridView_Total);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Contibution_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийСчетБанкаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripMenuItem Currency_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Currency_Dollar_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Currency_Euro_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rub_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_Dollar;
        private System.Windows.Forms.ToolStripButton toolStripButton_Euro;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rub;
        private System.Windows.Forms.ToolStripButton toolStripButton_Gold;
        private System.Windows.Forms.DataGridView dataGridView_Total;
        private System.Windows.Forms.ToolStripButton toolStripButton_Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Euro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Rub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_All_int_Rub;
        private System.Windows.Forms.ToolStripMenuItem Gold_ToolStripMenuItem;
    }
}

