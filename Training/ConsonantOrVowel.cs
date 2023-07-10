using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ConsonantOrVowel
    {
        public void CheckConsonantOrVowel()
        {
            Console.WriteLine("Enter a character:");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e')
                Console.WriteLine("The character is a vowel.");
            else if (ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("The character is a vowel.");
            else if (ch == 'A' || ch == 'E' || ch == 'I')
                Console.WriteLine("The character is a vowel.");
            else if (ch == 'O' || ch == 'U')
                Console.WriteLine("The character is a vowel.");
            else
                Console.WriteLine("The character is a consonant.");

        }

    }
}
