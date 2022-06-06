using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    class Kettle : KitchenEquipment
    {
        bool Water;
        bool HotWater;

        public Kettle(string Name, int Power, string Coat, string Food)
        {
            this.Power = Power;
            PowerOn = false;
            base.Name = Name;
            Water = false;
            HotWater = false;
            base.Coat = Coat;
            base.Food = Food;
            Type = "чайник";
        }
        string? BoilWater()
        {
            if (PowerOn && Water)
            {
                HotWater = true;
                return null;
            }
            else
                if (!PowerOn)
                return (Name + " Не включен в розетку.");
            else
                return (Name + " Нет воды в чайнике.");
        }
        void FillWater()
        {
            Water = true;
        }
    }
}
