using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh4
{
    public class Bus : Car
    {
        public int CountTrips { get; set; }
        public int BusNumber { get; set; }

        public Bus(int busNumber)
        {
            this.BusNumber = busNumber;
            CountTrips = 0;
        }
        public Bus()
        {
            this.BusNumber = 65;
            CountTrips = 0;
        }
        public void GoToTrip()
        {
            CountTrips++;
        }
        public void ChangeBusNumber(int busNumber)
        {
            if (busNumber > 0)
                this.BusNumber = busNumber;
            else
                MessageBox.Show("Номер автобуса должен быть положителен");
        }
    }
}
