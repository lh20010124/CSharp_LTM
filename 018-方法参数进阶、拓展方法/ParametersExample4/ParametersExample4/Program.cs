namespace ParametersExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int y = 1;
            IWantSideEffect(ref y);
            Console.WriteLine(y);
        }

        static void IWantSideEffect(ref int x)
        {
            x += 100;
        }
    }
}
