using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class PrimeFact
    {
        public void Prime()
        {
            int a, b;
            Console.WriteLine("Enter a number : ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 2; a > 1; b++ )
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;

                    }
                    Console.WriteLine("{0} is a prime factor {1} times. ",b ,x);
                }
            }
        }
    }
}
