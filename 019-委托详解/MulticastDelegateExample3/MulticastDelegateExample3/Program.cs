

namespace MulticastDelegateExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            Task task1 = new Task(new Action(stu1.DoHomework));
            Task task2 = new Task(new Action(stu2.DoHomework));
            Task task3 = new Task(new Action(stu3.DoHomework));

            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Main thread {i}.");
                Thread.Sleep(1000);
            }
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine($"Student {this.ID} doing homework {i} hour(s)");
                Thread.Sleep(1000);
            }
        }
    }
}