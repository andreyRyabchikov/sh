using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    public class SolderingIron : RepairEquipment //паяльник
    {
        int HeatingTemperature;
        int WorkingTimeRod;
        public SolderingIron(string Name, int Power, int HeatingTemperature, int WorkingTimeRod, int NoiseLevel)
        {
            this.Power = Power;
            this.PowerOn = false;
            this.Name = Name;
            this.HeatingTemperature = HeatingTemperature;
            this.WorkingTimeRod = WorkingTimeRod;
            this.IsHeating = true;
            this.NoiseLevel = NoiseLevel;
            this.Type = "паяльник";
        }
        string Solder()
        {
            if (PowerOn)
                return Name + " спаял.";
            else
                return Name + " Не включен в розетку." ;
        }
    }
}
