using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms.Sorting_Algorithms
{
    public static class HeapSorter
    {
       


        public static TimeSpan Heap(this int[] arr)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int n = arr.Length;
            int[] copyArr = arr.GetArr();

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                
                Sort(copyArr, n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = copyArr[0];
                copyArr[0] = copyArr[i];
                copyArr[i] = temp;

                
                Sort(copyArr, i, 0);
            }
            sw.Stop();
            
            return sw.Elapsed;
        }

        private static void Sort(int[] arr, int n, int i)
        {
            int largest = i;  
            int l = 2 * i + 1;
            int r = 2 * i + 2;          

            if (l < n && arr[l] > arr[largest])
                largest = l;

            if (r < n && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;


                Sort(arr, n, largest);
            }
        }

       
    }
}
