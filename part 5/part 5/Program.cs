using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam score as a percentage: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("your grade is A ");

            }
            else if (score >= 80 && score <90)
            {
                Console.WriteLine("your grade is B");

            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("your grade is C");

            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("your grade is D");

            }
            else
            {
                Console.WriteLine("Your grade is F");
            }
            Console.ReadKey();
        }
    }
}
