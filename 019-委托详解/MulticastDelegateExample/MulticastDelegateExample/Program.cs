

namespace MulticastDelegateExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            //action1.Invoke();
            //action2.Invoke();
            //action3.Invoke();

            //多播委托
            ///
            //action1 += action2;
            //action1 += action3;
            //action1.Invoke();
            ///

            //直接同步调用
            ///
            //stu1.DoHomework();
            //stu2.DoHomework();
            //stu3.DoHomework();
            ///

            //间接同步调用
            ///
            //action1.Invoke();
            //action2.Invoke();
            //action3.Invoke();
            ///

            //隐式异步调用
            ///
            //action1.BeginInvoke(null, null);
            //action2.BeginInvoke(null, null);
            //action3.BeginInvoke(null, null);
            ///

            Task task1 = Task.Run(() => stu1.DoHomework());
            Task task2 = Task.Run(() => stu2.DoHomework());
            Task task3 = Task.Run(() => stu3.DoHomework());

            await Task.WhenAll(task1, task2, task3);

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Main thread {i}");
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
