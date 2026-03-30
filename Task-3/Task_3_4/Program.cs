using System;

namespace Task_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "PassKey";
            string k = "";
            do{
                k = Console.ReadLine();
            }
                while(k != key);
            Console.WriteLine("Вход разрешен");
        }
    }
}