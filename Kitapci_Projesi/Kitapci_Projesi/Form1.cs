using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapci_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k_sayisi;
            k_sayisi = Convert.ToInt16(textBox1.Text);
            double toplam, indirimli;

            toplam = k_sayisi * 8;
            if (k_sayisi < 20)
            {
                indirimli = toplam - (toplam * 0.2);
            }
            else if(k_sayisi>=20 && k_sayisi < 40)
            {
                indirimli = toplam - (toplam * 0.4);
            }
            else
            {
                indirimli = toplam - (toplam * 0.5);
            }

            textBox2.Text = toplam.ToString();
            textBox3.Text = indirimli.ToString();
        }
    }
}
