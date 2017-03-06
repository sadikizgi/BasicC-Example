using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01042016
{
    class Test
    {
        static void Main(string[] args)
        {
            //Invoice inv = new Invoice("1","RAM",5,150);
            //Invoice inv1 = new Invoice("1", "RAM", -5, 150);
            //Console.WriteLine(inv1.GetInvoiceAmount());
            //Console.WriteLine(inv.GetInvoiceAmount());
            Rational r1 = new Rational();
            Rational r2 = new Rational(3, 9);
            Rational add = r1.Add(r2);
            Rational sub = r1.Subtraction(r2);
            Rational div = r1.Division(r2);
            Rational mul = r1.Multiply(r2);
            Console.WriteLine(r2.ToString());
            Console.WriteLine(r1.ToString());
            Console.WriteLine(r1.ToString()+"+"+r2.ToString()+"="+add.ToString());
            Console.WriteLine(r1.ToString() + "-" + r2.ToString() + "=" + sub.ToString());
            Console.WriteLine(r1.ToString() + "*" + r2.ToString() + "=" + mul.ToString());
            Console.WriteLine(r1.ToString() + "/" + r2.ToString() + "=" + div.ToString());


            Console.WriteLine(r2.Display());
        }
    }
}
