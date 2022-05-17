using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class oven : kitchenEquipment
    {
        int max_temperature;
        bool grill;
        public oven(string Name, int Power, int Max_temperature, bool Grill, string Coat, string Food)
        {
            power = Power;
            power_on = false;
            name = Name;
            max_temperature = Max_temperature;
            grill = Grill;
            coat = Coat;
            food = Food;
            type = "печь";
        }
        void bake()
        {
            if (power_on)
                MessageBox.Show(name + " испек.");
            else
                MessageBox.Show(name + " Не включен в розетку.");
        }

    }
}
