using System;

namespace Task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int i = 0;
            int[] arr = new int[a];

            for(i=0;i<a;i++)
            {
                Console.Write($"A({i}) = ");
                int.TryParse(Console.ReadLine(), out int t);
                arr[i] = t;
            }

            Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine($"Первый ноль: {Array.IndexOf(arr, 0)}");
            Console.WriteLine($"Положительные: {Array.FindAll(arr, x => x > 0).Length}");
            Console.WriteLine($"Отрицательные: {Array.FindAll(arr, x => x < 0).Length}");

        }
    }
}