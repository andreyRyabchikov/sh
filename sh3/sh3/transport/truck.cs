using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh3
{
    public class truck : car
    {
        public int load_capacity { get; set; }
        public int count_wheels { get; set; }
        public int weight { get; set; }
        public int empty_weight { get; set; }
        public truck()
        {
            load_capacity = 0;
            count_wheels = 4;
            weight = 2000;
            empty_weight = 2000;
        }
        public void load(int kg)
        {
            if (kg + weight > load_capacity)
                MessageBox.Show("Перегруз!");
            else
                weight += kg;
        }
        public void unload(int kg)
        {
            if (weight - kg < empty_weight)
                MessageBox.Show("Столько груза нет.");
            else
                weight -= kg;
        }
    }
}
