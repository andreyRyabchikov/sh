using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh4
{
    public class truck : car
    {
        public int loadCapacity { get; set; }
        public int countWheels { get; set; }
        public int weight { get; set; }
        public int emptyWeight { get; set; }
        public truck()
        {
            loadCapacity = 0;
            countWheels = 4;
            weight = 2000;
            emptyWeight = 2000;
        }
        public void load(int kg)
        {
            if (kg + weight > loadCapacity)
                MessageBox.Show("Перегруз!");
            else
                weight += kg;
        }
        public void unload(int kg)
        {
            if (weight - kg < emptyWeight)
                MessageBox.Show("Столько груза нет.");
            else
                weight -= kg;
        }
    }
}
