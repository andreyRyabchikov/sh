using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh4
{
    public abstract class car : transportVehicle
    {
        public int mileage { get; set; }
        public int passenger { get; set; }
        public int maxPassenger { get; set; }
        public int fuel { get; set; }
        public car()
        {
            passenger = 0;
            maxPassenger = 4;
            mileage = 0;
            fuel = 0;
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
        public void loadPassengers(int passengers)
        {
            if (passenger + passengers > maxPassenger)
            {
                MessageBox.Show("Не удалось посадить пассажиров!");
            }
            else
                passenger += passengers;
        }
        public void refuel(int litre)
        {
            fuel += litre;
        }
    }
}
