using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace sh5
{
    class makeObj
    {
        Bitmap bitmap;
        private Graphics graphics;
        Timer timer;

        public makeObj(PictureBox pictureBox, Image backgroundImage, Font textFont,
                        List<storageCoord> viewObjects, object viewObjectsLocker,
                        List<model> viewModels, object viewModelsLocker)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(backgroundImage, 0, 0);


                lock (viewObjectsLocker)
                {
                    foreach (var item in viewObjects)
                    {
                        Draw(item);
                    }
                }

                lock (viewModelsLocker)
                {
                    foreach (var item in viewModels)
                    {
                        Draw(item);
                    }
                }

                pictureBox.Image = bitmap;
            });
        }

        void Draw(storageCoord viewObject)
        {
            graphics.DrawImage(viewObject.image,
                (float)viewObject.X - viewObject.image.Width / 2, (float)viewObject.Y - viewObject.image.Height / 2);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
