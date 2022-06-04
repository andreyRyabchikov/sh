using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sh5
{
    class storageCoord
    {
        public virtual double X { get; set; }
        public virtual double Y { get; set; }

        public Image image { get; set; }

        public storageCoord(Image image)
        {
            this.image = image;
        }

        public storageCoord(Image image, double x, double y)
        {
            this.image = image;
            X = x;
            Y = y;
        }
    }
}
