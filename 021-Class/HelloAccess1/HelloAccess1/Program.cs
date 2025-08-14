using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace HelloAccess1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Refuell();
            car.Accelerate();
            car.TurboAccelerate();
            Console.WriteLine(car.Speed);
        }
    }
}
