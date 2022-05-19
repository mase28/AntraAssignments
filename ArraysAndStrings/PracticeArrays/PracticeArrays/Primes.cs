using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    public class Primes
    {
        public static int[] FindPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = start; i < end + 1; i++)
            {
                if (Primes.IsPrime(i))
                {
                    primes.Add(i);
                }
                
            }

            return primes.ToArray();
        }

        private static bool IsPrime(int p)
        {
            if (p <= 1 || p % 2 == 0)
            {
                return false;
            } else if (p == 2)
            {
                return true;
            } else
            {
                int mid = (int)Math.Floor(Math.Sqrt((double)p));
                for (int i = 3; i <= mid; i += 2)
                {
                    if (p % i == 0)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
