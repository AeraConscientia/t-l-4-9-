using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_l_4
{
    class Human
    {
        public string surname;

        public double
            Kurs_dollar = 64,
            Kurs_euro = 71,
            Kurs_gold = 3108270;

        public double
            dollars,
            euros,
            rubs,
            golds,
            all_in_rubs;

        public Human(string surname, double dollars, double euros, double rubs, double golds)//, double all_in_rubs)
        {
            this.surname = surname;
            this.dollars = dollars;
            this.euros = euros;
            this.rubs = rubs;
            this.golds = golds;
            all_in_rubs = (dollars * Kurs_dollar) + (euros * Kurs_euro) + (golds * Kurs_gold);
        }
    }
}
