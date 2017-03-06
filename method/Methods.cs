using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP22032016
{
    class Methods
    {
        public void display()
        {
            Console.WriteLine("hello");
        }
        public int sacma()
        {

           return 6;

        }
        public int ikiKati(int x)
        {
            x = 20;
            return 2 * x;
        }

        public void islem(int[] x)//1,3,5,2
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] + x[(i + 1) % x.Length];
            }

        }

        public int [] islem2(int[] x)//1,3,5,2
        {
            int[] y=new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i];
            }
            for (int i = 1; i < y.Length; i++)
            {
                y[i] = y[i-1] + y[(i + 1) % y.Length];
            }
            return y;

        }

        public int say(int []x, int aranan)
        {
            int sayac = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == aranan)
                    sayac++;
            }
            return sayac;

        }

        //public bool tekrarEdenElemanVarMi(int[] x)
        //{



        //}




    }
}
