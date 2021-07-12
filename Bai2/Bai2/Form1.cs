using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            double b = Convert.ToDouble(textBoxb.Text);
            double c = Convert.ToDouble(textBoxc.Text);
            double nghiem = -c / b;
            textBoxNghiem.Text = nghiem.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            textBoxb.Text = "";
            textBoxc.Text = "";
        }
    }
}
