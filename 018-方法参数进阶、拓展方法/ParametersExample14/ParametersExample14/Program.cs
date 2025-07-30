

namespace ParametersExample14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 11, 12, 13, 14, 15 };
            bool result1 = AllGreaterThenTen(myList);
            bool result2 = myList.All(i => i > 10);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static bool AllGreaterThenTen(List<int> intList)
        {
            foreach (var item in intList)
            {
                if (item <= 10)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
