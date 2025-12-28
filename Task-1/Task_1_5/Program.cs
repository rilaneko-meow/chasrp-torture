using System;

namespace Task_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
			// Запрашиваем ввод радиуса
            Console.Write("Введите радиус: ");
            if (!double.TryParse(Console.ReadLine(), out double R))
                R = 0;

            const double PI = Math.PI;    // Число Pi (из класса Math)

            // Здесь описать формулы для вычисления
            double circle_length = 2 * PI * R;               // Расчет длины окружности
            double circle_area = PI*R*R;
            double sphere_area = 4 * PI * R * R;
            double sphere_volime = 4/3 * PI * R *R*R;


            // Вывод информации
            Console.WriteLine();                   // Доп. пустая строка
            Console.WriteLine("Длина окружности: " + circle_length + " ед");
            Console.WriteLine("Площадь круга: " + circle_area + " ед^2");
            Console.WriteLine("Площадь сферы: " + sphere_area + " ед^2");
            Console.WriteLine("Объем сферы: " + sphere_volime + " ед^3");
        }
    }
}