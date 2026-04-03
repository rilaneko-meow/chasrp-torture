using System;

namespace FunctionSpase
{
    public class Linear
    {
        public double a;
        public double b;

        public Linear() { }
        public Linear(double a) => this.a = a;
        public Linear(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            if (a == 0 && b == 0)
                return "0";
            else if (a == 0)
                return $"{b}";
            else if (b == 0)
                return $"{a}x";
            else if (b > 0)
                return $"{a}x + {b}";
            else
                return $"{a}x - {-b}";
        }


        public double GetValue(double x = 0) => a * x + b;

        //public double GetValue() => b;

        public bool IsConstant() => a == 0;

        public bool IsIncreasing() => a > 0;

        public bool IsDecreasing() => a < 0;

        private static Linear _GetNegative(Linear f) =>
            new Linear(-f.a, -f.b);

        public static Linear _GetSum(Linear f, Linear g) =>
            new Linear(f.a + g.a, f.b + g.b);
        public static Linear Negative(Linear f) => _GetNegative(f);
        public static Linear operator -(Linear f) => _GetNegative(f);


        public static Linear Sum(Linear f, Linear g) => _GetSum(f, g);
        public static Linear operator +(Linear f, Linear g) => _GetSum(f, g);

        private static Linear _GetSub(Linear f, Linear g) =>
            new Linear(f.a - g.a, f.b - g.b);
        public static Linear Sub(Linear f, Linear g) => _GetSub(f, g);
        public static Linear operator -(Linear f, Linear g) => _GetSub(f, g);

        private static Linear _GetScale(double k, Linear f) =>
            new Linear(k * f.a, k * f.b);
        public static Linear Scale(double k, Linear f) => _GetScale(k, f);
        public static Linear operator *(double k, Linear f) => _GetScale(k, f);
        public static Linear Scale(Linear f, double k) => _GetScale(k, f);
        public static Linear operator *(Linear f, double k) => _GetScale(k, f);

        public string GetRoot()
        {
            if (a == 0 && b == 0)
                return "x - любое";
            else if (a == 0)
                return "нет корней";
            else
                return $"x = {-b / a}";
        }

    }
}