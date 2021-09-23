using System;

namespace DevidingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1, input2;
            Console.Write("Enter positive number: ");
            do
                input1 = double.Parse(Console.ReadLine());
            while (input1 <= 0); ;
            Console.Write("Enter other positive number: ");
            do
                input2 = double.Parse(Console.ReadLine());
            while (input2 <= 0); ;

            Console.WriteLine($"The result of the operation is {input1/input2}");
        }
    }
}
