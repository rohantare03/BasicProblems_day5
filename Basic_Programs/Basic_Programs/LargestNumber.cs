using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class LargestNumber
    {
        public void LargestNum()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Largest number is " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Largest number is " + num2);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("Largest number is " + num3);
            }
        }
    }
}
