namespace Giriş_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String sifre = "12345";
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtK_adi.Text == "Emine Göçer" && pswSifre.Text == sifre)
            {

                MessageBox.Show("Başarılı Giriş");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void k_adi_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             MessageBox.Show("Mevcut Şifre:" + sifre);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}