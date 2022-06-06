using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MediumMeh : Meh
    {
        public MediumMeh(Action<string> messages, double startX, double startY, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
            : base(messages, startX, startY, quadrocopters, quadrocopterLocker)
        {
            speedRepair = 3000;
            typeMeh = "Средний механик";
        }
    }
}
