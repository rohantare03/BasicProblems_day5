﻿namespace Basic_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number for a particular problem.\n");
            Console.WriteLine("1 for Flip coin and finding percentage of heads and tails");
            Console.WriteLine("2 for checking Leap year or not");

            int Problem = Convert.ToInt32(Console.ReadLine());
            Program basicprogram = new Program();
            switch (Problem)
            {
                case 1:
                    FlipCoin coin = new FlipCoin();
                    coin.Cointoss();
                    break; 
                case 2:
                    leapyear leap = new leapyear();
                    leap.LeapYear();
                    break; 
            }
        }
    }
}
