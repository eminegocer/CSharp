namespace Dama_Tahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            Button[,] buttons = new Button[9, 9];
            
            for (int i = 0; i < buttons.GetUpperBound(0); i++) {
               
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left= left;
                    buttons[i, j].Top= top;
                    left += 50;
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else if (i % 2 == 1 && j % 2 == 1)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    
                  
                    this.Controls.Add(buttons[i, j]);
                    
                }
                left = 0;
                top += 50;
            }
        }
    }
}