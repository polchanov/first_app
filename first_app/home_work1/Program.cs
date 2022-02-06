using System;

namespace home_work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -6*x^3+5*x^2-10*x+15
            // abs(x) * sin(x)
            // 2 * pi * x
            // max(x, y)

            double x = 1;
            Console.WriteLine(-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15);
            //Console.WriteLine(Math.Abs(x) * Math.Sin(x);
            double x2 = 1;
            Console.WriteLine(Math.Abs(x2) * Math.Sin(x2));
            double x3 = 1;
            Console.WriteLine(2 * Math.PI * x3);
            Console.WriteLine(Math.Max(2, 3));
            DateTime now = DateTime.Now;
            DateTime end = new DateTime(now.Year + 1, 1, 1);
            Console.WriteLine((int)(end - now).TotalDays);
            DateTime start = new DateTime(now.Year, 1, 1);
            Console.WriteLine((int)(now - start).TotalDays);
            // the End
        }
    }
}
