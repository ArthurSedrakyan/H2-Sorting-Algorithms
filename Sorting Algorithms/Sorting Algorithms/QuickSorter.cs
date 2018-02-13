using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms.Sorting_Algorithms
{
    public static class QuickSorter
    {
        public static TimeSpan Quick(this int[] arr, List<int> memory)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] copyArr = arr.GetArr();
            Sort(copyArr, 0, copyArr.Length - 1);
            sw.Stop();
            memory.Add(((int)Math.Log(arr.Length) + arr.Length) * 4);
            return sw.Elapsed;
        }

        private static void Sort(int[] arr, int lowerIndex, int higherIndex)
        {

            int left = lowerIndex;
            int right = higherIndex;

            int pivot = arr[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (left <= right)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    left++;
                    right--;
                }
            }
            if (lowerIndex < right)
                Sort(arr, lowerIndex, right);

            if (left < higherIndex)
                Sort(arr, left, higherIndex);
        }
    }
}
