using System;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file Name", ConsoleColor.Red);
            var input = Console.ReadLine();
            Console.WriteLine($"File Name " + input, ConsoleColor.Green);
        }
    }
}
