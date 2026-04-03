using System;

namespace Tusk_5_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine();


            int rez = IsPrime(n);

            Console.WriteLine(rez);
           
            // Выводит простые числа.
            static int IsPrime(int n)
            {
                int result = 0;
                for (int i = 2; i <= n; i++)
                {
                    int k = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                            k ++;
                    }
                    
                    if (k == 1)
                    { 
                        Console.WriteLine($"{i}"); 
                        result = i; 
                    } 
                }
                return result;       
            }
            
        }
    }
}



