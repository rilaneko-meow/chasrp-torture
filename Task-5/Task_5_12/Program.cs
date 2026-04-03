using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Номер числа = ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int result = Fibon(n);
            Console.WriteLine($"Fib({n}) = {result}");
        }

        static int Fibon(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fibon(n - 1) + Fibon(n - 2);
        }

    }
}
