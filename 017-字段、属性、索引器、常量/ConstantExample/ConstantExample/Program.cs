using System.Diagnostics;

namespace ConstantExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入圆的半径：");
            string str = Console.ReadLine();
            double r = Convert.ToInt32(str);
            Console.WriteLine("半径{0}圆的面积为：{1}",r,GetArea(r));
        }
        
        static double GetArea(double r)
        {
            double a = Math.PI * r * r;
            return a;
        }
    }
}
