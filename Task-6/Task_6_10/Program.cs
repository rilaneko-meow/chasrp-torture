using System;

namespace FunctionSpase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var f = new Linear(-5);

            var g = new Linear(6, 2);         

            Console.WriteLine("f(x) = " + f);
            Console.WriteLine("a = " + f.a);
            Console.WriteLine("b = " + f.b);


            Console.WriteLine("f(2) = " + f.GetValue(2));
            if (f.IsConstant())
                Console.WriteLine("Функция постоянна");
            else
                Console.WriteLine("Функция непостоянна");


            var h = f + g + g;
            Console.WriteLine("h(x) = f(x) + 2g(x) = " + h);
            
            var t = f - g + h;
            Console.WriteLine("t(x) = f(x) - g(x) + h(x) = " + t);

            var w = 2 * (2 * f - g * 3);
            Console.WriteLine(w);

            var p = -f;

            Console.WriteLine($"w(x) = {w} = 0");
            Console.WriteLine(w.GetRoot());

        }
    }
}