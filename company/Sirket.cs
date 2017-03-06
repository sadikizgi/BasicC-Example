using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP05042016
{
    class Sirket
    {
        string isim;
        Mudur[] mudurler;//=new Mudur[2];
        Muhendis[] muhendisler;//=new Muhendis[3];
        int muhendisIndex;
        int mudurIndex;
        public Sirket(string ism, 
                      int mudurSayisi, int MuhSayisi)
        {
            isim = ism;
            mudurler = new Mudur[mudurSayisi];
            muhendisler = new Muhendis[MuhSayisi];
        }

        public void MuhendisIseAl(Muhendis yeni)
        {
            //muhendisler[0] = yeni;
            //for (int i = 0; i < muhendisler.Length; i++)
            //{
            //    if (muhendisler[i] == null)
            //    {
            //        muhendisler[i] = yeni;
            //        return;
            //    } 
            //}
            if (muhendisIndex < muhendisler.Length)
                muhendisler[muhendisIndex++] = yeni;
            else
                Console.WriteLine("şirkette yeterince muhendis var");
        }
        public void MuhendisIseAl(int no, string isim,
                   float ucret, int saat)
        {
            if (muhendisIndex < muhendisler.Length)
                muhendisler[muhendisIndex++] = 
                                new Muhendis(no, isim, ucret, saat);
            else
                Console.WriteLine("şirkette yeterince muhendis var");

        }
        public float SirketGiderleri()
        {
            float toplam = 0;
            for (int i = 0; i < muhendisler.Length; i++)
            {
                if(muhendisler[i]!= null)
                    toplam += muhendisler[i].MaasHesapla();
            }
            for (int i = 0; i < mudurler.Length; i++)
            {

            }
            return toplam;
        }

    }
}
