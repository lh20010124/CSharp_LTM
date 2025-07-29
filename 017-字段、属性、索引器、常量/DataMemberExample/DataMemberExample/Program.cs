
namespace DataMemberExample
{
     class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student();
            //stu1.Age = 40;
            //stu1.Score = 90;

            //Student stu2 = new Student();
            //stu2.Age = 24;
            //stu2.Score = 60;

            List<Student> stuList = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stuList.Add(stu);
            }

            int totalAge = 0;
            int totalScore = 0;
            foreach (var stu in stuList)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }

            Student.AverageAge = totalAge / Student.Amount;
            Student.AverageScore = totalScore / Student.Amount;

            Student.ReportAmount();
            Student.ReportAverageAge();
            Student.ReportAverageScore();
        }
    }
    class Student
    {
        public int Age;
        public int Score;
        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student()
        {
            Student.Amount++;
        }
        public static void ReportAmount()
        {
            Console.WriteLine(Student.Amount);
        }
        public static void ReportAverageAge()
        {
            Console.WriteLine(Student.AverageAge);
        }
        public static void ReportAverageScore()
        {
            Console.WriteLine(Student.AverageScore);
        }
    }

}
