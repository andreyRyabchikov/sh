using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace sh5
{
    class model : storageCoord
    {
        public obj Model { get; }

        public override double X { get => Model.x; }
        public override double Y { get => Model.y; }

        public model(obj model, Image image): base(image)
        {
           Model = model;
        }
    }
}
