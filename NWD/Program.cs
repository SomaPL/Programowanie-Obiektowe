using System;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for (int i = 0; i < test; i++)
            {
                string[] liczby = Console.ReadLine().Split(' ');
                int a = int.Parse(liczby[0]);
                int b = int.Parse(liczby[1]);
                Console.WriteLine(nwd(a, b));
            }
        }
        static int nwd(int a, int b)
        {
            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
