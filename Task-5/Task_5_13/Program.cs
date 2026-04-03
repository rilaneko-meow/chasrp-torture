using System;

namespace Tusk_5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            double result = Recursive_Progression_Sum(n);

             Console.WriteLine($"S({n}) = {result}");
        }

    static double Recursive_Progression_Sum(int n)
    {
        if (n == 1)
            return 1;
        else
            return 1.0 / (n * n) + Recursive_Progression_Sum(n - 1);
    }
    }
}
