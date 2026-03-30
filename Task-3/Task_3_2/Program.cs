using System;

namespace Task_3_2
{
    class Program
    {
        static double f(double x)
        {
            return Math.Log((Math.Sin(x*x)+2)/(x*x+2));
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double h);

            while(a<=b)
            {
                Console.WriteLine($"{a:F3} {f(a):F5}");
                a= a+h;
            }
        }
    }
}