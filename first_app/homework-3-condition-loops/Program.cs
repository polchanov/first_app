using System;

namespace homework_3_condition_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message1 = Console.ReadLine();
            string message2 = Console.ReadLine();
            if (float.TryParse(message1, out float x))
            {     
                   
                    if (float.TryParse(message2, out float y))
                    {
                        if (x == y) { Console.WriteLine(x); }
                        else
                        {
                            float min = Math.Min(x, y);
                            float max = Math.Max(x, y);
                            float result = 0;
                            for (; min <= max ; min++)
                            {
                                result += min;
                            }
                            Console.WriteLine(result);
                        }
                    }
                    else { Console.WriteLine("Invalid input"); }
            }
            else { Console.WriteLine("Invalid input"); }





        }
    }
}
