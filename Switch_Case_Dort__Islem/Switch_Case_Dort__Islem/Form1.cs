using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Dort__Islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            char islem = Convert.ToChar(textBox3.Text);
            
            switch (islem)
            {
                case '+': sonuc = sayi1 + sayi2;
                    textBox4.Text = sonuc.ToString();
                    break;
                case '-': sonuc = sayi1 - sayi2;
                    textBox4.Text = sonuc.ToString();
                    break;
                case '*': sonuc = sayi2 * sayi1;
                    textBox4.Text = sonuc.ToString();
                    break;
                case '/': sonuc = sayi1 / sayi2;
                    textBox4.Text = sonuc.ToString();
                    break;
                default: MessageBox.Show("Hatalı İşlem Girişi!"); break;
            }

            
        }
    }
}
