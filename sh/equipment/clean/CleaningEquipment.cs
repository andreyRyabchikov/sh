using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    abstract class CleaningEquipment : HouseholdEquipment
    {
        public bool WetCleaning { get; set; }
        public int NoiseLevel { get; set; }
    }
}
