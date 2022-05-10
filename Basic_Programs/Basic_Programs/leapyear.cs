﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class leapyear
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter the year : ");
            int Year = Convert.ToInt32(Console.ReadLine());

            while (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Enter a four digit number : ");
                Year = Convert.ToInt32(Console.ReadLine());
            }

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year + " is a leap year");
            }
            else
            {
                Console.WriteLine(Year + " is not a leap year");

            }
        }
    }
}
