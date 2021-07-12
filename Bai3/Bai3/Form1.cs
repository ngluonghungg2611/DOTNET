using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxc_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGiai_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxa.Text);
            double b = Convert.ToDouble(textBoxb.Text);
            double c = Convert.ToDouble(textBoxc.Text);
            double nghiem1;
            double nghiem2;
            if (a == 0)
            {
                nghiem1 = -c / b;
                MessageBox.Show("Phương trình có 1 nghiệm là: " + nghiem1);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    MessageBox.Show("Phương trình vô nghiệm!");
                }
               if(delta > 0)
                {
                    nghiem1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    nghiem2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    textBoxNghiem1.Text = nghiem1.ToString();
                    textBoxNghiem2.Text = nghiem2.ToString();
                }
               if(delta == 0)
                {
                    nghiem1 = -b / (2 * a);
                    textBoxNghiem1.Text = nghiem1.ToString();
                    textBoxNghiem2.Text = nghiem1.ToString();
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxa.Text = "";
            textBoxb.Text = "";
            textBoxc.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
