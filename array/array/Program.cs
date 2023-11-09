using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[] { 10, 20, 30, 40, 50 };

            int sum = 0;
            double average;

            foreach (int num in numberArray)

            {
                sum += num;
            }

            average = sum / numberArray.Length;

            Console.WriteLine($"Average: {average}\nSum: {sum}");


        }
    }
}
