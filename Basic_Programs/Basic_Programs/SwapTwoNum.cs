using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class SwapTwoNum
    {
        public void SwapNum()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping, the first number is : " + num1);
            Console.WriteLine("After Swapping, the second number is : " + num2);
        }
    }
}
