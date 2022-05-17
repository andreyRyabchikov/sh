using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh3
{
    public abstract class car : transport_vehicle
    {
        public int mileage { get; set; }
        public int passenger { get; set; }
        public int max_passenger { get; set; }
        public string color { get; set; }
        public int fuel { get; set; }
        public car()
        {
            passenger = 0;
            max_passenger = 4;
            mileage = 0;
            fuel = 0;
            color = "white";
        }
        public void move(int km)
        {
            if (fuel - km > 0)
            {
                mileage += km;
                fuel -= km;
            }
            else
                MessageBox.Show("Не хватает топлива!");
        }
        public void load_passengers(int passengers)
        {
            if (passenger + passengers > max_passenger)
            {
                MessageBox.Show("Не удалось посадить пассажиров!");
            }
            else
                passenger += passengers;
        }
        public void repaint(string color)
        {
            this.color = color;
        }
        public void refuel(int litre)
        {
            fuel += litre;
        }
    }
}
