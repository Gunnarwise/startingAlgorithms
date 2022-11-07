﻿using System;
using System.Collections.Generic;
using System.Text;

namespace startingAlgorithms
{
    internal class SelectionSort
    {
        public static void selectionsort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
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
