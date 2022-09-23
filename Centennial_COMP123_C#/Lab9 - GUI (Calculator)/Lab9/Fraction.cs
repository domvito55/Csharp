using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public static Fraction Add(Fraction left, Fraction right)
        {
            int numerator = (left.Numerator * right.Denominator) + (right.Numerator *
           left.Denominator);
            int denominator = left.Denominator * right.Denominator;
            return new Fraction(numerator, denominator);
        }
        public static Fraction Subtract(Fraction left, Fraction right)
        {
            int numerator = (left.Numerator * right.Denominator) - (right.Numerator *
           left.Denominator);
            int denominator = left.Denominator * right.Denominator;
            return new Fraction(numerator, denominator);
        }
        public static Fraction Multiplication(Fraction left, Fraction right)
        {
            int numerator = left.Numerator * right.Numerator;
            int denominator = left.Denominator * right.Denominator;
            return new Fraction(numerator, denominator);
        }
        public static Fraction Division(Fraction left, Fraction right)
        {
            int numerator = left.Numerator * right.Denominator;
            int denominator = left.Denominator * right.Numerator;
            return new Fraction(numerator, denominator);
        }
        public override string ToString()
        {
            return $"[{Numerator}, {Denominator}]";
        }
    }
}
