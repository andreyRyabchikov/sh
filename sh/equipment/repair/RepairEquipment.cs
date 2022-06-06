using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    abstract class RepairEquipment : HouseholdEquipment
    {
        protected bool IsHeating { get; set; }
        protected int NoiseLevel { get; set; }
    }
}
