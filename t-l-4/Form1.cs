using System;
using System.Collections;
using System.Windows.Forms;

namespace t_l_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        ArrayList Base = new ArrayList();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            currency.ShowDialog();
        }
    }
}
