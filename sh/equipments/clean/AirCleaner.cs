using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    public class AirCleaner : CleaningEquipment
    {
        int FilterOperationTime;
        int CountTransmittedAir;
        public AirCleaner(string Name, int Power, int CountTransmittedAir, int FilterOperationTime, int NoiseLevel)
        {
            this.Power = Power;
            PowerOn = false;
            base.Name = Name;
            this.CountTransmittedAir = CountTransmittedAir;
            this.FilterOperationTime = FilterOperationTime;
            WetCleaning = false;
            this.NoiseLevel = NoiseLevel;
            Type = "очиститель воздуха";
        }
        string CleanAir()
        {
            if (PowerOn)
                return (Name + " воздух очистил.");
            else
                return (Name + " Не включен в розетку.");
        }
    }
}
