using System;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);
            int u = (1-a)*(1-a);
            int v = 4*a*(b-3);

            int t = u*u+8*v*v;

            Console.WriteLine("u = "+u);
            Console.WriteLine("v = "+v);
            Console.WriteLine("t = "+t);
        }
    }
}