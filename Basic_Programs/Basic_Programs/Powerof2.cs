using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Powerof2
    {
        public void PowerOfTwo()
        {
            Console.WriteLine("Please Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 0 || number >= 31)
            {
                Console.WriteLine("Please Enter a valid number :");
                number = Convert.ToInt32(Console.ReadLine());
            }

            for ( int i = 0; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }

    }
}
