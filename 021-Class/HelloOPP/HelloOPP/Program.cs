
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Console.WriteLine(tb.FullName);
            Console.WriteLine(tb.BaseType.FullName);
            Console.WriteLine(tb.BaseType is object);
            Console.WriteLine(tb.BaseType.BaseType == null);
        }
    }

    class Vehicle
    {

    }

    // 继承

    class Car : Vehicle
    {

    }
}
