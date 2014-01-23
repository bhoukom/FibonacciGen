using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class FibonacciGenerator
    {
        //Making my Fibonacci Generator method so I can call it from where ever I want.
        public static IEnumerable<int> FibGen(int n)
        {
            //Creating a list to store all the generated numbers in.
            var _numberList = new List<int>();

            //Setting my variables for the loop.
            var first = 0;
            var second = 1;

            //Adding the first two numbers to the list because they will be changed, there's probably a better way to do this but for now it works.
            _numberList.Add(first);
            _numberList.Add(second);

            //Array that will loop "n" times specified by the User to generate a list of Fibonacci numbers.
            for (var i = 2; i < n; i++)
                {
                    var next = second;

                    second = first + second;

                    first = next;

                    //Adding the newest Fibonacci number to the list.
                    _numberList.Add(second);
                }

            //Return my list to the main loop.
            return _numberList;
        }
    }
}