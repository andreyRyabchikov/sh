using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using army;

namespace sh2Forms
{
    public partial class main : Form
    {
        Human human;
        Solder solder;
        private void data_for_human(DataGridView dg)
        {
            dg.RowCount = 1;
            dg.ColumnCount = 3;
            dg.Columns[0].HeaderCell.Value = "Фамилия";
            dg.Columns[0].Width = 133;
            dg.Columns[1].HeaderCell.Value = "Рост";
            dg.Columns[1].Width = 50;
            dg.Columns[2].HeaderCell.Value = "Вес";
            dg.Columns[2].Width = 50;
        }
        public main()
        {
            InitializeComponent();
            human = new Human();
            solder = new Solder();
            data_for_human(dataGridView1);
            data_for_human(dataGridView2);
            dataGridView2.ColumnCount++;
            dataGridView2.Columns[3].HeaderCell.Value = "Образование";
            dataGridView2.Columns[3].Width = 114;
            button3.Enabled = false;
            button6.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Качество q = "+human.QualityQ());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            humanRead nf = new humanRead();
            nf.ShowDialog();
            human.Read(nf.surname,nf.hight,nf.weight);
            dataGridView1.Rows[0].Cells[0].Value = nf.surname;
            dataGridView1.Rows[0].Cells[1].Value = nf.hight;
            dataGridView1.Rows[0].Cells[2].Value = nf.weight;
            this.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            solderRead nf = new solderRead();
            nf.ShowDialog();
            solder.Read(nf.surname, nf.hight, nf.weight,nf.education);
            dataGridView2.Rows[0].Cells[0].Value = nf.surname;
            dataGridView2.Rows[0].Cells[1].Value = nf.hight;
            dataGridView2.Rows[0].Cells[2].Value = nf.weight;
            dataGridView2.Rows[0].Cells[3].Value = nf.education;
            this.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Качество q = " + solder.QualityQ());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("человек\n\r" + human.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("солдат\n\r" + solder.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
