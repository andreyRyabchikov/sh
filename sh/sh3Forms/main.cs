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
    public partial class main : Form
    {
        List<ITransportVehicle> ts;
        private void print_truck(DataGridView dg)
        {
            dg.RowCount = 1;
            int i = 0;
            foreach (Truck truck in ts)
            {
                dg.RowCount++;
                dg.Rows[i].HeaderCell.Value = i;
                dg.Rows[i].Cells[0].Value =truck.Weight-truck.EmptyWeight;
                dg.Rows[i].Cells[1].Value = truck.Weight;
                dg.Rows[i].Cells[2].Value = truck.LoadCapacity;
                dg.Rows[i].Cells[3].Value = truck.Fuel;
                dg.Rows[i].Cells[4].Value = truck.Mileage;
                i++;
            }
        }
        public main()
        {
            InitializeComponent();
            ts = new List<ITransportVehicle>();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderCell.Value = "Вес груза";
            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].HeaderCell.Value = "Вес грузовика";
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].HeaderCell.Value = "Максимальный вес";
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].HeaderCell.Value = "Топливо";
            dataGridView1.Columns[3].Width = 105;
            dataGridView1.Columns[4].HeaderCell.Value = "Пробег";
            dataGridView1.Columns[4].Width = 105;
            button1.Enabled = false;   
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fuel = Convert.ToInt32(textBox1.Text);
            if (fuel < 0||ts.Count==0)
                MessageBox.Show("Ошибка ввода, топлива меньше 0 или нет грузовиков");
            else
                foreach (Truck truck in ts)
                {
                    truck.Fuel += fuel;
                }
            print_truck(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int km = Convert.ToInt32(textBox4.Text);
            if (km < 0 || ts.Count == 0)
                MessageBox.Show("Ошибка ввода, путь меньше 0 или нет грузовиков");
            else
                foreach (Truck truck in ts)
                {
                    truck.Move(km);
                }
            print_truck(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kg = Convert.ToInt32(textBox3.Text);
            if (kg < 0 || ts.Count == 0)
                MessageBox.Show("Ошибка ввода, вес меньше 0 или нет грузовиков");
            else
                foreach (Truck truck in ts)
                {
                    truck.Unload(kg);
                }
            print_truck(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kg = Convert.ToInt32(textBox2.Text);
            if (kg < 0 || ts.Count == 0)
                MessageBox.Show("Ошибка ввода, вес меньше 0 или нет грузовиков");
            else
                foreach (Truck truck in ts)
                {
                    truck.Load(kg);
                }
            print_truck(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            this.Enabled = false;
            addTruck nf = new addTruck();
            nf.ShowDialog();
            ts.Add(nf.truck);
            this.Enabled = true;
            print_truck(dataGridView1);
        }
    }
}
