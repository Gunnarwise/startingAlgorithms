using System;
using System.Collections.Generic;
using System.Text;

namespace startingAlgorithms
{
    internal class LinearSearch
    {
        public static int linearsearch(int[] arr, int x)
        {
            int index = 0;
            while (index < arr.Length)
            {
                if (arr[index] == x)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
