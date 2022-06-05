using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh5
{
    public abstract class MoveObj : obj
    {
        protected double startX, startY;
        public double moveX { get; set; }
        public double moveY { get; set; }
        public MoveObj(Action<string> messages, double startX, double startY) : base(messages)
        {
            this.startX = startX;
            this.startY = startY;
            x = startX;
            y = startY;
            moveX = startX;
            moveY = startY;
            task = null;
        }
        public string name { get; set; }
        protected Func<Task> task;
        protected abstract void checkEvents();
        public bool endMove()
        {
            return Math.Abs(x - moveX) < 5 && Math.Abs(y - moveY) < 5;
        }
        const int speed = 5;
        public void move()
        {
            if (endMove())
                return;

            if (Math.Abs(x - moveX)  > 2)
            {
                y += (3*(moveY - y) / Math.Abs(x - moveX)) % speed;
                x += (3 * Math.Sign(moveX - x)) % speed;
            }
            else
            {
                x += (3 * (moveX - x) / Math.Abs(y - moveY))% speed;
                y += (3 * Math.Sign(moveY - y)) % speed;
            }
        }

        public async override void start()
        {
            while (!isWork)
            {
                checkEvents();
                move();
                if (task != null)
                    await task();
                await Task.Delay(30);
            }
        }
    }
}
