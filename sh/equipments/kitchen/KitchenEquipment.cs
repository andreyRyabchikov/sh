using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipment
{
    public abstract class KitchenEquipment : HouseholdEquipment
    {
        public string Food { get; set; }
        public string Coat { get; set; }


        public string CanCook()
        {
            return Food;
        }
        public string WhatIsCoating()
        {
            return Coat;
        }
    }
}
