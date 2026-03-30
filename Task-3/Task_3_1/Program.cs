using System;

namespace Task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long.TryParse(Console.ReadLine(), out long a);
            long b = a;
            int i = 2;
            int t = 0;
            while (i < Math.Sqrt(a)){
                if (b % i == 0){
                    b = b / i;
                    t++;
                }else
                {
                    if(t!=0)
                    {
                        Console.WriteLine(i+" ^ "+t);
                        t=0;
                    }
                    i++;
                }
            }
        }
    }
}