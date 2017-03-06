using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP15032016
{
    class Operations
    {

        //public void tersUcgenCiz(int boyut)
        //{
        //    for (int i = 0; i < boyut; i++)
        //    {
        //        for (int j = boyut - i; j > 0; j--)
        //        {
        //            Console.Write('*');
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //public void ortalamaHesapla()
        //{
        //    int boyut;
        //    Console.Write("Kac sayi gireceksiniz?:");
        //    boyut = int.Parse(Console.ReadLine());
        //    int[] dizi = new int[boyut];
        //    int toplam = 0;
        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //        Console.Write((i + 1) + ". sayi:");
        //        dizi[i] = int.Parse(Console.ReadLine());
        //        toplam += dizi[i];
        //    }
        //    double toplam = 0;
        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //        toplam += dizi[i];
        //    }
        //    Console.WriteLine("Ortalama=" + ((toplam + 0.0) / dizi.Length));


        //}

        //public void diziTest(int sayi, int[] dizi)
        //{
        //    sayi = 7;
        //    dizi[2] = 1000;
        //    Console.WriteLine("metotta: sayi:" + sayi + "dizi[2]:" + dizi[2]);

        //}

        //kullanicidan ogrenci sayisi, isimleri ve notlari alinip
        //en basarili ogrenci bulunur.
        public void enBasariliOgrenci()
        {
            Console.Write("Kac ogrenci gireceksiniz?:");
            int ogrSayi = int.Parse(Console.ReadLine());
            int[] notlar = new int[ogrSayi];
            string[] isimler = new string[ogrSayi];
            for (int i = 0; i < ogrSayi; i++)
            {
                Console.Write((i + 1) + ". ogrencinin adi:");
                isimler[i] = Console.ReadLine();
                Console.Write((i + 1) + ". ogrencinin notu:");
                notlar[i] = int.Parse(Console.ReadLine());
            }
            int enBasariliIndex = maxNotIndex(notlar);
            Console.WriteLine("En basarili ogrenci:" + isimler[enBasariliIndex]);

        }

        //en yuksek notun indeksi bulunup dondurulur
        private int maxNotIndex(int[] notlar)
        {
            int max = notlar[0];
            int maxIndex = 0;
            for (int i = 1; i < notlar.Length; i++)
            {
                if (notlar[i] > max)
                {
                    max = notlar[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }



    }
}

