using System;
using System.Collections.Generic;
using System.Linq;

namespace Alex_Hofer_DotNET_Training_Project_One
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //Stub for now, will be adding console parsing in the future.
            Console.WriteLine("Please enter a number:");
            var input = Console.ReadLine();
            Console.Clear();
            //End of stub

            //Getting my input from the console, converting to an Int, then sending it off to the Fibonacci generator.
            //Then getting back the list of numbers and storing it into "returnedNumbers".
            var returnedNumbers = FibonacciGenerator.FibGen(Convert.ToInt32(input));

            //Going though each number in the list and writing it to the console.
            //NOTE: THe list will eventually be passed to one of three other methods that will output an XML File, Plain Text File, or just still write to the console.
            foreach (var returnedNumber in returnedNumbers)
            {
                Console.WriteLine(returnedNumber);
            }
        }
    }
}