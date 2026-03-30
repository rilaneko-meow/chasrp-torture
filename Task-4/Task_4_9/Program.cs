using System;

namespace Task_4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);

            double[,] arr = new double[a, b];

            for(int i =0;i<a;i++){
                for(int j =0;j<b;j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    double.TryParse(Console.ReadLine(), out double c);
                    arr[i,j] = c;
                }
            }

            double[] rr = new double[a];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                rr[i] = arr[i,0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j]>rr[i])
                    {
                        rr[i] = arr[i,j];
                    }
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for(int i=0; i<a;i++)
            {
                Console.WriteLine($"Максимум строки {i}: {rr[i]}");
            }
        }
    }
}