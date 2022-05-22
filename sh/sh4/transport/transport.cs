using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh4
{
    interface transportVehicle
    {
        int mileage { get; set; }
        int passenger { get; set; }
        int maxPassenger { get; }
        void move(int km);
        void loadPassengers(int passengers);

    }
}
