using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sh5
{

    public class Oper : Obj
    {
        public Quadrocopter quadrocopter;


        public Oper(Action<string> messages,double x, double y): base(messages)
        {
            base.X = x;
            base.Y = y;
            quadrocopter = null;
        }

        async Task FlightСontrol()
        {
            messages("Взлетает квадракоптер номер "+ quadrocopter.Name);
            await quadrocopter.Fly();
        }

       

        public override async void Start()
        {
            while (!IsWork)
            {
                messages("Начало полета квадракоптера номер "+ quadrocopter.Name);
                await Task.Delay(3000);
                await FlightСontrol();
                await Task.Delay(6000);
            }
        }
    }
}
