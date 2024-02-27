namespace Uçak_Bileti_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text);
            listBox1.Items.Add("Tarih:" + dateTimePicker1.Text);
            listBox1.Items.Add("Saat:" + maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Adı Soyadı:" + textBox1.Text);
            listBox1.Items.Add("TC:" + maskedTextBox2.Text);
            listBox1.Items.Add("Telefon:" + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String degistir = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = degistir;


        }
    }
}