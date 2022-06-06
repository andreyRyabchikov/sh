using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SlowMeh:Meh
    {
        public SlowMeh(Action<string> messages, double startX, double startY, List<Quadrocopter> quadrocopters, object quadrocopterLocker)
            : base(messages, startX, startY,quadrocopters,quadrocopterLocker)
        {
            speedRepair = 5000;
            typeMeh = "Медленный механик";
        }    
    }
}
