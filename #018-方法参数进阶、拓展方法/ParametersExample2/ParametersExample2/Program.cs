namespace ParametersExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            SomeMethod(stu);
            Console.WriteLine($"{stu.GetHashCode()},{stu.Name}");

        }
        static void SomeMethod(Student stu)
        {
            stu = new Student() { Name = "Tom"};
            Console.WriteLine($"{stu.GetHashCode()},{stu.Name}");
        }
    }
    class Student
    {
        public string Name { get; set; }
    }

}
