using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your numbers on a single line, separated by a space:");
            string[] numbers = Console.ReadLine().Split();
            int[] sortedNums = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sortedNums[i] = int.Parse(numbers[i]);
            }
            Array.Sort(sortedNums);
            Console.WriteLine("Your sorted numbers:");
            Console.WriteLine(string.Join(" ", sortedNums));
        }
    }

