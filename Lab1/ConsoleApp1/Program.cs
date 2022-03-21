using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        public int Menominator { get; set; }
        public int Meter { get; set; }

        public Fraction()
        {

        }

        public Fraction(int Meter, int Menominator)
        {
            this.Meter = Meter;
            this.Menominator = Menominator;
        }
        public Fraction(Fraction fraction)
        {
            this.Menominator = fraction.Menominator;
            this.Meter = fraction.Meter;

        }


        public override string ToString() => $"{Meter}/{Menominator}";

        public bool Equals([AllowNull] Fraction other)
        {
            return this.Meter / this.Menominator == other.Meter / other.Menominator;
        }

        public int CompareTo([AllowNull] Fraction other)
        {
            int A = this.Meter / this.Menominator;
            int b = other.Meter / other.Menominator;

            if (A > b)
                return +1;
            if (A < b)
                return -1;
            return 0;

        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Meter, a.Menominator);
        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.Meter * b.Menominator + b.Meter * a.Menominator, a.Menominator * b.Menominator);
        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.Meter * b.Meter, a.Menominator * b.Menominator);
        /*public static Fraction operator/(Fraction a, Fraction b)
        {
            if (b.Menominator == 0)
            {
                throw new DivideByZeroException();
            }
        }
        */

    }

