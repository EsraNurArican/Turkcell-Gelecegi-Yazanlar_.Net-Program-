
namespace ZarAtmaOyunu
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
            this.button1_OyuncuZarAt = new System.Windows.Forms.Button();
            this.button2_OyuncuZarAt = new System.Windows.Forms.Button();
            this.textBox1Oyuncu1Adi = new System.Windows.Forms.TextBox();
            this.butonAd1 = new System.Windows.Forms.Button();
            this.label1OyuncuAd = new System.Windows.Forms.Label();
            this.label2OyuncuAd = new System.Windows.Forms.Label();
            this.textBox2Oyuncu2Adi = new System.Windows.Forms.TextBox();
            this.butonad2 = new System.Windows.Forms.Button();
            this.labelKazanan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1OyuncuZar = new System.Windows.Forms.Label();
            this.label2OyuncuZar = new System.Windows.Forms.Label();
            this.oyuncu1_bahisGir = new System.Windows.Forms.Button();
            this.oyuncu2BahisGir = new System.Windows.Forms.Button();
            this.oync1_bahisMiktar = new System.Windows.Forms.TextBox();
            this.oyuncu2bahisMiktar = new System.Windows.Forms.TextBox();
            this.oy1Kasa = new System.Windows.Forms.Label();
            this.oync2Kasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_OyuncuZarAt
            // 
            this.button1_OyuncuZarAt.Location = new System.Drawing.Point(29, 236);
            this.button1_OyuncuZarAt.Name = "button1_OyuncuZarAt";
            this.button1_OyuncuZarAt.Size = new System.Drawing.Size(113, 23);
            this.button1_OyuncuZarAt.TabIndex = 0;
            this.button1_OyuncuZarAt.Text = "1. Oyuncu Zar At";
            this.button1_OyuncuZarAt.UseVisualStyleBackColor = true;
            this.button1_OyuncuZarAt.Click += new System.EventHandler(this.button1_OyuncuZarAt_Click);
            // 
            // button2_OyuncuZarAt
            // 
            this.button2_OyuncuZarAt.Location = new System.Drawing.Point(278, 236);
            this.button2_OyuncuZarAt.Name = "button2_OyuncuZarAt";
            this.button2_OyuncuZarAt.Size = new System.Drawing.Size(124, 23);
            this.button2_OyuncuZarAt.TabIndex = 1;
            this.button2_OyuncuZarAt.Text = "2. Oyuncu Zar At";
            this.button2_OyuncuZarAt.UseVisualStyleBackColor = true;
            this.button2_OyuncuZarAt.Click += new System.EventHandler(this.button2_OyuncuZarAt_Click);
            // 
            // textBox1Oyuncu1Adi
            // 
            this.textBox1Oyuncu1Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1Oyuncu1Adi.Location = new System.Drawing.Point(42, 47);
            this.textBox1Oyuncu1Adi.Name = "textBox1Oyuncu1Adi";
            this.textBox1Oyuncu1Adi.Size = new System.Drawing.Size(100, 20);
            this.textBox1Oyuncu1Adi.TabIndex = 2;
            this.textBox1Oyuncu1Adi.TextChanged += new System.EventHandler(this.textBox1Oyuncu1Adi_TextChanged);
            // 
            // butonAd1
            // 
            this.butonAd1.Location = new System.Drawing.Point(52, 73);
            this.butonAd1.Name = "butonAd1";
            this.butonAd1.Size = new System.Drawing.Size(75, 23);
            this.butonAd1.TabIndex = 3;
            this.butonAd1.Text = "oyuncu1";
            this.butonAd1.UseVisualStyleBackColor = true;
            this.butonAd1.Click += new System.EventHandler(this.butonAd1_click);
            // 
            // label1OyuncuAd
            // 
            this.label1OyuncuAd.AutoSize = true;
            this.label1OyuncuAd.Location = new System.Drawing.Point(67, 217);
            this.label1OyuncuAd.Name = "label1OyuncuAd";
            this.label1OyuncuAd.Size = new System.Drawing.Size(35, 13);
            this.label1OyuncuAd.TabIndex = 4;
            this.label1OyuncuAd.Text = "label1";
            this.label1OyuncuAd.Click += new System.EventHandler(this.label1OyuncuAd_Click);
            // 
            // label2OyuncuAd
            // 
            this.label2OyuncuAd.AutoSize = true;
            this.label2OyuncuAd.Location = new System.Drawing.Point(322, 217);
            this.label2OyuncuAd.Name = "label2OyuncuAd";
            this.label2OyuncuAd.Size = new System.Drawing.Size(35, 13);
            this.label2OyuncuAd.TabIndex = 5;
            this.label2OyuncuAd.Text = "label2";
            // 
            // textBox2Oyuncu2Adi
            // 
            this.textBox2Oyuncu2Adi.Location = new System.Drawing.Point(243, 47);
            this.textBox2Oyuncu2Adi.Name = "textBox2Oyuncu2Adi";
            this.textBox2Oyuncu2Adi.Size = new System.Drawing.Size(100, 20);
            this.textBox2Oyuncu2Adi.TabIndex = 6;
            // 
            // butonad2
            // 
            this.butonad2.Enabled = false;
            this.butonad2.Location = new System.Drawing.Point(256, 73);
            this.butonad2.Name = "butonad2";
            this.butonad2.Size = new System.Drawing.Size(75, 23);
            this.butonad2.TabIndex = 7;
            this.butonad2.Text = "oyuncu2";
            this.butonad2.UseVisualStyleBackColor = true;
            this.butonad2.Click += new System.EventHandler(this.butonad2_Click);
            // 
            // labelKazanan
            // 
            this.labelKazanan.AutoSize = true;
            this.labelKazanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKazanan.Location = new System.Drawing.Point(176, 338);
            this.labelKazanan.Name = "labelKazanan";
            this.labelKazanan.Size = new System.Drawing.Size(60, 24);
            this.labelKazanan.TabIndex = 8;
            this.labelKazanan.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Kazanan Kişi";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1OyuncuZar
            // 
            this.label1OyuncuZar.AutoSize = true;
            this.label1OyuncuZar.Location = new System.Drawing.Point(67, 262);
            this.label1OyuncuZar.Name = "label1OyuncuZar";
            this.label1OyuncuZar.Size = new System.Drawing.Size(53, 13);
            this.label1OyuncuZar.TabIndex = 10;
            this.label1OyuncuZar.Text = "zar değeri";
            // 
            // label2OyuncuZar
            // 
            this.label2OyuncuZar.AutoSize = true;
            this.label2OyuncuZar.Location = new System.Drawing.Point(322, 262);
            this.label2OyuncuZar.Name = "label2OyuncuZar";
            this.label2OyuncuZar.Size = new System.Drawing.Size(53, 13);
            this.label2OyuncuZar.TabIndex = 11;
            this.label2OyuncuZar.Text = "zar değeri";
            // 
            // oyuncu1_bahisGir
            // 
            this.oyuncu1_bahisGir.Location = new System.Drawing.Point(29, 148);
            this.oyuncu1_bahisGir.Name = "oyuncu1_bahisGir";
            this.oyuncu1_bahisGir.Size = new System.Drawing.Size(119, 23);
            this.oyuncu1_bahisGir.TabIndex = 12;
            this.oyuncu1_bahisGir.Text = "Oyuncu1 Bahis Gir";
            this.oyuncu1_bahisGir.UseVisualStyleBackColor = true;
            this.oyuncu1_bahisGir.Click += new System.EventHandler(this.oyuncu1_bahisGir_Click);
            // 
            // oyuncu2BahisGir
            // 
            this.oyuncu2BahisGir.Location = new System.Drawing.Point(235, 148);
            this.oyuncu2BahisGir.Name = "oyuncu2BahisGir";
            this.oyuncu2BahisGir.Size = new System.Drawing.Size(122, 23);
            this.oyuncu2BahisGir.TabIndex = 13;
            this.oyuncu2BahisGir.Text = "Oyuncu 2 Bahis Gir";
            this.oyuncu2BahisGir.UseVisualStyleBackColor = true;
            this.oyuncu2BahisGir.Click += new System.EventHandler(this.oyuncu2BahisGir_Click);
            // 
            // oync1_bahisMiktar
            // 
            this.oync1_bahisMiktar.Location = new System.Drawing.Point(42, 122);
            this.oync1_bahisMiktar.Name = "oync1_bahisMiktar";
            this.oync1_bahisMiktar.Size = new System.Drawing.Size(100, 20);
            this.oync1_bahisMiktar.TabIndex = 14;
            this.oync1_bahisMiktar.TextChanged += new System.EventHandler(this.oync1_bahisMiktar_TextChanged);
            // 
            // oyuncu2bahisMiktar
            // 
            this.oyuncu2bahisMiktar.Location = new System.Drawing.Point(243, 122);
            this.oyuncu2bahisMiktar.Name = "oyuncu2bahisMiktar";
            this.oyuncu2bahisMiktar.Size = new System.Drawing.Size(100, 20);
            this.oyuncu2bahisMiktar.TabIndex = 15;
            // 
            // oy1Kasa
            // 
            this.oy1Kasa.AutoSize = true;
            this.oy1Kasa.Location = new System.Drawing.Point(26, 323);
            this.oy1Kasa.Name = "oy1Kasa";
            this.oy1Kasa.Size = new System.Drawing.Size(65, 13);
            this.oy1Kasa.TabIndex = 16;
            this.oy1Kasa.Text = "oync1_kasa";
            this.oy1Kasa.Click += new System.EventHandler(this.label1_Click);
            // 
            // oync2Kasa
            // 
            this.oync2Kasa.AutoSize = true;
            this.oync2Kasa.Location = new System.Drawing.Point(388, 323);
            this.oync2Kasa.Name = "oync2Kasa";
            this.oync2Kasa.Size = new System.Drawing.Size(65, 13);
            this.oync2Kasa.TabIndex = 18;
            this.oync2Kasa.Text = "oync2_kasa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.oync2Kasa);
            this.Controls.Add(this.oy1Kasa);
            this.Controls.Add(this.oyuncu2bahisMiktar);
            this.Controls.Add(this.oync1_bahisMiktar);
            this.Controls.Add(this.oyuncu2BahisGir);
            this.Controls.Add(this.oyuncu1_bahisGir);
            this.Controls.Add(this.label2OyuncuZar);
            this.Controls.Add(this.label1OyuncuZar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelKazanan);
            this.Controls.Add(this.butonad2);
            this.Controls.Add(this.textBox2Oyuncu2Adi);
            this.Controls.Add(this.label2OyuncuAd);
            this.Controls.Add(this.label1OyuncuAd);
            this.Controls.Add(this.butonAd1);
            this.Controls.Add(this.textBox1Oyuncu1Adi);
            this.Controls.Add(this.button2_OyuncuZarAt);
            this.Controls.Add(this.button1_OyuncuZarAt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_OyuncuZarAt;
        private System.Windows.Forms.Button button2_OyuncuZarAt;
        private System.Windows.Forms.TextBox textBox1Oyuncu1Adi;
        private System.Windows.Forms.Button butonAd1;
        private System.Windows.Forms.Label label1OyuncuAd;
        private System.Windows.Forms.Label label2OyuncuAd;
        private System.Windows.Forms.TextBox textBox2Oyuncu2Adi;
        private System.Windows.Forms.Button butonad2;
        private System.Windows.Forms.Label labelKazanan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1OyuncuZar;
        private System.Windows.Forms.Label label2OyuncuZar;
        private System.Windows.Forms.Button oyuncu1_bahisGir;
        private System.Windows.Forms.Button oyuncu2BahisGir;
        private System.Windows.Forms.TextBox oync1_bahisMiktar;
        private System.Windows.Forms.TextBox oyuncu2bahisMiktar;
        private System.Windows.Forms.Label oy1Kasa;
        private System.Windows.Forms.Label oync2Kasa;
    }
}

