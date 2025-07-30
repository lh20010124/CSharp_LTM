namespace ParametersExample13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.1415926;
            double y = Math.Round(x, 4);
            double z = x.Round(4);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }


    static class DoubleExtension
    {
        public static double Round(this double input,int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
