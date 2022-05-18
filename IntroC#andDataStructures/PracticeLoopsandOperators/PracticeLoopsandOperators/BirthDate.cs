using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopsandOperators
{
    public class BirthDate
    {
        public BirthDate(string date)
        {
            DateTime curr = new DateTime(2022, 5, 17);
            
            string[] date_split = date.Split("/");
            int[] date_num = new int[3] { int.Parse(date_split[0]), int.Parse(date_split[1]), int.Parse(date_split[2]) };

            DateTime inp = new DateTime(date_num[2], date_num[0], date_num[1]);

            TimeSpan ts = curr.Subtract(inp);

            Console.WriteLine($"You are {ts.Days} days old.");
        }
    }
}
