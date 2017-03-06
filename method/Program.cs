using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP22032016
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Methods objem = new Methods();
            //objem.display();
            //Console.WriteLine("bitti");
            //int x=objem.sacma();
            //Console.WriteLine(x);
            //Console.WriteLine("yine bitti");
            //int z = 10;
            //int y = objem.ikiKati(z);
            //Console.WriteLine(y);
            //int[] dizi = { 1, 3, 5, 2 };
            ////objem.islem(dizi);
            //int [] dizi2=objem.islem2(dizi);
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi2[i]);
            //}

            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(r.Next(1,11));
            //}
            //string[] s = {"ali", "ayse", "veli" };

            //string s2 = "mehmet";
            //Console.WriteLine(s2.Length);
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    Console.WriteLine(s2[i]);
            //}
            //string s3 = s2[0].ToString();
            //char c = s2[1];

            //int[,] x = new int[2, 3];//ilki satır ikinci sutun
            int[,] x = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
