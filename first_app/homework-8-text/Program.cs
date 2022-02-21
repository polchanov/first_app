using System;
using System.IO;
using System.Text.RegularExpressions;

namespace lesson_8_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Phone Book.csv";
            string content = GetBookText(filePath);
            Console.WriteLine("What are looking for?");
            string FindInPhone = Console.ReadLine(); // search query 
            Console.WriteLine("We think we find:");

            string[] names = content.Split("\n");

            Regex regex = new Regex(@"^(\w+);(\d+)$");

            var book = new (string name, int number)[names.Length];

            for (var index = 0; index < names.Length; index++)
            {
                var item = names[index];
                var match = regex.Match(item);


                if (item.Contains(FindInPhone))
                {
                    if (match.Success)
                    {
                        book[index].name = match.Groups[1].Value;
                        book[index].number = int.Parse(match.Groups[2].Value);
                        Console.WriteLine($"{book[index].name}, which phone number is  { book[index].number}");
                    }

                }

            }

        }

        static string GetBookText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

    }
}