using System;

namespace Task_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            if (!double.TryParse(Console.ReadLine(), out double x))
                x = 0;

            double f;

            // Условный выбор и вычисление f
            if (x < -2)
            {
                f = Math.Abs(x)*Math.Sin(x);
            }else if (-2<=x && x<0)
            {
                f = Math.Pow(Math.E, 2*x);
            }else if (x == 0)
            {
                f = 1;
            }else
            {
                f = Math.Log(x*x+1);
            }

            Console.WriteLine($"f({x}) = {f:F7}");
        }
    }
}