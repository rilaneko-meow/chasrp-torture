using System;

namespace Task_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            if (!double.TryParse(Console.ReadLine(), out double a))
                a = 0;
            Console.Write("b = ");
            if (!double.TryParse(Console.ReadLine(), out double b))
                b = 0;
            Console.Write("c = ");
            if (!double.TryParse(Console.ReadLine(), out double c))
                c = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            //case 1 linear
            if (a == 0)
            {
                Console.WriteLine("Уравнение вырождается в линейное");
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("x - любой вещественное");
                        return;
                    }

                    Console.WriteLine("Корней нет");
                    return;
                }

                Console.WriteLine($"x = {c / b}");
                return;
            }

            double d = Math.Pow(b,2)- 4 * a * c;
            Console.WriteLine(Math.Sqrt(d));

            Console.WriteLine("Уравнение является квадратным");
            switch (d>=0)
            {
                case true:
                {
                    if (d == 0)
                    {
                        Console.WriteLine($"x = {(-1*b+Math.Sqrt(d))/2*a}");
                        return;
                    }
                    Console.WriteLine($"x1 = {(-1*b+Math.Sqrt(d))/(2*a)}");
                    Console.WriteLine($"x2 = {(-1*b-Math.Sqrt(d))/(2*a)}");
                    break;
                }
                case false:
                {
                    Console.WriteLine($"z1 = {(-b/2*a)}-{Math.Sqrt(Math.Abs(d))/2*a}i");
                    Console.WriteLine($"z2 = {(-b/2*a)}+{Math.Sqrt(Math.Abs(d))/2*a}i");
                    break;
                }
            }
        }
    }
}