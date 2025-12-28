using System;

namespace Task_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
			// Задаем Пи, большой радиус и радиус сечения тора
            Console.Write("Большой радиус тора: ");
            double big_radius = double.Parse(Console.ReadLine() ?? "1.0");

            Console.Write("Радиус сечения: ");
            double section_radius = double.Parse(Console.ReadLine() ?? "0.5");

            const double PI = 3.14159265359;

			// Записать формулу для вычисления объема в переменную torus_volume и вывести данные на экран

            double V = 2 * PI * PI * big_radius * section_radius * section_radius;
            Console.WriteLine("Объем тора: "+V+"ед^2");
        }
    }
}