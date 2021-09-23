using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInput1, userInput2, sum;
            Console.Write("Enter the first number: ");
            userInput1 = double.Parse( Console.ReadLine());
            Console.Write("Enter the socond number: ");
            userInput2 = double.Parse( Console.ReadLine());

            Console.WriteLine($"The sum of the two numbers is: {userInput1 + userInput2} ");
        }
    }
}
