using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t_l_4
{
    public partial class Currency : Form
    {
        public Currency()
        {
            InitializeComponent();
            textBox_Dollar.Enabled = false;
            textBox_Euro.Enabled = false;
            textBox_Gold.Enabled =  false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Dollar.Text = "";
            textBox_Euro.Text = "";
            textBox_Gold.Text = "";
        }

        private void checkBox_Dollar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Dollar.Checked)
            {
                textBox_Dollar.Enabled = true;
            }
            else
            {
                textBox_Dollar.Enabled = false;
            }
        }

        private void checkBox_Euro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Euro.Checked)
            {
                textBox_Euro.Enabled = true;
            }
            else
            {
                textBox_Euro.Enabled = false;
            }
        }

        private void checkBox_Gold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Gold.Checked)
            {
                textBox_Gold.Enabled = true;
            }
            else
            {
                textBox_Gold.Enabled = false;
            }
        }
    }
}
