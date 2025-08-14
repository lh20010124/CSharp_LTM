using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };

            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Avg(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Avg(nums2));
        }
        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
            }
            return sum;
        }

        static double Avg(IEnumerable nums)
        {
            int sum = 0; int count = 0;
            foreach (var item in nums)
            {
                sum += (int)item;
                count++;
            }
            return sum / count;
        }
    }
}
