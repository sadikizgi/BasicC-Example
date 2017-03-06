using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP05042016
{
    class Program
    {
        public static int factorial(int x)
        {
            int sonuc = 1;
            for (int i = 1; i <= x; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        public static int factorialRecursive(int x)
        {
            if (x==0 || x == 1)
                return 1;
            else
                return x * factorialRecursive(x - 1);
        }

        public static int usHesaplaRecursive(int x, int us)
        {
            if (us == 0)
                return 1;
            else
                return x * usHesaplaRecursive(x,us - 1);
        }


        static void Main(string[] args)
        {
            //Console.WriteLine(usHesaplaRecursive(3,5));
            Muhendis aliMuhendis = new Muhendis(111, "ali", 50, 40);
//            Console.WriteLine(aliMuhendis.MaasHesapla());
            Console.WriteLine(aliMuhendis.ToString());
            Muhendis ayseMuhendis=new Muhendis(122, "Ayse", 70, 30);
            Console.WriteLine(ayseMuhendis.ToString());
            Mudur ahmetMudur = new Mudur(133, "ahmet", 100, 30);
            Console.WriteLine(ahmetMudur.ToString());
            Sirket cengBilisim = new Sirket("Computer Engineer Bilişim", 2, 3);
            cengBilisim.MuhendisIseAl(ayseMuhendis);
            cengBilisim.MuhendisIseAl(new Muhendis(144, "mete", 30, 20));
            cengBilisim.MuhendisIseAl(155, "FAtma", 40, 30);


        }
    }
}
