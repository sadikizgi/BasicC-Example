using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP12042016
{
    class Test
    {
        static void Main(string[] args)
        {
            //Dikdortgen d1 = new Dikdortgen(2, 5);
            //Dikdortgen d2 = new Dikdortgen(3, 4);
            ////Console.WriteLine(d1.alan());
            //Console.WriteLine(d1.ToString());
            //if(d1.CompareTo(d2)==1)
            //    Console.WriteLine("ilk dikdörtgen büyük");
            //else if (d1.CompareTo(d2) == -1)
            //    Console.WriteLine("ikinci  dikdörtgen büyük");
            //else
            //    Console.WriteLine("eşit");
            Nokta n1 = new Nokta();
            Nokta n2 = new Nokta(3, 4);
            //Console.WriteLine(n1.uzaklik(n2));
            //Console.WriteLine(n1.ToString());
            Nokta[] noktalar = new Nokta[3];
            noktalar[0] = n1;
            noktalar[1] = n2;
            noktalar[2] = new Nokta(6, 8);
            //for (int i = 0; i < noktalar.Length; i++)
            //{
            //    Console.WriteLine(noktalar[i].ToString());
            //}
            //ArrayList list = new ArrayList();
            //list.Add(5);
            //list.Add(7);
            //list.Add(9);
            //list.Add("ali");
            //list.Add(n1);
            ////Console.WriteLine(list.Count);
            //Console.WriteLine(list[0]);
            //int y = (int)list[0];
            //int toplam = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] is int)
            //        toplam += (int)list[i];
            //    else if(list[i] is Nokta)
            //        Console.WriteLine(((Nokta)list[i]).ToString());
            //    //Console.WriteLine(list[i]);
            //}
            //Console.WriteLine(toplam);
            YeniDaire yd1 = new YeniDaire();
            YeniDaire yd2 = new YeniDaire(5, 12, 6);
            YeniDaire yd3 = new YeniDaire(8, n2);
            Console.WriteLine(yd1.ToString());
            Console.WriteLine(yd2.ToString());
            Console.WriteLine(yd3.ToString());
            Console.WriteLine(yd1.uzaklik(yd3));

            //Daire d = yd1;
            //Nokta n = (Nokta)yd2;
            Object o=yd1;
            //YeniDaire yd4 = (YeniDaire)o;
            Daire d = (Daire)o;

        }
    }
}
