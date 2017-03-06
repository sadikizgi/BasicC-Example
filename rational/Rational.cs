using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01042016
{
    class Rational
    {
        int numerator; //pay
        int denominator; //payda

        public Rational()
        {
            numerator = 1;
            denominator = 1;
        }
        public Rational(int numerator,int denominator)
        {
           
            int gcd=Gcd(numerator,denominator);
            // divides by gcd to the fraction in reduced form
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }
        //return Gcd(numerator,denominator) 
        //GCD (greatest common divisor)
        public int Gcd(int num,int denom)
        {
           
            while (denom != 0)
            {
                int temp = num % denom;
                num = denom;
                denom = temp;
            }
            return num;
        }
        //return (this+r)
        public Rational Add(Rational r)
        {
            int n = numerator * r.denominator + denominator * r.numerator;
            int d = denominator * r.denominator;
    
            return new Rational(n, d);
        }
        //return (this-r)
        public Rational Subtraction(Rational r)
        {
            return new Rational(numerator * r.denominator - denominator * r.numerator, denominator * r.denominator);
        }
        //return (this*r)
        public Rational Multiply(Rational r)
        {
            return new Rational(numerator * r.numerator, denominator * r.denominator);
        }
        //return (this/r)
        public Rational Division(Rational r)
        {
            return new Rational(numerator * r.denominator, denominator * r.numerator);
        }
        public float Display()
        {
            return (float)numerator / denominator;
        }
        public override string ToString()
        {
            return "(" + numerator + "/" + denominator + ")";
        }
    }
}
