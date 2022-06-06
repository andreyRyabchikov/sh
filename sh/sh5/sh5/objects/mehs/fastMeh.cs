using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh5
{
    public class FastMeh : Meh
    {
        public FastMeh(Action<string> messages, double startX, double startY, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
    : base(messages, startX, startY, quadrocopters, quadrocopterLocker) 
        {
            speedRepair = 1000;
            typeMeh = "Быстрый механик";
        }
    }
}
