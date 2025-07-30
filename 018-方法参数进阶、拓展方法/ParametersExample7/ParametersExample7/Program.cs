namespace ParametersExample7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number.");
            string arg1 = Console.ReadLine();
            double x = 0;
            bool b1 = double.TryParse(arg1, out x);
            if (b1==false)
            {
                Console.WriteLine("Input error!");
                return;
            }

            Console.WriteLine("Please input second number.");
            string arg2 = Console.ReadLine();
            double y = 0;
            bool b2 = double.TryParse(arg2, out y);
            if (b2==false)
            {
                Console.WriteLine("Input error!");
                return;
            }

            double z = x + y;
            Console.WriteLine($"{x}+{y}={z}");
        }
    }
}
