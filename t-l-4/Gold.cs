using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_l_4
{
    class Gold : Account
    {
        private static double Kurs = 3108270;
 //       private double golds = 0;

        public Gold(string surname, double golds) : base(surname)
        {
            this.golds = golds;
        }

        public double Golds
        {
            set
            {
                golds = value;
            }
            get
            {
                return golds;
            }
        }

        public override double To_Rub()
        {
            return golds * Kurs;
        }
        public override string Information()
        {
            return string.Format("{0,-20}{2,10:f2}" + "₽" + "{1,10:f2}" + "кг",
                                 surname, golds, To_Rub());
        }
    }
}
