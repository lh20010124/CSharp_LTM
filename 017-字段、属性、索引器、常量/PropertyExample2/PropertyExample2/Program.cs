namespace PropertyExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu1 = new Student();
                stu1.Age = 20;
                Student stu2 = new Student();
                stu2.Age = 20;
                Student stu3 = new Student();
                stu3.Age = 20;

                int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine(avgAge);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
    class Student
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age value has error.");
                }
            }
        }
        private static int amount;

        public static int Amount
        {
            get { return amount; }
            set
            {
                if (value>=0)
                {
                    Student.amount = value;
                }
                else
                {
                    throw new Exception("Amount must greater than 0.");
                }
            }
        }


    }
}
