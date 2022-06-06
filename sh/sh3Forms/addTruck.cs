using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transport;

namespace sh3Forms
{

    public partial class addTruck : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public Truck truck;
        public addTruck()
        {
            InitializeComponent();
            truck = new Truck();
        }

        private void add_truck_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight= Convert.ToInt32(textBox2.Text), max_weight=Convert.ToInt32(textBox1.Text);
            if (weight < 0 || max_weight < weight)
            {
                MessageBox.Show("Ошибка ввода");
            }
            else
            {
                truck.LoadCapacity = max_weight;
                truck.Weight = weight;
                truck.EmptyWeight = weight;
                this.Close();
            }

        }
    }
}
