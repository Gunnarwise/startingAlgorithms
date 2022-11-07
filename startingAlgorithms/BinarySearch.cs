using System;
using System.Collections.Generic;
using System.Text;

namespace startingAlgorithms
{
    internal class BinarySearch
    {
        public static int binarysearch(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (true)
            {
                int mid = (low + high) / 2;
                if (x == arr[mid])
                {
                    return mid;
                }

                else if (x > arr[mid])
                {
                    low = mid + 1;
                }

                else
                {
                    high = mid - 1;
                }
            }

        }
    }
}
