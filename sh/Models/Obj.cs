using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Obj
    {
        public double X { get; set; }
        public double Y { get; set; }

        public bool IsMove { get; set; }

        public bool IsWork { get; set; }
        public abstract void Start();

        public Action<string> messages;

        public Obj(Action<string> messages)
        {
            this.messages = messages;
        }
    }
}
