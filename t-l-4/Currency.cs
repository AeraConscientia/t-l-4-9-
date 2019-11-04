﻿using System;
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
            textBox_Euro.Enabled   = false;
            textBox_Gold.Enabled   = false;
        }

        double
            dollars = 0,
            euros = 0,
            golds = 0;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Dollar.Text = "";
            textBox_Euro.Text   = "";
            textBox_Gold.Text   = "";
            checkBox_Dollar.Checked = false;
            checkBox_Euro.Checked = false;
            checkBox_Gold.Checked = false;
        }

        private void checkBox_Dollar_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Dollar.Enabled = checkBox_Dollar.Checked;
        }

        private void checkBox_Euro_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Euro.Enabled = checkBox_Euro.Checked;
        }

        private void checkBox_Gold_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Gold.Enabled = checkBox_Gold.Checked;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            /*            if (checkBox_Euro.Checked)
                        {
                            euros = double.Parse(textBox_Euro.Text);
                        }
                        if (checkBox_Dollar.Checked)
                        {
                            dollars = double.Parse(textBox_Dollar.Text);
                        }
                        if (checkBox_Gold.Checked)
                        {
                            golds = double.Parse(textBox_Gold.Text);
                        }*/
        }
    }
}
