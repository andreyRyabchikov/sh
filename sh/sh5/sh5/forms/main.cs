using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace sh5
{
    public partial class main : Form
    {
        const int maxMehs = 10;
        const int maxOpers = 10;
        List<storageCoord> viewObjects;
        object viewObjectsLocker;
        List<model> viewModels;
        object viewModelsLocker;
        object cuadrosLocker;
        makeObj creator;
        List<oper> opers;
        List<cuadro> cuadros;
        List<string> messages;
        int countMehs;
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            countMehs = 0;
            viewObjects = new List<storageCoord>();
            viewObjectsLocker = new object();
            viewModels = new List<model>();
            viewModelsLocker = new object();
            cuadrosLocker= new object();
            cuadros = new List<cuadro>();
            opers = new List<oper>();
            messages = new List<string>();
            opers = new List<oper>();
            creator = new makeObj(pictureBox1, Properties.Resources.back,
               new Font(textBox1.Font.FontFamily, 10f, textBox1.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);
            creator.Start();

        }

        void message(string message)
        {
            textBox1.Invoke((MethodInvoker)delegate
            {
                messages.Add(message);

                if (messages.Count >= 15)
                {
                    messages = messages.GetRange(5, 9);

                    textBox1.Text = "";

                    foreach (var item in messages)
                    {
                        textBox1.Text += item + "\r\n";
                    }
                }

                textBox1.Text += message + "\r\n";
            });
        }


        private void вызватьОператораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float x = 50+opers.Count*50,y =380;
            opers.Add(new oper(message, x, y));
            lock (viewObjectsLocker)
            {
                viewObjects.Add(new storageCoord(Properties.Resources.oper, x, y));
            }

            
            opers[opers.Count() - 1].cuadro = new cuadro(message, cuadrosLocker, opers[opers.Count() - 1].x, opers[opers.Count() - 1].y);
            opers[opers.Count() - 1].cuadro.name= input("Введите название квадракоптера");
            Task.Run(opers[opers.Count() - 1].start);
            lock (viewModels)
            {
                viewModels.Add(new model(opers[opers.Count() - 1].cuadro, Properties.Resources.cuadro));
                cuadros.Add(opers[opers.Count() - 1].cuadro);
            }
            if (opers.Count() > maxOpers)
                вызватьоператораToolStripMenuItem.Enabled = false;
            Task.Run(opers[opers.Count() - 1].cuadro.start);
        }
        private void добавитьМеханикаToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        string input(string message)
        {
            read nf = new read(message);
            nf.ShowDialog();
            this.Enabled = true;

            return nf.tmp;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            creator.Stop();

            foreach (var item in opers)
            {
                item.isWork = true;
            }

            foreach (var item in viewModels)
            {
                if (item is model viewModel)
                    viewModel.Model.isWork = true;
            }
        }
        private void newMeh(meh meh)
        {
            countMehs++;
            meh.name = input("Введите имя механика");

            lock (viewModelsLocker)
            {
                viewModels.Add(new model(meh, Properties.Resources.meh));
            }
            if (countMehs > maxMehs)
                добавитьМеханикаToolStripMenuItem.Enabled = false;
            Task.Run(meh.start);
        }
        private void быстрыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastMeh meh = Activator.CreateInstance(typeof(fastMeh), new object[] 
            { (Action<string>)message, 740 + countMehs * 10, 340, cuadros, cuadrosLocker }) as fastMeh;
            newMeh(meh); 
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediumMeh meh = Activator.CreateInstance(typeof(mediumMeh), new object[] 
            { (Action<string>)message, 740 + countMehs * 10, 340, cuadros, cuadrosLocker }) as mediumMeh;
            newMeh(meh);
        }

        private void медленныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slowMeh meh = Activator.CreateInstance(typeof(slowMeh), new object[] 
            { (Action<string>)message, 740 + countMehs * 10, 340, cuadros, cuadrosLocker }) as slowMeh;
            newMeh(meh);
        }
    }
}
