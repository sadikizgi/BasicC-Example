using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL15042016
{
    class Deste
    {
        const int kartSayisi = 52;
        string[] tipler = { "Kupa", "Karo", "Maca", "Sinek" };
        string[] numaralar = { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
        Kart[] kartlar;
        int sonKart = 0;


        public Deste()
        {
            kartlar = new Kart[kartSayisi];
            int sayac = 0;
            for (int i = 0; i < tipler.Length; i++)
            {
                for (int j = 0; j < numaralar.Length; j++)
                {
                    kartlar[sayac++] = new Kart(tipler[i], numaralar[j]);
                }
            }
        }

        public void Goster()
        {
            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(kartlar[i] + "\t" + kartlar[i + 13] + "\t" + kartlar[i + 26] + "\t" + kartlar[i + 39]);
            }
        }

        public void Karistir()
        {
            Random r = new Random();
            Kart temp;

            for (int i = 0; i < kartSayisi; i++)
            {
                int rand = r.Next(0, 52);
                temp = kartlar[i];
                kartlar[i] = kartlar[rand];
                kartlar[rand] = temp;
            }

        }
        public Kart KartCek()
        {
            if (sonKart > kartSayisi)
            {
                Console.WriteLine("Kart kalmadi");
                return null;
            }
            else
                return kartlar[sonKart++];
        }


    }
}
