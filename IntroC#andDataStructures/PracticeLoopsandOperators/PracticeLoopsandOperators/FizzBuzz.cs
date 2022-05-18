using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopsandOperators
{
    class FizzBuzz
    {
        public FizzBuzz(int n)
        {
            for (int i = 1; i < n+1; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");

                } else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");

                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
