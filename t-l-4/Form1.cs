using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_l_4
{
    /*
     * Привет)
     Привет, котя)
     Я люблю тебя)
     А я люблю тебя, счастье моё)
        
     Пссссс
     Как ты относишься ко всяким извращениям?)
     Например... МОЙ КОД
     погуляй... посмотри, что тут...
         */

        /*
            А я не против)
            Сейчас)

        Могу просто зипом кинуть
        Да лаааадно)


        */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void Table_Insert(string _Surname, double _dollars, double _euros, double _rubs, double _golds)
        {
            foreach (Human _human in Base)
            {
                //int Index;
                if (_human.surname == _Surname)
                {
                    //Index = Base.IndexOf(_human);
                    _dollars += _human.dollars;
                    _euros   += _human.euros;
                    _rubs    += _human.rubs;
                    _golds   += _human.golds;
                    Base.Remove(_human);
                    break;
                }
            }
            //Base.Remove(human);
            Human human = new Human(_Surname, _dollars, _euros, _rubs, _golds);
            Base.Add(human);
            //Base.Add(new Human(_Surname, _dollars, _euros, _rubs, _golds));
            dataGridView_Total.Rows.Insert(0, 1);
            dataGridView_Total[0, 0].Value = _Surname;
            dataGridView_Total[1, 0].Value = _dollars;          // ? Воть туть все классно, однако моня сразу сделать dataGridView_Total[1, 0].Value = double.Parse(currency.textBox_Dollar.Text);
            dataGridView_Total[2, 0].Value = _euros;            // если честно... Оно работает, я довольна. Боюсь все поломать...
            dataGridView_Total[3, 0].Value = _rubs;             // Я просто на будущее) Короче) Моня создать в дочерней форме Public переменные, добавить им Text поля объектов и передать в MainForm, воть
            dataGridView_Total[4, 0].Value = _golds;           //Тут просто наоборот)
        } // эээ... Ладушки. Но пусть пока так останется, хорошо? Ты можешь открыть ветку dev и все) Она для этого и нужна)
        // это-то да, но я хотела уже другим заняться (проверка на то, что человек уже в базе... Обновление его аккаунта, а не перезапись/создание дубляжа)
        //Я, кажется, сделал все, что хотел, думаю над 5 лабкой) Но...а что там хотят кроме фабрики? Dll? И Singletone? Так, а работа с графикой нужна, не помнишь?.. Значит, любая тема и фабрика с dll Еще один паттерн не помню... мозг немного того
        //окей... Я пока немнооого занята.                              Хм. Вроде, ничего...        Yep. Забыла про это            Ничего не слышала по этому поводу    Как-то так, да  Фабрика - абстрактная (для 5 лабы) Абстрактая + конкретная :) Я... не помню...
        // мне бы хоть эту лабу доделать Сегодня?..Завтра к 1 паре...
        //Физра...Ага....Больно, понимаю...Хорошо, не отвлекаю..Я люблю тебя.  Удачи.
       //... мне сдавать 4 в этот четверг... А еще кр по матану в пятницу. А переписывать можно только раз.
       // Я очень сильно тебя люблю. Спасибо тебе за все. Пожалуйста, пойми... Я люблю тебя всей душой.
        //Как и я тебя. Коммит всей переписки в master)   
        // ахаха, хорошо, моя любовь)
        // хм... может, я и пойду сейчас спать)
        public ArrayList Base = new ArrayList();
        string _Surname;
        double
            _dollars = 0,
            _euros = 0,
            _rubs = 0,
            _golds = 0;
       // Human human; // = new Human();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // полная таблица валюты
        {
            Currency currency = new Currency();
            currency.ShowDialog();
            _Surname = currency.listBox_Sur.SelectedItem.ToString();
            _dollars = double.Parse(currency.textBox_Dollar.Text);
            _euros   = double.Parse(currency.textBox_Euro.Text);
            _golds   = double.Parse(currency.textBox_Gold.Text);
            Table_Insert(_Surname, _dollars, _euros, 0, _golds);
        }

        private void Currency_Dollar_ToolStripMenuItem_Click(object sender, EventArgs e) // Вкладка Доллар
        {
            Dollars_Single D_single = new Dollars_Single();
            D_single.ShowDialog();
            _Surname = D_single.listBox_Sur.SelectedItem.ToString();
            _dollars = double.Parse(D_single.textBox_Dollar.Text);
            Table_Insert(_Surname, _dollars, 0, 0, 0);
        }

        private void Currency_Euro_ToolStripMenuItem_Click(object sender, EventArgs e) // Вкладка Евро
        {
            Euros_Single E_single = new Euros_Single();
            E_single.ShowDialog();
            _Surname = E_single.listBox_Sur.SelectedItem.ToString();
            _euros = double.Parse(E_single.textBox_Euro.Text);
            Table_Insert(_Surname, 0, _euros, 0, 0);
        }

        private void Rub_ToolStripMenuItem_Click(object sender, EventArgs e) // Вкладка Рубли
        {
            Rubs_Single R_single = new Rubs_Single();
            R_single.ShowDialog();
            _Surname = R_single.listBox_Sur.SelectedItem.ToString();
            _rubs = double.Parse(R_single.textBox_Rub.Text);
            Table_Insert(_Surname, 0, 0, _rubs, 0);
        }

        private void Gold_ToolStripMenuItem_Click(object sender, EventArgs e) // вкладка золото
        {
            Golds_Single G_single = new Golds_Single();
            G_single.ShowDialog();
            _Surname = G_single.listBox_Sur.SelectedItem.ToString();
            _golds = double.Parse(G_single.textBox_Gold.Text);
            Table_Insert(_Surname, 0, 0, 0, _golds);
        }



        private void toolStripButton_Dollar_Click(object sender, EventArgs e) // иконка Доллары
        {
            Dollars_Single D_single = new Dollars_Single();
            D_single.ShowDialog();
            _Surname = D_single.listBox_Sur.SelectedItem.ToString();
            _dollars = double.Parse(D_single.textBox_Dollar.Text);
            Table_Insert(_Surname, _dollars, 0, 0, 0);
        }
        private void toolStripButton_Euro_Click(object sender, EventArgs e) // иконка Евро
        {
            Euros_Single E_single = new Euros_Single();
            E_single.ShowDialog();
            _Surname = E_single.listBox_Sur.SelectedItem.ToString();
            _euros = double.Parse(E_single.textBox_Euro.Text);
            Table_Insert(_Surname, 0, _euros, 0, 0);
        }

        private void toolStripButton_Rub_Click(object sender, EventArgs e) // иконка Рубли
        {
            Rubs_Single R_single = new Rubs_Single();
            R_single.ShowDialog();
            _Surname = R_single.listBox_Sur.SelectedItem.ToString();
            _rubs = double.Parse(R_single.textBox_Rub.Text);
            Table_Insert(_Surname, 0, 0, _rubs, 0);
        }

        private void toolStripButton_Gold_Click(object sender, EventArgs e) // иконка золото
        {
            Golds_Single G_single = new Golds_Single();
            G_single.ShowDialog();
            _Surname = G_single.listBox_Sur.SelectedItem.ToString();
            _golds = double.Parse(G_single.textBox_Gold.Text);
            //_golds = double.Parse(G_single.textBox_Gold.Text);
            Table_Insert(_Surname, 0, 0, 0, _golds);
        }
    }
}
