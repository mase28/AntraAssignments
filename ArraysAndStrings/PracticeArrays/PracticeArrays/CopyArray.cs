using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    public class CopyArray
    {
        public static void CopyToArray(int size)
        {
            int[] arr1 = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                arr1[i] = r.Next(1, 101);
            }

            int[] arr2 = new int[arr1.Length];
            for (int j = 0; j < arr1.Length; j++)
            {
                arr2[j] = arr1[j];
            }

            for (int k = 0; k < size; k++)
            {
                Console.WriteLine($"index: {k}, array1: {arr1[k]}, array2: {arr1[k]}");
            }
        }
    }
}
