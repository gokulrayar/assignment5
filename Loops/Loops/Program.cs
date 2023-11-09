using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count  = 0;
            int number = 2;
            while (count<10)
            {
                Console.WriteLine(number);
                number += 2;
                count ++;
            }
        }
    }
}
