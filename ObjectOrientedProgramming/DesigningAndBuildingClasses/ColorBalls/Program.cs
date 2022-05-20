

namespace ColorBalls
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.Write("Enter Number of Balls to be created: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of Balls to be popped: ");
            int popped = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of Balls to be thrown before and after popping: ");
            int thrown = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Random rand = new Random();

            Console.WriteLine("Creating Balls");
            Ball[] b = new Ball[num];
            for (int i = 0; i < num; i++)
            {
                b[i] = new Ball(rand.Next(1, 10), new Color(rand.Next(1, 256), rand.Next(1, 256), rand.Next(1, 256)));
            }

            Console.WriteLine("Throwing Random Balls");
            for (int i = 0; i < thrown; i++)
            {
                b[rand.Next(0, num)].Throw();
            }
            Console.WriteLine();

            Console.WriteLine("Balls after being thrown:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Ball size: {b[i].size}, Ball Color: red={b[i].c.red}, blue={b[i].c.blue}, green={b[i].c.green}, Ball Thrown Number: {b[i].GetThrown()}, Is Popped? {(b[i].size > 0 ? "No" : "Yes")}");
            }
            Console.WriteLine();

            Console.WriteLine("Popping Random Balls");
            for (int i = 0; i < popped; i++)
            {
                b[rand.Next(0, num)].Pop();
            }
            Console.WriteLine();

            Console.WriteLine("Throwing Random Balls");
            for (int i = 0; i < thrown; i++)
            {
                b[rand.Next(0, num)].Throw();
            }
            Console.WriteLine();

            Console.WriteLine("Balls after being thrown:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Ball size: {b[i].size}, Ball Color: red={b[i].c.red}, blue={b[i].c.blue}, green={b[i].c.green}, Ball Thrown Number: {b[i].GetThrown()}, Is Popped? {(b[i].size > 0 ? "No" : "Yes")}");
            }
            Console.WriteLine();

            return 0;
        }
    }
}