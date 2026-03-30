using System;

namespace Task_4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] test = [23.5, 56.3, -67.9, 22.3,10, -5, 12.3];

            double[] copy = test;

            copy.Sort();

            Console.WriteLine(string.Join(" ", test));
            Console.WriteLine(string.Join(" ", copy));

            if (Array.Exists(copy, x => x == 0))
            {
                Console.WriteLine("Есть нули");
            }
            else
            {
                Console.WriteLine("Нет нулей");
            }



            if (Array.Exists(copy, x => x >= 0 && x <= 15))
            {
                Console.WriteLine("Содержит числа из промежутка [0, 15]");
            }
            else
            {
                Console.WriteLine("Не содержит числа из промежутка [0, 15]");
            }

            double[] p = Array.FindAll(copy, x => x > 0);

            Console.WriteLine("Положительные элементы:");
            Console.WriteLine(string.Join(" ", p));
        }
    }
}