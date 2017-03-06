using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL18032016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3,12,25,7,1,10};
           // a = new int[15];
            Console.WriteLine(a[2]);
            ArrayOperations ao = new ArrayOperations();
            Console.WriteLine( ao.diziToplami(a));
            Console.WriteLine(ao.diziOrtalamasi(a));
            Console.WriteLine(ao.enKucukBul(a));
            Console.WriteLine(ao.tekCiftOrani(a));
            Console.WriteLine(ao.enBuyukBul(a));
            Console.WriteLine("En Küçük Sayi +En Büyük Sayi = "+ao.enKucukEnBuyukToplami(a));

        }
    }
}
