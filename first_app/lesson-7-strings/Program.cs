using System;
using System.Text;

namespace lesson_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string placeholder = "Hello {0} and {1}"; ;
            string name = "Serhii";
            string hisName = "Alex";
            Console.WriteLine("Hello " + name);
            Console.WriteLine(string.Format("Hello {0}",  name));
            Console.WriteLine(string.Format("Hello {0} and {1}",  name, hisName));
            Console.WriteLine($"Hello {name} and {hisName}");
            Console.WriteLine(string.Format(placeholder, name, hisName));


            var hello = $"Hello, {name} and {hisName}";
            char symbol = hello[0];

            Console.WriteLine(symbol);
            Console.WriteLine(char.IsLetter(symbol));
            Console.WriteLine(char.IsDigit(symbol));
            Console.WriteLine(char.IsUpper(symbol));

            Console.WriteLine(hello.Contains('q'));
            Console.WriteLine(hello.Contains("hii"));
            Console.WriteLine(hello.EndsWith("lex"));
            Console.WriteLine(hello.StartsWith("lex"));

            var helloPlaceHolder = "Hello ";
            var index = helloPlaceHolder.IndexOf(' '); // 5
            
            Console.WriteLine("Hello ".Insert(index + 1, name));
            Console.WriteLine($"Helo {name}".Replace(name, hisName));

            Console.WriteLine(hello.PadLeft(40));
            Console.WriteLine(hello.PadLeft(40).Trim());
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());

            Console.WriteLine(String.Compare("abc", "bcd"));
            Console.WriteLine(String.Equals("abc", "bcd"));
            Console.WriteLine("abc" == "bcd");
            Console.WriteLine("abc" != "bcd");
            Console.WriteLine("Hello " + name);
            
            
            var emptyString = string.Empty;
            const int N = 13;
            for(int i = 0; i < N; i++)
            {
                emptyString += $" {i}";
            }

            

            var stringBuilder = new StringBuilder();
            for(int i = 0; i < N; ++i)
            {
                stringBuilder.AppendFormat(" {0}", i);
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine(emptyString);

           // Uppercase => Lowecase
           string string1 = Console.ReadLine();
           string string2 = string.Empty;
           for (int i = 0; i< string1.Length; i++)
            {
                
                if (char.IsUpper(string1[i]))
                {
                    ///char string2 = string1[i];
                    string2 += char.ToLower(string1[i]);
                }

                if (char.IsLower(string1[i]))
                {
                    ///char string2 = string1[i];
                    string2 += char.ToUpper(string1[i]);
                }
                
            }

            Console.WriteLine(string2);


        }
    }
}
