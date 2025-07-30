namespace ParametersExample6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student outterStu = new Student() { Name = "Tim" };
            Console.WriteLine($"HashCode={outterStu.GetHashCode()},Name={outterStu.Name}");
            Console.WriteLine("------------------------");
            SomeSideEffecct(ref outterStu);
        }

        static void SomeSideEffecct(ref Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine($"HashCode={stu.GetHashCode()},Name={stu.Name}");
        }
    }
    public class Student
    {
        public string Name { get; set; }
    }
}
