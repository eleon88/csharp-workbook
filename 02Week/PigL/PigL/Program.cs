using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigL
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a word to convert ot pig latin");
            string Word = Console.ReadLine().ToLower();

            char[] Vowels = new char[6];
            Vowels[0] = 'a';
            Vowels[1] = 'e';
            Vowels[2] = 'i';
            Vowels[3] = 'o';
            Vowels[4] = 'u';
            Vowels[5] = 'y';

            //for(int i = 0; i < Vowels.Count(); i++)
            //{
            //    Console.WriteLine(i);
            //}

            string FirstPart = Word.Substring(0, Word.IndexOfAny(Vowels));
            string LastPart = Word.Substring(Word.IndexOfAny(Vowels));

            Console.WriteLine($"Your word in Pig Latin is: {LastPart}{FirstPart}ay");

            Console.WriteLine("Would you like to enter another word?");
            string AnotherWord = Console.ReadLine().ToLower();

            if(AnotherWord == "yes")
            {
                Console.WriteLine("Too bad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("okay");
                Console.ReadLine();
            }
            
        }
    }
}
