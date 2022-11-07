using System;
using System.Collections.Generic;
using System.Text;

namespace startingAlgorithms
{
    internal class BubbleSort
    {
        public static void bubblesort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
           
        }
    }
}
