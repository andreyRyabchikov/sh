using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transport2
{
    public abstract class Car : ITransportVehicle
    {
        public int Mileage { get; set; }
        public int Passenger { get; set; }
        public int MaxPassenger { get; set; }
        public int Fuel { get; set; }
        public Car()
        {
            Passenger = 0;
            MaxPassenger = 4;
            Mileage = 0;
            Fuel = 0;
        }
        public void Move(int km)
        {
            if (Fuel - km > 0)
            {
                Mileage += km;
                Fuel -= km;
            }
            else
                MessageBox.Show("Не хватает топлива!");
        }
        public void LoadPassengers(int passengers)
        {
            if (Passenger + passengers > MaxPassenger)
            {
                MessageBox.Show("Не удалось посадить пассажиров!");
            }
            else
                Passenger += passengers;
        }
        public void Refuel(int litre)
        {
            Fuel += litre;
        }
    }
}
