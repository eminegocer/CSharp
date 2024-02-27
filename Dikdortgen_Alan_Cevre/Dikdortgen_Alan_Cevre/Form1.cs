using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdortgen_Alan_Cevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alan, cevre;
            double k_kenar = Convert.ToInt16(textBox1.Text);
            double u_kenar = Convert.ToInt16(textBox2.Text);

            alan = k_kenar * u_kenar;
            cevre = (k_kenar + u_kenar) * 2;

            textBox3.Text = alan.ToString();
            textBox4.Text = cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            
        }
    }
}
