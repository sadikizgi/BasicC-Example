using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYPL25032016
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 5 , 7 ,2};
            ArrayOperations aop = new ArrayOperations();
            aop.display(arr);
            aop.swapMaxWithFirst(arr);
            aop.display(arr);
            Console.WriteLine(aop.search(arr,2));
        }
    }
}
