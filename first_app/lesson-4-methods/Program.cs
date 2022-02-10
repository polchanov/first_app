using System;

namespace lesson_4_methods
{
    internal class Program
    {
        /** static void Main(string[] args)
         {
             int sum = Sum(3, 5);
             Console.WriteLine(sum);
             Console.WriteLine(Sum(10, 20, true));
             Console.WriteLine(Sum(10, 20, false));
             Console.WriteLine(SumNumbers(10, 20));
             Console.WriteLine(SumNumbers(20, 10));

             int i = 10;
             Increment(ref i);
             Increment(ref i);
             Console.WriteLine(i);
             
             if (TryDivideByTree(i, out int result))
             {
                 Console.WriteLine(result);
             }

             Concat(10, 20); // 30
             Concat("10", "20"); // "10", "20"
             Concat("10", "20", "30"); // "10", "20", "30"
             Console.ReadKey();
         }

         static int Factorial(int value)
         {
             if (value == 1) return value;
             return value * Factorial(value - 1);
         }
         
         static void Concat(int a, int b)
         {
             Console.WriteLine(a + b);   
         }

         static void Concat(string a, string b)
         {
             Console.WriteLine($"{a}, {b}");
         }

         static void Concat(string a)
         {
             Console.WriteLine($"{a}");
         }

         static void Concat(string a, string b, string c)
         {
             Console.WriteLine($"{a}, {b}, {c}");
         }

         static void Concat(params string[] strings)

         { Console.WriteLine(strings.Length); }
         static bool TryDivideByTree(int a, out int result)
         {
             result = a / 3;
             return a % 3 == 0;

         }

         static int Increment(ref int i)
         {
             i++;
             return i;
         }


         static int Sum(int a, int b, bool r = true)
         {
             if (r == true)
             {
                 return a + b;
             }
             else { return a - b; }
         }
         static int SumNumbers(int a, int b)
             {
                 int sum = 0;
                 for (int i = a; i<= b; i++)
                 {
                     sum += i;
                     
                 }

                 return sum;
             }
        **/

        // HOMEWORK

        
             // Method that will return max value among all the parameters
            static int MethodMax(int a, int b)
            {
                return Math.Max(a, b);
            }

            static int MethodMax(int a, int b, int c)
            {
                return Math.Max(MethodMax(a, b), c);
            }

            static int MethodMax(int a, int b, int c, int d)
            {
                return Math.Max(MethodMax(a, b, c), d);
            }

            // Method that will return min value among all the parameter
            static int MethodMin(int a, int b)
            {
                return Math.Min(a, b);
            }
            static int MethodMin(int a, int b, int c)
            {
                return Math.Min(MethodMin(a, b), c);
            }

            static int MethodMin(int a, int b, int c, int d)
            {
                return Math.Min(MethodMin(a, b, c), d);
            }
            // Method TrySumIfOdd 

            static bool TrySumIfOdd(int a, int b, out int result)
                {
                    result = a + b;
                    return result % 2 != 0;
                }
            static void Main(string[] args)
            {
                if (TrySumIfOdd(1, 3, out int result))
                {
                    Console.WriteLine(result); // check how TrySumIfOdd works
                }

                Console.WriteLine($"MethodMax(1, 3): {MethodMax(1, 3)}"); // check how MethodMax works
                Console.WriteLine($"MethodMin(1, 3): {MethodMin(1, 3)}"); // check how MethodMin works
                Console.WriteLine($"MethodMax(1, 3, 5): {MethodMax(1, 3, 5)}"); // check how MethodMax works
                Console.WriteLine($"MethodMax(1, 3, 5, 7): {MethodMax(1, 3, 5, 7)}"); // check how MethodMax works
                Console.WriteLine($"MethodMin(1, 3, 5): {MethodMin(1, 3, 5)}"); // check how MethodMin works
                Console.WriteLine($"MethodMin(1, 3, 5, 7): {MethodMin(1, 3, 5, 7)}"); // check how MethodMin works

            }
    }
}
