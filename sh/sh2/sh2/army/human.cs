using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh2
{
    class human
    {
        string surname;
        double hight;
        double weight;

        public human()
        {
            hight = 180;
            weight = 70;
            surname = "None";
        }
        public virtual void read(string surname,double hight,double weight)
        {
            this.surname = surname;
            this.hight = hight;
            this.weight = weight;
        }
        public virtual double quality_q()
        {
            return hight * weight;
        }
        public override string ToString()
        {
            return "Фамилия: " + surname + " Рост: " + hight + " Вес :" + weight;
        }

    }

}
