using System;

namespace Task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            if (!double.TryParse(Console.ReadLine(), out double x))
                x = 0;
            Console.Write("y = ");
            if (!double.TryParse(Console.ReadLine(), out double y))
                y = 0;

            bool check = true;

            // Check 1
            check = check ^ (x*x+y*y <= 1);

            check = check ^ (y>-x+1);

            string str = "";

                if(!check)
                {
                    str = "не ";
                }

            Console.WriteLine($"f({x},{y}) {str}попадает в искомую область");
        }
    }
}