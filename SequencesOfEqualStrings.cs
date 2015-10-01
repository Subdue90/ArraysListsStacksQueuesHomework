using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SequencesOfEqualStrings
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your strings:");
            string[] inputElements = Console.ReadLine().Split(' ').ToArray();
            
            Console.WriteLine();
            for (int i = 0; i < inputElements.Length; i++)
            {
                Console.Write(inputElements[i]);
                if (i < inputElements.Length - 1 && (inputElements[i] == inputElements[i + 1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }

