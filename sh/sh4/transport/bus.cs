using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh4
{
    public class bus : car
    {
        public int countTrips { get; set; }
        public int busNumber { get; set; }

        public bus(int busNumber)
        {
            this.busNumber = busNumber;
            countTrips = 0;
        }
        public bus()
        {
            this.busNumber = 65;
            countTrips = 0;
        }
        public void goToTrip()
        {
            countTrips++;
        }
        public void changeBusNumber(int busNumber)
        {
            if (busNumber > 0)
                this.busNumber = busNumber;
            else
                MessageBox.Show("Номер автобуса должен быть положителен");
        }
    }
}
