using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class kettle : kitchenEquipment
    {
        bool water;
        bool hot_water;

        public kettle(string Name, int Power, string Coat, string Food)
        {
            power = Power;
            power_on = false;
            name = Name;
            water = false;
            hot_water = false;
            coat = Coat;
            food = Food;
            type = "чайник";
        }
        void boil_water()
        {
            if (power_on && water)
            {
                hot_water = true;
            }
            else
                if (!power_on)
                MessageBox.Show(name + " Не включен в розетку.");
            else
                MessageBox.Show(name + " Нет воды в чайнике.");
        }
        void fill_water()
        {
            water = true;
        }
    }
}
