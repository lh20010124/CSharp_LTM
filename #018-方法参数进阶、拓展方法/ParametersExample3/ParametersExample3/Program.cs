namespace ParametersExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            UpdateObject(stu);
            Console.WriteLine($"{stu.GetHashCode()},{stu.Name}");
        }
        static void UpdateObject(Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine($"{stu.GetHashCode()},{stu.Name}");
        }
    }
    class Student
    {
        public string Name { get; set; }     
    }
}
