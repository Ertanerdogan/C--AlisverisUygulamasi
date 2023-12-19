using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş
{
    public partial class Form1 : Form
    {
        int para = 1000;
        int biftek = 250;
        int burger = 130;
        int doner = 90;
        int lahmacun = 35;
        int kola = 15;
        int pide = 50;
        int makarna = 75;
        int ayran = 10;
        int pizza = 120;
        int toplam = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toplam += biftek;
            liste_box.Items.Add("Biftek");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            toplam += burger;
            liste_box.Items.Add("Burger");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            toplam += doner;
            liste_box.Items.Add("Döner");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            toplam += lahmacun;
            liste_box.Items.Add("Lahmacun");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            toplam += kola;
            liste_box.Items.Add("Kola");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            toplam += pide;
            liste_box.Items.Add("Pide");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            toplam += makarna;
            liste_box.Items.Add("Makarna");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            toplam += ayran;
            liste_box.Items.Add("Ayran");
            sayac.Text = toplam.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            toplam += pizza;
            liste_box.Items.Add("Pizza");
            sayac.Text = toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(para >= toplam)
            {
                para = para - toplam;
                para_label.Text = para.ToString();
                MessageBox.Show("Ödemeniz alındı !\nAfiyet olsun !","Bilgilendirme");
                toplam = 0;
                liste_box.Items.Clear();
                sayac.Text = toplam.ToString();
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye !","Bilgilendirme");
                toplam = 0;
                liste_box.Items.Clear();
                sayac.Text = toplam.ToString();
            }
        }

    }
}
