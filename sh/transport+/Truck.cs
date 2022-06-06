using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transport2
{
    public class Truck : Car
    {
        public int LoadCapacity { get; set; }
        public int CountWheels { get; set; }
        public int Weight { get; set; }
        public int EmptyWeight { get; set; }
        public Truck()
        {
            LoadCapacity = 0;
            CountWheels = 4;
            Weight = 2000;
            EmptyWeight = 2000;
        }
        public void Load(int kg)
        {
            if (kg + Weight > LoadCapacity)
                MessageBox.Show("Перегруз!");
            else
                Weight += kg;
        }
        public void Unload(int kg)
        {
            if (Weight - kg < EmptyWeight)
                MessageBox.Show("Столько груза нет.");
            else
                Weight -= kg;
        }
    }
}
