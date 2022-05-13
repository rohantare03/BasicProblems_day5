namespace Basic_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number for a particular problem.");
            Console.WriteLine("1 for Flip coin and finding percentage of heads and tails");
            Console.WriteLine("2 for checking Leap year or not");
            Console.WriteLine("3 for finding power of 2");
            Console.WriteLine("4 for Harmonic number");
            Console.WriteLine("5 for prime factors");
            Console.WriteLine("6 for finding Quotient and Remainder");
            Console.WriteLine("7 for swapping two numbers");
            Console.WriteLine("8 for Checking Even or Odd");
            Console.WriteLine("9 for Checking Vowel or Consonant");
            Console.WriteLine("10 for finding the largest number");
           

            int Problem = Convert.ToInt32(Console.ReadLine());
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
                case 6:
                    QuotientRemainder quotientremainder = new QuotientRemainder();
                    quotientremainder.Quotient_Remainder();
                    break;
                case 7:
                    SwapTwoNum swap = new SwapTwoNum();
                    swap.SwapNum();
                    break;
                case 8:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenOrOdd();
                    break;
                case 9:
                    VowelConsonant vowelConsonant = new VowelConsonant();
                    vowelConsonant.Vowel_Consonant();
                    break;
                case 10:
                    LargestNumber largestnumber = new LargestNumber();
                    largestnumber.LargestNum();
                    break;
                default:
                    Console.WriteLine("Enter a valid number");
                    break;
         
            }
        }
    }
}
