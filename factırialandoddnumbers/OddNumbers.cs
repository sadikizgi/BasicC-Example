using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09032016_week2_erdi
{
    class OddNumbers
    {
        public int FindOddNumbers(int p1)
        {
            int sum = 0, i = 1;
            while(i <= p1)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.Write("{0} ", i);
                }
                i++;                   
            }
            return sum;
        }
    }
}
