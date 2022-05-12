using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class EvenOdd
    {
        public void EvenOrOdd()
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if ( num % 2 == 0 )
            {
                Console.WriteLine("Entered number is a Even number.");
            }
            else
            {
                Console.WriteLine("Entered number is a Odd number.");
            }
        }
    }
}
