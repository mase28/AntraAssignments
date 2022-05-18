using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopsandOperators
{
    public class Greetings
    {
        public Greetings()
        {
            DateTime dt = DateTime.Now;
            if (5 < dt.Hour && dt.Hour < 11)
            {
                Console.WriteLine("Good Morning!");
            } else if (11 < dt.Hour && dt.Hour < 15)
            {
                Console.WriteLine("Good Afternoon!");
            } else if (15 < dt.Hour && dt.Hour < 20)
            {
                Console.WriteLine("Good Evening!");
            } else if (20 < dt.Hour && dt.Hour < 5)
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
