
using System.Timers;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            Boy boy = new Boy();
            Gril gril = new Gril();
            timer.Elapsed += boy.Action;
            timer.Elapsed += gril.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {
        internal void Action(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Gril
    {
        internal void Action(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
