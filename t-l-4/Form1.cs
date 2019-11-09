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
        private void Form1_Load(object sender, EventArgs e) { }
        private void Currency_Input()
        {
            Currency currency = new Currency();
            currency.ShowDialog();
            if (currency.listBox_Sur.SelectedItem.ToString() != "")
            {
                _Surname = currency.listBox_Sur.SelectedItem.ToString();
                _dollars = double.Parse(currency.textBox_Dollar.Text);   bank_dollars += _dollars;
                _euros   = double.Parse(currency.textBox_Euro.Text);     bank_euros   += _euros;
                _golds   = double.Parse(currency.textBox_Gold.Text);     bank_golds   += _golds;
                Table_Insert(_Surname, _dollars, _euros, 0, _golds);
            }
        }

        private void Dollar_Input()
        {
            Dollars_Single D_single = new Dollars_Single();
            D_single.ShowDialog();
            if (D_single.listBox_Sur.SelectedItem.ToString() != "")
            {
                _Surname = D_single.listBox_Sur.SelectedItem.ToString();
                _dollars = double.Parse(D_single.textBox_Dollar.Text);    bank_dollars += _dollars;
                Table_Insert(_Surname, _dollars, 0, 0, 0);
            }
        }

        private void Euro_Input()
        {
            Euros_Single E_single = new Euros_Single();
            E_single.ShowDialog();
            if (E_single.listBox_Sur.SelectedItem.ToString() != "")
            {
                _Surname = E_single.listBox_Sur.SelectedItem.ToString();  
                _euros = double.Parse(E_single.textBox_Euro.Text);        bank_euros += _euros;
                Table_Insert(_Surname, 0, _euros, 0, 0);
            }
        }
               
        private void Rub_Input()
        {
        Rubs_Single R_single = new Rubs_Single();
            R_single.ShowDialog();
            if (R_single.listBox_Sur.SelectedItem.ToString() != "")
            {
                _Surname = R_single.listBox_Sur.SelectedItem.ToString();
                _rubs = double.Parse(R_single.textBox_Rub.Text);          bank_rubs += _rubs;
                Table_Insert(_Surname, 0, 0, _rubs, 0);
            }
        }

        private void Gold_Input()
        {
            Golds_Single G_single = new Golds_Single();
            G_single.ShowDialog();
            if (G_single.listBox_Sur.SelectedItem.ToString() != "")
            {
                _Surname = G_single.listBox_Sur.SelectedItem.ToString();
                _golds = double.Parse(G_single.textBox_Gold.Text);       bank_golds += _golds;
                Table_Insert(_Surname, 0, 0, 0, _golds);
            }
        }

        private void Table_Insert(string _Surname, double _dollars, double _euros, double _rubs, double _golds)
        {
            
            int key = 0;    int index = 0;
            foreach (Human _human in Base)
            {

                if ((_human.surname == _Surname))
                {

                    _dollars += _human.dollars;     _human.dollars = _dollars;
                    _euros   += _human.euros;       _human.euros   = _euros;
                    _rubs    += _human.rubs;        _human.rubs    = _rubs;
                    _golds   += _human.golds;       _human.golds   = _golds;

                    _human.all_in_rubs = (_human.Kurs_dollar*_dollars)+(_human.Kurs_euro*_euros)+(_human.Kurs_gold*_golds)+_human.rubs;

                    for (int j = 0; j < allinbase; j++)
                    {
                        if (dataGridView_Total[0, j].Value.ToString() == _Surname)
                        {
                            index = j;
                        }
                    }

                    dataGridView_Total[1, index].Value = _dollars;
                    dataGridView_Total[2, index].Value = _euros;
                    dataGridView_Total[3, index].Value = _rubs;
                    dataGridView_Total[4, index].Value = _golds;
                    dataGridView_Total[5, index].Value = _human.all_in_rubs;
                    key = 1;
                    break;
                }
            }
            if (key == 0)
            {
                Human _human = new Human(_Surname, _dollars, _euros, _rubs, _golds);
                Base.Add(_human);
                allinbase++;
                _human.all_in_rubs = (_human.Kurs_dollar * _dollars) +
                     (_human.Kurs_euro * _euros) +
                     (_human.Kurs_gold * _golds) +
                     _human.rubs;
                dataGridView_Total.Rows.Insert(0, 1);
                dataGridView_Total[0, 0].Value = _Surname;  
                dataGridView_Total[1, 0].Value = _dollars;
                dataGridView_Total[2, 0].Value = _euros;
                dataGridView_Total[3, 0].Value = _rubs;
                dataGridView_Total[4, 0].Value = _golds;
                dataGridView_Total[5, 0].Value = _human.all_in_rubs;

            }
        } 
        private ArrayList Base = new ArrayList();
        
        string _Surname;
        double _dollars = 0, _euros = 0, _rubs = 0, _golds = 0;
        double bank_dollars = 0, bank_euros = 0, bank_rubs = 0, bank_golds = 0;
        int allinbase = 0;

        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // полная таблица валюты
        {
            Currency_Input();
        }

        private void Currency_Dollar_ToolStripMenuItem_Click(object sender, EventArgs e)    // Вкладка Доллар
        {
            Dollar_Input();
        }
        private void Currency_Euro_ToolStripMenuItem_Click(object sender, EventArgs e)      // Вкладка Евро
        {
            Euro_Input();
        }
        private void Rub_ToolStripMenuItem_Click(object sender, EventArgs e)                // Вкладка Рубли
        {
            Rub_Input();
        }
        private void Gold_ToolStripMenuItem_Click(object sender, EventArgs e)               // вкладка золото
        {
            Gold_Input();
        }


        private void toolStripButton_Dollar_Click(object sender, EventArgs e)   // иконка Доллары
        {
            Dollar_Input();
        }
        private void toolStripButton_Euro_Click(object sender, EventArgs e)     // иконка Евро
        {
            Euro_Input();
        }
        private void toolStripButton_Rub_Click(object sender, EventArgs e)      // иконка Рубли
        {
            Rub_Input();
        }
        private void toolStripButton_Gold_Click(object sender, EventArgs e)     // иконка золото
        {
            Gold_Input();
        }
    }
}
