using System;

namespace Tusk_5_7
{
    public class Program
    {
        static void Main(string[] args) 
        { 
            Console.WriteLine(GetMean()); 
            Console.WriteLine(GetMean(6)); 
            Console.WriteLine(GetMean(3, 8)); 
            Console.WriteLine(GetMean(5, 0, 1, -2, 7, 56, 12, 9)); 
        } 
        // вычисляющий среднее значение среди заданных чисел
        static double GetMean(params double[] numbers) 
        { 
            double sr_arifm = 0;
            double sum = 0;
            int k = 0;

            foreach (var x in numbers) 
            {
                sum += x; 
                k += 1;
            }
            if (k ==0)
                sr_arifm = 0;
            else
                sr_arifm = sum / k;
            return sr_arifm; 
        } 
    }
}


