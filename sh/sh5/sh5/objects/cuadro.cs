using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh5
{
    public class cuadro : MoveObj
    {
        private readonly object cuadroLocker;
        public bool broke { get; set; }
        public cuadro(Action<string> messages, object cuadroLocker, double startX, double startY) : base(messages, startX, startY) {
            this.cuadroLocker = cuadroLocker;
        }
        void startTheFlight()
        {

            lock (cuadroLocker)
            {
                moveY = startY - 300;
                isMove = true;
            }
        }
        async Task waitCuadroUp()
        {
            bool CuadroIsUp = false;

            while (!CuadroIsUp)
            {
                await Task.Delay(100);
                lock (cuadroLocker)
                {
                    CuadroIsUp = endMove();
                }
            }
        }
        async Task waitCuadroDown()
        {
            bool CuadroIsDown = false;
            while (!CuadroIsDown)
            {
                await Task.Delay(100);
                lock (cuadroLocker)
                {
                    CuadroIsDown = endMove();
                }
            }
        }
        public void endTheFlight()
        {
            messages("Полет квадракоптера номер " + name + " закончился");
            lock (cuadroLocker)
            {
                moveY = startY;
                moveX = startX;
            }
           
        }
        public bool waitingForTheMech { get; set; }
        private async Task brokeDown()
        {
            bool CuadroIsDown = false;
            moveX = x;
            moveY = startY;
            while (!CuadroIsDown)
            {
                await Task.Delay(100);
                lock (cuadroLocker)
                {
                    CuadroIsDown = endMove();
                }
            }
        }

        public async Task randomBroke()
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 10)
            {
                await brokeDown();
                messages("Сломан квадракоптер номер " + name);
                broke = true;
                waitingForTheMech = false;
            }
        }
        protected override void checkEvents()
        {
            if (!isMove)
            {
                moveX = startX;
                moveY = startY;
            }
        }
        async Task waitRepair()
        {
            do
            {
                await Task.Delay(100);
            } while (broke);
            startTheFlight();
            await waitCuadroUp();
        }
        public async Task fly()
        {
            startTheFlight();
            await waitCuadroUp();
            messages("Начинается полет квадракоптера номер " + name);
            var rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                moveX = rand.Next(50,700);
                moveY = rand.Next(50,(int)startY-200);
                await Task.Delay(400);
                await randomBroke();
                await waitRepair();
            }
            endTheFlight();
            await waitCuadroDown();
            isWork = false;
        }
    }
}
