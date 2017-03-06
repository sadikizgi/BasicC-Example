using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP08042016
{
    class Test
    {
        static void Main(string[] args)
        {

            //string myStr = "Ali ata bak";

            //string[] parcalanmis= myStr.Split(' ');
            //for (int i = 0;i< parcalanmis.Length; i++)
            //{
            //    Console.WriteLine(parcalanmis[i]);
            //}
            //Console.WriteLine(parcalanmis[1][0]);
            Zaman z1 = new Zaman(0,20,05);
            Console.WriteLine(z1.ToEvrenselString());
            Console.WriteLine(z1.ToString());
            Tarih t1 = new Tarih(29,2,2000);
            Console.WriteLine(t1.ToString());

        }
    }
}
