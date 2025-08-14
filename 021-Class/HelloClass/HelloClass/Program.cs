using System;

namespace HelloClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Timothy");
            Student s2 = new Student(2, "Jacky");
            Console.WriteLine(Student.Amount);
        }
    }



    class Student
    {
        public static int Amount { get; set; }

        // 静态构造器

        static Student()
        {
            Amount = 100;
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"I'm #{ID} student, my name is {Name}");
        }

        // 构造器
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }

        // 析构器
        ~Student()
        {
            Amount--;
        }
    }
}
