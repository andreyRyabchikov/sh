using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    class Hover : CleaningEquipment //пылесос
    {
        int BagSize;
        int HandleLength;
        public Hover(string Name, int Power, int BagSize, int HandleLength, int NoiseLevel)
        {
            this.Power = Power;
            PowerOn = false;
            base.Name = Name;
            this.BagSize = BagSize;
            this.HandleLength = HandleLength;
            WetCleaning = false;
            this.NoiseLevel = NoiseLevel;
            Type = "пылесос";
        }
        string Vacuum()
        {
            if (PowerOn)
                return (Name + " пропылесосил.");
            else
                return (Name + " Не включен в розетку.");
        }
    }
}
