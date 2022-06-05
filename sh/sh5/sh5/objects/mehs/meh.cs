using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh5
{
    public abstract class meh : MoveObj,IMeh
    {
        private readonly List<cuadro> cuadros;
        private readonly object cuadroLocker;

        cuadro brokeCuadro;
        protected int speedRepair;
        protected string typeMeh;
        
        public meh(Action<string> messages, double startX, double startY, List<cuadro> cuadros, object cuadroLocker): base(messages, startX, startY)
        {
            countRepear = 0;
            this.cuadros = cuadros;
            this.cuadroLocker = cuadroLocker;
        }
        public int countRepear { get; set; }
        async Task repair()
        {
            if (endMove())
            {
                messages(typeMeh+" " + name + " чинит квадракоптер номер " + brokeCuadro.name);
                countRepear++;
                await Task.Delay(speedRepair);
                brokeCuadro.broke = false;
                brokeCuadro.isMove = true;
                messages("Квадракоптер номер "+ brokeCuadro.name+ " починен");
                messages(typeMeh + " " + name + " починил " + countRepear+" квадракоптер");
                task = null;
                isMove = false;
                moveX = startX;
                moveY = startY;
            }
        }
        protected override void checkEvents()
        {
            if (isMove)
                return;
            lock (cuadroLocker)
            {
                brokeCuadro = cuadros.FirstOrDefault(cuadro => cuadro.broke&& !cuadro.waitingForTheMech);
                if (brokeCuadro != null)
                {
                    brokeCuadro.waitingForTheMech = true;
                    moveX = brokeCuadro.x;
                    moveY = brokeCuadro.y-10;
                    isMove = true;
                    task = repair;
                    messages(typeMeh + " " + name + " пошёл чинить квадракоптер номер " + brokeCuadro.name);
                }
            }
        }
    }
}
