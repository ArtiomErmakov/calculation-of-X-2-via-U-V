using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int u = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ras()
        {
            u = Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox2.Text) + 1;
            dataGridView1.Visible = true;
            for (int i = 0; i < u; i++)
            {
                int u1 = Convert.ToInt32(textBox2.Text) + i;
                int v = Convert.ToInt32(textBox1.Text);
                double x = (Math.Pow(u1, 2) + Math.Pow(v, 2)) / 2;
                dataGridView1.Rows.Add(u1, v, x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            else if (textBox1.Text == "0")
                MessageBox.Show("Принимаются только натуральные числа", "Ошибка");
            else if (Convert.ToInt32(textBox2.Text) <= Convert.ToInt32(textBox1.Text))
                MessageBox.Show("Минимальное значение U должно быть больше V", "Ошибка");
            else if (Convert.ToInt32(textBox3.Text) <= Convert.ToInt32(textBox2.Text))
                MessageBox.Show("Максимальное значение U должно быть больше минимального значения U", "Ошибка");
            else
                ras();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
