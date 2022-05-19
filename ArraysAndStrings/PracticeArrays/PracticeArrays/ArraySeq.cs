using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    public class ArraySeq
    {
        public static void LongestSequence()
        {
            Console.Write("Enter Sequence of integers seperated by a space: ");
            string inp = Console.ReadLine();
            string[] inps = inp.Split(' ');
            int[] arr = new int[inps.Length];
            for (int i = 0; i < inps.Length; i++)
            {
                arr[i] = int.Parse(inps[i]);
            }
            Console.WriteLine();

            int count = 0;
            int max = 0;
            int[] max_idx = new int[2];
            int[] curr_idx = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                curr_idx[0] = i;
                count = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] != curr)
                    {
                        curr_idx[1] = j;
                        break;
                    } else
                    {
                        count++;
                    }
                }
                if (count > max)
                {
                    max = count;
                    max_idx[0] = curr_idx[0];
                    max_idx[1] = curr_idx[1];  
                }
                i += count - 1;
            }
            Console.Write("Longest Sequence: ");
            for (int i = max_idx[0]; i < max_idx[1]; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
