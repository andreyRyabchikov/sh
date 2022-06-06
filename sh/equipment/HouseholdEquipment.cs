using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    abstract class HouseholdEquipment
    {
        public string Type { get; set; }
        public string Name { get; set; }
        private int power;
        public int Power { get { return PowerOn ? power : 0; } set { power = value;  } }
        public int RatedPower { get { return Power; } set { RatedPower = Power; } }
        public bool PowerOn { get; set; }
        public void Outlet()
        {
            PowerOn = !PowerOn;
        }

        public override string ToString()
        {
            return "Тип: " + Type + "\n\rНазвание: " + Name + "\n\rМощность: " + RatedPower;
        }
    }

}








