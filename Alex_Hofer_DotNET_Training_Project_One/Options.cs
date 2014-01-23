using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CommandLine;

namespace AlexHofer.DotNetTraining.ProjectOne
{
    internal class Options
    {
        private string _inputFile;
        private string _interactiveNumber;
        private string _outputFile;

        [Option('t', "interactive", HelpText = "Interactive mode - You will be prompted for a number.")]
        public string InteractiveNumber
        {
            get { return _interactiveNumber; }
            set { _interactiveNumber = value; }
        }

        [Option('i', "inputFile", HelpText = "A file to be used for input.")]
        public string InputFile
        {
            get { return _inputFile; }
            set { _inputFile = value; }
        }

        [Option('o', "outputFile", HelpText = "A file to be used for output.")]
        public string OutputFile
        {
            get { return _outputFile; }
            set { _outputFile = value; }
        }

        [HelpOption]
        public string GetUsage()
        {
            // this without using CommandLine.Text
            var usage = new StringBuilder();
            usage.AppendLine("Fibonacci Generator 1.0");
            return usage.ToString();
        }
    }
}