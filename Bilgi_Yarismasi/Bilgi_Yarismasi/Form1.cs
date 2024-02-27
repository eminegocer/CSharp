using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru=0, yanlis=0;
        char cevap='C';
        bool sonuc=false;
        

        private void btnA_Click(object sender, EventArgs e)
        {
            
            if (cevap == 'A')
            {
                sonuc = true;
            }
            
            
            
            
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (cevap == 'B')
            {
                sonuc = true;
            }
            
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (cevap == 'C')
            {
                sonuc = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (cevap == 'D')
            {
                sonuc = true;
            }
            
           
        }

        private void BtnCvp_Click(object sender, EventArgs e)
        {

            btnSonraki.Enabled = true;
            if (sonuc)
            {
                dogru++;
                pBoxTrue.Visible = true;
                pBoxFalse.Visible = false;
                lblDogru.Text = dogru.ToString();
               
            }
            else
            {
                yanlis++;
                pBoxFalse.Visible = true;
                pBoxTrue.Visible = false;
                lblYanlis.Text = yanlis.ToString();
              
            }
            BtnCvp.Enabled = false;


        }

      
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            pBoxFalse.Visible = false;
            pBoxTrue.Visible = false;
            if (soruNo == -1)
            {
                btnSonraki.Enabled = true;
            }
            else
            {
                btnSonraki.Enabled= false;
            }


            BtnCvp.Enabled = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            ++soruNo;
            lblSoru.Text = soruNo.ToString();

            switch (soruNo)
            {
                case 0:
                    rTxtBox.Text = "Bilgi Yarışmasına Hoş Geldiniz !!!";
                    break;

                case 1:
                    rTxtBox.Text = "Cumhuriyet Kaç Yılında İlan Edildi?";
                    btnA.Text = "1923";
                    btnB.Text = "1898";
                    btnC.Text = "1989";
                    btnD.Text = "1959";

                    cevap = 'A';

                    break;
                case 2:
                    rTxtBox.Text = "Atatürk Ne Zaman Vefat Etti?";
                    btnA.Text = "15 Temmuz 1881";
                    btnB.Text = "23 Nisan 1920";
                    btnC.Text ="10 Kasım 1938";
                    btnD.Text = "20 Eylül 1938";

                    cevap = 'C';

                    break;

                case 3:
                    rTxtBox.Text = "NH3 Formülünün Yaygın Adı Nedir?";
                    btnA.Text = "Hidroklorik Asit";
                    btnB.Text = "Sülfat";
                    btnC.Text = "Nitrat";
                    btnD.Text = "Amonyak";

                    
                    btnSonraki.Text = "Sonuçları Göster";

                    cevap = 'D';
                    break;

                default:

                    rTxtBox.Text = "";
                    btnA.Text = "";
                    btnB.Text = "";
                    btnC.Text = "";
                    btnD.Text = "";
                    lblSoru.Text = "";
                    lblDogru.Text = "";
                    lblYanlis.Text = "";

                    MessageBox.Show("Yarışma Sona Erdi ! \nDoğru Sayısı: " + dogru + "\nYanlış Sayısı: " + yanlis);
                    this.Close();
                    break;
            }

        }
    }
}
