using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopsandOperators
{
    public class PrintAPyramid
    {
        public PrintAPyramid(int bot)
        {
            int stars = 1;
            int spaces = bot / 2;

            while (stars <= bot)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", spaces)) + String.Concat(Enumerable.Repeat("*", stars)) + String.Concat(Enumerable.Repeat(" ", spaces)));
                stars += 2;
                spaces -= 1;
            }
        }
    }
}
