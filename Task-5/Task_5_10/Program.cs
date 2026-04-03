using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            Console.WriteLine($"{n}! = {IterFactorial(n)}");
            Console.WriteLine($"{n}! = {RecFactorial(n)}");
        }

        // вычисляет факториал циклически
        static long IterFactorial(int n)
        {
            long factor = 1;

            for (int i = 1; i <= n; i++)
            {
                factor *= i;
            }

            return factor;
        }

        // вычисляет факториал рекурсивно
		static long RecFactorial(int n) =>
           n == 0 ? 1 : RecFactorial(n - 1) * n;
    }
}