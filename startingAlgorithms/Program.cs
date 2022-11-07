using System;

namespace startingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 4, 5, 2, 7, 6, 9, 8, 0, 11 ,13, 14, 17, 12, 23, 567, 2435, 567, 111 };

            //binary search
            Console.WriteLine("binary search:");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Console.WriteLine(BinarySearch.binarysearch(numbers, 11));
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed}" + "\n\n\n");

            // linear search
            Console.WriteLine("Linear Search");
            var watch2 = new System.Diagnostics.Stopwatch();
            watch2.Start();
            Console.WriteLine(LinearSearch.linearsearch(numbers, 6));
            watch2.Stop();
            Console.WriteLine($"Execution Time: {watch2.Elapsed}" + "\n\n\n");

            // bubble sort
            Console.WriteLine("Bubble Sort");
            var watch3 = new System.Diagnostics.Stopwatch();
            watch3.Start();
            BubbleSort.bubblesort(numbers);
            watch3.Stop();
            Console.WriteLine($"Execution Time: {watch3.Elapsed}" + "\n\n\n");

            // Selection Sort
            Console.WriteLine("Selection Sort");
            var watch4 = new System.Diagnostics.Stopwatch();
            watch4.Start();
            SelectionSort.selectionsort(numbers);
            watch4.Stop();
            Console.WriteLine($"Execution Time: {watch4.Elapsed}" + "\n\n\n");

            // quick Sort
            Console.WriteLine("quick Sort");
            var watch5 = new System.Diagnostics.Stopwatch();
            watch5.Start();
            QuickSort.quicksort(numbers, 0, numbers.Length - 1);
            watch5.Stop();
            Console.WriteLine($"Execution Time: {watch5.Elapsed}" + "\n\n\n");

            // merge Sort
            Console.WriteLine("merge Sort");
            var watch6 = new System.Diagnostics.Stopwatch();
            watch6.Start();
            MergeSort.sort(numbers, 0, numbers.Length - 1);
            MergeSort.printArray(numbers);
            watch6.Stop();
            Console.WriteLine($"Execution Time: {watch6.Elapsed}" + "\n\n\n");

        }


    }
}
