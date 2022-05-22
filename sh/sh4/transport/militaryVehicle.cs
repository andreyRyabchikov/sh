using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh4
{
    public class militaryVehicle : car
    {
        public int countBullets { get; set; }
        public int countMachinegun { get; set; }

        public militaryVehicle(int countMachinegun)
        {
            this.countMachinegun = countMachinegun;
            countBullets = 0;
        }
        public militaryVehicle()
        {
            this.countMachinegun = 2;
            countBullets = 0;
        }
        public void loadBullets(int bullets)
        {
            countBullets += bullets;
        }
        public void shoot()
        {
            while (countBullets > 0)
                countBullets -= countMachinegun;
            countBullets = 0;
        }
    }
}
