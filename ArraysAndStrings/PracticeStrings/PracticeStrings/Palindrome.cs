using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStrings
{
    public class Palindrome
    {
        public static void FindPalindromes()
        {
            Console.Write("Enter Sentence: ");
            string inp = Console.ReadLine();

            string s = "";
            for (int i = 0; i < inp.Length; i++)
            {
                if (!Char.IsPunctuation(inp[i]))
                {
                    s += inp[i];
                }
            }

            string[] words = s.Split(' ');
            string ret = "";
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    ret += word + ", ";
                }
            }
            Console.WriteLine($"Found Palindromes: {ret}");
        }

        private static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
