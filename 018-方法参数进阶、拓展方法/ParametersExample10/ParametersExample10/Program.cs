namespace ParametersExample10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int result = CalculateSum(1,2,3);
            Console.WriteLine($"{result}");
            int x = 100;
            int y = 200;
            int z = x + y;
            Console.WriteLine("{0}+{1}={2}",x,y,z);
            string str = "Tim;Tom,Amy.Lisa";
            string[] resultStr = str.Split(';', '.', ',');
            foreach (var name in resultStr)
            {
                Console.WriteLine(name);
            }
        }

        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
