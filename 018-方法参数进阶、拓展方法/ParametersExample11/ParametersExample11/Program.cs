namespace ParametersExample11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("Tim", 34);  //不具名调用
            PrintInfo(age: 34, name: "Tom");  //具名调用
        }

        static void PrintInfo(string name,int age)
        {
            Console.WriteLine($"Hello {name},you are {age}.");
        }
    }
}
