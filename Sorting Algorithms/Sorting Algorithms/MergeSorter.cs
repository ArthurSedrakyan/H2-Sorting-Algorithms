using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms.Sorting_Algorithms
{
    public static class MergeSorter
    {
        public static TimeSpan Merge(this int[] arr, int left, int right)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (left < right)
            {
                int m = (left + right) / 2;

                Merge(arr, left, m);
                Merge(arr, m + 1, right);

                Sort(arr, left, m, right);
            }
            sw.Stop();
           
            return sw.Elapsed;
        }

        private static void Sort(int[] arr, int left, int m, int right)
        {
            int n1 = m - left + 1;
            int n2 = right - m;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int p = 0; p < n1; ++p)
                leftArr[p] = arr[left + p];
            for (int n = 0; n < n2; ++n)
                rightArr[n] = arr[m + 1 + n];


            int i = 0, j = 0;

            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

       
        
    }
}
