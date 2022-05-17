using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class solderingIron : repairEquipment //паяльник
    {
        int heating_temperature;
        int working_time_rod;
        public solderingIron(string Name, int Power, int Heating_temperature, int Working_time_rod, int Noise_level)
        {
            power = Power;
            power_on = false;
            name = Name;
            heating_temperature = Heating_temperature;
            working_time_rod = Working_time_rod;
            is_heating = true;
            noise_level = Noise_level;
            type = "паяльник";
        }
        void solder()
        {
            if (power_on)
                MessageBox.Show(name + " спаял.");
            else
                MessageBox.Show(name + " Не включен в розетку.");
        }
    }
}
