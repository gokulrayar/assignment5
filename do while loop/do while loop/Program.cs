using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            do
            {
                Console.WriteLine(number);
                number += 2;

            } 
            while (number <= 20);

        }
    }
}
