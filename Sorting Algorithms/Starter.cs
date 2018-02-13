using System;
using Sorting_Algorithms.Sorting_Algorithms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Starter
    {
        private List<int> memory = new List<int>();
        public void Start()
        {
            Console.Write("Please enter the size of an array that you want to sort: ");

            string n = Console.ReadLine();
            int size = Convert.ToInt32(n);

            int[] arr = Helper.CreateArr(size);

            Console.WriteLine("Select which algorithm you want to perform");
            Console.WriteLine("1.Insertion sort \n2.Bubble sort \n3.Quick sort \n4.Heap sort \n5.Merge sort \n6.All");

            n = Console.ReadLine();
            string[] alg1 = n.Split(',');
            string[] alg2 = n.Split('-');
            int[] alg3;
            if (alg1.Length == 1 && alg2.Length == 1)
            {
                if (alg1[0].Equals("6") && alg1.Length == 1)
                {
                    alg3 = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        alg3[i] = i + 1;
                    }
                    AlgorithmChoose(arr, alg3);

                }
                else
                {
                    alg3 = new int[1];
                    alg3[0] = Convert.ToInt32(alg1[0]);
                    AlgorithmChoose(arr, alg3);
                }

            }
            else if (alg1.Length == 1)
            {
                alg3 = new int[Convert.ToInt32(alg2[alg2.Length - 1]) - Convert.ToInt32(alg2[0]) + 1];
                for (int i = 0; i < alg3.Length; i++)
                {
                    alg3[i] = Convert.ToInt32(alg2[0]) + i;
                }
                AlgorithmChoose(arr, alg3);
            }
            else
            {
                alg3 = new int[alg1.Length];
                for (int i = 0; i < alg1.Length; i++)
                {
                    alg3[i] = Convert.ToInt32(alg1[i]);
                }
                AlgorithmChoose(arr, alg3);
            }
        }

        public void AlgorithmChoose(int[] arr, int[] alg)
        {
            List<TimeSpan> sw = new List<TimeSpan>(3);
            List<string> symbols = new List<string>(3);
            foreach (int item in alg)
            {
                switch (item)
                {
                    case 1:
                        sw.Add(arr.Insertion(memory));
                        symbols.Add("Insertion sort");
                        break;
                    case 2:
                        sw.Add(arr.Bubble(memory));
                        symbols.Add("Bubble sort");
                        break;
                    case 3:
                        sw.Add(arr.Quick(memory));
                        symbols.Add("Quick sort");
                        break;
                    case 4:
                        memory.Add(4 * arr.Length);
                        sw.Add(arr.Heap());
                        symbols.Add("Heap sort");
                        break;
                    case 5:
                        memory.Add(4 * arr.Length * 2);
                        sw.Add(arr.Merge(0, arr.Length - 1));
                        symbols.Add(" Merge sort");
                        break;

                }
            }

            TimeSpan min = sw[0];
            int index = 0;
            for (int i = 1; i < sw.Count; i++)
            {
                if (sw[i] < min)
                {
                    min = sw[i];
                    index = i;
                }
            }

            Helper.Print(sw, index,symbols,memory);

        }

    }
}
