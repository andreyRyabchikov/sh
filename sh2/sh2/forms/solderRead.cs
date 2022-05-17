using System;
using System.Windows.Forms;

namespace sh2
{
    public partial class solderRead : Form
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
        public string education;
        public solderRead()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            surname = textBox1.Text;
            hight = Convert.ToDouble(textBox2.Text);
            weight = Convert.ToDouble(textBox3.Text);
            education = textBox4.Text;
            if (education != "начальное" && education != "среднее" && education != "высшее" || ((hight < 130 || hight > 260) || (weight < 50 || weight > 150)))
                MessageBox.Show("Ошибка ввода!");
            else
                this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void solderRead_Load(object sender, EventArgs e)
        {

        }
    }
}
