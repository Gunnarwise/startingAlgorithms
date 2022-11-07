using System;
using System.Collections.Generic;
using System.Text;

namespace startingAlgorithms
{
    internal class QuickSort
    {
        public static int partition(int[] arr, int left, int right)
        {
            int pivot = arr[0];

            while (true)
            {
                while (arr[left] < pivot )
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void quicksort(int[] arr, int left, int right)
        {
            int pivot;
            
            if (left  > right)
            {
                pivot = partition(arr, left, right);
                
                if (pivot > 1)
                {
                    quicksort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quicksort(arr, pivot + 1, right);
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
