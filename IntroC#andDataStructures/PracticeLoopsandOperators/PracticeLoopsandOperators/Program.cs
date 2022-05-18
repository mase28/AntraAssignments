// See https://aka.ms/new-console-template for more information

namespace PracticeLoopsandOperators
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.Write("Enter number for fizzbuzz: ");
            FizzBuzz fb = new FizzBuzz(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Lower bound for guessing game: ");
            int low = int.Parse(Console.ReadLine());
            Console.Write("Enter Greater bound for guessing game: ");
            int high = int.Parse(Console.ReadLine());
            GuessingGame gg = new GuessingGame(low, high);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Lenght of Bottom of Pyramid (will round down to nearest odd number): ");
            int bot = int.Parse(Console.ReadLine());
            PrintAPyramid pap = new PrintAPyramid(bot);

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter your birthdate (format: M/D/YYYY): ");
            BirthDate bd = new BirthDate(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Greetings greet = new Greetings();

            Console.WriteLine();
            Console.WriteLine();

            Count24 c24 = new Count24();

            return 0;
        }
    }
}
