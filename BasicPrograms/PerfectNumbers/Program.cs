using System;
using System.Collections.Generic;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max num for evaluation");
            int userInput = int.Parse(Console.ReadLine());
            int sumOfArray = 0;

            List<int> numbers = new List<int>(), perfectNumbers = new List<int>();
            
            for (int i = 1; i < userInput; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        numbers.Add(j);
                    }
                }

                for (int x = 0; x < numbers.Count; x++)
                    sumOfArray += numbers[x];


                if (sumOfArray == i)
                {
                    perfectNumbers.Add(i);
                }

                sumOfArray = 0;
                numbers.Clear();

            }
            //hgcyjcmgckgchcgmhg
            for (int i = 0; i < perfectNumbers.Count; i++)
            {
                Console.WriteLine(perfectNumbers[i]);
            }
        }
    }
}