using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh3
{
    interface transport_vehicle
    {
        int mileage { get; set; }
        int passenger { get; set; }
        int max_passenger { get; }
        void move(int km);
        void load_passengers(int passengers);

    }
}
