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
using Models;

namespace sh5Forms
{
    public partial class Main : Form
    {
        const int maxMehs = 10;
        const int maxOpers = 10;
        List<StorageCoord> viewObjects;
        object viewObjectsLocker;
        List<Model> viewModels;
        object viewModelsLocker;
        object QuadrocoptersLocker;
        MakeObj creator;
        List<Oper> opers;
        List<Quadrocopter> Quadrocopters;
        List<string> messages;
        int countMehs;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            countMehs = 0;
            viewObjects = new List<StorageCoord>();
            viewObjectsLocker = new object();
            viewModels = new List<Model>();
            viewModelsLocker = new object();
            QuadrocoptersLocker= new object();
            Quadrocopters = new List<Quadrocopter>();
            opers = new List<Oper>();
            messages = new List<string>();
            opers = new List<Oper>();
            creator = new MakeObj(pictureBox1, Properties.Resources.back,
               new Font(textBox1.Font.FontFamily, 10f, textBox1.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);
            creator.Start();

        }

        void Message(string message)
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


        private void ВызватьОператораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float x = 50+opers.Count*50,y =380;
            opers.Add(new Oper(Message, x, y));
            lock (viewObjectsLocker)
            {
                viewObjects.Add(new StorageCoord(Properties.Resources.oper, x, y));
            }

            
            opers[opers.Count() - 1].quadrocopter = new Quadrocopter(Message, QuadrocoptersLocker, opers[opers.Count() - 1].X, opers[opers.Count() - 1].Y);
            opers[opers.Count() - 1].quadrocopter.Name= Input("Введите название квадракоптера");
            Task.Run(opers[opers.Count() - 1].Start);
            lock (viewModels)
            {
                viewModels.Add(new Model(opers[opers.Count() - 1].quadrocopter, Properties.Resources.cuadro));
                Quadrocopters.Add(opers[opers.Count() - 1].quadrocopter);
            }
            if (opers.Count() > maxOpers)
                вызватьоператораToolStripMenuItem.Enabled = false;
            Task.Run(opers[opers.Count() - 1].quadrocopter.Start);
        }

        string Input(string message)
        {
            Read nf = new Read(message);
            nf.ShowDialog();
            this.Enabled = true;

            return nf.tmp;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            creator.Stop();

            foreach (var item in opers)
            {
                item.IsWork = true;
            }

            foreach (var item in viewModels)
            {
                if (item is Model viewModel)
                    viewModel.Element.IsWork = true;
            }
        }
        private void NewMeh(Meh meh)
        {
            countMehs++;
            meh.Name = Input("Введите имя механика");

            lock (viewModelsLocker)
            {
                viewModels.Add(new Model(meh, Properties.Resources.meh));
            }
            if (countMehs > maxMehs)
                добавитьМеханикаToolStripMenuItem.Enabled = false;
            Task.Run(meh.Start);
        }
        private void БыстрыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastMeh meh = Activator.CreateInstance(typeof(FastMeh), new object[] 
            { (Action<string>)Message, 740 + countMehs * 10, 340, Quadrocopters, QuadrocoptersLocker }) as FastMeh;
            NewMeh(meh); 
        }

        private void СреднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediumMeh meh = Activator.CreateInstance(typeof(MediumMeh), new object[] 
            { (Action<string>)Message, 740 + countMehs * 10, 340, Quadrocopters, QuadrocoptersLocker }) as MediumMeh;
            NewMeh(meh);
        }

        private void МедленныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlowMeh meh = Activator.CreateInstance(typeof(SlowMeh), new object[] 
            { (Action<string>)Message, 740 + countMehs * 10, 340, Quadrocopters, QuadrocoptersLocker }) as SlowMeh;
            NewMeh(meh);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
