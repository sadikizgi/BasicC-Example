using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09032016_week2_erdi
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------İlk Örnek------------------------------------------

            Console.Write("Lütfen bir sayı giriniz: ");
            int number;
            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                int i = 1;
                while (i <= number)
                {
                    Console.WriteLine("{0} {1} {2}", i, i * i, i * i * i);
                    i++;
                }
                Console.ReadKey();
            }
            else
                Console.WriteLine("Sayısal bir değer girmelisiniz!");

            //---------------------Kare Örneği------------------------------------------

            Console.Write("Lütfen karenin uzunluğunu giriniz: ");
            int length;
            if (int.TryParse(Console.ReadLine(), out length))
            {
                int j = 1;
                while (j <= length)
                {
                    int k = 0;
                    while (k < length)
                    {
                        Console.Write("*");
                        k++;
                    }
                    Console.Write("\n");
                    j++;
                }
                Console.ReadKey();
            }
            else
                Console.WriteLine("Sayısal bir değer girmelisiniz!");

            //---------------------Üçgen Örneği------------------------------------------

            Console.Write("Lütfen üçgenin uzunluğunu giriniz: ");
            int length2;
            if (int.TryParse(Console.ReadLine(), out length2))
            {
                int j = 1;
                while (j <= length2)
                {
                    int k = 0;
                    while (k < j)
                    {
                        Console.Write("*");
                        k++;
                    }
                    Console.WriteLine();
                    j++;
                }
                Console.ReadKey();
            }
            else
                Console.WriteLine("Sayısal bir değer girmelisiniz!");

            //---------------------Tek Sayıları Bulma------------------------------------------

            Console.Write("Lütfen bir sayı giriniz: ");
            int number2;
            if (int.TryParse(Console.ReadLine(), out number2))
            {
                OddNumbers odd = new OddNumbers();
                int sum = odd.FindOddNumbers(number2);
                Console.WriteLine();
                Console.WriteLine("1'den {0}'a kadar olan tek sayıların toplamı: {1}", number2, sum);
            }
            else
                Console.WriteLine("Sayısal bir değer girmelisiniz!");
            Console.ReadKey();

            //---------------------Faktöriyel Hesaplama------------------------------------------

            Console.Write("Lütfen bir sayı giriniz: ");
            int number3;
            if (int.TryParse(Console.ReadLine(), out number3))
            {
                Factorial f = new Factorial();
                int sum = f.CalculateFactorial(number3);
                Console.WriteLine();
                Console.WriteLine("{0}! = {1}", number3, sum);
            }
            else
                Console.WriteLine("Sayısal bir değer girmelisiniz!");
            Console.ReadKey();
        }
    }
    }
}
