using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms.Sorting_Algorithms
{
    public static class InsertionSorter
    {
        public static TimeSpan Insertion(this int[] arr, List<int> memory)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] copyArr = arr.GetArr();

            for (int i = 1; i < copyArr.Length; i++)
            {
                int j = i;
                while (j > 0 && copyArr[j] < copyArr[j - 1])
                {
                    int temp = copyArr[j];
                    copyArr[j] = copyArr[j - 1];
                    copyArr[j - 1] = temp;
                    --j;
                }
            }
            sw.Stop();
            memory.Add(4 * arr.Length);
            return sw.Elapsed;
        }

    }
}
