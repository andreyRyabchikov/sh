using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh1
{
    abstract class kitchenEquipment : householdEquipment
    {
        public string food { get; set; }
        public string coat { get; set; }


        public string can_cook()
        {
            return food;
        }
        public string what_is_coating()
        {
            return coat;
        }
    }
}
