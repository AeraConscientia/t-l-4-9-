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

        public void Table_Insert()
        {
            Base.Add(new Human(_Surname, _dollars, _euros, _rubs, _golds));
            dataGridView_Total.Rows.Insert(0, 1);
            dataGridView_Total[0, 0].Value = _Surname;
            dataGridView_Total[1, 0].Value = _dollars;
            dataGridView_Total[2, 0].Value = _euros;
            dataGridView_Total[3, 0].Value = _rubs;
            dataGridView_Total[4, 0].Value = _golds;
        }

        public ArrayList Base = new ArrayList();
        string _Surname;
        double
            _dollars = 0,
            _euros = 0,
            _rubs = 0,
            _golds = 0;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // полная таблица
        {
            Currency currency = new Currency();
            currency.ShowDialog();
            _Surname = currency.listBox_Sur.SelectedItem.ToString();
            _dollars = double.Parse(currency.textBox_Dollar.Text);
            _euros   = double.Parse(currency.textBox_Euro.Text);
            _golds   = double.Parse(currency.textBox_Gold.Text);
            Table_Insert();
        }

        private void Currency_Dollar_ToolStripMenuItem_Click(object sender, EventArgs e) // Вкладка Доллар
        {
            Dollars_Single D_single = new Dollars_Single();
            D_single.ShowDialog();
            _Surname = D_single.listBox_Sur.SelectedItem.ToString();
            _dollars = double.Parse(D_single.textBox_Dollar.Text);
            Table_Insert();
        }

        private void Currency_Euro_ToolStripMenuItem_Click(object sender, EventArgs e) // Вкладка Евро
        {
            Euros_Single E_single = new Euros_Single();
            E_single.ShowDialog();
            _Surname = E_single.listBox_Sur.SelectedItem.ToString();
            _euros = double.Parse(E_single.textBox_Euro.Text);
            Table_Insert();
        }

        private void Rub_ToolStripMenuItem_Click(object sender, EventArgs e) // Вкладка Рубли
        {
            Rubs_Single R_single = new Rubs_Single();
            R_single.ShowDialog();
            _Surname = R_single.listBox_Sur.SelectedItem.ToString();
            _rubs = double.Parse(R_single.textBox_Rub.Text);
            Table_Insert();
        }

        private void toolStripButton_Dollar_Click(object sender, EventArgs e) // иконка Доллары
        {
            Dollars_Single D_single = new Dollars_Single();
            D_single.ShowDialog();
            _Surname = D_single.listBox_Sur.SelectedItem.ToString();
            _dollars = double.Parse(D_single.textBox_Dollar.Text);
            Table_Insert();
        }

        private void toolStripButton_Euro_Click(object sender, EventArgs e) // иконка Евро
        {
            Euros_Single E_single = new Euros_Single();
            E_single.ShowDialog();
            _Surname = E_single.listBox_Sur.SelectedItem.ToString();
            _euros = double.Parse(E_single.textBox_Euro.Text);
            Table_Insert();
        }

        private void toolStripButton_Rub_Click(object sender, EventArgs e) // Иконка Рубли
        {
            Rubs_Single R_single = new Rubs_Single();
            R_single.ShowDialog();
            _Surname = R_single.listBox_Sur.SelectedItem.ToString();
            _rubs = double.Parse(R_single.textBox_Rub.Text);
            Table_Insert();
        }
    }
}
