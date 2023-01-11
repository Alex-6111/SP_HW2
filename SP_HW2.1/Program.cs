namespace SP_HW2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "+":
                    Console.WriteLine(Convert.ToInt32(args[0]) + Convert.ToInt32(args[2]));
                    break;
                case "-":
                    Console.WriteLine(Convert.ToInt32(args[0]) - Convert.ToInt32(args[2]));
                    break;
                case "*":
                    Console.WriteLine(Convert.ToInt32(args[0]) * Convert.ToInt32(args[2]));
                    break;
                case "/":
                    Console.WriteLine(Convert.ToInt32(args[0]) * Convert.ToInt32(args[2]));
                    break;
            }

            Console.ReadKey();
        }
    }
}