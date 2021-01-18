using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Bu oyunda iki oyuncu olmalıdır.
             * Her oyuncunun bir zarı vardır.
             * Oyuncular zar atar.
             * Zarlar karşılaştırılır.
             * Büyük atan kazanır.
             * 
             * Nesneler:
             * -oyun
             * -oyuncu
             * -zar
             */


        }
        Oyun zarOyunu = new Oyun();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1Oyuncu1Adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void butonAd1_click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBox1Oyuncu1Adi.Text;
            zarOyunu.birinciOyuncu = new oyuncu(oyuncuAdi);
            zarOyunu.birinciOyuncu.OyuncununZari = new Zar();
            label1OyuncuAd.Text = zarOyunu.birinciOyuncu.Ad;
            zarOyunu.birinciOyuncu.Kasa = 100;
            butonad2.Enabled = true;
        }

        private void butonad2_Click(object sender, EventArgs e)
        {
            zarOyunu.ikinciOyuncu = new oyuncu(textBox2Oyuncu2Adi.Text);
            zarOyunu.ikinciOyuncu.OyuncununZari = new Zar();
            label2OyuncuAd.Text = zarOyunu.ikinciOyuncu.Ad;
            zarOyunu.ikinciOyuncu.Kasa = 100;

            
        }

        private void button1_OyuncuZarAt_Click(object sender, EventArgs e)
        {
                zarOyunu.IlkOyuncuZarAt();
                label1OyuncuZar.Text = zarOyunu.birinciOyuncu.OyuncununZari.Deger.ToString();
            
            
        }

        private void button2_OyuncuZarAt_Click(object sender, EventArgs e)
        {
            
                zarOyunu.ikinciOyuncuZarAt();
                label2OyuncuZar.Text = zarOyunu.ikinciOyuncu.OyuncununZari.Deger.ToString();
                oyuncu kazanan = zarOyunu.Karsilastir();
                oy1Kasa.Text = zarOyunu.birinciOyuncu.Kasa.ToString();
                oync2Kasa.Text = zarOyunu.ikinciOyuncu.Kasa.ToString();

               
                if (kazanan != null)
                {
                    if (zarOyunu.birinciOyuncu.Kasa < 0 || zarOyunu.ikinciOyuncu.Kasa < 0)
                    {
                        labelKazanan.Text = $" Oyunculardan birinin oyuna devam edecek parası kalmadı!!";
                        button1_OyuncuZarAt.Enabled = false;
                        button2_OyuncuZarAt.Enabled = false;
                    }
                    else
                    {
                        labelKazanan.Text = $"{kazanan.Ad}, {kazanan.OyuncununZari.Deger} atarak oyunu kazandı.";
                    }
                    
                }
                else
                {
                    labelKazanan.Text = "Berabere!!";
                }
            
        }

        private void label1OyuncuAd_Click(object sender, EventArgs e)
        {

        }

        private void oync1_bahisMiktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void oyuncu1_bahisGir_Click(object sender, EventArgs e)
        {
            zarOyunu.birinciOyuncu.Bahis = Convert.ToDecimal(oync1_bahisMiktar.Text);
          
        }

        private void oyuncu2BahisGir_Click(object sender, EventArgs e)
        {
            zarOyunu.ikinciOyuncu.Bahis = Convert.ToDecimal(oyuncu2bahisMiktar.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
