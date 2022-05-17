using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    class hover : cleaningEquipment //пылесос
    {
        int bag_size;
        int handle_length;
        public hover(string Name, int Power, int Bag_size, int Handle_length, int Noise_level)
        {
            power = Power;
            power_on = false;
            name = Name;
            bag_size = Bag_size;
            handle_length = Handle_length;
            wet_cleaning = false;
            noise_level = Noise_level;
            type = "пылесос";
        }
        void vacuum()
        {
            if (power_on)
                MessageBox.Show(name + " пропылесосил.");
            else
                MessageBox.Show(name + " Не включен в розетку.");
        }
    }
}
