using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh2
{
    class solder : human
    {
        string education;
        public solder()
        {
            education = "начальное";
        }
        public void read(string surname, double hight, double weight, string education)
        {
            base.read(surname, hight, weight);
            this.education = education;
        }

        public override double quality_q()
        {
            switch (education)
            {
                case "начальное":
                    return base.quality_q() * 0.5;
                case "среднее":
                    return base.quality_q();
                default:
                    return base.quality_q() * 2;
            }
        }
        public override string ToString()
        {

            return base.ToString() + " Образование: " + education;
        }

    }
}
