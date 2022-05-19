
namespace WorkingWithMethods 
{ 
    class Program
    {
        public static int Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            PrintNumbers(numbers);
            Reverse(ref numbers);
            PrintNumbers(numbers);

            int num = Fibonacci(10);
            Console.WriteLine($"Fibonacci 10th number is: {num}");
            return 0;
        }

        public static int[] GenerateNumbers(int size)
        {
            int[] numbers = new int[size];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0, 11);
            }

            return numbers;
        }

        public static void Reverse( ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }

        public static void PrintNumbers(int[] numbers)
        {
            Console.Write("Number Sequence: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            } else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
