using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Gecme_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ort, sınav1, sınav2, proje;
            sınav1 = Convert.ToDouble(textBox1.Text);
            sınav2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ort = (sınav1 * 0.5) + (sınav2 * 0.3) + (proje * 0.2);

            if (ort < 50)
            {
                textBox4.Text = "Ortalama:"+ ort +"   Kaldı";

            }else if (ort <= 60)
            {
                textBox4.Text = "Ortalama:" + ort + "   E";

            }
            else if (ort <= 70)
            {
                textBox4.Text = "Ortalama:" + ort + "   D";

            }
            else if (ort <= 80)
            { 
                textBox4.Text = "Ortalama:" + ort + "   C";

            }
            else if (ort <= 90)
            {
                textBox4.Text = "Ortalama:" + ort +  "   B";

            }
            else
            {
                textBox4.Text = "Ortalama:" + ort + "   A";

            }
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
