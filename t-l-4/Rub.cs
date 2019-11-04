using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_l_4
{
    class Rub : Account
    {

        public Rub(string surname, double rubs) : base(surname)
        {
            this.rubs = rubs;
        }

        public double Rubs
        {
            set
            {
                rubs = value;
            }
            get
            {
                return rubs;
            }
        }

        public override double To_Rub()
        {
            return rubs;
        }
        public override string Information()
        {
            return string.Format("{0,-20}{2,10:f2}" + "₽" + "{1,10:f2}" + "₽",
                                 surname, rubs, To_Rub());
        }
    }
}
