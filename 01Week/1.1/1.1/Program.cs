using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine("\n The result is " + result);

            Console.WriteLine("\n please enter a number in yards to convert into inches");
            int yards = int.Parse(Console.ReadLine());
            int inches = yards * 36;

            Console.WriteLine("\n" + yards + " yards = " + inches + " inches");

            bool people = true;
            bool f = false;
            decimal num = 13;

            Console.WriteLine("\n People = " + people + " f = " + f + " num = " + num * num);

            Console.ReadLine();
        }
    }
}
