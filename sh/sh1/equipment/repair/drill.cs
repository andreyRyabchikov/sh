using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class drill : repairEquipment
    {
        int rotation_speed;
        string drill_type;
        public drill(string Name, int Power, int Rotation_speed, string Drill_type, int Noise_level)
        {
            power = Power;
            power_on = false;
            name = Name;
            rotation_speed = Rotation_speed;
            drill_type = Drill_type;
            is_heating = true;
            noise_level = Noise_level;
            type = "дрель";
        }
        void bore()
        {
            if (power_on)
                MessageBox.Show(name + " просверлил.");
            else
                MessageBox.Show(name + " Не включен в розетку.");
        }
    }
}
