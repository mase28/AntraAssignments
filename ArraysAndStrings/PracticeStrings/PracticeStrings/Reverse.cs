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
                string temp_aft = "";
                int target = words.Length - 1 - i;
                string targ_aft = "";
                
                string temp_punct_bef = "";
                string temp_punct_aft = "";
                string targ_punct_bef = "";
                string targ_punct_aft = "";

                bool flag = false;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (ignore.Contains(temp[j]) && !flag)
                    {
                        temp_punct_bef += temp[j];
                    } 
                    else if (ignore.Contains(temp[j])) 
                    {
                        temp_punct_aft += temp[j];
                    } 
                    else
                    {
                        temp_aft += temp[j];
                        flag = true;
                    }
                }

                flag = false;
                for (int j = 0; j < words[target].Length; j++)
                {
                    if (ignore.Contains(words[target][j]) && !flag)
                    {
                        targ_punct_bef += words[target][j];
                    }
                    else if (ignore.Contains(words[target][j]))
                    {
                        targ_punct_aft += words[target][j];
                    }
                    else
                    {
                        targ_aft += words[target][j];
                        flag = true;
                    }
                }

                words[i] = temp_punct_bef + targ_aft + temp_punct_aft;
                words[target] = targ_punct_bef + temp_aft + targ_punct_aft;
                
            }
            Console.WriteLine(String.Join(" ", words));
        }
    }
}
