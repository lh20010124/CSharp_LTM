namespace ParametersExample9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            bool b = StudentFactory.Create("Tim", 34, out stu);
            if (b==true)
            {
                Console.WriteLine($"Student {stu.Name},age is {stu.Age}");
            }
        }
    }

    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class StudentFactory
    {
        public static bool Create(string stuName,int stuAge,out Student result)
        {
            result = null;
            if(string.IsNullOrEmpty(stuName))
            {
                return false;
            }
            if (stuAge < 20 || stuAge >80)
            {
                return false;
            }

            result = new Student() { Name = stuName, Age = stuAge };
            return true;
        }
    }
}
