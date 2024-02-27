using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Fiyat_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            String urunAdi = textBox1.Text;
            double urunFiyati = Convert.ToDouble(textBox2.Text);
            double hesapla8, hesapla18;

            hesapla8 = urunFiyati + (urunFiyati * 0.08);
            hesapla18 = urunFiyati + (urunFiyati * 0.18);

            listBox1.Items.Add("Ürün Adı: " + urunAdi +"\n");
            listBox1.Items.Add("KDV'siz fiyatı:" + urunFiyati);
            listBox1.Items.Add("%8 KDV'li fiyatı: " + hesapla8);
            listBox1.Items.Add("%18 KDV'li fiyatı: " + hesapla18);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
