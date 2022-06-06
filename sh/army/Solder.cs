using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace army
{
    public class Solder : Human
    {
        string education;
        public Solder()
        {
            education = "начальное";
        }
        public void Read(string surname, double hight, double weight, string education)
        {
            base.Read(surname, hight, weight);
            this.education = education;
        }

        public override double QualityQ()
        {
            switch (education)
            {
                case "начальное":
                    return base.QualityQ() * 0.5;
                case "среднее":
                    return base.QualityQ();
                default:
                    return base.QualityQ() * 2;
            }
        }
        public override string ToString()
        {

            return base.ToString() + " Образование: " + education;
        }

    }
}
