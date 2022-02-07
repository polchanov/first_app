using System;

namespace lesson_3_condition_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            if (a <=b)
            {
                Console.WriteLine($"{a} is less than {b}");
            }

            else
            {
                Console.WriteLine($"{a} is more than {b}");
            }

            switch (a)
            {
                case 5:
                    Console.WriteLine("a is 5");
                    break;
                case 6:
                    Console.WriteLine("a is 6");
                    break;
                case 7:
                    Console.WriteLine("a is 7");
                    break;
                default : Console.WriteLine("a is something");
                    break;

            }

            string s = a <= 5
                ? $"{a} is less than {b}"
                : $"{a} is more than {b}";

            int c = a <= b
                ? a + b
                : a - b;

            Console.WriteLine(s);

            const int N = 10;
            int sum = 0;
            int i = 0;
            for (; i < N; i++)
            {
               sum += i;
            }
            Console.WriteLine(sum);
            sum = 0;
            i = 0;
            while (i < N)
            {
                sum += i++;
            }
            Console.WriteLine(sum);

            sum = 0;
            i = 0;
            do
            {
                sum += i++;
            } while (i < N);
            
            sum = 0;
            i = 0;
            for(; i < N; i++)
            {
                if (i % 2 == 0)
                { sum += i;                }
            }

            i = 0;
            sum = 0;
            for (; i < N; i++)
            {
                sum += (i % 2 == 0)
                ? i
                : 0;
            }

            i = 0;
            sum = 0;
            for (; i < N; i++)
            {
                if ( i % 2 != 0)
                {
                    continue; 
                }
                sum += i;
                }

            i = 0;
            sum = 0;
            while (true)
            {
                
                if (i == N)
                {
                    break;
                }
                sum += i++;

            }
            Console.WriteLine(sum);
            Console.WriteLine("------------");
            //Console.ReadKey();
            //string message = Console.ReadLine();

            //int.Parse(message);
            // if (int.TryParse(message, out int digit))
            // {
            //  Console.WriteLine(digit);
            // }
            // else { Console.WriteLine("Input is incorrect"); }

            // Console.WriteLine(message);





            // a i b  ввдоми з клави
            // v
            // 1 - додавання
            // 2 - відмінмання
            // 3 множення
            // 4 ділення
            // друге значення - вихід з програми

            //string a1 = Console.ReadLine();
            //string b1 = Console.ReadLine();
            //int a11 = int.Parse(a1);
            //int b11 = int.Parse(b1);
            //Console.WriteLine(a11 + b11);

            
            string message1 = Console.ReadLine();
            if (float.TryParse(message1, out float digit1))
            {
             //Console.WriteLine(digit + 1);
            }
            else { Console.WriteLine("Input is incorrect"); }

            string message2 = Console.ReadLine();
            if (float.TryParse(message2, out float digit2))
            {
                //Console.WriteLine(digit + 1);
            }
            else { Console.WriteLine("Input is incorrect"); }

            string message3 = Console.ReadLine();
            if (int.TryParse(message3, out int digit3))
            {
                switch (digit3)
                {
                    case 1:
                        Console.WriteLine(digit1 + digit2);
                        break;
                    case 2:
                        Console.WriteLine(digit1 - digit2);
                        break;
                    case 3:
                        Console.WriteLine(digit1 * digit2);
                        break;
                    case 4:
                        Console.WriteLine(digit1 / digit2);
                        break;
                    default:
                        break;

                }
            }
            else { }


           


            //if (int.TryParse(a1, out int digit1))
            // {
            //  Console.WriteLine(digit);
            // }

            //int b = Console.ReadLine();


            //if (int.TryParse(message, out int digit))
            //{
            //  Console.WriteLine(digit);
            //  }
            //int result 
            //Console.WriteLine(result);

        }
    }
}
