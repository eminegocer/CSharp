namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rTxtBox = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.pBoxFalse = new System.Windows.Forms.PictureBox();
            this.pBoxTrue = new System.Windows.Forms.PictureBox();
            this.BtnCvp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // rTxtBox
            // 
            this.rTxtBox.Location = new System.Drawing.Point(12, 60);
            this.rTxtBox.Name = "rTxtBox";
            this.rTxtBox.Size = new System.Drawing.Size(505, 184);
            this.rTxtBox.TabIndex = 0;
            this.rTxtBox.Text = "";
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Location = new System.Drawing.Point(12, 267);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(207, 33);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Location = new System.Drawing.Point(251, 267);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(207, 33);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Location = new System.Drawing.Point(12, 324);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(207, 33);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Location = new System.Drawing.Point(251, 324);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(207, 33);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(733, 100);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(25, 29);
            this.lblSoru.TabIndex = 8;
            this.lblSoru.Text = "0";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(733, 145);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(25, 29);
            this.lblDogru.TabIndex = 9;
            this.lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(733, 190);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(25, 29);
            this.lblYanlis.TabIndex = 10;
            this.lblYanlis.Text = "0";
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(667, 256);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(207, 44);
            this.btnSonraki.TabIndex = 11;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // pBoxFalse
            // 
            this.pBoxFalse.Enabled = false;
            this.pBoxFalse.Image = ((System.Drawing.Image)(resources.GetObject("pBoxFalse.Image")));
            this.pBoxFalse.Location = new System.Drawing.Point(537, 345);
            this.pBoxFalse.Name = "pBoxFalse";
            this.pBoxFalse.Size = new System.Drawing.Size(121, 86);
            this.pBoxFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFalse.TabIndex = 12;
            this.pBoxFalse.TabStop = false;
            this.pBoxFalse.Visible = false;
            // 
            // pBoxTrue
            // 
            this.pBoxTrue.Enabled = false;
            this.pBoxTrue.Image = ((System.Drawing.Image)(resources.GetObject("pBoxTrue.Image")));
            this.pBoxTrue.Location = new System.Drawing.Point(694, 345);
            this.pBoxTrue.Name = "pBoxTrue";
            this.pBoxTrue.Size = new System.Drawing.Size(122, 86);
            this.pBoxTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxTrue.TabIndex = 13;
            this.pBoxTrue.TabStop = false;
            this.pBoxTrue.Visible = false;
            // 
            // BtnCvp
            // 
            this.BtnCvp.Enabled = false;
            this.BtnCvp.Location = new System.Drawing.Point(129, 389);
            this.BtnCvp.Name = "BtnCvp";
            this.BtnCvp.Size = new System.Drawing.Size(207, 33);
            this.BtnCvp.TabIndex = 14;
            this.BtnCvp.Text = "Cevabı Göster";
            this.BtnCvp.UseVisualStyleBackColor = true;
            this.BtnCvp.Click += new System.EventHandler(this.BtnCvp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 459);
            this.Controls.Add(this.BtnCvp);
            this.Controls.Add(this.pBoxTrue);
            this.Controls.Add(this.pBoxFalse);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.rTxtBox);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtBox;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.PictureBox pBoxFalse;
        private System.Windows.Forms.PictureBox pBoxTrue;
        private System.Windows.Forms.Button BtnCvp;
    }
}

