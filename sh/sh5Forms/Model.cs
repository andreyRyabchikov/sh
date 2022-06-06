using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Models;

namespace sh5Forms
{
    class Model : StorageCoord
    {
        public Obj Element { get; }

        public override double X { get => Element.X; }
        public override double Y { get => Element.Y; }

        public Model(Obj model, Image image): base(image)
        {
           Element = model;
        }
    }
}
