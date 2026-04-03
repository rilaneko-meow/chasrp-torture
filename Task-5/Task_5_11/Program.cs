using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20400;
            int m = 53400;

        int result = NOD(n, m);
        Console.WriteLine($"НОД({n}, {m}) = {result}");
            
        }

        static int NOD(int n, int m)
        {
            if (n == m)                 // если числа равны, ТО НОД — само число (n или m)
                return n;
            else if (n > m)             // Если n > m, рекурсивно вызываем НОД с (n - m, m)
                return NOD(n - m, m);
            else                        // Если m > n, рекурсивно вызываем НОД с (n, m - n)
                return NOD(n, m - n);
        }
		
    }
}
