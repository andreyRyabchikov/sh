using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sh5Forms
{
    class StorageCoord
    {
        public virtual double X { get; set; }
        public virtual double Y { get; set; }

        public Image image { get; set; }

        public StorageCoord(Image image)
        {
            this.image = image;
        }

        public StorageCoord(Image image, double x, double y)
        {
            this.image = image;
            X = x;
            Y = y;
        }
    }
}
