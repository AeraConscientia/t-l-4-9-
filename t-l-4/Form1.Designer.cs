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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_Dollar = new System.Windows.Forms.DataGridView();
            this.Column_Dollar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Euro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Rub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dollar)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
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
            this.Currency_Euro_ToolStripMenuItem});
            this.Currency_ToolStripMenuItem.Name = "Currency_ToolStripMenuItem";
            this.Currency_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Currency_ToolStripMenuItem.Text = "Валюта";
            // 
            // Currency_Dollar_ToolStripMenuItem
            // 
            this.Currency_Dollar_ToolStripMenuItem.Name = "Currency_Dollar_ToolStripMenuItem";
            this.Currency_Dollar_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Currency_Dollar_ToolStripMenuItem.Text = "Доллары";
            // 
            // Currency_Euro_ToolStripMenuItem
            // 
            this.Currency_Euro_ToolStripMenuItem.Name = "Currency_Euro_ToolStripMenuItem";
            this.Currency_Euro_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Currency_Euro_ToolStripMenuItem.Text = "Евро";
            // 
            // Rub_ToolStripMenuItem
            // 
            this.Rub_ToolStripMenuItem.Name = "Rub_ToolStripMenuItem";
            this.Rub_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Rub_ToolStripMenuItem.Text = "Рубли";
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
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(600, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // dataGridView_Dollar
            // 
            this.dataGridView_Dollar.AllowUserToOrderColumns = true;
            this.dataGridView_Dollar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Dollar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dollar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Dollar,
            this.Column_Euro,
            this.Column_Rub,
            this.Column_Gold});
            this.dataGridView_Dollar.Location = new System.Drawing.Point(23, 71);
            this.dataGridView_Dollar.Name = "dataGridView_Dollar";
            this.dataGridView_Dollar.Size = new System.Drawing.Size(553, 344);
            this.dataGridView_Dollar.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dataGridView_Dollar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dollar)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView dataGridView_Dollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Dollar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Euro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Rub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gold;
    }
}

