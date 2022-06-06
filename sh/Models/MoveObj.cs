using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class MoveObj : Obj
    {
        protected double startX, startY;
        public double MoveX { get; set; }
        public double MoveY { get; set; }
        public MoveObj(Action<string> messages, double startX, double startY) : base(messages)
        {
            this.startX = startX;
            this.startY = startY;
            X = startX;
            Y = startY;
            MoveX = startX;
            MoveY = startY;
            task = null;
        }
        public string Name { get; set; }
        protected Func<Task> task;
        protected abstract void CheckEvents();
        public bool EndMove()
        {
            return Math.Abs(X - MoveX) < 5 && Math.Abs(Y - MoveY) < 5;
        }
        const int speed = 5;
        public void Move()
        {
            if (EndMove())
                return;

            if (Math.Abs(X - MoveX)  > 2)
            {
                Y += (3*(MoveY - Y) / Math.Abs(X - MoveX)) % speed;
                X += (3 * Math.Sign(MoveX - X)) % speed;
            }
            else
            {
                X += (3 * (MoveX - X) / Math.Abs(Y - MoveY))% speed;
                Y += (3 * Math.Sign(MoveY - Y)) % speed;
            }
        }

        public async override void Start()
        {
            while (!IsWork)
            {
                CheckEvents();
                Move();
                if (task != null)
                    await task();
                await Task.Delay(30);
            }
        }
    }
}
