using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh1
{
    abstract class householdEquipment
    {
        public string type { get; set; }
        public string name { get; set; }
        
        private int Power;
        public int power { get { return power_on ? Power : 0; } set { Power = value; } }
        public int rated_power { get { return Power; } set { rated_power = Power; } }
        public bool power_on { get; set; }
        public void outlet()
        {
            power_on = !power_on;
        }

        public override string ToString()
        {
            return "Тип: " + type + "\n\rНазвание: " + name + "\n\rМощность: " + rated_power;
        }
    }

}


   
  
   
  
   

