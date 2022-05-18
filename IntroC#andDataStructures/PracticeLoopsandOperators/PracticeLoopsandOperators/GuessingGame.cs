using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoopsandOperators
{
    public class GuessingGame
    {
        public GuessingGame(int low, int high)
        {
            int number = new Random().Next(low, high+1);
            int guess = low - 1;
            while (guess != number)
            {
                Console.Write("Enter Guess: ");
                guess = int.Parse(Console.ReadLine()); 
                if (guess < number)
                {
                    Console.WriteLine("Incorrect. Guess higher.");
                } else if (guess > number)
                {
                    Console.WriteLine("Incorrect. Guess lower.");
                }
            }
            Console.WriteLine("Correct!");
        }
    }
}
