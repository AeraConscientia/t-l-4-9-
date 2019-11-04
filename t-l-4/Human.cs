using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_l_4
{
    class Human
    {
        string surname;

        double
            dollars,
            euros,
            rubs,
            golds;

        public Human(string surname, double dollars, double euros, double rubs, double golds)
        {
            this.surname = surname;
            this.dollars = dollars;
            this.euros = euros;
            this.rubs = rubs;
        }
    }
}
