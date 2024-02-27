using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_Timer_Pasta_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
           
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.BackColor = Color.Red;
                label5.Visible = true;
                label5.Text = "Karıştırma İşlemi Başarılı Bir Şekilde Tamamlandı";
                label5.BackColor= Color.Red;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Red;
            }
            else
            {
                label1.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
             if(progressBar2.Value%20 == 0)
            {
                label2.BackColor = Color.Red;
            }
            else
            {
                label2.BackColor = Color.White;
            }

            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                label6.Visible = true;
                label6.Text = "Çırpma İşlemi Başarılı Bir  Şekilde Tamamlandı";
                label6.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Red;
            }
            else
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                label7.Visible = true;
                label7.BackColor = Color.Red;
                label7.Text = "Karıştırma İşlemi Başarılı Bir Şekilde Tamamlandı";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10
;
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.Red;
            }
            else
            {
                label4.BackColor = Color.White;
            }

            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                label8.Visible = true;
                label8.BackColor = Color.Red;
                label8.Text = "Pişme İşlemi Başarılı Bir Şekilde Tamamlandı";
                MessageBox.Show("PASTAMIZ HAZIR :))");
                
            }
        }
    }
}
