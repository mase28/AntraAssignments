using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    public class Manage
    {
        public static void Start()
        {
            List<String> elements = new List<string>();
            String inp = "test";

            while (inp != "Quit")
            {
                Console.WriteLine("Enter command (+ item, - item, -- to clear, and Quit to end)");
                inp = Console.ReadLine();
                string[] inps = inp.Split(' ');
                Console.WriteLine();
                if (inps[0] == "+")
                {
                    elements.Add(string.Join(" ", inps.ToArray().TakeLast(inps.Length-1)));
                    for (int i = 0; i < elements.Count; i++)
                    {
                        Console.WriteLine(elements[i]);
                    }
                } else if (inps[0] == "-")
                {
                    elements.Remove(string.Join(" ", inps.ToArray().TakeLast(inps.Length - 1)));
                    for (int i = 0; i < elements.Count; i++)
                    {
                        Console.WriteLine(elements[i]);
                    }
                } else if (inps[0] == "--")
                {
                    elements.Clear();
                    Console.WriteLine("Cleared List.");
                } else if (inps[0] == "Quit")
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
