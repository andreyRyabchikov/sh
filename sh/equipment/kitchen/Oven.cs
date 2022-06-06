using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    class Oven : KitchenEquipment
    {
        int MaxTemperature;
        bool Grill;
        public Oven(string Name, int Power, int MaxTemperature, bool Grill, string Coat, string Food)
        {
            this.Power = Power;
            PowerOn = false;
            base.Name = Name;
            this.MaxTemperature = MaxTemperature;
            this.Grill = Grill;
            this.Coat = Coat;
            base.Food = Food;
            Type = "печь";
        }
        string Bake()
        {
            if (PowerOn)
                return (Name + " испек.");
            else
                return (Name + " Не включен в розетку.");
        }

    }
}
