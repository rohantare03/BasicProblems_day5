namespace Basic_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number for a particular problem.\n");
            Console.WriteLine("1 for Flip coin and finding percentage of heads and tails");
            Console.WriteLine("2 for checking Leap year or not");
            Console.WriteLine("3 for finding power of 2");
            Console.WriteLine("4 for Harmonic number");
            Console.WriteLine("5 for prime factors");
           

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
                case 3:
                    Powerof2 pow2 = new Powerof2();
                    pow2.PowerOfTwo();
                    break;
                case 4:
                    Harmonic harmonicnum = new Harmonic();
                    harmonicnum.HarmonicNumber();
                    break;
                case 5:
                    PrimeFact primefact = new PrimeFact();
                    primefact.Prime();
                    break;
            }
        }
    }
}
