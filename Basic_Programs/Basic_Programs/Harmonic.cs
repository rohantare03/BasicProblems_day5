using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Harmonic
    {
        public void HarmonicNumber()
        {
            float HarmonicResult = 0;

            Console.WriteLine("Enter the value of N for Nth Harmonic: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            for (float i = 1; i <= Number; i++)
            {
                HarmonicResult += 1 / i;

            }
            Console.WriteLine("The Nth Harmonic is given by {0}", HarmonicResult);

        }
    }
}
