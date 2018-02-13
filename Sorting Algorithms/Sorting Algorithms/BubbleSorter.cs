using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Sorting_Algorithms
{
    public static class BubbleSorter
    {
        public static TimeSpan Bubble(this int[] arr,List<int> memory)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int[] copyArr = arr.GetArr();

            for (int i = 0; i < copyArr.Length; i++)
            {
                bool isSort = true;
                for (int j = 0; j + i + 1 < copyArr.Length; j++)
                {
                    if (copyArr[j] > copyArr[j + 1])
                    {
                        int temp = copyArr[j];
                        copyArr[j] = copyArr[j + 1];
                        copyArr[j + 1] = temp;
                        isSort = false;
                    }
                }
                if(isSort)
                {
                    sw.Stop();
                    memory.Add(4 * arr.Length);
                    return sw.Elapsed;
                }
            }
            sw.Stop();
            memory.Add(4 * arr.Length);
            return sw.Elapsed;
            
        }
    }
}
