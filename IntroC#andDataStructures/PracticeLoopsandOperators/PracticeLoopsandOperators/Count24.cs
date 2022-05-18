using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopsandOperators
{
    public class Count24
    {
        public Count24()
        {
            int incr = 1;
            for (int i = 0; i < 4; i++)
            {
                int count = 0;
                while (count < 24)
                {
                    Console.Write($"{count},");
                    count += incr;
                }
                Console.Write($"{24}");
                Console.WriteLine();
                incr++;
            }
        }
    }
}
