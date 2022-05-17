using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh1
{
    abstract class cleaningEquipment : householdEquipment
    {
        public bool wet_cleaning { get; set; }
        public int noise_level { get; set; }
    }
}
