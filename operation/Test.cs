using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP15032016
{
    class Test
    {
        static void Main(string[] args)
        {
            //0dan 9a sayilari yazdirir
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //0dan 9a while kullanarak sayilari yazdirma
            //int j = 0;
            //while (j < 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}

            //continue calisirsa alttaki kodlar calismaz
            //break donguyu kirar, dongu sonlanir
            //int toplam = 0;
            //int sayac = 0;
            //for (int i = 1; i < 105; i+=2)
            //{
            //    if (i > 40)
            //        continue;
            //    sayac++;
            //    toplam += i;
            //    if (i > 55)
            //        break;



            //}
            //Console.WriteLine("Tek sayilar toplami:"+toplam);
            //Console.WriteLine("Sayac:"+sayac);
            //Console.WriteLine("Ortalama:"+(toplam/Double.Parse(sayac.ToString())));

            //Hem 2, hem de 3 bolunen sayilari yazdirmaz,
            //Yani 6 ve katlari haric, diger sayilari yazdirir
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 == 0 && i % 3 == 0)
            //        continue;
            //    Console.WriteLine(i);


            //}

            Operations op = new Operations();
            //op.tersUcgenCiz(5);


            //int[] a = new int[10];

            ////ekrana dizinin elemanlarini yazdirir
            ////atama yapilmadiysa int dizi tanimlandiginda tum elemanlar 0
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("[" + i + "]: " + a[i]);
            //}
            //a[0] = 1;
            //a[1] = 4;

            //a = new int[] { 1, 4, 2, 3, 5, 6 };
            ////dizideki elemanlari goruntuleme
            ////for (int i = 0; i < a.Length; i++)
            ////{
            ////    //Console.WriteLine("[" + i + "]: " + a[i]);
            ////    Console.WriteLine("[{0}]:{1}",i,a[i]);
            ////}

            ////b ile a ayni dizi
            //int[] b = a;

            //a[3] = 4;
            //b[3] = 7;
            //Console.WriteLine(a[3]);

            //int sayi = 1;
            //Console.WriteLine("Once: sayi:"+sayi+"dizi[2]:"+a[2]);
            ////op.diziTest(sayi, a);
            //Console.WriteLine("Sonra: sayi:" + sayi + "dizi[2]:" + a[2]);

            ////iki boyutlu dizi
            //int[,] c = { {1,2,3}, {1,2,4} };
            //int[,] d = { { 4, 2, 1 }, { 1, 4, 7 }};


            ////GetLength(0)--->satir, GetLenght(1)--->sutun
            //Console.WriteLine(c.GetLength(0));
            //int[,] toplam = new int[c.GetLength(0),c.GetLength(1)];
            ////matris toplama ve goruntuleme
            //for (int i = 0; i < toplam.GetLength(0); i++)
            //{
            //    for (int j = 0; j < toplam.GetLength(1); j++)
            //    {
            //        toplam[i, j] = c[i, j] + d[i, j];
            //        Console.Write(toplam[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //op.ortalamaHesapla();
            //op.enBasariliOgrenci();


            //int.TryParse kullanimi
            int myNumber;
            string myStr = "123a";
            bool isSuccessful = int.TryParse(myStr, out myNumber);

            Console.WriteLine(isSuccessful);
            if (isSuccessful)
                Console.WriteLine(myNumber);
            else
                Console.WriteLine("string integer'a donusturulemedi");





        }
    }
}
