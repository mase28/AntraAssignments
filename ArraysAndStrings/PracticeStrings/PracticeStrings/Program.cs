
namespace PracticeStrings
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Reverse.ReverseString();
            Console.WriteLine();

            Reverse.ReverseWords();
            Console.WriteLine();

            Palindrome.FindPalindromes();
            Console.WriteLine();

            ParseURL.Start();
            Console.WriteLine();

            return 0;
        }
    }
}
