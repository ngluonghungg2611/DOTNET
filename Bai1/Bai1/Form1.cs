using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKQ_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double kq = a + b;
            textBoxKQ.Text = kq.ToString();

        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double kq = a - b;
            textBoxKQ.Text = kq.ToString();
        }   

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double kq = a * b;
            textBoxKQ.Text = kq.ToString();
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            if (b == 0)
            {
                MessageBox.Show("Nhập số thứ 2 khác 0");
            }
            else
            {
                double kq = a / b;
                textBoxKQ.Text = kq.ToString();
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBoxKQ.Text = "";
        }
    }
}
