namespace ParametersExample12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("Tim", 34);  //不具名调用
            PrintInfo(age: 34, name: "Tom");  //具名调用
            PrintInfo();  //可选参数
        }

        static void PrintInfo(string name = "Tim", int age = 34)
        {
            Console.WriteLine($"Hello {name},you are {age}.");
        }
    }
}