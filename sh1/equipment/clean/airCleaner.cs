using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class airCleaner : cleaningEquipment
    {
        int filter_operation_time;
        int count_transmitted_air;
        public airCleaner(string Name, int Power, int Count_transmitted_air, int Filter_operation_time, int Noise_level)
        {
            power = Power;
            power_on = false;
            name = Name;
            count_transmitted_air = Count_transmitted_air;
            filter_operation_time = Filter_operation_time;
            wet_cleaning = false;
            noise_level = Noise_level;
            type = "очиститель воздуха";
        }
        void clean_air()
        {
            if (power_on)
                MessageBox.Show(name + " воздух очистил.");
            else
                MessageBox.Show(name + " Не включен в розетку.");
        }
    }
}
