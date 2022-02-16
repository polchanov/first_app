﻿using System;

namespace homework_6_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            int N = 10;

            var random = new Random();
            int[] randomArray = new int[N];
            for (i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(100);
            }

            Console.WriteLine("----!!--");
            i = -1;
            foreach (int item in BubbleSort(randomArray))
            {
                Console.WriteLine($"BubbleSort result: {++i} item of array is {item}");
                
            }

            foreach (int item in SelectionSort(randomArray))
            {
                Console.WriteLine($"SelectionSort result: {++i} item of array is {item}");

            }

            foreach (int item in InsertionSort(randomArray))
            {
                Console.WriteLine($"InsertionSort result: {++i} item of array is {item}");

            }

            Console.ReadKey();
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length -1 ; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;

                    }
                    int temp = array[min];
                    array[min] = array[i];
                    array[i] = temp;
                }
            }
            return array;
        }

        static int[] InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while(j>=0 && array[j] > key)
                {
                    array[j+1] = array[j];
                    j = j - 1;
                }
                array[j+1] = key;
            }
            return array;
        }

    }
}
