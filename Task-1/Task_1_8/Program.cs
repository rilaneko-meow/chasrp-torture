using System;

namespace Task_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new System.Random();
            Console.Write("Введите a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
                a = 0;

            Console.Write("Введите b: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
                b = 0;

            Console.WriteLine((b - a) * r.NextDouble() + a);
        }
    }
}