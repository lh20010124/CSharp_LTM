using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Tim");
            Console.WriteLine(car.Owner);
        }
    }

    class Vehicle
    {
        public Vehicle(string owner)
        {
            this.Owner = "N/A";
        }
        public string Owner { get; set; }

    }

    // 继承过程中，构造器不被继承

    class Car : Vehicle
    {
        public Car(string owner) : base(owner)
        {
            
        }

        public void ShowOwner()
        {
            Console.WriteLine(Owner);
        }
    }

}
