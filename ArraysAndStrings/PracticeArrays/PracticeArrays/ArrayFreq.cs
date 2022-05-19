using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    public class ArrayFreq
    {
        public static void MostFrequent()
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
            int max_count = 0;
            int max_value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                count = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] != curr)
                    {
                        break;
                    } else
                    {
                        count++;
                    }
                }
                if (count > max_count)
                {
                    max_count = count;
                    max_value = arr[i];
                }
                i += count - 1;
            }
            Console.WriteLine($"The Left Most frequent number in the sequence is: {max_value}");
        }
    }
}
