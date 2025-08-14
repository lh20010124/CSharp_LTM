using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 为做基类而生的“抽象类”与“开放/关闭原则”
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car();
            vehicle.Run();
        }
    }

    interface IVehicle
    {
        void Stop();
        void Fill();
        void Run();
    }

    abstract class Vehicle : IVehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
        public void Fill()
        {
            Console.WriteLine("Pay and Fill...");
        }
        abstract public void Run();
    }

    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }

    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }

    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running...");
        }
    }

    // 抽象类：函数成员里至少有一个没有被实现的函数成员的类
    abstract class Student
    {
        abstract public void Study();
    }
}
