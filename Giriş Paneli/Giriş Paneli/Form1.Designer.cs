namespace Giriş_Paneli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            k_adi = new Label();
            label2 = new Label();
            pswSifre = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            txtK_adi = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // k_adi
            // 
            k_adi.AutoSize = true;
            k_adi.BackColor = Color.LightCoral;
            k_adi.Location = new Point(137, 165);
            k_adi.Margin = new Padding(4, 0, 4, 0);
            k_adi.Name = "k_adi";
            k_adi.Size = new Size(116, 24);
            k_adi.TabIndex = 0;
            k_adi.Text = "Kullanıcı Adı";
            k_adi.Click += k_adi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Location = new Point(205, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // pswSifre
            // 
            pswSifre.BackColor = Color.Gold;
            pswSifre.Location = new Point(280, 217);
            pswSifre.Margin = new Padding(4);
            pswSifre.Name = "pswSifre";
            pswSifre.PasswordChar = '*';
            pswSifre.Size = new Size(170, 32);
            pswSifre.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Location = new Point(321, 277);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(129, 35);
            button1.TabIndex = 4;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 125);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(561, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Edwardian Script ITC", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(168, 39);
            label1.Name = "label1";
            label1.Size = new Size(348, 47);
            label1.TabIndex = 0;
            label1.Text = "Online Ders Giriş Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSalmon;
            panel2.Location = new Point(3, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 31);
            panel2.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(501, 221);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(176, 28);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtK_adi
            // 
            txtK_adi.BackColor = Color.Gold;
            txtK_adi.Location = new Point(280, 165);
            txtK_adi.Margin = new Padding(4);
            txtK_adi.Name = "txtK_adi";
            txtK_adi.Size = new Size(170, 32);
            txtK_adi.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 540);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pswSifre);
            Controls.Add(txtK_adi);
            Controls.Add(label2);
            Controls.Add(k_adi);
            Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Kullanıcı Giriş Paneli";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label k_adi;
        private Label label2;
        private TextBox pswSifre;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private TextBox txtK_adi;
    }
}