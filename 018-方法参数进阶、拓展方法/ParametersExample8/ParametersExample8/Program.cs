namespace ParametersExample8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            bool b = DoubleParser.TryParse("789", out x);
            if(b == true)
            {
                Console.WriteLine(x + 1);
            }
        }
    }

    public class DoubleParser
    {
        public static bool TryParse(string input,out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }
}
