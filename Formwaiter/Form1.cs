using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYPL13052016
{
    public partial class Form1 : Form
    {
        string[,] icecekler = { { "Soda", "1,95" }, { "Çay", "1,50" }, { "Kahve", "1,25" }, { "Zafer Gazoz", "1,50" }, {"Meyve Suyu","2,50" }, {"Süt","1,50" } };
        string[,] aperatifler = { {"Buffalo Wings","5,95" }, {"Buffalo Fingers","6,95" }, {"Patates Dilimleri","8,95" } };
        string[,] anaYemekler = { {"İskender","20,00" }, {"Beyti","25,00" }, {"Karışık Izgara","30,00" }, {"Tavuk Alfredo","13,50" } };
        string[,] tatlilar = { {"Kaymaklı Künefe","10,00" }, {"Köstebek Pasta","12,00" }, {"Waffle","15,00" } };
        int oldTab = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void comboBoxaYukle(ComboBox cb,string[,] dizi)
        {
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                cb.Items.Add(dizi[i,0]);
            }

        }

        private void buttonSipariseGec_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            label3.Text = "Masa:" + textBoxMasaNo.Text + " Garson:" + textBoxGarsonAd.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxaYukle(comboBoxIcecek, icecekler);
            comboBoxaYukle(comboBoxAperatif, aperatifler);
            comboBoxaYukle(comboBoxAnaYemek, anaYemekler);
            comboBoxaYukle(comboBoxTatli, tatlilar);
          

        }

        private void comboBoxIcecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void comboBoxAperatif_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void comboBoxAnaYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void comboBoxTatli_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapla();
        }
        public void hesapla()
        {
            decimal toplam=0, kdv=0, araToplam=0;
            if (comboBoxIcecek.SelectedIndex != -1)
                toplam += Convert.ToDecimal(icecekler[comboBoxIcecek.SelectedIndex,1]);
            if (comboBoxAperatif.SelectedIndex != -1)
                toplam += Convert.ToDecimal(aperatifler[comboBoxAperatif.SelectedIndex, 1]);
            if (comboBoxAnaYemek.SelectedIndex != -1)
                toplam += Convert.ToDecimal(anaYemekler[comboBoxAnaYemek.SelectedIndex,1]);
            if (comboBoxTatli.SelectedIndex != -1)
                toplam += Convert.ToDecimal(tatlilar[comboBoxTatli.SelectedIndex, 1]);

            kdv = (Decimal)0.08 * toplam;
            araToplam = toplam - kdv;
            textBoxAraToplam.Text = string.Format("{0:C}", araToplam);
            textBoxKDV.Text = string.Format("{0:C}", kdv);
            textBoxToplam.Text = string.Format("{0:C}", toplam);



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if ((sender is Button))
            //    oldTab = tabControl1.SelectedIndex;
            //else
            //{
            //    tabControl1.SelectedIndex = oldTab;
            //}

        }

        private void buttonGarsonaDon_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonHesabaGec_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
