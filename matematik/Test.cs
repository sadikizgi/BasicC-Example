using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP01032016
{
    class Test
    {
        //class içinde global
        int toplamNot;//class variable, field
        
        static void Main(string[] args)
        {
            //int x=9;//değişken variable
            //int y = 5;
            //string isim = "ali";
            //char harf = 'a';
            //x = y;
            //int z = y;
            //y = 8;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //string input=Console.ReadLine();
            //Console.WriteLine("girdiğiniz değer..:"+input);
            //int sayiDegeri = int.Parse(input);
            //Console.WriteLine(sayiDegeri);

            Console.Write("1. sayıyı giriniz..:");
            string input1 = Console.ReadLine();
            Console.Write("2. sayıyı giriniz..:");
            string input2 = Console.ReadLine();
            int sayi1 = int.Parse(input1);
            int sayi2 = int.Parse(input2);
            int toplam = sayi1 + sayi2;
            Console.WriteLine("sayıların toplamı..:"+toplam);
           Console.WriteLine("sayıların toplamı..:"+(sayi1+sayi2));

            Console.WriteLine("matematik classının metodu ile toplama yapılıyor");
            Matematik math = new Matematik();
            int sonuc= math.Topla(sayi1, sayi2);
            Console.WriteLine(sonuc);



            //Console.WriteLine("hello "+"world");
            //Console.WriteLine("x değeri..:"+x);
            //Console.WriteLine("x değeri..:{0}", x);
            //Console.WriteLine("x={0} \ny={1}", x,y);

        }
    }
}
