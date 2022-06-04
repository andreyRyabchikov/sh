using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sh5
{

    public class oper : obj
    {
        public cuadro cuadro;


        public oper(Action<string> messages,double x, double y): base(messages)
        {
            base.x = x;
            base.y = y;
            cuadro = null;
        }

        async Task flightСontrol()
        {
            messages("Взлетает квадракоптер номер "+ cuadro.name);
            await cuadro.fly();
        }

       

        public override async void start()
        {
            while (!isWork)
            {
                messages("Начало полета квадракоптера номер "+ cuadro.name);
                await Task.Delay(3000);
                await flightСontrol();
                await Task.Delay(6000);
            }
        }
    }
}
