using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Kullanim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Visible = true;
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 5)
            {
                this.BackColor = Color.PeachPuff;
            }
            if (sayac == 10)
            {
                this.BackColor = Color.GreenYellow;
                sayac = 0;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
