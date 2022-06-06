using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Quadrocopter : MoveObj
    {
        private readonly object quadrocopterLocker;
        public bool broke { get; set; }
        public bool WaitingForTheMech { get; set; }
        public Quadrocopter(Action<string> messages, object quadrocopterLocker, double startX, double startY) : base(messages, startX, startY) {
            this.quadrocopterLocker = quadrocopterLocker;
        }
        void StartTheFlight()
        {

            lock (quadrocopterLocker)
            {
                MoveY = startY - 300;
                IsMove = true;
            }
        }
        async Task WaitQuadrocopterUp()
        {
            bool quadrocopterIsUp = false;

            while (!quadrocopterIsUp)
            {
                await Task.Delay(100);
                lock (quadrocopterLocker)
                {
                    quadrocopterIsUp = EndMove();
                }
            }
        }
        async Task WaitQuadrocopterDown()
        {
            bool quadrocopterIsDown = false;
            while (!quadrocopterIsDown)
            {
                await Task.Delay(100);
                lock (quadrocopterLocker)
                {
                    quadrocopterIsDown = EndMove();
                }
            }
        }
        public void EndTheFlight()
        {
            messages("Полет квадракоптера номер " + Name + " закончился");
            lock (quadrocopterLocker)
            {
                MoveY = startY;
                MoveX = startX;
            }
           
        }

        private async Task BrokeDown()
        {
            bool quadrocopterIsDown = false;
            MoveX = X;
            MoveY = startY;
            while (!quadrocopterIsDown)
            {
                await Task.Delay(100);
                lock (quadrocopterLocker)
                {
                    quadrocopterIsDown = EndMove();
                }
            }
        }

        public async Task RandomBroke()
        {
            Random rand = new Random();
            if (rand.Next(0, 100) < 10)
            {
                await BrokeDown();
                messages("Сломан квадракоптер номер " + Name);
                broke = true;
                WaitingForTheMech = false;
            }
        }
        protected override void CheckEvents()
        {
            if (!IsMove)
            {
                MoveX = startX;
                MoveY = startY;
            }
        }
        async Task WaitRepair()
        {
            do
            {
                await Task.Delay(100);
            } while (broke);
            StartTheFlight();
            await WaitQuadrocopterUp();
        }
        public async Task Fly()
        {
            StartTheFlight();
            await WaitQuadrocopterUp();
            messages("Начинается полет квадракоптера номер " + Name);
            var rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                MoveX = rand.Next(50,700);
                MoveY = rand.Next(50,(int)startY-200);
                await Task.Delay(400);
                await RandomBroke();
                await WaitRepair();
            }
            EndTheFlight();
            await WaitQuadrocopterDown();
            IsWork = false;
        }
    }
}
