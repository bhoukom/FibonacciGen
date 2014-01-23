using System;
using System.Collections.Generic;
using System.Linq;

using Core;

namespace AlexHofer.DotNetTraining.ProjectOne
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //var result = CommandLine.Parser.Default.ParseArguments<Options>(args);

            //Testing for file writing. STUB
            //Console.WriteLine("Please enter a file name for input:");
            //var input = Console.ReadLine();
            //Console.Clear();

            Console.WriteLine("Please enter a file name to output to:");
            var output = Console.ReadLine();
            Console.Clear();
            //End of stub

            //var xmlReader = XmlIo.ReadFile(input);

            

            //var fileInput = PlainTextIO.ReadFile(input);

            var returnedNumbers = FibonacciGenerator.FibGen(Convert.ToInt32(25));

            XmlIo.ToXml(output, returnedNumbers);

            //var fileOutput = PlainTextIO.WriteFile(output, returnedNumbers);

            //Going though each number in the list and writing it to the console.
            //NOTE: THe list will eventually be passed to one of three other methods that will output an XML File, Plain Text File, or just still write to the console.
            foreach (var returnedNumber in returnedNumbers)
            {
                Console.WriteLine(returnedNumber);
            }
        }
    }
}