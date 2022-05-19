using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStrings
{
    public class Reverse
    {
        public static void ReverseString()
        {
            Console.Write("Enter string to reverse: ");
            string inp = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Convert to char array, reverse, then convert to string method: ");
            Console.Write($"string before reverse {inp}, string after reverse: ");
            char[] arr = inp.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            string ret = String.Join("", arr);
            Console.WriteLine($"{ret}");

            Console.WriteLine();   

            Console.WriteLine("Printing string backwards method: ");
            Console.Write($"string before reverse {inp}, string after reverse: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{inp[i]}");
            }
            Console.WriteLine();
        }

        public static void ReverseWords()
        {
            Console.Write("Enter Sentence to reverse: ");
            string inp = Console.ReadLine();
            Console.WriteLine();

            List<char> ignore = new List<char>() { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};

            string[] words = inp.Split(' ');

            Console.Write($"Sentence before reversal: {inp} \nsentence after reversal: ");
            for (int i = 0; i < words.Length / 2; i++)
            {
                string temp = words[i];
                char punct = ' ';
                if (ignore.Contains(temp[temp.Length-1]))
                {
                    punct = temp[temp.Length - 1];
                    temp = String.Join("", temp.Take(temp.Length - 1));
                    words[i] = words[words.Length - 1 - i] + punct;
                    words[words.Length - 1 - i] = temp;
                } else if (ignore.Contains(words[words.Length - 1 - i][words[words.Length - 1 - i].Length - 1])) {
                    punct = words[words.Length - 1 - i][words[words.Length - 1 - i].Length - 1];
                    words[i] = String.Join("", words[words.Length - 1 - i].Take(words[words.Length - i - 1].Length - 1));
                    words[words.Length - i - 1] = temp + punct;
                } else
                {
                    words[i] = words[words.Length - 1 - i];
                    words[words.Length - i - 1] = temp;
                }
            }
            Console.WriteLine(String.Join(" ", words));
        }
    }
}
