namespace ParametersExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int y = 100;
            stu.AddOne(y);
            Console.WriteLine(y);
        }
    }
    class Student
    { 
        public void AddOne(int x)
        {
            x += 1;
            Console.WriteLine(x);
        }
    }

}
