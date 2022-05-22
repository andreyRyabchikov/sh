using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh5
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private TextBox txtBox = new TextBox();
        private void main_Load(object sender, EventArgs e)
        {
            this.txtBox.Text = "Text";
            this.txtBox.Location = new System.Drawing.Point(10, 25);
            this.txtBox.Size = new System.Drawing.Size(70, 20);
            this.Controls.Add(txtBox);
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер";
            dataGridView1.Columns[0].Width = 55;
            dataGridView1.Columns[1].HeaderCell.Value = "Состояние";
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьКвадракоптерToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьКвадракоптерToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьМеханикаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьМеханикаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
