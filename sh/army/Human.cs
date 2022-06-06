using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace army
{
    public class Human
    {
        string surname;
        double hight;
        double weight;

        public Human()
        {
            hight = 180;
            weight = 70;
            surname = "None";
        }
        public virtual void Read(string surname,double hight,double weight)
        {
            this.surname = surname;
            this.hight = hight;
            this.weight = weight;
        }
        public virtual double QualityQ()
        {
            return hight * weight;
        }
        public override string ToString()
        {
            return "Фамилия: " + surname + " Рост: " + hight + " Вес :" + weight;
        }

    }

}
