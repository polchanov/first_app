using System;

namespace homework_7_string
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Type strings to Comapare");
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Console.WriteLine(Compare(string1, string2));

            Console.WriteLine("Type string to Count");
            string string3 = Console.ReadLine();
            Console.WriteLine($"You have {CoutInt(string3)} digit(s)");
            Console.WriteLine($"You have {CountLetter(string3)} letter(s)");
            int CountAnother = string3.Length - CoutInt(string3) - CountLetter(string3);
            Console.WriteLine($"You have {CountAnother} another special character(s)");
 

           static bool Compare(string str1, string str2)
            {
                int length = str1.Length;
                if (length != str2.Length)
                    return false;
                for (int i = 0; i < length; i++)
                    if (str1[i] != str2[i])
                        return false;
                return true;
            }

            static int CoutInt(string str1)
            {
                int IntInString = 0;
                for (int i = 0; i < str1.Length; i++)
                    if (char.IsDigit(str1[i]))
                        IntInString++;
                return IntInString;
            }

            static int CountLetter(string str1)
            {
                int LetterInString = 0;
                for (int i = 0; i < str1.Length; i++)
                    if (char.IsLetter(str1[i]))
                        LetterInString++;
                return LetterInString;
            }


            // Тут нашел в интернете код, и подогнал по себя
            string str;
            char[] arr1;
            char ch1;
            int index, j, l;
            Console.Write("Input the string to sort: ");
            str = Console.ReadLine();
            l = str.Length;
            arr1 = str.ToCharArray(0, l);

            for (index = 1; index < l; index++)
                for (j = 0; j < l - index; j++)

                    if (arr1[j] > arr1[j + 1])
                    {
                        ch1 = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch1;
                    }

            foreach (char c in arr1)
            {
                ch1 = c;
                Console.Write("{0}", ch1);
            }
            // Тут найденый в интернете текст подогнать не получилось((((

            Console.Write("\n");
          
            {
                Console.WriteLine("Let me find duplicatesd in input string");
                string text = Console.ReadLine();
                int Count = 0;
                char PreCh = ' ';
                foreach (char ch in text)
                {
                    foreach (char cha in text)
                        if (cha != PreCh && cha == ch)
                            Count++;
                    if (Count > 1)
                        Console.Write("{0} ", ch, Count);
                    Count = 0;
                    PreCh = ch;
                }
                Console.Write("\n"); 
                Console.ReadKey();

            }
        }
    }
}
