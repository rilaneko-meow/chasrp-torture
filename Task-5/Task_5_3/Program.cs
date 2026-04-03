using System;

namespace Task_5_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine() ?? "0");

            //int n = 10;
            //int m = 7;

            long cm = Combo(n, m);
            long ac = Accomodation(n, m);
            long f_n = Factorial(n);

            //Console.WriteLine($"Сочетания C({n};{m}) = {cm}");
            //Console.WriteLine($"Размещения A({n};{m}) = {ac}");

            Console.WriteLine();
            Console.WriteLine("Таблица факториалов");
            for (int i = 0; i <= n; i++)
            {
                long i_n = Factorial(i);
                Console.WriteLine($"{i}! = {i_n}");
            }

            Console.WriteLine();

            int k = 0;
            Console.WriteLine("Треугольник Паскаля");
            for (int i = 0; i <= n; i++)
            {
                if (k != m)
                    k++;
                for (int j = 0; j < k; j++)
                {
                    long j_m = Combo(i, j);
                    Console.Write($"{j_m,6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int km = 0;
            Console.WriteLine("Треугольник размещений");
            for (int i = 0; i <= n; i++)
            {
                if (km != m)
                    km++;
                for (int j = 1; j < km; j++)
                {
                    long ac_m = Accomodation(i, j);
                    Console.Write($"{ac_m,6}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }

        public static long Combo(int n, int m) => Factorial(n) / (Factorial(m) * Factorial(n - m));

        public static long Accomodation(int n, int m) => Factorial(n) / Factorial(n - m);

    }
}