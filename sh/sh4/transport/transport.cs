using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh4
{
    interface ITransportVehicle
    {
        int Mileage { get; set; }
        int Passenger { get; set; }
        int MaxPassenger { get; }
        void Move(int km);
        void LoadPassengers(int passengers);

    }
}
