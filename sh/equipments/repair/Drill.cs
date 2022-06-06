using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    public class Drill : RepairEquipment
    {
        private readonly int RotationSpeed;
        private readonly string DrillType;
        public Drill(string Name, int Power, int RotationSpeed, string DrillType, int NoiseLevel)
        {
            this.Power = Power;
            PowerOn = false;
            base.Name = Name;
            this.RotationSpeed = RotationSpeed;
            this.DrillType = DrillType;
            IsHeating = true;
            base.NoiseLevel = NoiseLevel;
            Type = "дрель";
        }
        string Bore()
        {
            if (PowerOn)
                return (Name + " просверлил.");
            else
                return (Name + " Не включен в розетку.");
        }
    }
}
