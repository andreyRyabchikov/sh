using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Meh : MoveObj,IMeh
    {
        private readonly List<Quadrocopter> quadrocopters;
        private readonly object quadrocopterLocker;

        Quadrocopter brokeQuadrocopter;
        protected int speedRepair;
        protected string typeMeh;
        
        public Meh(Action<string> messages, double startX, double startY, List<Quadrocopter> Quadrocopters, object QuadrocopterLocker): base(messages, startX, startY)
        {
            CountRepear = 0;
            this.quadrocopters = Quadrocopters;
            this.quadrocopterLocker = QuadrocopterLocker;
        }
        public int CountRepear { get; set; }
        async Task Repair()
        {
            if (EndMove())
            {
                messages(typeMeh+" " + Name + " чинит квадракоптер номер " + brokeQuadrocopter.Name);
                CountRepear++;
                await Task.Delay(speedRepair);
                brokeQuadrocopter.broke = false;
                brokeQuadrocopter.IsMove = true;
                messages("Квадракоптер номер "+ brokeQuadrocopter.Name+ " починен");
                messages(typeMeh + " " + Name + " починил " + CountRepear+" квадракоптер");
                task = null;
                IsMove = false;
                MoveX = startX;
                MoveY = startY;
            }
        }
        protected override void CheckEvents()
        {
            if (IsMove)
                return;
            lock (quadrocopterLocker)
            {
                brokeQuadrocopter = quadrocopters.FirstOrDefault(Quadrocopter => Quadrocopter.broke&& !Quadrocopter.WaitingForTheMech);
                if (brokeQuadrocopter != null)
                {
                    brokeQuadrocopter.WaitingForTheMech = true;
                    MoveX = brokeQuadrocopter.X;
                    MoveY = brokeQuadrocopter.Y-10;
                    IsMove = true;
                    task = Repair;
                    messages(typeMeh + " " + Name + " пошёл чинить квадракоптер номер " + brokeQuadrocopter.Name);
                }
            }
        }
    }
}
