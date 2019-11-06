using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_l_4
{
    abstract class Account
    {
        protected string surname;
        protected double dollars = 0;
        protected double euros = 0;
        protected double rubs = 0;
        protected double golds = 0;
        protected double all_in_rubs = 0;

        public Account(string surname)
        {
            this.surname = surname;
        }

        abstract public double To_Rub();

        abstract public string Information();
    }
}
