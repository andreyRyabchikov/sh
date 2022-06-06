using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sh2Forms
{

    public partial class humanRead : Form
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
        public string surname;
        public double weight;
        public double hight;
        public humanRead()
        {
            InitializeComponent();
        }

        private void human_read_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            surname = textBox1.Text;
            hight = Convert.ToDouble(textBox2.Text);
            weight = Convert.ToDouble(textBox3.Text);
            if ((hight < 130 || hight > 260) || (weight < 50 || weight > 150))
                MessageBox.Show("Ошибка ввода!");
            else
                this.Close();
        }
    }
}
