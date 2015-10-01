using System;
using System.Linq;
using System.Collections.Generic;

    class CategorizeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your numbers: ");
            string[] numbers = Console.ReadLine().Split();
            float[] floatNumbers = new float[numbers.Length];

            List<float> floatingPointNums = new List<float>();
            List<int> roundNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                floatNumbers[i] = float.Parse(numbers[i]); 
                int intNums = (int)floatNumbers[i]; 
                
                if (intNums != floatNumbers[i]) 
                {
                    floatingPointNums.Add(floatNumbers[i]);
                }
                else
                {
                    roundNumbers.Add(intNums);
                }
            }

            Console.WriteLine();
            Console.Write("[");

            for (int k = 0; k < floatingPointNums.Count - 1; k++)
            {
                Console.Write("{0}, ", floatingPointNums[k]);
            }

            Console.Write(floatingPointNums[floatingPointNums.Count - 1]);
            Console.Write("] -> ");
            Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", floatingPointNums.Min(), floatingPointNums.Max(),
                            floatingPointNums.Sum(), floatingPointNums.Average());
            Console.WriteLine();
            Console.Write("[");

            for (int k = 0; k < roundNumbers.Count - 1; k++)
            {
                Console.Write("{0}, ", roundNumbers[k]);
            }

            Console.Write(roundNumbers[roundNumbers.Count - 1]);
            Console.Write("] -> ");
            Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", roundNumbers.Min(), roundNumbers.Max(),
                            roundNumbers.Sum(), roundNumbers.Average());

            Console.ReadKey(true);
        }
    }

