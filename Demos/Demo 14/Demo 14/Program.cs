using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = null;
            int[] sortedArray = null;

            array = new int[100];

            for (int i = 0; i < array.Length; ++i)
                array[i] = rand.Next(0, 100);

            Console.Write("Unsorted Array: " );
            PrintArray(array);

            Console.WriteLine();

            sortedArray = BubbleSort(array);

            Console.Write("Sorted Array: ");
            PrintArray(sortedArray);

            Console.Read();
        }

        static int[] BubbleSort(int[] a)
        {
            //Make copy of array I got passed
            int[] newArray = new int[a.Length];

            for (int i = 0; i < newArray.Length; ++i)
                newArray[i] = a[i];

            bool pSwapped = true;
            while (pSwapped)
            {
                pSwapped = false;
                for (int i = 0; i < newArray.Length - 1; ++i)
                {
                    if (newArray[i] > newArray[i + 1])
                    {
                        swap(ref newArray[i], ref newArray[i + 1]);
                        pSwapped = true;
                    }
                }
            }
            return newArray;
        }

        static void PrintArray(int[] a)
        {
            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
