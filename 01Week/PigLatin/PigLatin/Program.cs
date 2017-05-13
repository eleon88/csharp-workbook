using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to eb translated to Pig Latin");
            String word = Console.ReadLine();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


            string firstPart = word.Substring(0, word.IndexOfAny(vowels));
            string restWord = word.Substring(word.IndexOfAny(vowels));

            Console.WriteLine(restWord + firstPart + "ay");


            Console.ReadLine();

        }
    }
}
