using System;

namespace Task_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
                a = 0;

            Console.Write("Введите b: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
                b = 0;

            // Вычисление H
            double H = Math.Min(a,b)*((Math.Sin(Math.Sqrt(a*a+b*b)+1)*Math.Cos(Math.Sqrt(a*a+b*b)+1))/(Math.Sqrt(a*a+b*b)+1));

            // Вывод (используется подстановка значения переменных в строку)
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"H({a};{b}) = {H:f7} (с точностью до 7 знаков)");
        }
    }
}