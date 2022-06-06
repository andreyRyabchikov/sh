using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using equipment;

namespace sh1Forms
{
    public partial class main : Form
    {
        Equipment eq;
        public main()
        {
            InitializeComponent();
            eq = new Equipment();
            eq.PrintEquipment(dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eq.Outlet(Convert.ToInt32(numericUpDown1.Value)-1);
            eq.PrintEquipment(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мощность включенных в розетку: "+eq.CountPower().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eq.Sort();
            eq.PrintEquipment(dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            input nf = new input();
            nf.ShowDialog();
            HouseholdEquipment result =eq.Find(nf.type, nf.name, nf.power);
            if (result != null)
                MessageBox.Show(result.ToString());
            this.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
