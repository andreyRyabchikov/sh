using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sh5
{
    public abstract class obj
    {
        public double x { get; set; }
        public double y { get; set; }

        public bool isMove { get; set; }

        public bool isWork { get; set; }
        public abstract void start();

        public Action<string> messages;

        public obj(Action<string> messages)
        {
            this.messages = messages;
        }
    }
}
