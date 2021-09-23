using System;

namespace Hello__World_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Hello, {userInput}!", userInput);
        }
    }
}
