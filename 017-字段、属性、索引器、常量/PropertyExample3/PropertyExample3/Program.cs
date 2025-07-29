namespace PropertyExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu1 = new Student();
                stu1.Age = 12;
                Console.WriteLine(stu1.CanWork);
                Student stu2 = new Student();
                stu2.Age = 18;
                Console.WriteLine(stu2.CanWork);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
    class Student
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool CanWork { get
            {
                if (this.age >= 16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

}
