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
            dollars,
            euros,
            rubs,
            golds,
            all_in_rubs;
        Account account;
        public Human(string surname, double dollars, double euros, double rubs, double golds, double all_in_rubs)
        {
            this.surname = surname;
            this.dollars = dollars;
            this.euros = euros;
            this.rubs = rubs;
            this.golds = golds;
            this.all_in_rubs = all_in_rubs;
        }
    }
}
