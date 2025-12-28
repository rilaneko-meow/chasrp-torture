using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            if (!int.TryParse(Console.ReadLine(), out int a))
                a = 0;
            Console.Write("b = ");
            if (!int.TryParse(Console.ReadLine(), out int b))
                b = 0;
            Console.Write("c = ");
            if (!int.TryParse(Console.ReadLine(), out int c))
                b = 0;
            Console.Write("Операнд ");
            string? s = Console.ReadLine();

            double res = (c-b)/(a*1.0);

            if (b<0)
                Console.WriteLine($"{a}x - {Math.Abs(b)} {s} {c}");
            else
                Console.WriteLine($"{a}x + {b} {s} {c}");

            if (a!=0)
                Console.WriteLine($"x {s} {res}");
            else
                Console.WriteLine($"Истина (любой x) - бесконечное множество решений");
        }
    }
}