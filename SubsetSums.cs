using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SubsetSums
    {
        static bool solution = false;
        static int[] input;
        static int givenSum;
        static void Main()
        {
            Console.WriteLine("Please, enter your numbers:");
            givenSum = int.Parse(Console.ReadLine());
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine();

            List<int> subset = new List<int>();
            MakeSubset(0, subset);
            if (!solution)
            {
                Console.WriteLine("No matching subsets");
            }
        }

        static void MakeSubset(int index, List<int> subset)
        {
            if (subset.Sum() == givenSum && subset.Count > 0) 
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", subset), givenSum);
                solution = true;
            }

            for (int i = index; i < input.Length; i++)
            {
                subset.Add(input[i]);
                MakeSubset(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }

