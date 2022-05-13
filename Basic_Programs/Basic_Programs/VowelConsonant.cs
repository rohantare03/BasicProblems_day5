using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class VowelConsonant
    {
        public void Vowel_Consonant()
        {
            char Alphabet; 
            Console.WriteLine("Enter the Character : ");
            Alphabet = Convert.ToChar(Console.ReadLine());

            if ( Alphabet == 'A' || Alphabet == 'a' || Alphabet == 'E' || Alphabet == 'e' || Alphabet == 'I' || Alphabet == 'i' || Alphabet == 'O' || Alphabet == 'o' || Alphabet == 'U' || Alphabet == 'u')
            {
                Console.WriteLine(Alphabet + " is a Vowel.");
            }
            else 
            {
                Console.WriteLine(Alphabet + " is a Consonant.");
            }
        }
    }
}
