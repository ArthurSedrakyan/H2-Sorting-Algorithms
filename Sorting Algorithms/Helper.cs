using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Sorting_Algorithms
{
    public static class Helper
    {
        public static int[] CreateArr(int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(0, 20);

            return arr;
        }

        public static int[] GetArr(this int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }

        public static void Print(List<TimeSpan> ts,int index,List<string> symbols,List<int> memory)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"the Fastest is {symbols[index]}");
            Console.WriteLine($"Running time: {ts[index]}");
            Console.WriteLine($"Memory usage:: {memory[index]}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            ts.RemoveAt(index);
            memory.RemoveAt(index);
            symbols.RemoveAt(index);
            for (int i = 0; i < ts.Count; i++)         
            {
                Console.WriteLine($"You choose {symbols[i]}");
                Console.WriteLine($"Running time: {ts[i]}");
                Console.WriteLine($"Memory usage:: {memory[i]}");
                Console.WriteLine();
            }

        }
    }
    
}
