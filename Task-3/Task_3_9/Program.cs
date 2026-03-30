using System;

namespace Task_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);

            for(int i=1; i<=a; i++)
            {
                int t = 0;
                for(int j = 1; j<=i-1;j++)
                {
                    if (i % j == 0)
                    {
                        t+=j;
                    }
                }
                if(t==i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}