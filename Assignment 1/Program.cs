using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of the array is : {sum}");
            Console.ReadLine();
        }
    }
}
