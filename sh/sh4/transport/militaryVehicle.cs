using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh4
{
    public class MilitaryVehicle : Car
    {
        public int CountBullets { get; set; }
        public int CountMachinegun { get; set; }

        public MilitaryVehicle(int countMachinegun)
        {
            this.CountMachinegun = countMachinegun;
            CountBullets = 0;
        }
        public MilitaryVehicle()
        {
            this.CountMachinegun = 2;
            CountBullets = 0;
        }
        public void LoadBullets(int bullets)
        {
            CountBullets += bullets;
        }
        public void Shoot()
        {
            while (CountBullets > 0)
                CountBullets -= CountMachinegun;
            CountBullets = 0;
        }
    }
}
