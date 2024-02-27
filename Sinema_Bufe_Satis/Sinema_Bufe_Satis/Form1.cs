using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cay_miktar = Convert.ToInt16(textBox1.Text);
            int su_miktar = Convert.ToInt16(textBox2.Text);
            int misir_miktar = Convert.ToInt16(textBox3.Text);
            int bilet_miktar = Convert.ToInt16(textBox4.Text);

            int toplam = (cay_miktar * 10) + (su_miktar * 5) + (misir_miktar * 20) + (bilet_miktar * 40);

            label10.Text = toplam.ToString() ;

            
            int musteri_toplam = Convert.ToInt16(label10.Text);

            kasa += musteri_toplam;

            label13.Text = kasa.ToString() + "TL";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }
    }
}
