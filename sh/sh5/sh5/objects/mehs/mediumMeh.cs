using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh5
{
    public class mediumMeh : meh
    {
        public mediumMeh(Action<string> messages, double startX, double startY, List<cuadro> cuadros, object cuadroLocker)
            : base(messages, startX, startY, cuadros, cuadroLocker)
        {
            speedRepair = 3000;
            typeMeh = "Средний механик";
        }
    }
}
